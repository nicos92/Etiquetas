using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas.BDConnection
{
    public sealed class BDNpgsql
    {
        private static BDNpgsql _instance = null;
        private static readonly object _lock = new object();
        private NpgsqlConnection _conn;

        private BDNpgsql()
        {
            string connString = "";
            _conn = new NpgsqlConnection(connString);
        }

        public static BDNpgsql Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BDNpgsql();
                        }
                    }
                }
                return _instance;
            }
        }

        public NpgsqlConnection GetConnection()
        {

            if (_conn.State != System.Data.ConnectionState.Open)
                _conn.Open();

            return _conn;

        }

        public void CloseConnection()
        {
            if (_conn.State != System.Data.ConnectionState.Closed)
                _conn.Close();
        }
    }
}
