using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using mvcVistaWeb.DAOs;
using mvcVistaWeb.Models;

namespace mvcVistaWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APIController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            var usuarios = UsuarioDAO.getInstancia().verUsuarios();
            return Content(JsonConvert.SerializeObject(usuarios),"application/json");
        }

/*
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var usuario = UsuarioDAO.getInstancia().getUsuarioById(id);
            return Content(JsonConvert.SerializeObject(usuario),"application/json");
        }
        //Necesito buscar por nombre para el login. Si dejo ambos gets (por id o por nombre) no sabe cual usar y se rompe.
*/

        // GET api/<controller>/franco
        [HttpGet("{nombre}")]
        public ActionResult Get(string nombre)
        {
            var usuario = UsuarioDAO.getInstancia().getUsuarioByNombre(nombre);
            return Content(JsonConvert.SerializeObject(usuario),"application/json");
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Usuario usuario)
        {
            UsuarioDAO.getInstancia().agregarUsuario(usuario);
        }

        //PUT api/<controller>/5
        [HttpPut("{nombre}")]
        public void Put(string nombre, [FromBody]Usuario usuario)
        {
            UsuarioDAO.getInstancia().modificarUsuario(usuario);
        }
/*
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UsuarioDAO.getInstancia().eliminarUsuario(id);
            //return JsonConvert.SerializeObject(personas);
        }
*/
    }
}