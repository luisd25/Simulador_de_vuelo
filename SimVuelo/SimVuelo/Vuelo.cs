using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using System.Drawing;
namespace SimVuelo
{
    class Vuelo
    {
        
        public DateTime hora_takeoff { get; set; }
        public DateTime hora_landing { get; set; }

        PointLatLng pos { get; set; }

        public int start, end, altitud, pista = -1, num_vuelo, num_pasajeros, VI, VA, VF;
        public bool colision { get; set; }
        public GMarkerGoogle mark;
        public Ruta ruta;
        public PointLatLng posicion;
        public bool status=true;
        public double distancia, combustible;
        public void Create_mark(Image plane)
        {
            mark = new GMarkerGoogle(pos, new Bitmap(plane));
            
        }

        public Vuelo()
        {
            Random r = new Random();
            num_pasajeros = r.Next(150);
            num_vuelo = r.Next(20);
            hora_takeoff = new DateTime();
            hora_landing = hora_takeoff.AddHours(2);
            VI = r.Next(257, 291);
            VF = r.Next(240, 268);
            VA = r.Next(885, 933);
            altitud = r.Next(28000, 39000);
            combustible = r.Next(200000, 216840);
            
        }
        public string info()
        {
            string info;
            info = num_vuelo.ToString() + ", " + num_pasajeros.ToString() + " ," + hora_takeoff.Hour.ToString()+ " ," + hora_landing.Hour.ToString();
            return info;
            
        }
        public void set_ruta(PointLatLng ini,PointLatLng fin)
        {
            
            pos = ini;
            ruta = new Ruta(ini, fin);
            Distance(ini, fin);
            if (distancia * 12 > combustible) status = false;
        }
        public double Distance(PointLatLng start, PointLatLng end)
        {
            double deg2radMultiplier = Math.PI / 180;
            double lat1 = start.Lat * deg2radMultiplier;
            double lon1 = start.Lng * deg2radMultiplier;
            double lat2 = end.Lat * deg2radMultiplier;
            double lon2 = end.Lng * deg2radMultiplier;

            double radius = 6378.137; 
            double dlon = lon2 - lon1;
            distancia = Math.Acos(Math.Sin(lat1) * Math.Sin(lat2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(dlon)) * radius;
            return distancia;
        }
    }
}
