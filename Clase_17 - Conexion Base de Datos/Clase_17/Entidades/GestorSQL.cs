using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class GestorSQL
    {
        private static string cadenaConexion;
        static GestorSQL()
        {
            GestorSQL.cadenaConexion = "Server=.;Database=DIV2EClase17;Trusted_Connection=True;";
        }

        /// <summary>
        /// LEE LA BASE DE DATOS COMPLETA
        /// </summary>
        /// <returns></returns>
        public static List<Persona> LeerDatos()
        {
            List<Persona> listaPersonas = new List<Persona>();
            
            string query = "SELECT * FROM personas";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open(); //Abro la conexion
                //El reader va a leer de la query
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string email = reader.GetString(3);
                    string sexo = reader.GetString(4);
                    int edad = reader.GetInt32(5);
                    // O bien podemos castear:
                    // (int)reader["id"];
                    // reader["nombre"].ToString();
                    // Los Get.. ya nos devuelven una excepcion y resulta más practico controlarlo
                    Persona p = new Persona(id, nombre, apellido, email, sexo, edad);
                    listaPersonas.Add(p);
                }
            }
            return listaPersonas;
        }

        /// <summary>
        /// LEE LOS DATOS DE UNA PERSONA QUE ELIJO PASANDO UN ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Persona LeerDatosPorId(int id)
        {
            Persona persona = null;

            //ASI no tenemos sseguridad, puede venirme un comando de sql y borrar de pronto
            //string query = "SELECT * FROM personas where id = "+ id;
            //la manera de resolverlo con seguridad:
            string query = "SELECT * FROM personas where id=@id"; //Luego utilizo Paramters
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id",id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string email = reader.GetString(3);
                    string sexo = reader.GetString(4);
                    int edad = reader.GetInt32(5);
                    persona = new Persona(id, nombre, apellido, email, sexo, edad);
                }
            }
            return persona;
        }

        /// <summary>
        /// DA DE ALTA UNA PERSONA
        /// </summary>
        /// <param name="persona"></param>
        public static void Alta(Persona persona)
        {
            string query = "Insert into personas (nombre, apellido, email, sexo, edad) values (@nombre,@apellido,@email,@sexo,@edad)";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(GestorSQL.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                cmd.Parameters.AddWithValue("email", persona.Mail);
                cmd.Parameters.AddWithValue("sexo", persona.Sexo);
                cmd.Parameters.AddWithValue("edad", persona.Edad);
                cmd.ExecuteNonQuery();//retorna el numero de filas afectadas
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if(connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// BORRA UNA PERSONA
        /// </summary>
        /// <param name="id"></param>
        public static void Borrar(int id)
        {
            string query = "DELETE FROM personas where id=@id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// MODIFICA UNA PERSONA
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="id"></param>
        public static void Actualizar(Persona persona, int id)
        {
            string query = "update personas set nombre=@nombre, apellido=@apellido, email=@email, sexo=@sexo, edad=@edad where id=@id";
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("apellido", persona.Apellido);
                cmd.Parameters.AddWithValue("email", persona.Mail);
                cmd.Parameters.AddWithValue("sexo", persona.Sexo);
                cmd.Parameters.AddWithValue("edad", persona.Edad);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
