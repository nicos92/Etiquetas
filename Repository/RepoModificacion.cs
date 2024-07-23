using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas.Repository
{
    public class RepoModificacion
    {
        public static void IngresarModificacion(string fecha, string numero, string destino, string tipo, string descripcion)
        {
			try
			{

			}
			catch (NpgsqlException e)
			{

                Console.WriteLine(  e.Message);
            }
        }
    }
}
