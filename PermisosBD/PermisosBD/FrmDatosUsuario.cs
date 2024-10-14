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
using Entidades;

namespace PermisosBD
{
    public partial class FrmDatosUsuario : Form
    {
        ManejadorUsuario mu;
        public static int idUsuario,idFormulario;
        public static string Nombre, ApellidoP, ApellidoM, FechaNacimiento, RFC, NIC, Contraseña, nombreFormulario;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            txtNombre.Clear ();
            txtApellidoP.Clear ();
            txtApellidoM.Clear ();
            txtFechaNacimiento.Clear ();
            txtRFC.Clear ();
            txtContraseña.Clear ();
            txtNic.Clear ();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.idUsuario > 0)
            {

                mu.Modificar(FrmUsuarios.idUsuario, txtNombre, txtApellidoP, txtApellidoM, txtFechaNacimiento,txtRFC,txtContraseña,txtNic,txtIdFormulario,comboBox1);
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtFechaNacimiento.Clear();
                txtRFC.Clear(); 
                txtContraseña.Clear();
                txtNic.Clear();
                txtIdFormulario.Clear();
                comboBox1.Items.Clear ();
            }
            else
            {

                mu.Guardar(txtNombre, txtApellidoP, txtApellidoM, txtFechaNacimiento,txtRFC, txtContraseña,txtNic, txtIdFormulario, comboBox1);
                txtNombre.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtFechaNacimiento.Clear();
                txtRFC.Clear();
                txtContraseña.Clear();
                txtNic.Clear();
                txtIdFormulario.Clear();
                comboBox1.Items.Clear();
            }
            MessageBox.Show("Correcto", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int fila = 0, columna = 0;
        public FrmDatosUsuario()
        {
            InitializeComponent();
            mu=new ManejadorUsuario();
            if (FrmUsuarios.idUsuario > 0)
            {
                txtNombre.Text = FrmUsuarios.Nombre;
                txtApellidoP.Text = FrmUsuarios.ApellidoP;
                txtApellidoM.Text = FrmUsuarios.ApellidoM;
                txtFechaNacimiento.Text = FrmUsuarios.FechaNacimiento;
                txtRFC.Text=FrmUsuarios.RFC;
                txtContraseña.Text = FrmUsuarios.Contraseña;
                txtNic.Text = FrmUsuarios.NIC;
                txtIdFormulario.Text = FrmUsuarios.idFormulario.ToString();
                comboBox1.Text = FrmUsuarios.nombreFormulario;
            }
        }
    }
}
