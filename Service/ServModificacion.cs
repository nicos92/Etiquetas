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
        

        internal static void IngresarModificacion(string fecha, string numero, string destino, string tipo, string descripcion)
        {
            RepoModificacion.IngresarModificacion(fecha, numero, destino, tipo, descripcion);
        }
    }
}
