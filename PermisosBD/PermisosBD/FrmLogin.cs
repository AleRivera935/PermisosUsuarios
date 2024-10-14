using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace PermisosBD
{
    public partial class FrmLogin : Form
    {
        ManejadorLogin lm;
        public FrmLogin()
        {
            InitializeComponent();
            lm = new ManejadorLogin();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string resultado = lm.validar(txtUsuario, txtContrasena);
            if (resultado != "Error")
            {
                MessageBox.Show("¡Inicio de sesión correcto!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Dependiendo del formulario obtenido, abrir la ventana correspondiente
                switch (resultado)
                {
                    case "Producto":
                        FrmProductos p = new FrmProductos();
                        p.Show();
                        this.Hide(); 
                        break;

                    case "Herramientas":
                        FrmHerramientas h = new FrmHerramientas();
                        h.Show();
                        this.Hide();
                        break;

                    case "Administrador":
                        FrmProductos frmAdminProductos = new FrmProductos();
                        FrmHerramientas frmAdminHerramientas = new FrmHerramientas();
                        FrmUsuarios frmAdminUsuarios = new FrmUsuarios();

                        frmAdminProductos.Show();
                        frmAdminHerramientas.Show();
                        frmAdminUsuarios.Show();
                        this.Hide();
                        break;

                    default:
                        MessageBox.Show("Formulario no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                // Mostrar mensaje de error en caso de que el login sea incorrecto
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
