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
            UsuarioDAO.getInstancia().modificarUsuario(usuario); //Comprobar si funciona
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

/*
       // GET: API
       public ActionResult Index()
       {
           return View();
       }

       // GET: API/Details/5
       public ActionResult Details(int id)
       {
           return View();
       }

       // GET: API/Create
       public ActionResult Create()
       {
           return View();
       }

       // POST: API/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult Create(IFormCollection collection)
       {
           try
           {
               // TODO: Add insert logic here

               return RedirectToAction(nameof(Index));
           }
           catch
           {
               return View();
           }
       }

       // GET: API/Edit/5
       public ActionResult Edit(int id)
       {
           return View();
       }

       // POST: API/Edit/5
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult Edit(int id, IFormCollection collection)
       {
           try
           {
               // TODO: Add update logic here

               return RedirectToAction(nameof(Index));
           }
           catch
           {
               return View();
           }
       }

       // GET: API/Delete/5
       public ActionResult Delete(int id)
       {
           return View();
       }

       // POST: API/Delete/5
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult Delete(int id, IFormCollection collection)
       {
           try
           {
               // TODO: Add delete logic here

               return RedirectToAction(nameof(Index));
           }
           catch
           {
               return View();
           }
       }
*/
