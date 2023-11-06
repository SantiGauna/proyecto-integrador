using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaLomaApi.Controllers
{
    public class PedidoController : ApiController
    {
        public List<Pedido> Get()
        {

            List<Pedido> oList = new List<Pedido>();

            using (LaLomaEntities db = new LaLomaEntities())
            {

                oList = db.Pedido.ToList();

            }

            return oList;
        }



        // GET: api/Pedido/5
        public Pedido Get(int id)
        {

            Pedido obj = new Pedido();

            using (LaLomaEntities db = new LaLomaEntities())
            {

                obj = db.Pedido.Find(id);

            }

            return obj;
        }



        // POST: api/Pedido
        public void Post([FromBody] Pedido value)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {

                db.Pedido.Add(value);
                db.SaveChanges();

            }

        }




        // PUT: api/Pedido/5
        public void Put(int id, [FromBody] Pedido value)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {

                var obj = db.Pedido.Find(id);

                obj.IdCliente = value.IdCliente;
                obj.IdProducto = value.IdProducto;
                obj.Fecha = value.Fecha;

                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }

        }


        // DELETE: api/Pedido/5
        public void Delete(int id)
        {
            using (LaLomaEntities db = new LaLomaEntities())
            {
                var obj = db.Pedido.Find(id);

                db.Pedido.Remove(obj);
                db.SaveChanges();

            }

        }
    }
}
