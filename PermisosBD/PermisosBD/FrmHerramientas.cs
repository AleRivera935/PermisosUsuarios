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
using Entidades;

namespace PermisosBD
{
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramienta mh;
        public static int codigoHerramienta;
        public static string Nombre, Medida, Marca, Descripcion;
        int fila = 0, columna = 0;

        private void dtgvHerramientas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 06:
                    {
                        codigoHerramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                        mh.Borrar(codigoHerramienta, dtgvHerramientas.Rows[fila].Cells[1].Value.ToString());
                        dtgvHerramientas.Visible = true;
                    }
                    break;
                case 05:
                    {

                        codigoHerramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dtgvHerramientas.Rows[fila].Cells[1].Value.ToString();
                        Medida = dtgvHerramientas.Rows[fila].Cells[2].Value.ToString();
                        Marca = dtgvHerramientas.Rows[fila].Cells[3].Value.ToString();
                        Descripcion = dtgvHerramientas.Rows[fila].Cells[4].Value.ToString();

                        FrmDatosProductos dp = new FrmDatosProductos();
                        dp.ShowDialog();
                        dtgvHerramientas.Visible = true;

                    }
                    break;
            }

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgvHerramientas.Visible = true;
            mh.BuscarH(dtgvHerramientas, txtBuscar.Text);
        }

        public FrmHerramientas()
        {
            InitializeComponent();
            mh=new ManejadorHerramienta();
        }

        private void btnAgregarHerramienta_Click(object sender, EventArgs e)
        {
            /*FrmLogin l= new FrmLogin();
            l.Show();*/

            FrmDatosHerramientas dh=new FrmDatosHerramientas();
            dh.Show();
        }
    }
}
