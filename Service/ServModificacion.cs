using Etiquetas.Models;
using Etiquetas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas.Service
{
    public class ServModificacion
    {
        

        public static int IngresarModificacion(string fecha, string numero, string destino, string tipo, string descripcion)
        {
            return RepoModificacion.IngresarModificacion(fecha, numero, destino, tipo, descripcion);
        }

        public static int IngresarModificacionDoble(string fecha, string numero, string destino,  string descripcion)
        {
            return RepoModificacion.IngresarModificacionDoble(fecha, numero, destino,  descripcion);
        }
        public static List<Modificacion> GetModificacionList(string tipo, string destino, string numero)
        {
            return RepoModificacion.GetModificacionList(tipo, destino, numero);
        }

        public static int UpdateModificacion()
        {
            return RepoModificacion.UpdateModificacion();
        }

        public static int DeleteLogicoModificacion()
        {
            return RepoModificacion.DeleteLogicoModificacion();
        }

        internal static List<string> GetListDestinos(string text)
        {
            return RepoModificacion.GetListDestinos(text);
        }

        internal static IEnumerable<object> GetListNumeros(string tipo, string destino)
        {
            return RepoModificacion.GetListNumeros(tipo, destino);
        }
    }
}
