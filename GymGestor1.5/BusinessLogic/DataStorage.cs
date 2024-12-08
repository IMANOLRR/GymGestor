using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymGestor1._5.BusinessLogic
{
    public static class DataStorage
    {
            public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
            public static List<Clase> Clases { get; set; } = new List<Clase>();
    }
}
