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
        

        

        
        

        public static int UpdateModificacion()
        {
            return RepoModificacion.UpdateModificacion();
        }

        public static async Task DeleteLogicoModificacionAsync(int id)
        {
            await RepoModificacion.DeleteLogicoModificacionAsync(id);
        }

      

        internal async static Task<List<string>> GetListDestinosAsync(string text)
        {
            return await RepoModificacion.GetListDestinosAsync(text);
        }

       

        internal static async void IngresarModificacionDobleAsync(string fecha, string numero, string destino, string descripcion)
        {
            await RepoModificacion.InsertDateDobleAsync(fecha, numero, destino, descripcion);
        }

        internal static async void  IngresarModificacionAsync(string fecha, string numero, string destino, string tipo, string descripcion)
        {
            await RepoModificacion.InsertDataAsync(fecha, numero, destino, tipo, descripcion);
        }

        internal static async Task<List<Modificacion>> GetModificacionListAsync(string tipo, string destino, string numero)
        {
            return await RepoModificacion.GetModificacionListAsync(tipo,destino, numero);
        }

        internal static async Task<List<String>> GetListNumerosAsync(string tipo, string destino)
        {
            return await RepoModificacion.GetListNumerosAsync(tipo, destino);
        }
    }
}
