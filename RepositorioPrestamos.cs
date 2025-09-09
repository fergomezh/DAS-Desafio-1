using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPractico1
{
    public class RepositorioPrestamos
    {
        private readonly List<Prestamo> prestamos = new List<Prestamo>();
        private int siguienteId = 1; // Para asignar IDs únicos

        public void Agregar(Prestamo prestamo)
        {
            prestamo.Id = siguienteId++;
            prestamos.Add(prestamo);
        }

        public Prestamo Buscar(int id)
        {
            return prestamos.FirstOrDefault(p => p.Id == id);
        }

        public List<Prestamo> ListarPrestamos()
        {
            return new List<Prestamo>(prestamos);
        }

        public void Actualizar(Prestamo prestamo)
        {
            var prestamoExistente = Buscar(prestamo.Id);
            if (prestamoExistente != null)
            {
                prestamos[prestamos.IndexOf(prestamoExistente)] = prestamo;
            }
        }

        public void EliminarPrestamo(int id)
        {
            prestamos.Remove(Buscar(id));
        }

        public List<Prestamo> ListarPrestamosActivos()
        {
            return prestamos.Where(p => p.Activo).ToList();
        }

        public List<Prestamo> ListarPrestamosPorUsuario(int idUsuario)
        {
            return prestamos.Where(p => p.IdUsuario == idUsuario).ToList();
        }
    }
}
