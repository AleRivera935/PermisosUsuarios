using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadUsuario
    {
        public EntidadUsuario(string nombre, string apellidoP, string apellidoM, int fechaNacimiento, int rFC, int nIC, string contraseña)
        {
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            FechaNacimiento = fechaNacimiento;
            RFC = rFC;
            NIC = nIC;
            Contraseña = contraseña;
        }

        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM  { get; set; }
        public int FechaNacimiento { get; set; }
        public int RFC{  get; set; }
        public int NIC { get; set; }
        public string Contraseña { get; set; }
    }
}
