using GymGestor1._5.BusinessLogic;
using GymGestor1._5.DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GymGestor1._5
{
    public partial class FormAgregar : Form
    {
        // Propiedad pública para acceder a los datos guardados
        public List<Usuario> DatosGuardados { get; private set; }

        public FormAgregar()
        {
            InitializeComponent();
            DatosGuardados = new List<Usuario>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario()
            { 
            Nombre = txtAddNombre.Text,
            Apellido = txtAddApellido.Text,
            Cedula = txtAddCed.Text,
            Telefono = txtAddTel.Text,
            Direccion = txtAddDireccion.Text,
            TipoSuscripcion = cboAddTipoSuscrip.Text,
            EstadoSuscripcion = cboAddEstadoSuscrip.Text,
            };

            DatabaseConnection.InsertarUsuario(usuario);
            DatosGuardados.Add(usuario);
            DataStorage.Usuarios.Add(usuario);
            MessageBox.Show("Guardado correctamente");

            txtAddNombre.Text = string.Empty;
            txtAddApellido.Text = string.Empty;
            txtAddCed.Text = string.Empty;
            txtAddTel.Text = string.Empty;
            txtAddDireccion.Text = string.Empty;
            cboAddTipoSuscrip.SelectedIndex = -1;
            cboAddEstadoSuscrip.SelectedIndex = -1;
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
