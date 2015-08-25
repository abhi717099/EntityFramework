using EfDemo.Web.Models;
using System.Web.Mvc;
using System.Linq;

namespace EfDemo.Web.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        MyOrders context = new MyOrders();
        public ActionResult Index()
        {
            return View(context.Orders);
        }

        //
        // GET: /Order/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Order/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Order/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Order/Edit/5

        public ActionResult Edit(int id)
        {
            return View(context.Orders.Find(id));
        }

        //
        // POST: /Order/Edit/5

        [HttpPost]
        public ActionResult Edit(Order updated)
        {
            try
            {
                //context.Orders.Where(o=> o.Price>3);
                var old = context.Orders.Find(updated.Id);
                context.Entry(old).CurrentValues.SetValues(updated);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Order/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Order/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}