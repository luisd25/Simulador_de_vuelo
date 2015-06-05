using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace SimVuelo
{
    class DataBase
    {
        public String connectionString;
        public SQLiteConnection connect;
       public void Connect()
        {
        
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            connect = new SQLiteConnection(connectionString);
            if (connect.State != ConnectionState.Open) connect.Open();
        }
    
        public void Close()
        {
            if (connect.State == ConnectionState.Open) connect.Close();
        }
        public double [,]coordenadas()
        {
            string sqlselectlat = "select lat from airport";
            string sqlselectlon = "select lon from airport";
            
            
            double[,] coor = new double[100, 2];
            int i = 0;
            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = sqlselectlat;

            SQLiteDataReader dr;
            dr = command.ExecuteReader();
            while(dr.Read())
            {
                coor[i, 0] = dr.GetDouble(0);
                i++;
            }
            dr.Close();
            command.CommandText = sqlselectlon;
            
            dr = command.ExecuteReader();
            i = 0;
            while (dr.Read())
            {
                coor[i, 1] = dr.GetDouble(0);
                i++;
            }
            return coor;
        }

        public string[] info()
        {
            string sqlselectn = "select name from airport";

            string[] name = new string[100];

            
            int i = 0;
            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = sqlselectn;

            SQLiteDataReader dr;
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                name[i] = dr.GetString(0);
                i++;
            }
            dr.Close();
            return name;
        }

        public void RegAirport(string name,double lat,double lng)
        {
            String SQLsituacion = "INSERT INTO airport(name, lat, lon) VALUES( ?, ?, ?)";
            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = SQLsituacion;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("lat", lat);
            command.Parameters.AddWithValue("lon", lng);
            command.ExecuteNonQuery();
        }
        public DataTable Busar()
        {
            string SQLSelect = "select * from airport";
            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = SQLSelect;

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            da.Fill(dt);
            return dt;

        }
        public void borrar(int id)
        {
            string SQLDelete="delete from airport where id= ?";
            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = SQLDelete;

            command.Parameters.AddWithValue("UserId",id);

            command.ExecuteNonQuery();
        }
        public int count()
        {
            string sqlselectn = "select count(id) from airport";

            int cant = 0;



            SQLiteCommand command = connect.CreateCommand();
            command.CommandText = sqlselectn;

            SQLiteDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cant = dr.GetInt32(0);
            }

            dr.Close();
            return cant;
        }
        

    }
}
