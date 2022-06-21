using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class GestorSql
    {
        private static string connectionString;

        static GestorSql()
        {
            GestorSql.connectionString = "Server=.;Database=bomberos-db;Trusted_Connection=True;";
        }

        public static string LeerDatos()
        {
            string query = "select * from log";
            string concatenacion = String.Empty;//o string builder
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSql.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        concatenacion += reader.GetString(1) + '\n';
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer los datos de la base", ex);
            }
            return concatenacion;
        }

        public static void GuardarDatos(string info)
        {
            string query = "insert into log (entrada, alumno) " +
                "values (@info, 'Mica vazzana')";
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorSql.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("info",info);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar en la base", ex);
            }
        }
    }
}
