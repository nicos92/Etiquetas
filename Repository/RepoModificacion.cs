using Etiquetas.BDConnection;
using Etiquetas.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas.Repository
{
    public class RepoModificacion
    {
        public static int IngresarModificacion(string fecha, string numero, string destino, string tipo, string descripcion)
        {
            int result = 0;
            string insert = $"INSERT INTO etiquetasmod (fecha, numero, destino, tipo, descripcion) VALUES ('{fecha}', '{numero}', '{destino}', '{tipo}', '{descripcion}');";

            try
            {
                using (NpgsqlCommand cmd = new(insert, BDNpgsql.Instance.GetConnection))
                {
                    result = cmd.ExecuteNonQuery();
                    
                }

                BDNpgsql.Instance.CloseConnection();
            }
            catch (NpgsqlException e)
            {
                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show("Error en base de datos INVALID OPERATION", e.Message);
            }

            return result;
        }

        public static int IngresarModificacionDoble(string fecha, string numero, string destino, string descripcion)
        {
            int result = 0;
            string insert = $"INSERT INTO etiquetasmod (fecha, numero, destino, tipo, descripcion) VALUES ('{fecha}', '{numero}', '{destino}', 'INTERNA', '{descripcion}')," +
                $"('{fecha}', '{numero}', '{destino}', 'EXTERNA', '{descripcion}');";

            try
            {
                using (NpgsqlCommand cmd = new(insert, BDNpgsql.Instance.GetConnection))
                {
                    result = cmd.ExecuteNonQuery();
                }

                BDNpgsql.Instance.CloseConnection();
            }
            catch (NpgsqlException e)
            {
                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show("Error en base de datos SQL EXCEPTION", e.Message);
            }
            catch (InvalidOperationException e)
            {
                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show("Error en base de datos INVALID OPERATION", e.Message);
            }

            return result;
        }

        public static List<Modificacion> GetModificacionList(string tipo, string destino, string numero)
        {

            List<Modificacion> modificacions = [];

            try
            {
                string list1 = "select id, fecha, tipo, destino, numero, descripcion from etiquetasmod where date_delete is null and tipo like '%" + tipo +"%' and destino like '%"+ destino +"%' and numero like '%"+ numero + "%' ORDER BY id DESC ;";


               

                using NpgsqlCommand cmd = new(list1, BDNpgsql.Instance.GetConnection);
                using NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Modificacion modificacion = new()
                    {
                        Id = reader.GetInt32(0),
                        Fecha = reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                        Tipo = reader.GetString(2),
                        Destino = reader.GetString(3),
                        Numero = reader.GetString(4),
                        Descripcion = reader.GetString(5)
                    };

                    modificacions.Add(modificacion);
                }

            }
            catch (NpgsqlException e)
            {

                Console.WriteLine(e.Message);
            }
            return modificacions;
        }

        public static int UpdateModificacion()
        {
            int result = 0;
            try
            {
                string update = $"update modificacion set";
            }
            catch (NpgsqlException e)
            {

                Console.WriteLine(e.Message);
            }
            return result;
        }

        public static int DeleteLogicoModificacion()
        {
            int result = 0;

            try
            {

            }
            catch (NpgsqlException e)
            {

                Console.WriteLine(e.Message);
            }
            return result;
        }

        internal static List<string> GetListDestinos(string text)
        {
            List<string> destinos = [];

            try
            {

                string list = "select destino from etiquetasmod where date_delete is null and tipo like '%"+GetTipo(text)+"' group by destino;";

                NpgsqlCommand cmd = new(list, BDNpgsql.Instance.GetConnection);
                using NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string destino = reader.GetString(0);
                    destinos.Add(destino);
                }


            }
            catch (NpgsqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return destinos;
        }

        private static string GetTipo(string text)
        {
            if (text == "AMBOS")
            {
                return "ERNA";
            }
            return text;
        }

        internal static IEnumerable<object> GetListNumeros(string tipo, string destino)
        {
            List<string> numeros = [];

            try
            {
                string list = "select numero from etiquetasmod where date_delete is null and tipo like '%"+GetTipo(tipo)+"'  and destino = '"+ destino +"' group by numero;";


                NpgsqlCommand cmd = new(list, BDNpgsql.Instance.GetConnection);
                using NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string numero = reader.GetString(0).ToUpper();
                    numeros.Add(numero);
                }
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return numeros;
        }
    }
}
