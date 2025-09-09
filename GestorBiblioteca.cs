using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPractico1
{
    public class GestorBiblioteca
    {
        private readonly RepositorioLibros repositorioLibros;
        private readonly RepositorioUsuarios repositorioUsuarios;
        private readonly RepositorioPrestamos repositorioPrestamos;

        public GestorBiblioteca()
        {
            repositorioLibros = new RepositorioLibros();
            repositorioUsuarios = new RepositorioUsuarios();
            repositorioPrestamos = new RepositorioPrestamos();
            CargarDatosDeEjemplo();
        }

        public void AgregarLibro(string titulo, string autor, int anio)
        {
            var libro = new Libro
            {
                Titulo = titulo,
                Autor = autor,
                Anio = anio,
                Disponible = true
            };
            repositorioLibros.CrearLibro(libro);
        }

        public void EditarLibro(int id, string titulo, string autor, int anio)
        {
            var libro = repositorioLibros.Buscar(id);
            if (libro != null)
            {
                libro.Titulo = titulo;
                libro.Autor = autor;
                libro.Anio = anio;
                repositorioLibros.Actualizar(libro);
            }
        }

        public void EliminarLibro(int id)
        {
            repositorioLibros.Eliminar(id);
        }

        public List<Libro> ObtenerLibros()
        {
            return repositorioLibros.ListarLibros();
        }

        public List<Libro> ObtenerLibrosDisponibles()
        {
            return repositorioLibros.ListarLibrosDisponibles();
        }

        public void AgregarUsuario(string nombre, string email)
        {
            var usuario = new Usuario
            {
                Nombre = nombre,
                Email = email
            };
            repositorioUsuarios.Agregar(usuario);
        }

        public void EditarUsuario(int id, string nombre, string correo)
        {
            var usuario = repositorioUsuarios.Buscar(id);
            if (usuario != null)
            {
                usuario.Nombre = nombre;
                usuario.Email = correo;
                repositorioUsuarios.Actualizar(usuario);
            }
        }

        public void EliminarUsuario(int id)
        {
            repositorioUsuarios.Eliminar(id);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return repositorioUsuarios.ListarUsuarios();
        }

        public bool RealizarPrestamo(int idUusario, int idLibro)
        {
            var usuario = repositorioUsuarios.Buscar(idUusario);
            var libro = repositorioLibros.Buscar(idLibro);

            if (usuario == null || libro == null || !libro.Disponible)
            {
                return false; // No se puede realizar el préstamo
            }

            var prestamo = new Prestamo
            {
                IdUsuario = idUusario,
                IdLibro = idLibro,
                FechaPrestamo = DateTime.Now,
                Activo = true,
                NombreUsuario = usuario.Nombre,
                TituloLibro = libro.Titulo
            };

            repositorioPrestamos.Agregar(prestamo);
            libro.Disponible = false;
            repositorioLibros.Actualizar(libro);
            return true;
        }

        public bool DevolverLibro(int idPrestamo)
        {
            var prestamo = repositorioPrestamos.Buscar(idPrestamo);

            if (prestamo == null || !prestamo.Activo)
            {
                return false; // Préstamo no encontrado o ya devuelto
            }

            var libro = repositorioLibros.Buscar(prestamo.IdLibro);

            if (libro != null)
            {
                libro.Disponible = true;
                repositorioLibros.Actualizar(libro);
            }

            prestamo.FechaDevolucion = DateTime.Now;
            prestamo.Activo = false;
            repositorioPrestamos.Actualizar(prestamo);
            return true;
        }

        public List<Prestamo> ObtenerTodosPrestamos()
        {
            return repositorioPrestamos.ListarPrestamos();
        }

        public List<Prestamo> ObtenerPrestamosActivos()
        {
            return repositorioPrestamos.ListarPrestamosActivos();
        }

        public List<Libro> BuscarLibros(string criterio)
        {
            if (string.IsNullOrEmpty(criterio))
            {
                return ObtenerLibros();
            }

            var porTitulo = repositorioLibros.BuscarPorTitulo(criterio);
            var porAutor = repositorioLibros.BuscarPorAutor(criterio);
            return porTitulo.Union(porAutor).Distinct().ToList(); //Distict para que no se dupliquen los resultados
        }

        public Dictionary<string, int> ObtenerEstadisticasUsuarios()
        {
            return repositorioPrestamos.ListarPrestamos()
                .GroupBy(p => p.NombreUsuario)
                .ToDictionary(u => u.Key, u => u.Count());
        }
        private void CargarDatosDeEjemplo()
        {
            AgregarLibro("El Gran Gatsby", "F. Scott Fitzgerald", 1925);
            AgregarLibro("Matar a un Ruisenor", "Harper Lee", 1960);
            AgregarLibro("1984", "George Orwell", 1949);
            AgregarLibro("Orgullo y Prejuicio", "Jane Austen", 1813);
            AgregarUsuario("Juan Pérez", "juan.perez@email.com");
            AgregarUsuario("María Gómez", "maria.gomez@email.com");
            AgregarUsuario("Ana Torres", "ana.torres@email.com");
        }
    }

}
