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
    public partial class FrmModuloRefacciones : Form
    {
        public FrmModuloRefacciones()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmLogin l=new FrmLogin();
            l.Show();

           /* FrmProductos p= new FrmProductos();
            p.Show();*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
