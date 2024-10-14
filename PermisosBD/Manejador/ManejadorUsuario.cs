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
using Entidades;

namespace Manejador
{
    public class ManejadorUsuario
    {
        Base b = new Base("localhost", "root", "", "PermisosUsuarios");
        public string Guardar(TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, TextBox FechaNacimiento, TextBox RFC, TextBox NIC, TextBox Contraseña, TextBox IdFormulario, ComboBox NombreFormulario)
        {
            try
            {
                return b.Comando($"INSERT INTO Usuarios VALUES (NULL,'{Nombre.Text}','{ApellidoP.Text}','{ApellidoM.Text}','{FechaNacimiento.Text}','{RFC.Text}','{NIC.Text}', SHA1('{Contraseña.Text}'),'{IdFormulario.Text}','{NombreFormulario.Text}');");
            }
            catch (Exception)
            {
                return "Error de Valor";
            }
        }

        public void Mostrar(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource = b.Consultar($"select  idUsuario, Nombre, ApellidoP, ApellidoM,fechaNacimiento, RFC, NIC, Contraseña, idFormulario,nombreFormulario from Usuarios where idUsuario like '%{filtro}", "Usuarios").Tables[0];
            Tabla.Columns.Insert(11, Boton("Eliminar", Color.Pink));
            Tabla.Columns.Insert(12, Boton("Modificar", Color.Green));
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

        public void Borrar(int idusuario, string Dato)
        {
            DialogResult rs = MessageBox.Show($"Esta seguro de borrar:{Dato}", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.Comando($"delete from Usuarios where idUsuario={idusuario}");
                MessageBox.Show("Registro Eliminado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(int idusuario, TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, TextBox FechaNacimiento, TextBox RFC,TextBox NIC, TextBox Contraseña, TextBox IdFormulario, ComboBox NombreFormulario)
        {
            b.Comando($"update Usuarios set Nombre='{Nombre.Text}', ApellidoP='{ApellidoP.Text}', ApellidoM='{ApellidoM.Text}', FechaNacimiento='{FechaNacimiento.Text}',contraseña='{Contraseña.Text}',idFormulario='{IdFormulario.Text}',nombreFormulario='{NombreFormulario.Text}' where idUsuario={idusuario}");
            MessageBox.Show("Registro Modificado", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static string Sha1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            byte[] TextOriginal = ASCIIEncoding.Default.GetBytes(texto);
            byte[] hash = sha1.ComputeHash(TextOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
        public void BuscarU(DataGridView Tabla, string filtro)
        {
            Tabla.Columns.Clear();
            Tabla.DataSource =
            b.Consultar($"select * from Usuarios where Nombre like '%{filtro}%'", "Usuarios").Tables[0];
            Tabla.Columns.Insert(10, Boton("Modificar", Color.Green));
            Tabla.Columns.Insert(11, Boton("Eliminar", Color.Pink));
            Tabla.AutoResizeColumns();
            Tabla.AutoResizeRows();

        }
        public DataTable ObtenerUsuarios()
        {
            return b.Consultar("SELECT idUsuario, Nombre, ApellidoP, ApellidoM FROM Usuarios", "Usuarios").Tables[0];
        }
        public DataTable Consultar(string consulta)
        {
            return b.Consultar(consulta, "Usuarios").Tables[0];
        }

    }
}
