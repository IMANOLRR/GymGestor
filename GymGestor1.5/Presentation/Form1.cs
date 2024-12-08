using GymGestor1._5.DataAccess;
using GymGestor1._5.Presentation;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace GymGestor1._5
{
    public partial class Form1 : Form
    {
        private FormAgregar formAgregar;
        private FormEliminar formEliminar;

        public Form1()
        {
            InitializeComponent();

            // Instancia de FormAgregar para compartir datos
            formAgregar = new FormAgregar();
            formEliminar = new FormEliminar(formAgregar);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formAgregar.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditar formEditar = new FormEditar();
            formEditar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            formEliminar.ShowDialog();
        }

        // Buscar el usuario por cédula en la base de datos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lstbInfoClientes.Items.Clear();
            string cedulaBusqueda = txtCedula.Text.Trim();

            var usuario = DatabaseConnection.ObtenerUsuarioPorCedula(cedulaBusqueda);

            if (usuario != null)
            {
                lstbInfoClientes.Items.Add($"Nombre: {usuario.Nombre}");
                lstbInfoClientes.Items.Add($"Apellido: {usuario.Apellido}");
                lstbInfoClientes.Items.Add($"Cédula: {usuario.Cedula}");
                lstbInfoClientes.Items.Add($"Teléfono: {usuario.Telefono}");
                lstbInfoClientes.Items.Add($"Dirección: {usuario.Direccion}");
                lstbInfoClientes.Items.Add($"Tipo de Suscripción: {usuario.TipoSuscripcion}");
                lstbInfoClientes.Items.Add($"Estado de Suscripción: {usuario.EstadoSuscripcion}");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado en la base de datos.", "Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstbInfoClientes.Items.Clear();
            txtCedula.Clear();
        }

        private void btnAgregarClase_Click(object sender, EventArgs e)
        {
            FormClase formClase = new FormClase();
            formClase.ShowDialog();
        }

        private void btnEditarClase_Click(object sender, EventArgs e)
        {
            FormEditarClase formEditarClase = new FormEditarClase();
            formEditarClase.ShowDialog();
        }
    }
}
