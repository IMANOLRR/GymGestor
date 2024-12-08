using System;
using System.Linq;
using System.Windows.Forms;
using GymGestor1._5.DataAccess;
using MySql.Data.MySqlClient;

namespace GymGestor1._5
{
    public partial class FormEditar : Form
    {
        public FormEditar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cedulaBusqueda = txtCed.Text.Trim();

            var usuario = DatabaseConnection.ObtenerUsuarioPorCedula(cedulaBusqueda);

            if (usuario != null)
            {
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtTel.Text = usuario.Telefono;
                txtDireccion.Text = usuario.Direccion;
                cmbTipoSuscripcion.Text = usuario.TipoSuscripcion;
                cmbEstadoSuscripcion.Text = usuario.EstadoSuscripcion;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado en la base de datos.", "Error");
            }
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            string cedulaBusqueda = txtCed.Text.Trim();

            var usuario = DatabaseConnection.ObtenerUsuarioPorCedula(cedulaBusqueda);

            if (usuario != null)
            {
                usuario.Nombre = txtNombre.Text.Trim();
                usuario.Apellido = txtApellido.Text.Trim();
                usuario.Telefono = txtTel.Text.Trim();
                usuario.Direccion = txtDireccion.Text.Trim();
                usuario.TipoSuscripcion = cmbTipoSuscripcion.Text;
                usuario.EstadoSuscripcion = cmbEstadoSuscripcion.Text;

                ActualizarUsuario(usuario);

                MessageBox.Show("Usuario actualizado correctamente.", "Éxito");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar. Por favor, busca al usuario nuevamente.", "Error");
            }
        }

        private void ActualizarUsuario(Usuario usuario)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE Usuarios SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, " +
                                   "Direccion = @Direccion, TipoSuscripcion = @TipoSuscripcion, EstadoSuscripcion = @EstadoSuscripcion " +
                                   "WHERE Cedula = @Cedula";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Cedula", usuario.Cedula);
                        command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        command.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                        command.Parameters.AddWithValue("@TipoSuscripcion", usuario.TipoSuscripcion);
                        command.Parameters.AddWithValue("@EstadoSuscripcion", usuario.EstadoSuscripcion);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el usuario en la base de datos: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtCed.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            cmbTipoSuscripcion.SelectedIndex = -1;
            cmbEstadoSuscripcion.SelectedIndex = -1;
        }
    }
}
