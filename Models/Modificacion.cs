using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas.Models
{
    public class Modificacion
    {
        public Int64 Id { get; set; }
        public string Fecha { get; set; }
        public string Tipo { get; set; }
        public string Destino { get; set; }
        public string Numero { get; set; }
        public string Descripcion { get; set; }

        public Modificacion() { }

        public Modificacion(Int64 id, string fecha, string tipo, string numero, string destino, string descripcion)
        {
            Id = id;
            Fecha = fecha;
            Tipo = tipo;
            Destino = destino;
            Numero = numero;
            Descripcion = descripcion;
        }

        public Modificacion(string fecha, string tipo, string numero, string destino, string descripcion)
        {
            Fecha = fecha;
            Tipo = tipo;
            Destino = destino;
            Numero = numero;
            Descripcion = descripcion;
        }
    }
}
