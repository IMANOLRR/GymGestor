using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymGestor1._5.BusinessLogic
{
    public class Clase
    {
        public string NombreClase {  get; set; }
        public int Cupos {  get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Encargado { get; set; }
        public decimal Costo { get; set; }
        public int ClaseID { get; set; }

        public List<Usuario> Participantes { get; set; } = new List<Usuario>();
    }
}
