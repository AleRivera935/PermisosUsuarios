using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadHerramienta
    {
        public EntidadHerramienta(int codigoHerramientas, string nombre, int medida, string marca, string descripcion)
        {
            this.codigoHerramientas = codigoHerramientas;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }

        public int codigoHerramientas { get; set; }
        public string Nombre { get; set; }
        public int Medida { get; set; }
        public string Marca { get; set;}
        public string Descripcion { get; set; }
    }
}
