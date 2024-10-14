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
    public partial class FrmDatosProductos : Form
    {
        ManejadorProductos mp;
        public static int codigoBarras;
        public static string Nombre, Descripción, Marca;
        int fila = 0, columna = 0;
        public FrmDatosProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if (FrmProductos.codigoBarras > 0)
            {
                txtNombre.Text = FrmProductos.Nombre;
                txtDescripcion.Text = FrmProductos.Descripción;
                txtMarca.Text = FrmProductos.Marca;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmProductos.codigoBarras > 0)
            {

                mp.Modificar(FrmProductos.codigoBarras, txtNombre, txtDescripcion, txtMarca);
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtMarca.Clear();
            }
            else
            {

                mp.Guardar(txtcodigoBarras,txtNombre, txtDescripcion, txtMarca);
                txtcodigoBarras.Clear();
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtMarca.Clear();

            }
            MessageBox.Show("Correcto", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            txtcodigoBarras.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
        }
    }
}
