using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
namespace SimVuelo
{
    public partial class SimVuelo : Form
    {
        GMapOverlay AirporOverlay = new GMapOverlay("marker");
        GMapOverlay planeOverlay = new GMapOverlay("marker");
        static int cant = 6;
        int indice;
        bool flag;
        int[] end;
        Airport[] start;

        Vuelo[] plane;
       

        public SimVuelo()
        {
            tam();
            start = new Airport[cant];
            plane = new Vuelo[cant];
            end = new int[cant];
            InitializeComponent();
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap2.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            load_airports();
            load_vuelo();
            cmb_mapa.DataSource = GMapProviders.List;

            cmb_mapa.SelectedItem = GMapProviders.GoogleMap;
            cmb_mapa.DropDownStyle = ComboBoxStyle.DropDownList;
            
            
        }

        private void load_airports()
        {
            DataBase db = new DataBase();
            string[] name = new string[cant];
            double[,] coor = new double[cant, 2];
            db.Connect();
            name = db.info();
            coor = db.coordenadas();
            db.Close();
            
            for (int i = 0; i < cant; i++)
            {
                start[i] = new Airport();
                start[i].pos.Lat = coor[i, 0];
                start[i].pos.Lng = coor[i, 1];
                start[i].name = name[i];

                GMarkerGoogle mark=new GMarkerGoogle(start[i].pos,new Bitmap(Properties.Resources.urban));
                
                mark.ToolTipText = name[i]+" "+start[i].pista.Length.ToString();
                AirporOverlay.Markers.Add(mark);
            }
            gmap.Overlays.Add(AirporOverlay);
        }

        private void load_vuelo()
        {
            load_destinos();
           
            for (int i = 0; i < cant; i++)
            {
                plane[i] = new Vuelo();
                plane[i].set_ruta(start[i].pos, start[end[i]].pos);
                plane[i].start = i;
                plane[i].end = end[i];
                
           
                if (plane[i].ruta.direccion == "ne") plane[i].Create_mark(Properties.Resources.planeNE);
                else if (plane[i].ruta.direccion == "so") plane[i].Create_mark(Properties.Resources.planeSW);
                else if (plane[i].ruta.direccion == "se") plane[i].Create_mark(Properties.Resources.planeSE);
                else if (plane[i].ruta.direccion == "no") plane[i].Create_mark(Properties.Resources.planeNO);
                planeOverlay.Markers.Add(plane[i].mark);
               
                
            }
            gmap.Overlays.Add(planeOverlay);
        }
        private void load_destinos()
        {
            Random r = new Random();
            for (int i = 0; i < cant;)
            {
                int m=r.Next(0,cant);
                if (m != i)
                {
                    end[i] = m;
                    i++;
                } 
            }
            
            
           
        }
        
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            planeOverlay.Clear();
            for (int i = 0; i < cant; i++)
            {
             
                int aux = plane[i].end;
                if (plane[i].status != true) nuevoV(aux, i);
                if (plane[i].ruta.pos.Count == 0 )
                {
                    
                    if (start[i].pista[plane[i].pista].tiempo == 0)
                    {
                        nuevoV(aux, i);
                    }
                    else start[i].pista[plane[i].pista].tiempo--;
                }

                else 
                {
                first:
                    if (plane[i].ruta.pos.Count > 6)
                    {
                        plane[i].mark.Position = plane[i].ruta.pos[0];
                        plane[i].ruta.pos.RemoveAt(0);
                    }
                    else if(plane[i].pista!=-1)
                    {
                        plane[i].mark.Position = plane[i].ruta.pos[0];
                        plane[i].ruta.pos.RemoveAt(0);
                    }
                    else
                    {
                        
                        for (int j = 0; j <start[aux].pista.Length; j++)
                        {
                            if(start[aux].pista[j].pista==false)
                            {
                                start[aux].EnUso(j);
                                plane[i].pista = j;
                                goto first;
                            }
                        }
                    }
                if (plane[i].ruta.pos.Count > 0)
                {
                    plane[i].posicion = plane[i].ruta.pos[0];
                    plane[i].combustible-=(plane[i].distancia-plane[i].Distance(plane[i].posicion, start[plane[i].end].pos))*12;
                }

                    colision(i);                   
                    plane[i].mark.ToolTipText = plane[i].mark.Position.ToString();
                    planeOverlay.Markers.Add(plane[i].mark);
                    
                    
                }
                
            }
            if(flag==true)
            {
                gmap2.Overlays.Add(planeOverlay);
                gmap2.Position = plane[indice].mark.Position;
                Plane_info();

            }
            else gmap.Overlays.Add(planeOverlay);
            
        }
        private void nuevoV(int aux,int i)
        {
            load_destinos();
            start[aux].Liberar(plane[i].pista);
            plane[i] = new Vuelo();
            plane[i].set_ruta(start[i].pos, start[end[i]].pos);
            plane[i].start = i;
            plane[i].end = end[i];

            if (plane[i].ruta.direccion == "ne") plane[i].Create_mark(Properties.Resources.planeNE);
            else if (plane[i].ruta.direccion == "so") plane[i].Create_mark(Properties.Resources.planeSW);
            else if (plane[i].ruta.direccion == "se") plane[i].Create_mark(Properties.Resources.planeSE);
            else if (plane[i].ruta.direccion == "no") plane[i].Create_mark(Properties.Resources.planeNO);
        }

        private void gmap_Click(object sender, EventArgs e)
        {
            try
            {
                 for (int i = 0; i < plane.Length; i++)
            {
                if(plane[i].mark.IsMouseOver)
                {
                    if(flag!=true)
                    {
                        flag = true;
                        indice = i;
                    }
                    gmap2.Overlays.Add(AirporOverlay);
                    Avion.Select();
                    gmap2.Position = plane[i].mark.Position;
                    gmap2.Zoom = 8;
                    panel_Avion.Visible = true;
                   
                    Tab.SelectTab(Avion);
                    

                }
            }
            }
            catch (Exception)
            {
                
             
            }

        }
        private void Plane_info()
        {
            txt_numPas.Text = plane[indice].num_pasajeros.ToString();
            txt_numAvion.Text = plane[indice].num_vuelo.ToString();
            txt_Combustible.Text = plane[indice].combustible.ToString();
            txt_numAvion.Text = plane[indice].num_vuelo.ToString();
            txt_numPas.Text = plane[indice].num_pasajeros.ToString();
            txt_Posicion.Text = plane[indice].posicion.ToString();
            txt_Distancia.Text = plane[indice].distancia.ToString()+"  KM";
            txt_Combustible.Text = plane[indice].combustible.ToString()+"  L";
            txt_Htakeoff.Text = plane[indice].hora_landing.ToString();
            txt_hLanding.Text = plane[indice].hora_takeoff.ToString();
            txt_proviende.Text = start[indice].name;
            txt_destino.Text = start[plane[indice].end].name;
            txt_VA.Text = plane[indice].VA.ToString()+" KmPh";
           
            txt_VF.Text = plane[indice].VF.ToString() + " KmPh";
            txt_VI.Text = plane[indice].VI.ToString() + " KmPh";
        }

        private void Avion_Leave(object sender, EventArgs e)

        {
            gmap.Overlays.Clear();
            gmap.Overlays.Add(AirporOverlay);
            gmap.Overlays.Add(planeOverlay);
            load_airports();
           flag = false;
        }

      
 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar();

        }
        private void buscar()
        {
            DataBase db = new DataBase();
            db.Connect();
            dataGrid.RowEnter -= dataGrid_RowEnter;
            dataGrid.DataSource = db.Busar();
            dataGrid.RowEnter += dataGrid_RowEnter;
            db.Close();
        }

        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            int id = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            String name = (String)dataGrid.Rows[e.RowIndex].Cells[1].Value;
            double lat = double.Parse(dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            double lon = double.Parse(dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString());

           
            txt_AirName.Text = name;
            txt_latitud.Text = lat.ToString();
            txt_longitud.Text = lon.ToString();
            txt_id.Text = id.ToString();
        }
        private void colision(int i)
        {
            for (int j = 0; j < plane.Length; j++)
            {

                if (plane[i].Distance(plane[i].mark.Position, plane[j].mark.Position) < 1 && j != i && (Math.Abs(plane[i].altitud - plane[j].altitud)>50))
                {
                    timer1.Stop();
                    MessageBox.Show("ajustando Altitud para evitar colision");
                    plane[i].altitud += 100;
                    plane[j].altitud -= 100;
                    timer1.Start();
                }
            }
        }
        private void btn_add_Click_1(object sender, EventArgs e)
        {
           
            if (txt_latitud.Text.Count() > 0 && txt_longitud.Text.Count() > 0 &&(double.Parse(txt_latitud.Text)>0 || double.Parse(txt_longitud.Text)>0) &&(double.Parse(txt_latitud.Text)<180 || double.Parse(txt_longitud.Text)<180) )
            {
                DataBase db = new DataBase();
                db.Connect();
                db.RegAirport(txt_AirName.Text, double.Parse(txt_latitud.Text), double.Parse(txt_longitud.Text));
                db.Close();
                MessageBox.Show("Se guardo correctamente porfavor reinicie la aplicacion para apreciar los cambios");
            }
            else
            {
                MessageBox.Show("Digite los datos correctos mayor que 0 y dentro del rango de las coordenadas reales");
            }
            buscar();
            cant++;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
         
            if (!String.IsNullOrEmpty(txt_id.Text))
            {
                DataBase db = new DataBase();
                db.Connect();
                db.borrar(int.Parse(txt_id.Text));
                db.Close();
                MessageBox.Show("Se elimino correctamente porfavor reinicie la aplicacion para apreciar los cambios");
                clean();
                buscar();
            }
        }
        private void clean()
        {
            txt_id.Clear();
            txt_latitud.Clear();
            txt_longitud.Clear();
            txt_AirName.Clear();
        }

        private void Simular_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Stop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cmb_mapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            gmap.MapProvider = cmb_mapa.SelectedItem as GMapProvider;
        }
        private void tam()
        {
            DataBase db = new DataBase();
            db.Connect();
            cant = db.count();
            db.Close();
        }

       
        

      
        
      
    }
}
