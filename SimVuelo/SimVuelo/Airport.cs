using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
namespace SimVuelo
{
    class Airport
    {
        public PointLatLng pos;
        public string name;
        public Runway[] pista;
        
        public Airport()
        {
            Random r=new Random();
            pista = new Runway[1];
            for (int i = 0; i < pista.Length; i++)
            {
                pista[i] = new Runway();
            }
        }
        public void EnUso(int n)
        {
            if (n > 0) pista[n].pista = true;
            
        }
        public void Liberar(int n)
        {
            if (n > 0) pista[n].pista = false;
        }
    }
    class Runway
    {
        public bool pista;
        public int tiempo;
        public Runway()
        {
            tiempo = 2;
        }
    }
    
}
