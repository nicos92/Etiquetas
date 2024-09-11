using Etiquetas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas.Singleton
{
    public class SingleModificacion
    {
        private SingleModificacion() { }

        private static SingleModificacion _instance;
        private static  Modificacion modificacion;
        private static readonly object _lock = new ();

        public static SingleModificacion Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingleModificacion();
                            modificacion = new Modificacion();
                        }
                    }
                }
                return _instance;
            }
        }

        public  Modificacion GetModificacion
        {
            get
            {
                return modificacion;
            }
        }

        public void SetModificacion(int id, string fecha, string tipo, string destino,string numero, string descripcion)
        {

            modificacion.Id = id;
            modificacion.Fecha = fecha;
            modificacion.Tipo = tipo;
            modificacion.Destino = destino;
            modificacion.Numero = numero;
            modificacion.Descripcion = descripcion;

        }
    }
}
