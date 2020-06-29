using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using mvcVistaWeb.Models;

namespace mvcVistaWeb.DAOs
{
    public class UsuarioDAO
    {

        public static UsuarioDAO instancia = null;
        public List<Usuario> usuarios = new List<Usuario>();

        private UsuarioDAO() {
            usuarios.Add(new Usuario(1, "pepitox", "1234", 1000, 3, 10));
            usuarios.Add(new Usuario(2, "gabrielox", "1234", 1000, 5, 10));
            usuarios.Add(new Usuario(3, "samWicked", "1234", 1000, 10, 15));
        }

        public static UsuarioDAO getInstancia() { 
        
            if(instancia == null){
                instancia = new UsuarioDAO();
            }

            return instancia;

        }
       
        public List<Usuario> verUsuarios()
        {
            return usuarios;
        }
       
        public UsuarioDAO agregarUsuario(Usuario user)
        {
            foreach(var us in usuarios)
            {
                if(us.nombre == user.nombre)
                {
                    return null;
                }
            }
            usuarios.Add(user);
            return this;

        }

        public int length()
        {
            return usuarios.Count;
        }

        public Usuario getUsuarioById(int id)
        {
            return usuarios.Find(x => x.id == id);
        }

        public Usuario getUsuarioByNombre(string nombre)
        {
            return usuarios.Find(x => x.nombre == nombre);
        }

        public void eliminarUsuario(int id)
        {
            usuarios.RemoveAll(x => x.id == id);
        }

        public void reemplazarUsuario(int id, Usuario usuario)
        {
            this.eliminarUsuario(id);
            this.agregarUsuario(usuario);
        }
        
        public void modificarUsuario(Usuario usuario)
        {
            Usuario datosViejos = getUsuarioById(usuario.id);
            datosViejos.partidasGanadas = usuario.partidasGanadas;
            datosViejos.partidasJugadas = usuario.partidasJugadas;
            datosViejos.puntaje = usuario.puntaje;

        }

    }


}
