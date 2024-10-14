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
    public partial class FrmDatosHerramientas : Form
    {
        ManejadorHerramienta mh;
        public static int codigoHerramientas;
        public static string Nombre, Medida, Marca, Descripcion;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmHerramientas.codigoHerramienta > 0)
            {

                mh.Modificar(FrmHerramientas.codigoHerramienta, txtNombre, txtMedida, txtMarca, txtDescripcion);
                txtCodigoBarras.Clear();
                txtNombre.Clear();
                txtMedida.Clear();
                txtMarca.Clear();
                txtDescripcion.Clear(); 
            }
            else
            {

                mh.Guardar(txtCodigoBarras, txtNombre, txtMedida, txtMarca, txtDescripcion);
                txtCodigoBarras.Clear();
                txtNombre.Clear();
                txtMedida.Clear();
                txtMarca.Clear();
                txtDescripcion.Clear();

            }
            MessageBox.Show("Correcto", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            txtCodigoBarras.Clear();
            txtNombre.Clear();
            txtMedida.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
        }

        int fila = 0, columna = 0;
        public FrmDatosHerramientas()
        {
            InitializeComponent();
            mh=new ManejadorHerramienta();
            if (FrmHerramientas.codigoHerramienta > 0)
            {
                txtNombre.Text = FrmHerramientas.Nombre;
                txtMedida.Text = FrmHerramientas.Medida;
                txtMarca.Text = FrmHerramientas.Marca;
                txtDescripcion.Text = FrmHerramientas.Descripcion;
            }
        }
    }
}
