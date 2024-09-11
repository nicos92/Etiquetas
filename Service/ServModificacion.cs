using Etiquetas.Models;
using Etiquetas.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas.Service
{
    public class ServModificacion
    {
        

        

        
        

        public static async Task UpdateModificacionAsync(string id, string fecha, string tipo, string destino, string numero, string descipcion)
        {
             await RepoModificacion.UpdateModificacionAsync(id, fecha, tipo, destino, numero, descipcion);
        }

        public static async Task<int> DeleteLogicoModificacionAsync(int id)
        {
            return await RepoModificacion.DeleteLogicoModificacionAsync(id);
        }

      

        internal async static Task<List<string>> GetListDestinosAsync(string text)
        {
            return await RepoModificacion.GetListDestinosAsync(text);
        }

       

        internal static async Task<int> IngresarModificacionDobleAsync(string fecha, string numero, string destino, string descripcion)
        {
            return await RepoModificacion.InsertDateDobleAsync(fecha, numero, destino, descripcion);
        }

        internal static async Task<int> IngresarModificacionAsync(string fecha, string numero, string destino, string tipo, string descripcion)
        {
              return await RepoModificacion.InsertDataAsync(fecha, numero, destino, tipo, descripcion);
        }

        internal static  async Task<List<string[]>> GetModificacionListAsync(string tipo, string destino, string numero)
        {
            return await RepoModificacion.GetModificacionListAsync(tipo,destino, numero);
        }

        internal static async Task<int> GetCountModificacionListAsync(string tipo, string destino, string numero)
        {
            return await RepoModificacion.GetCountModificacionListAsync(tipo, destino, numero);
        }

        internal static async Task<List<String>> GetListNumerosAsync(string tipo, string destino)
        {
            return await RepoModificacion.GetListNumerosAsync(tipo, destino);
        }
    }
}
