
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermisosBD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string permisosUsuario = ManejadorLogin.tipo; 
            if (permisosUsuario == "Lectura")
            { 
                ModuloRefacciones.Enabled = true;
                ModuloTaller.Enabled = true;
                btnUsuarios.Visible = false; 
            }
            else if (permisosUsuario == "Escritura")
            {
                ModuloRefacciones.Enabled = true;
                ModuloTaller.Enabled = true;
                btnUsuarios.Visible = false; 
            }
            else if (permisosUsuario == "Administrador")
            {
                ModuloRefacciones.Enabled = true;
                ModuloTaller.Enabled = true;
                btnUsuarios.Visible = true;  
            }

        }

        private void ModuloRefacciones_Click(object sender, EventArgs e)
        {
            FrmModuloRefacciones mr = new FrmModuloRefacciones();
            mr.Show();
        }

        private void ModuloTaller_Click(object sender, EventArgs e)
        {
            FrmModuloTaller mt = new FrmModuloTaller();
            mt.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios u = new FrmUsuarios();
            u.Show();
        }
    }
}
