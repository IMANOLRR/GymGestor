using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymGestor1._5
{
    public partial class FormEliminar : Form
    {
        private FormAgregar formAgregar;

        public FormEliminar(FormAgregar formAgregar)
        {
            InitializeComponent();
            if (formAgregar == null)
            {
                MessageBox.Show("La referencia al formulario de agregar es nula.", "Error");
                return;
            }

            this.formAgregar = formAgregar;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedulaBusqueda = txtCed.Text.Trim();

            var usuario = formAgregar.DatosGuardados.FirstOrDefault(u => u.Cedula == cedulaBusqueda);

            if (usuario != null)
            {
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtTel.Text = usuario.Telefono;
                txtDireccion.Text = usuario.Direccion;
                cmbTipoSuscrip.Text = usuario.TipoSuscripcion;
                cmbEstadoSuscrip.Text = usuario.EstadoSuscripcion;
            }
            else
            {
                MessageBox.Show("No se encontró un usuario con esta cédula.", "Error");
            }
        }

        private void btnConfirmarCambios_Click(object sender, EventArgs e)
        {
            string cedulaBusqueda = txtCed.Text.Trim();

            var usuario = formAgregar.DatosGuardados.FirstOrDefault(u => u.Cedula == cedulaBusqueda);

            if (usuario != null)
            {
                formAgregar.DatosGuardados.Remove(usuario);
                LimpiarCampos();

                MessageBox.Show("El usuario ha sido eliminado correctamente.", "Éxito");
            }
            else
            {
                MessageBox.Show("No se encontró un usuario con esta cédula.", "Error");
            }
        }
            private void LimpiarCampos()
            {
                txtCed.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtTel.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                cmbTipoSuscrip.SelectedIndex = -1;
                cmbEstadoSuscrip.SelectedIndex = -1;

        }
    }
            
}

