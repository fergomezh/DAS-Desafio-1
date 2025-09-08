using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPractico1
{
    public class RepositorioLibros
    {
        private readonly List<Libro> libros = new List<Libro>();
        private int siguienteId = 1; // Para asignar IDs únicos

        public void AgregarLibro(Libro libro)
        {
            libro.Id = siguienteId++;
            libros.Add(libro);
        }

        public Libro BuscarLibro(int id)
        {
            return libros.FirstOrDefault(l => l.Id == id);
        }

        public List<Libro> ListarLibros()
        {
            return libros;
        }

        public void ActualizarLibro(Libro libro)
        {
            var libroExistente = BuscarLibro(libro.Id);
            if (libroExistente != null)
            {
                libroExistente.Titulo = libro.Titulo;
                libroExistente.Autor = libro.Autor;
                libroExistente.AnioPublicacion = libro.AnioPublicacion;
                libroExistente.Disponible = libro.Disponible;
            }
        }

        public void EliminarLibro(int id)
        {
            libros.Remove(BuscarLibro(id));
        }
    }
}
