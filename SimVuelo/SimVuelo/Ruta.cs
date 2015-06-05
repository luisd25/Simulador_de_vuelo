using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace SimVuelo
{
    class Ruta
    {
        public List<PointLatLng> pos = new List<PointLatLng>();
        public string direccion = " ";
        private List<double> plat = new List<double>();
        private List<double> plon = new List<double>();
         public Ruta(PointLatLng ini,PointLatLng fin)
        {
            double lat1 = ini.Lat, lat2 = fin.Lat, lon1 = ini.Lng, lon2 = fin.Lng;
            lat1=Math.Round(lat1, 0); 
            lat2=Math.Round(lat2, 0);
            lon1=Math.Round(lon1, 0);
            lon2=Math.Round(lon2, 0);
            plat.Add(ini.Lat);
            plon.Add(ini.Lng);
            PasosLat(lat1, lat2);
            if ((lon1 >= 0 && lon2>=0) || (lon1<0 && lon2<0)) PasosLonA(lon1, lon2);
            else if(lon1<0 && lon2>0)
            {
                if (Math.Abs(lon1) + lat2 < (180 - lon1) + (180 - lon2)) PasosLonA(lon1, lon2);
                else PasosLonB(lon1, lon2);
            }
            else if(lon1>0 && lon2<0)
            {
                if (lon1 + Math.Abs(lon2) < (180 - lon1) + (180 - Math.Abs(lon2))) PasosLonA(lon1, lon2);
                else PasosLonB(lon1, lon2);
            }
            
            crear_ruta(fin);

        }
         private void PasosLat(double lat1, double lat2)
         {
             bool flag=false;
             while(lat1!=lat2)
             {
                 if (lat1 > lat2)
                 {
                     if (flag == false)
                     {
                         flag = true;
                         direccion = "s";
                     }
                     lat1--;
                     plat.Add(lat1);
                 }
                 else
                 {
                     if (flag == false)
                     {
                         flag = true;
                         direccion = "n";
                     }
                     lat1++;
                     plat.Add(lat1);
                 }
             }
         }
    
        private void PasosLonA(double lon1,double lon2)
         {
             bool flag = false;
             while (lon1 != lon2)
             {
                 if (lon1 > lon2)
                 {
                     if(flag==false)
                     {
                         direccion += "o";
                         flag = true;
                     }
                     lon1--;
                     plon.Add(lon1);
                 }
                 else
                 {
                     if (flag == false)
                     {
                         direccion += "e";
                         flag = true;
                     }
                     lon1++;
                     plon.Add(lon1);
                 }
             }

          }
         

        private void PasosLonB(double lon1,double lon2)
        {
            bool flag = false;
            if (lon1 > lon2)
            {
                if (flag == false)
                {
                    direccion += "e";
                    flag = true;
                }
                while(lon1!=lon2)
                {
                    
                    if (lon1 == 180) lon1 = -180;
                    lon1++;
                    plon.Add(lon1);
                }
            }
            else
            {
                if (flag == false)
                {
                    direccion += "o";
                    flag = true;
                }
                while (lon1 != lon2)
                {
                    if (lon1 == -180) lon1 = 180;
                    lon1--;
                    plon.Add(lon1);
                }
            }
        }

        private void crear_ruta(PointLatLng fin)
        {
            if(plat.Count>=plon.Count)
            {
                while (plon.Count>0)
                {
                    pos.Add(new PointLatLng(plat[0], plon[0]));
                    plat.RemoveAt(0);
                    plon.RemoveAt(0);

                }
                while(plat.Count>0)
                {
                    pos.Add(new PointLatLng(plat[0], fin.Lng));
                    plat.RemoveAt(0);
                }
            }
            else if (plon.Count>plat.Count)
            {
                while (plat.Count > 0)
                {
                    pos.Add(new PointLatLng(plat[0], plon[0]));
                    plat.RemoveAt(0);
                    plon.RemoveAt(0);

                }
                while (plon.Count > 0)
                {
                    pos.Add(new PointLatLng(fin.Lat, plon[0]));
                    plon.RemoveAt(0);
                }
            }
        }
    }
}
