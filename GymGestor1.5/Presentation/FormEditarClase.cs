using GymGestor1._5.BusinessLogic;
using GymGestor1._5.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymGestor1._5.Presentation
{
    public partial class FormEditarClase : Form
    {
        public FormEditarClase()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreClase = txtClase.Text.Trim();

            if (string.IsNullOrEmpty(nombreClase))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la clase.");
                return;
            }

            var clase = DatabaseConnection.ObtenerClasePorNombre(nombreClase);

            if (clase != null)
            {
                txtClase.Text = clase.NombreClase;
                txtCupos.Text = clase.Cupos.ToString();
                txtDate.Text = clase.Fecha.ToShortDateString();
                txtTime.Text = clase.Hora.ToString(@"hh\:mm");
                txtEncargado.Text = clase.Encargado;
                txtCosto.Text = clase.Costo.ToString("F2");

                lstbParticipantes.Items.Clear();
            }
            else
            {
                MessageBox.Show("Clase no encontrada.");
            }
        }
 
        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            
        }


        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarClase_Click(object sender, EventArgs e)
        {
            string nombreClase = txtClase.Text.Trim();

            if (string.IsNullOrEmpty(nombreClase))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la clase.");
                return;
            }

            // Eliminar la clase desde la base de datos
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Clases WHERE NombreClase = @NombreClase";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreClase", nombreClase);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Clase eliminada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la clase para eliminar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la clase: " + ex.Message);
                }
            }
        }


        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            string nombreClase = txtClase.Text.Trim();

            if (string.IsNullOrEmpty(nombreClase))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la clase.");
                return;
            }

            var clase = DatabaseConnection.ObtenerClasePorNombre(nombreClase);

            if (clase != null)
            {
                clase.NombreClase = txtClase.Text.Trim();
                clase.Cupos = int.TryParse(txtCupos.Text, out var cupos) ? cupos : clase.Cupos;
                clase.Fecha = DateTime.TryParse(txtDate.Text, out var fecha) ? fecha : clase.Fecha;
                clase.Hora = TimeSpan.TryParse(txtTime.Text, out var hora) ? hora : clase.Hora;
                clase.Encargado = txtEncargado.Text.Trim();
                clase.Costo = decimal.TryParse(txtCosto.Text, out var costo) ? costo : clase.Costo;

                using (var connection = DatabaseConnection.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE Clases SET NombreClase = @NombreClase, Cupos = @Cupos, Fecha = @Fecha, " +
                                       "Hora = @Hora, Encargado = @Encargado, Costo = @Costo WHERE NombreClase = @NombreClase";

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

                        MessageBox.Show("Cambios confirmados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar la clase: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Clase no encontrada.");
            }
        }

    }

}
