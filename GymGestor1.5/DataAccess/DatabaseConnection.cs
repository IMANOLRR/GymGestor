using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymGestor1._5.BusinessLogic;
using MySql.Data.MySqlClient;


namespace GymGestor1._5.DataAccess
{
    public static class DatabaseConnection
    {
        private static string connectionString = "Server=localhost;Database=GymGestorDB;User ID=admin;Password=1234;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }


        public static void InsertarUsuario(Usuario usuario)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // insertar un nuevo usuario
                    string query = "INSERT INTO Usuarios (Nombre, Apellido, Cedula, Telefono, Direccion, TipoSuscripcion, EstadoSuscripcion) " +
                                   "VALUES (@Nombre, @Apellido, @Cedula, @Telefono, @Direccion, @TipoSuscripcion, @EstadoSuscripcion)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@Cedula", usuario.Cedula);
                        command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        command.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                        command.Parameters.AddWithValue("@TipoSuscripcion", usuario.TipoSuscripcion);
                        command.Parameters.AddWithValue("@EstadoSuscripcion", usuario.EstadoSuscripcion);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario registrado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                }
            }
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            var usuarios = new List<Usuario>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Nombre, Apellido, Cedula, Telefono, Direccion, TipoSuscripcion, EstadoSuscripcion FROM Usuarios";

                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // objeto Usuario con los datos obtenidos de la base de datos
                            var usuario = new Usuario()
                            {
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                Cedula = reader.GetString("Cedula"),
                                Telefono = reader.GetString("Telefono"),
                                Direccion = reader.GetString("Direccion"),
                                TipoSuscripcion = reader.GetString("TipoSuscripcion"),
                                EstadoSuscripcion = reader.GetString("EstadoSuscripcion")
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los usuarios: " + ex.Message);
                }
            }

            return usuarios;
        }

        public static Usuario ObtenerUsuarioPorCedula(string cedula)
        {
            Usuario usuario = null;

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para obtener el usuario por cédula
                    string query = "SELECT Nombre, Apellido, Cedula, Telefono, Direccion, TipoSuscripcion, EstadoSuscripcion FROM Usuarios WHERE Cedula = @Cedula";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cedula", cedula);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usuario = new Usuario()
                                {
                                    Nombre = reader.GetString("Nombre"),
                                    Apellido = reader.GetString("Apellido"),
                                    Cedula = reader.GetString("Cedula"),
                                    Telefono = reader.GetString("Telefono"),
                                    Direccion = reader.GetString("Direccion"),
                                    TipoSuscripcion = reader.GetString("TipoSuscripcion"),
                                    EstadoSuscripcion = reader.GetString("EstadoSuscripcion")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el usuario: " + ex.Message);
                }
            }

            return usuario;
        }

        public static void InsertarClase(Clase clase)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Clases (NombreClase, Cupos, Fecha, Hora, Encargado, Costo) " +
                                   "VALUES (@NombreClase, @Cupos, @Fecha, @Hora, @Encargado, @Costo)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreClase", clase.NombreClase);
                        command.Parameters.AddWithValue("@Cupos", clase.Cupos);
                        command.Parameters.AddWithValue("@Fecha", clase.Fecha);
                        command.Parameters.AddWithValue("@Hora", clase.Hora);
                        command.Parameters.AddWithValue("@Encargado", clase.Encargado);
                        command.Parameters.AddWithValue("@Costo", clase.Costo);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Clase registrada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la clase: " + ex.Message);
                }
            }
        }

        public static void ActualizarClase(Clase clase)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Clases SET NombreClase = @NombreClase, Cupos = @Cupos, Fecha = @Fecha, Hora = @Hora, Encargado = @Encargado, Costo = @Costo WHERE NombreClase = @NombreClase";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreClase", clase.NombreClase);
                        command.Parameters.AddWithValue("@Cupos", clase.Cupos);
                        command.Parameters.AddWithValue("@Fecha", clase.Fecha);
                        command.Parameters.AddWithValue("@Hora", clase.Hora);
                        command.Parameters.AddWithValue("@Encargado", clase.Encargado);
                        command.Parameters.AddWithValue("@Costo", clase.Costo);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Clase actualizada en la base de datos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la clase: " + ex.Message);
                }
            }
        }
        public static Clase ObtenerClasePorNombre(string nombreClase)
        {
            Clase clase = null;

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT NombreClase, Cupos, Fecha, Hora, Encargado, Costo FROM Clases WHERE NombreClase = @NombreClase";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreClase", nombreClase);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                clase = new Clase()
                                {
                                    NombreClase = reader.GetString("NombreClase"),
                                    Cupos = reader.GetInt32("Cupos"),
                                    Fecha = reader.GetDateTime("Fecha"),
                                    Hora = reader.GetTimeSpan("Hora"),
                                    Encargado = reader.GetString("Encargado"),
                                    Costo = reader.GetDecimal("Costo")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la clase: " + ex.Message);
                }
            }
            return clase;

        }

        public static bool AgregarParticipanteAClase(int claseId, int usuarioId)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Clase_Usuario (ClaseID, UsuarioID) VALUES (@ClaseID, @UsuarioID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ClaseID", claseId);
                    command.Parameters.AddWithValue("@UsuarioID", usuarioId);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el participante: " + ex.Message);
                return false;
            }
        }

        public static bool EstaUsuarioEnClase(int claseID, int usuarioID)
        {
            string query = "SELECT COUNT(*) FROM Participantes WHERE ClaseID = @ClaseID AND UsuarioID = @UsuarioID";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClaseID", claseID);
                    command.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public static bool AgregarUsuarioAClase(int claseID, int usuarioID)
        {
            string query = "INSERT INTO Participantes (ClaseID, UsuarioID) VALUES (@ClaseID, @UsuarioID)";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClaseID", claseID);
                    command.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}