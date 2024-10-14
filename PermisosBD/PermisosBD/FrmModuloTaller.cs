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
    public partial class FrmModuloTaller : Form
    {
        public FrmModuloTaller()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            /*FrmLogin l = new FrmLogin();
            l.Show();*/

           FrmHerramientas h=new FrmHerramientas();
            h.Show();
        }
    }
}
