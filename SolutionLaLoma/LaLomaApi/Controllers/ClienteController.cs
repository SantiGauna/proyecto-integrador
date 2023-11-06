using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaLomaApi.Controllers
{
    public class ClienteController : ApiController
    {
        // GET: api/Clientes
        public List<Cliente> Get()
        {

            List<Cliente> oList = new List<Cliente>();

            using (LaLomaEntities db = new LaLomaEntities())
            {

                oList = db.Cliente.ToList();

            }

            return oList;
        }

        // GET: api/Cliente/por ID
        public Cliente Get(int id)
        {

            Cliente obj = new Cliente();

            using (LaLomaEntities db = new LaLomaEntities())
            {

                obj = db.Cliente.Find(id);

            }

            return obj;
        }


        // POST: api/Cliente
        public void Post([FromBody] Cliente value)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {

                db.Cliente.Add(value);
                db.SaveChanges();

            }

        }


        // PUT: api/Cliente/5
        public void Put(int id, [FromBody] Cliente value)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {

                var obj = db.Cliente.Find(id);

                obj.Nombre = value.Nombre;
                obj.Apellido = value.Apellido;
                obj.Direccion = value.Direccion;

                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

        }


        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {
                var obj = db.Cliente.Find(id);

                db.Cliente.Remove(obj);
                db.SaveChanges();

            }



        }
    }
}
