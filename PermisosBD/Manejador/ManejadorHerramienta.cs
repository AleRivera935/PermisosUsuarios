using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorHerramienta
    {
        Base b = new Base("localhost", "root", "", "PermisosUsuarios");
        public string Guardar(TextBox CodigoBarras, TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion)
        {
            try
            {
                return b.Comando($"INSERT INTO Herramientas VALUES ({CodigoBarras.Text},'{Nombre.Text}','{Medida.Text}','{Marca.Text}','{Descripcion.Text}')");
            }
            catch (Exception)
            {
                return "Error de Valor";
            }
        }

        public void Mostrar(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource = b.Consultar($"select  codigoHerramientas, Nombre, Medida, Marca, Descripcion from Herramientas where codigoHerramientas like '%{filtro}", "Herramientas").Tables[0];
            Tabla.Columns.Insert(6, Boton("Eliminar", Color.Pink));
            Tabla.Columns.Insert(5, Boton("Modificar", Color.Green));
            Tabla.AutoResizeColumns();
            Tabla.AutoResizeRows();
        }
        DataGridViewButtonColumn Boton(string t, Color f)
        {
            DataGridViewButtonColumn x = new DataGridViewButtonColumn();
            x.Text = t;
            x.UseColumnTextForButtonValue = true;
            x.FlatStyle = FlatStyle.Popup;
            x.DefaultCellStyle.ForeColor = Color.White;
            x.DefaultCellStyle.BackColor = f;
            return x;
        }

        public void Borrar(int codigoHerramientas, string Dato)
        {
            DialogResult rs = MessageBox.Show($"Esta seguro de borrar:{Dato}", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from Herramientas where codigoHerramientas={codigoHerramientas}");
                MessageBox.Show("Registro Eliminado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(int codigoHerramientas, TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion)
        {
            b.Comando($"update Herramientas set Nombre='{Nombre.Text}', Medida='{Medida.Text}', Marca='{Marca.Text}', Descripcion='{Descripcion.Text}'  where codigoHerramientas={codigoHerramientas}");
            MessageBox.Show("Registro Modificado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        public void BuscarH(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource =
            b.Consultar($"select * from Herramientas where Nombre like '%{filtro}%'", "Herramientas").Tables[0];
            Tabla.Columns.Insert(5, Boton("Modificar", Color.Pink));
            Tabla.Columns.Insert(6, Boton("Eliminar", Color.Pink));
            Tabla.AutoResizeColumns();
            Tabla.AutoResizeRows();
        }
        public DataTable ObtenerHerramientas()
        {
            return b.Consultar("SELECT codigoHerramientas, Nombre, Medida, Marca, Descripcion FROM Herramientas", "Herramientas").Tables[0];
        }
        public DataTable Consultar(string consulta)
        {
            return b.Consultar(consulta, "Herramientas").Tables[0];
        }

    }
}
