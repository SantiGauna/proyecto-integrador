using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaLomaApi.Controllers
{
    public class ProductoController : ApiController
    {
        // GET: api/Producto
        public List<Producto> Get()
        {

            List<Producto> oList = new List<Producto>();

            using (LaLomaEntities db = new LaLomaEntities())
            {

                oList = db.Producto.ToList();

            }

            return oList;
        }



        // GET: api/Producto/5
        public Producto Get(int id)
        {

            Producto obj = new Producto();

            using (LaLomaEntities db = new LaLomaEntities())
            {

                obj = db.Producto.Find(id);

            }

            return obj;
        }



        // POST: api/Producto
        public void Post([FromBody] Producto value)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {

                db.Producto.Add(value);
                db.SaveChanges();

            }

        }

        // PUT: api/Producto/5
        public void Put(int id, [FromBody] Producto value)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {

                var obj = db.Producto.Find(id);

                obj.Nombre = value.Nombre;
                obj.Descripcion = value.Descripcion;
                obj.Precio = value.Precio;

                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

        }



        // DELETE: api/Producto/5
        public void Delete(int id)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {
                var obj = db.Producto.Find(id);

                db.Producto.Remove(obj);
                db.SaveChanges();

            }

        }
    }
}

