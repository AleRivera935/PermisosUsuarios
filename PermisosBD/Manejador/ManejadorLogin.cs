using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using AccesoDatos;
using System.Data;
using System.Windows.Forms;
using Entidades;


namespace Manejador
{
    public class ManejadorLogin
    {
        Base b = new Base("localhost", "root", "", "PermisosUsuarios");
        public static string tipo = "", formulario = "";
        public string validar(TextBox Usuario, TextBox Contraseña)
        {

            DataSet ds = b.Consultar($"call p_validarU('{Usuario.Text}','{Sha1(Contraseña.Text)}')", "Login");
            DataTable dt = ds.Tables[0];
            if (dt.Rows[0]["rs"].ToString().Equals("Correcto"))
            {
                tipo = dt.Rows[0]["tipo"].ToString();
                formulario = dt.Rows[0]["formulario"].ToString(); 
                return formulario;
            }
            else
            {
                return "Error";
            }
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

    }
}