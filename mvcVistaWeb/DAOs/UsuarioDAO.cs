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

            /*
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();
            queryBuilder.setQuery("SELECT * FROM usuarios");

            var dataReader = DBConnection.getInstance().select(queryBuilder);
            var lista = new List<Usuario>();
            while (dataReader.Read())
            {
                var usuario = new Usuario(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetInt32(4), dataReader.GetInt32(5));
                lista.Add(usuario);
            }

            return lista;
            */
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

            /*
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("INSERT INTO usuarios (nombre,contraseña,puntaje,partidasGanadas,partidasJugadas) VALUES (@nombre,@contraseña,@puntaje,@partidasGanadas,@partidasJugadas)");
            queryBuilder.addParam("@nombre", user.nombre);
            queryBuilder.addParam("@edad", user.contraseña);
            queryBuilder.addParam("@puntaje", user.puntaje);
            queryBuilder.addParam("@partidasGanadas", user.partidasGanadas);
            queryBuilder.addParam("@partidasJugadas", user.partidasJugadas);

            DBConnection.getInstance().abm(queryBuilder);
            */

        }

        public int length()
        {
            return usuarios.Count;
        }

        public Usuario getUsuarioById(int id)
        {
            return usuarios.Find(x => x.id == id);

            /*
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("SELECT * FROM usuarios WHERE id=@id");
            queryBuilder.addParam("@id", id);

            var dataReader = DBConnection.getInstance().select(queryBuilder);
            Usuario user = null;
            while (dataReader.Read())
            {
                user = new Usuario(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetInt32(4), dataReader.GetInt32(5));
            }

            return user;
            */
        }

        public Usuario getUsuarioByNombre(string nombre)
        {
            return usuarios.Find(x => x.nombre == nombre);

            /*
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("SELECT * FROM usuarios WHERE nombre=@nombre");
            queryBuilder.addParam("@nombre", nombre);

            var dataReader = DBConnection.getInstance().select(queryBuilder);
            Usuario user = null;
            while (dataReader.Read())
            {
                user = new Usuario(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3), dataReader.GetInt32(4), dataReader.GetInt32(5));
            }

            return user;
            */
        }

        public void eliminarUsuario(int id)
        {
            usuarios.RemoveAll(x => x.id == id);

            /*
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("DELETE FROM usuarios WHERE id=@id");
            queryBuilder.addParam("@id", id);

            DBConnection.getInstance().abm(queryBuilder);
            */
        }
        
        public void modificarUsuario(Usuario usuario)
        {
            Usuario datosViejos = getUsuarioById(usuario.id);
            datosViejos.partidasGanadas = usuario.partidasGanadas;
            datosViejos.partidasJugadas = usuario.partidasJugadas;
            datosViejos.puntaje = usuario.puntaje;

            /*
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("UPDATE usuarios SET puntaje=@puntaje, partidasGanadas=@partidasGanadas, partidasJugadas=@partidasJugadas WHERE id=@id");
            queryBuilder.addParam("@id", usuario.id);
            queryBuilder.addParam("@puntaje", usuario.puntaje);
            queryBuilder.addParam("@partidasGanadas", usuario.partidasGanadas);
            queryBuilder.addParam("@partidasJugadas", usuario.partidasJugadas);

            DBConnection.getInstance().abm(queryBuilder);
            */

        }

    }


}
