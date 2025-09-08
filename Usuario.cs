using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPractico1
{
    public class Usuario : EntidadBase
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int PrestamosRealizados { get; set; } = 0; // Contador de préstamos realizados

    }
}
