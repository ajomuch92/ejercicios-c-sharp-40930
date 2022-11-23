using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String connectionString = "Server=sql.bsite.net\\MSSQL2016;" +
                "Database=ajomuch92_coderhouse_csharp_40930;" +
                "User Id=ajomuch92_coderhouse_csharp_40930;" +
                "Password=ElQuequit0Sexy2022;";
            try
            {
                Console.WriteLine("Creando la conexión");
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario", sqlConnection))
                    {
                        sqlConnection.Open();
                        List<Usuario> lista = new List<Usuario>();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while(reader.Read())
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
                                Console.WriteLine("Imprimiendo lista");
                                foreach(Usuario usuario in lista)
                                {
                                    Console.WriteLine("ID " + usuario.Id);
                                    Console.WriteLine("Nombre " + usuario.Nombre);
                                    Console.WriteLine("Apellido " + usuario.Apellido);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No tiene registros...");
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CreandoConsultas()
        {
            String connectionString = "Server=sql.bsite.net\\MSSQL2016;" +
                "Database=ajomuch92_coderhouse_csharp_40930;" +
                "User Id=ajomuch92_coderhouse_csharp_40930;" +
                "Password=ElQuequit0Sexy2022;";
            try
            {
                Console.WriteLine("Creando la conexión");
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    /*SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Usuario", sqlConnection);
                    sqlConnection.Open();

                    DataSet dataset = new DataSet();
                    sqlDataAdapter.Fill(dataset);*/
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE id=@id", sqlConnection))
                    {
                        SqlParameter sqlParameter = new SqlParameter();
                        sqlParameter.ParameterName = "id";
                        sqlParameter.DbType = DbType.Int64;
                        sqlParameter.Value = 1;
                        cmd.Parameters.Add(sqlParameter);
                        sqlConnection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine(reader.GetInt64(0));
                                    Console.WriteLine(reader.GetString(1));
                                }
                            }
                            else
                            {
                                Console.WriteLine("No tiene registros...");
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ConsultandoProductos()
        {
            String connectionString = "Server=sql.bsite.net\\MSSQL2016;" +
                "Database=ajomuch92_coderhouse_csharp_40930;" +
                "User Id=ajomuch92_coderhouse_csharp_40930;" +
                "Password=ElQuequit0Sexy2022;";
            List<Producto> listaProductos = new List<Producto>();
            try
            {
                Console.WriteLine("Creando la conexión");
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string query = "SELECT codigo, descripcion, precioCompra, precioVenta, categoria FROM productos";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Producto producto = new Producto();
                                    producto.Codigo = Convert.ToInt64(reader["codigo"]);
                                    producto.Descripcion = reader["descripcion"].ToString();
                                    producto.PrecioVenta = Convert.ToDouble(reader["precioVenta"].ToString());
                                    producto.PrecioCompra = Convert.ToDouble(reader["precioCompra"].ToString());
                                    producto.Categoria = reader["categoria"].ToString();
                                    listaProductos.Add(producto);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No tiene registros...");
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
