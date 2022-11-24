using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConexionBaseDeDatos
{
    public class ConexionBaseDatos
    {
        private SqlConnection conexion;
        private String cadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" +
            "Database=ajomuch92_coderhouse_csharp_40930;" +
            "User Id=ajomuch92_coderhouse_csharp_40930;" +
            "Password=ElQuequit0Sexy2022;";

        public ConexionBaseDatos()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {

            }
        }

        public List<Usuario> listarUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = long.Parse(reader["Id"].ToString());
                                usuario.Nombre = reader["Nombre"].ToString();
                                usuario.Apellido = reader["Apellido"].ToString();
                                usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                                usuario.Contrasenia = reader["Contraseña"].ToString();
                                usuario.Mail = reader["Mail"].ToString();
                                lista.Add(usuario);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tiene registros...");
                        }
                    }
                }
                conexion.Close();
            }
            catch(Exception ex)
            {

            }
            return lista;
        }

        public int InsertarUsuario(Usuario usuario)
        {
            try
            {
                string query = "INSERT INTO Usuario(Nombre, Apellido, NombreUsuario, Contraseña, mail) " +
                    "VALUES(@nombre, @apellido, @nombreUsuario, @contrasenia, @mail); SELECT @@IDENTITY;";
                conexion.Open();
                int ultimoIdInsertado = 0;
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.Add(new SqlParameter("nombre", SqlDbType.VarChar) { Value = usuario.Nombre});
                    command.Parameters.Add(new SqlParameter("apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    command.Parameters.Add(new SqlParameter("nombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    command.Parameters.Add(new SqlParameter("contrasenia", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                    command.Parameters.Add(new SqlParameter("mail", SqlDbType.VarChar) { Value = usuario.Mail });

                    /* Este método retorna las filas afectadas por la consulta */
                    //filasAfectadas = command.ExecuteNonQuery();

                    // Este método sirve para obtener un valor simple de la consulta realizada
                    ultimoIdInsertado = Convert.ToInt32(command.ExecuteScalar());
                    usuario.Id = ultimoIdInsertado;
                }
                conexion.Close();
                return ultimoIdInsertado;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int EliminarUsuario(long idUsuario)
        {
            try
            {
                string query = "DELETE FROM Usuario WHERE id = @idUsuario;";
                conexion.Open();
                int filasAfectadas = 0;
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.BigInt) { Value = idUsuario });
                    filasAfectadas = command.ExecuteNonQuery();
                }
                conexion.Close();
                return filasAfectadas;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int CambiarContrasenia(Usuario usuario)
        {
            try
            {
                string query = "UPDATE Usuario SET Contraseña = @contrasenia WHERE id = @idUsuario";
                conexion.Open();
                int filasAfectadas = 0;
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.BigInt) { Value = usuario.Id });
                    command.Parameters.Add(new SqlParameter("contrasenia", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                    filasAfectadas = command.ExecuteNonQuery();
                }
                conexion.Close();
                return filasAfectadas;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int CambiarContrasenia(long IdUsuario, string nuevaContrasenia)
        {
            try
            {
                string query = "UPDATE Usuario SET Contraseña = @contrasenia WHERE id = @idUsuario";
                conexion.Open();
                int filasAfectadas = 0;
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.BigInt) { Value = IdUsuario });
                    command.Parameters.Add(new SqlParameter("contrasenia", SqlDbType.VarChar) { Value = nuevaContrasenia });
                    filasAfectadas = command.ExecuteNonQuery();
                }
                conexion.Close();
                return filasAfectadas;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
