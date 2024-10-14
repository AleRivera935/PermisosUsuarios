using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManejadorProductos
    {
        Base b = new Base("localhost", "root", "", "PermisosUsuarios");
        public string Guardar(TextBox CodigoBarras, TextBox Nombre, TextBox Descripcion, TextBox Marca)
        {
            try
            {
                return b.Comando($"insert into Producto values ('{CodigoBarras.Text}', '{Nombre.Text}', '{Descripcion.Text}','{Marca.Text}')");
            }
            catch (Exception)
            {
                return "Error de Valor";
            }
        }
        public void Mostrar(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource =
            b.Consultar($"select * from Producto where Nombre like '%{filtro}'", "Producto").Tables[0];
            Tabla.Columns.Insert(5, Boton("Eliminar", Color.Pink));
            Tabla.Columns.Insert(6, Boton("Modificar", Color.Green));
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

        public void Borrar(int CodigoBarras, string Dato)
        {
            DialogResult rs = MessageBox.Show($"Esta seguro de borrar:{Dato}", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from Producto where codigoBarras={CodigoBarras}");
                MessageBox.Show("Registro Eliminado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(int CodigoBarras, TextBox Nombre, TextBox Descripcion, TextBox Marca)
        {
            b.Comando($"update Producto set Nombre='{Nombre.Text}', Descripcion='{Descripcion.Text}', Marca='{Marca.Text}', where codigoBarras={CodigoBarras}");
            MessageBox.Show("Registro Modificado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void BuscarP(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource =b.Consultar($"select * from Producto where Nombre like '%{filtro}%'", "Producto").Tables[0];
            Tabla.Columns.Insert(4, Boton("Modificar", Color.Pink));
            Tabla.Columns.Insert(5, Boton("Eliminar", Color.Pink));
            Tabla.AutoResizeColumns();
            Tabla.AutoResizeRows();
        }
    }
}

