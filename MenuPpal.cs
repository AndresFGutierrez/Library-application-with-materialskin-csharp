using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class MenuPpal : MaterialForm
    {
        PrivateFontCollection pfc;
        MaterialSkinManager skinManager=MaterialSkin.MaterialSkinManager.Instance;
        Login form1 = null; //objeto 
        gestionDB DB = new gestionDB();


        public MenuPpal()
        {
            skinManager.AddFormToManage(this);
            skinManager.EnforceBackcolorOnAllComponents=true;
           
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600,
                Primary.BlueGrey700, Primary.BlueGrey500, Accent.Orange400,
                TextShade.BLACK
                );
           
            InitializeComponent();
        }

        public Login Form1 { get => form1; set => form1 = value; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Close();
            form1.Show();
         
        }
        
        private void materialTabControl1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtTitulo.Text)
                  || string.IsNullOrEmpty(txtAutor.Text) || string.IsNullOrEmpty(txtEditorial.Text)
                  || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtPrecio.Text)
                  || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("No deje campos sin diligenciar", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else { 
                        Libro libro = new Libro();
                        libro.Autor = txtAutor.Text;
                        libro.Codigo=int.Parse(txtCodigo.Text);
                        libro.Editorial=txtEditorial.Text;
                        libro.Titulo=txtTitulo.Text;
                        libro.Ubicacion=txtUbicacion.Text;
                        libro.Precio=float.Parse(txtPrecio.Text);
                        libro.Cantidad=int.Parse(txtCantidad.Text);
                        if(DB.AgregarLibro(libro)>0)
                        {
                            MessageBox.Show("Libro guardado con éxito", "Confirmación",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }               
                    }
                
                 } catch(FormatException ex) {
                            MessageBox.Show("Se produjo un error por: "+ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar();

            } 
        }

        void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtUbicacion.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtEditorial.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {   
            string autor=txtAutorBuscar.Text;

            var libros = DB.BuscarLibroxAutor(autor);
            if (libros.Count > 0)
            {
                CardLibros.Visible = true;
                dataGridView1.DataSource = libros;
            }
            else
            {
                MessageBox.Show("No se encontraron libros del autor", "Confirmación",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoBuscar.Text))
            {
                var libro = DB.BuscarLibroxCodigo(int.Parse(txtCodigoBuscar.Text));
                if(libro!=null)
                {
                    if (libro.Codigo >= 1)
                    {
                        lblTitulo.Text = libro.Titulo;
                        lblAutor.Text = libro.Autor;
                        lblPrecio.Text= "Precio: "+libro.Precio;
                        cardVenta.Visible = true;
                    }
                    else
                           MessageBox.Show("No hay unidades en existencia", "Advertencia",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
                   else
                    MessageBox.Show("libro no encontrado", "Advertencia",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
                MessageBox.Show("Ingrese el codigo del libro a buscar", "Advertencia",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(DB.RegistrarVenta(int.Parse(txtCodigoBuscar.Text))>0)
                MessageBox.Show("Venta registrada con éxito", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
