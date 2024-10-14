using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorBuscar
    {
        Base b = new Base("localhost", "root", "", "PermisosUsuarios");
        public void MostrarNombre(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource =
            b.Consultar($"select * from Usuarios where Nombre like '%{filtro}%'", "Usuarios").Tables[0];
            Tabla.AutoResizeColumns();
            Tabla.AutoResizeRows();
        }

        public void MostrarApellidos(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource =
            b.Consultar($"select * from Usuarios where ApellidoP, ApellidoM like '%{filtro}%'", "Usuarios").Tables[0];
            Tabla.AutoResizeColumns();
            Tabla.AutoResizeRows();
        }

    }
}
