using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace PermisosBD
{

    public partial class FrmUsuarios : Form
    {
        ManejadorUsuario mu;
        public static int idUsuario, idFormulario;
        public static string Nombre, ApellidoP, ApellidoM, FechaNacimiento, RFC, NIC, Contraseña, nombreFormulario;

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            FrmDatosUsuario du= new FrmDatosUsuario();
            du.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dtgvUsuarios.Visible = true;
            mu.BuscarU(dtgvUsuarios, txtBuscar.Text);
        }

        int fila = 0, columna = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuario();
        }

        private void dtgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 11:
                    {
                        idUsuario = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        mu.Borrar(idUsuario, dtgvUsuarios.Rows[fila].Cells[1].Value.ToString());
                        dtgvUsuarios.Visible = true;
                    }
                    break;
                case 12:
                    {

                        idUsuario = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                        ApellidoP = dtgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                        ApellidoM = dtgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                        FechaNacimiento = dtgvUsuarios.Rows[fila].Cells[4].Value.ToString();
                        RFC = dtgvUsuarios.Rows[fila].Cells[5].Value.ToString();
                        NIC = dtgvUsuarios.Rows[fila].Cells[6].Value.ToString();
                        Contraseña = dtgvUsuarios.Rows[fila].Cells[7].Value.ToString();
                        idFormulario = int.Parse(dtgvUsuarios.Rows[fila].Cells[8].Value.ToString());
                        nombreFormulario = dtgvUsuarios.Rows[fila].Cells[9].Value.ToString();

                        FrmDatosUsuario du = new FrmDatosUsuario();
                        du.ShowDialog();
                        dtgvUsuarios.Visible = true;

                    }
                    break;

            }
        }
    }
}
