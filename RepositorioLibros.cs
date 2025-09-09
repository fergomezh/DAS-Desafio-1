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

        public void CrearLibro(Libro libro)
        {
            libro.Id = siguienteId++;
            libros.Add(libro);
        }

        public Libro Buscar(int id)
        {
            return libros.FirstOrDefault(l => l.Id == id);
        }

        public List<Libro> ListarLibros()
        {
            return new List<Libro>(libros);
        }

        public void Actualizar(Libro libro)
        {
            var libroExistente = Buscar(libro.Id);
            if (libroExistente != null)
            {
                libros[libros.IndexOf(libroExistente)] = libro;
            }
        }

        public void Eliminar(int id)
        {
            libros.Remove(Buscar(id));
        }

        public List<Libro> ListarLibrosDisponibles()
        {
            return libros.Where(l => l.Disponible).ToList();
        }

        public List<Libro> BuscarPorAutor(string autor)
        {
            return libros.Where(l => l.Autor.ToLower().Contains(autor.ToLower())).ToList();
        }

        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return libros.Where(l => l.Titulo.ToLower().Contains(titulo.ToLower())).ToList();
        }
    }
}
