using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPractico1
{
    public class Prestamo : EntidadBase
    {
        public int IdUsuario { get; set; }
        public int IdLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; } // Nullable para indicar que puede no estar devuelto aún
        public bool Activo { get; set; } = true; // Indica si el préstamo está activo o cerrado

        public string NomreUsuario { get; set; }
        public string TituloLibro { get; set; }
    }
}
