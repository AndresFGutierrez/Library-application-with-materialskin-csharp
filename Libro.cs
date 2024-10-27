using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Libro
    {
        //atributos
        int codigo;
        string titulo;
        string autor;
        string editorial;
        string ubicacion;
        int cantidad;
        float precio;


        public Libro() { }

        public Libro(int codigo, string titulo, string autor, 
            string editorial, string ubicacion, int cantidad, float precio)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.ubicacion = ubicacion;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
