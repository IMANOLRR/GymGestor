using GymGestor1._5.BusinessLogic;
using GymGestor1._5.DataAccess;
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
    public partial class FormClase : Form
    {
        public List<Clase> ClasesGuardadas { get; private set; }

        public FormClase()
        {
            InitializeComponent();
            ClasesGuardadas = new List<Clase>();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var clase = new Clase()
            {
                NombreClase = txtAddClass.Text,
                Cupos = int.TryParse(txtAddCupos.Text, out var cupos) ? cupos : 0,
                Fecha = DateTime.TryParse(txtAddDate.Text, out var fecha) ? fecha : DateTime.MinValue,
                Hora = TimeSpan.TryParse(txtAddTime.Text, out var hora) ? hora : TimeSpan.Zero,
                Encargado = txtAddEncargado.Text,
                Costo = decimal.TryParse(txtAddCosto.Text, out var costo) ? costo : 0m,
            };

            DatabaseConnection.InsertarClase(clase);
        }
    }
}
