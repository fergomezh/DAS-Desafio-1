using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPractico1
{
    public class RepositorioUsuarios
    {
        private readonly List<Usuario> usuarios = new List<Usuario>();
        private int siguienteId = 1; // Para asignar IDs únicos

        public void Agregar(Usuario usuario)
        {
            usuario.Id = siguienteId++;
            usuarios.Add(usuario);
        }

        public Usuario Buscar(int id)
        {
            return usuarios.FirstOrDefault(u => u.Id == id);
        }

        public List<Usuario> ListarUsuarios()
        {
            return new List<Usuario>(usuarios);
        }

        public void Actualizar(Usuario usuario)
        {
            var usuarioExistente = Buscar(usuario.Id);
            if (usuarioExistente != null)
            {
                usuarios[usuarios.IndexOf(usuarioExistente)] = usuario;
            }
        }

        public void Eliminar(int id)
        {
            usuarios.Remove(Buscar(id));
        }
    }
}
