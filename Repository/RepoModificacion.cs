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

        public static async Task<int> InsertDataAsync(string fecha, string numero, string destino, string tipo, string descripcion)
        {
            int result = 0;
            var conn =await  BDNpgsql.Instance.GetConnectionAsync();

            string insert = $"INSERT INTO etiquetasmod (fecha, numero, destino, tipo, descripcion) VALUES ('{fecha}', '{numero}', '{destino}', '{tipo}', '{descripcion}');";

            try
            {
                using var cmd = new NpgsqlCommand(insert, conn);
                result = await cmd.ExecuteNonQueryAsync();
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
            BDNpgsql.Instance.CloseConnection();

            return result;

        }

        public static async Task<int> InsertDateDobleAsync(string fecha, string numero, string destino, string descripcion)
        {

            int result = 0;
            string insert = $"INSERT INTO etiquetasmod (fecha, numero, destino, tipo, descripcion) VALUES ('{fecha}', '{numero}', '{destino}', 'INTERNA', '{descripcion}')," +
                $"('{fecha}', '{numero}', '{destino}', 'EXTERNA', '{descripcion}');";

            try
            {
                using (NpgsqlCommand cmd = new(insert, await BDNpgsql.Instance.GetConnectionAsync()))
                {
                    result = await cmd.ExecuteNonQueryAsync();
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




        public static async Task<List<string[]>> GetModificacionListAsync(string tipo, string destino, string numero)
        {

            //List<Modificacion> modificacions = [];
            List<string[]> mistrings = new List<string[]>();

            try
            {
                string list1 = "select id, fecha, tipo, destino, numero, descripcion from etiquetasmod where date_delete is null and tipo like '%" + tipo + "%' and destino like '%" + destino + "%' and numero like '%" + numero + "%' ORDER BY id DESC ;";




                using NpgsqlCommand cmd = new(list1, await BDNpgsql.Instance.GetConnectionAsync());
                await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    string[] list2 = new string[6];
                    
                    Modificacion modificacion = new()
                    {
                        Id= reader.GetInt64(0),
                        Fecha = reader.GetDateTime(1).ToString("yyyy-MM-dd"),
                        Tipo = reader.GetString(2),
                        Destino = reader.GetString(3),
                        Numero = reader.GetString(4),
                        Descripcion = reader.GetString(5)
                    };
                    

                    
                        list2[0] = modificacion.Id.ToString();
                    list2[1] = modificacion.Fecha;

                    list2[2] = modificacion.Tipo;
                    list2[3] = modificacion.Destino;
                    list2[4] = modificacion.Numero;
                    list2[5] = modificacion.Descripcion;


                    mistrings.Add(list2);

                    //modificacions.Add(modificacion);
                }
                BDNpgsql.Instance.CloseConnection();


            }
            catch (NpgsqlException e)
            {

                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show("Error en base de datos SQL EXCEPTION", e.Message);
                
            }
            return mistrings;
        }

        public static async Task<int> GetCountModificacionListAsync(string tipo, string destino, string numero)
        {
            int count = 0;

            try
            {
                string list1 = "select count(id) from etiquetasmod where date_delete is null and tipo like '%" + tipo + "%' and destino like '%" + destino + "%' and numero like '%" + numero + "%' ;";




                using NpgsqlCommand cmd = new(list1, await BDNpgsql.Instance.GetConnectionAsync());
                using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    count = reader.GetInt32(0);
                        
                        }
                BDNpgsql.Instance.CloseConnection();

            }
            catch (NpgsqlException e)
            {

                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show("Error en base de datos SQL EXCEPTION", e.Message);

            }
            return count;
        }

        public static async Task UpdateModificacionAsync(string id, string fecha, string tipo, string destino, string numero, string descripcion)
        {




            string update = $"update etiquetasmod set fecha ='" + fecha + "',   tipo ='" + tipo + "', destino='" + destino + "', numero='" + numero + "', descripcion='" + descripcion + "', date_modify=current_date, time_modify=current_time where id=" + id + ";";
            try
            {
                using (NpgsqlCommand cmd = new(update, await BDNpgsql.Instance.GetConnectionAsync()))
                {
                    await cmd.ExecuteNonQueryAsync();
                }

                BDNpgsql.Instance.CloseConnection();
            }
            catch (NpgsqlException e)
            {
                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show("Error en base de datos SQL EXCEPTION", e.Message);
                return;
            }
            catch (InvalidOperationException e)
            {
                BDNpgsql.Instance.CloseConnection();
                System.Windows.Forms.MessageBox.Show("Error en base de datos INVALID OPERATION", e.Message);
                return;

            }
            Utils.Util.CartelConfirmInfo("Actualización Correcta", "ACTUALIZACION");

        }

        public static async Task<int> DeleteLogicoModificacionAsync(int id)
        {
            int result = 0;

            string insert = $"update etiquetasmod set date_delete=current_date, time_delete=current_time where id=" + id + ";";

            try
            {
                using var cmd = new NpgsqlCommand(insert, await BDNpgsql.Instance.GetConnectionAsync());
                result = await cmd.ExecuteNonQueryAsync();
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



        public async static Task<List<string>> GetListDestinosAsync(string text)
        {
            List<string> destinos = [];

            try
            {

                string list = "select destino from etiquetasmod where date_delete is null and tipo like '%" + GetTipo(text) + "%' group by destino;";

                NpgsqlCommand cmd = new(list,await BDNpgsql.Instance.GetConnectionAsync());
                using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
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




        public static async Task<List<string>> GetListNumerosAsync(string tipo, string destino)
        {
            List<string> numeros = [];

            try
            {
                string list = "select numero from etiquetasmod where date_delete is null and tipo like '%" + GetTipo(tipo) + "'  and destino = '" + destino + "' group by numero;";


                NpgsqlCommand cmd = new(list, await BDNpgsql.Instance.GetConnectionAsync());
                using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
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

        private static string GetTipo(string text)
        {
            if (text == "AMBOS")
            {
                return "ERNA";
            }
            return text;
        }


    }
}
