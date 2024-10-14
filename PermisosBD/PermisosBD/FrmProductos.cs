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
    public partial class FrmProductos : Form
    {
        ManejadorProductos mp;
        public static int codigoBarras;
        public static string Nombre, Descripción, Marca;
        int fila = 0, columna = 0;

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgvProductos.Visible = true;
            mp.BuscarP(dtgvProductos, txtBuscar.Text);
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 05:
                    {
                        codigoBarras = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        mp.Borrar(codigoBarras, dtgvProductos.Rows[fila].Cells[1].Value.ToString());
                        dtgvProductos.Visible = true;
                    }
                    break;
                case 04:
                    {

                        codigoBarras = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dtgvProductos.Rows[fila].Cells[1].Value.ToString();
                        Descripción = dtgvProductos.Rows[fila].Cells[2].Value.ToString();
                        Marca = dtgvProductos.Rows[fila].Cells[3].Value.ToString();


                        FrmDatosProductos dp = new FrmDatosProductos();
                        dp.ShowDialog();
                        dtgvProductos.Visible = true;

                    }
                    break;
            }
        }

        public FrmProductos()
        {
            InitializeComponent();
            mp= new ManejadorProductos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
           /* FrmLogin l = new FrmLogin();
            l.Show();*/

            FrmDatosProductos dp = new FrmDatosProductos();
            dp.Show();
        }
    }
}
