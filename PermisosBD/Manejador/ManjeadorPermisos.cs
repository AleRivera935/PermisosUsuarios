using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Entidades;

namespace Manejador
{
    public class ManjeadorPermisos
    {
        Base b = new Base("localhost", "root", "", "PermisosUsuarios");
        public string ObtenerNivelPermiso(string nic, string contrasena)
        {
            try
            {
                DataSet ds = b.Consultar($"call p_Validar('{nic}','{contrasena}')", "permisos");
                DataTable dt = ds.Tables[0];

                if (dt.Rows[0]["rs"].ToString().Equals("C0rr3Ct0"))
                {
                    return dt.Rows[0]["Nivel"].ToString();
                }
                return "Error";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener nivel de permisos: " + ex.Message);
                return "Error";
            }
        }
        public void AplicarPermisos(string nivel, Form formulario, int idUsuario)
        {
            if (nivel == "LECTURA")
            {
                // Si es cliente, mostramos el mensaje y cerramos el formulario
                MessageBox.Show("No tienes permisos para acceder a este módulo.");
                formulario.Close();
                return; // Salimos de la función
            }

            foreach (Control control in formulario.Controls)
            {
                if (control is Button btn)
                {
                    // Ajustamos los botones de acuerdo con el nivel de acceso
                    if (nivel == "ADMINISTRADOR")
                    {
                        // Administrador tiene acceso completo
                    }
                    else if (nivel == "ESCRITURA")
                    {
                        if (btn.Name.Contains("Admin") || btn.Name.Contains("Eliminar"))
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}
 