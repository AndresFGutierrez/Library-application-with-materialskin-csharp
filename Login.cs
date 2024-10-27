using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        MaterialSkinManager skinManager= MaterialSkin.MaterialSkinManager.Instance;
        public Login()
        {
            //skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600, 
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange700, 
                TextShade.BLACK
                );
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtUsuario.Text)))
            { 
                string user = txtUsuario.Text;
                string pass=txtClave.Text;
                gestionDB gestionDB = new gestionDB();
                if(gestionDB.Login(user, pass))
                {
                    MenuPpal form2 = new MenuPpal();
                    form2.Form1 = this;
                    Limpiar();
                    this.Hide();
                    form2.Show();
                    
                }
                else
                {
                    Limpiar();
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void Limpiar()
        {
            txtClave.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
