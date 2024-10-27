using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WindowsFormsApp1
{
    internal class gestionDB
    {
        private const string DBName = "LibreriaDB.sqlite";
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;
        string mensaje=string.Empty;

        public string Mensaje { get => mensaje; }

        void Conectar()
        {
            try
            {
                con = new SQLiteConnection(string.Format("Data Source={0};Version=3;", DBName));
                con.Open();
            }
            catch (SQLiteException ex)
            {
                mensaje = "No fue posible establecer conexión por: " + ex.Message;
            }
        }
        public bool Login (string user, string pass)
        {
            bool result = false;
            Conectar();
            try
            {
                string query = "Select * from Usuarios where nombreUsuario=@user and clave=@clave";
                cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@clave", pass);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result= true;
                }
            }
            catch (SQLiteException ex)
            {
                
            }
            con.Close();
            return result;   
        }
        public int AgregarLibro(Libro libro)
        {
            int result = 0;
            Conectar();
            string query = "INSERT INTO libro (codigo,titulo,autor,editorial, ubicacion,precio,cantidad)" +
                "VALUES (@cod,@titulo,@autor,@edit,@ubicacion,@precio,@cant)";
            cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@cod", libro.Codigo);
            cmd.Parameters.AddWithValue("@titulo", libro.Titulo);
            cmd.Parameters.AddWithValue("@autor", libro.Autor);
            cmd.Parameters.AddWithValue("@edit", libro.Editorial);
            cmd.Parameters.AddWithValue("@ubicacion", libro.Ubicacion);
            cmd.Parameters.AddWithValue("@precio", libro.Precio);
            cmd.Parameters.AddWithValue("@cant", libro.Cantidad);

            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public Libro BuscarLibroxCodigo(int codigo )
        {
            Libro libro=null;
            Conectar();
            string query = "SELECT * FROM libro where codigo=@cod";
            cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@cod",codigo);
            reader =cmd.ExecuteReader();
            if (reader.Read())
            {
                libro = new Libro();
                libro.Codigo = reader.GetInt32(0);
                libro.Titulo = reader.GetString(1);
                libro.Autor = reader.GetString(2);
                libro.Editorial = reader.GetString(3);
                libro.Ubicacion = reader.GetString(4);
                libro.Cantidad = reader.GetInt32(5);
                libro.Precio=reader.GetFloat(6);
            }
            reader.Close();
            con.Close();
            return libro;
        }

        public List<Libro> BuscarLibroxAutor(string autor)
        {
            List<Libro> libros = new List<Libro>();
            Conectar();
            string query = "SELECT * FROM libro WHERE autor like '%"+autor+"%'";
            cmd = new SQLiteCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Libro libro = new Libro();
                libro.Codigo = reader.GetInt32(0);
                libro.Titulo = reader.GetString(1);
                libro.Autor = reader.GetString(2);
                libro.Editorial = reader.GetString(3);
                libro.Ubicacion = reader.GetString(4);
                libro.Cantidad = reader.GetInt32(5);
                libro.Precio = reader.GetFloat(6);
                libros.Add(libro);
            }
            reader.Close();
            con.Close();
            return libros;
        }

        public int RegistrarVenta(int codigo)
        {
            int result =0;
            Conectar();
            try
            {
                string query = "UPDATE libro SET cantidad= cantidad-1 WHERE codigo="+codigo;
                cmd = new SQLiteCommand(query, con);
                result = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                mensaje=ex.Message;
            }
            con.Close();
            return result;
        }
    }
}
