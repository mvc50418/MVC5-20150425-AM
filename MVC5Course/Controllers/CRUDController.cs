using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Course.Models;
using System.Data.Entity.Validation;

namespace MVC5Course.Controllers
{
    public class CRUDController : Controller
    {
        FabricsEntities db = new FabricsEntities();

        // GET: CRUD
        public ActionResult Index()
        {
            var data = db.Product.Where(p => p.ProductName.StartsWith("C"));

            return View(data);
        }

        // GET: CRUD/Details/5
        public ActionResult Details(int id)
        {
            //Product p = db.Product.Find(id);
            //Product p = db.Product.Where(x => x.ProductId == id);
            Product p = db.Product.First(x => x.ProductId == id);

            return View(p);
        }

        // GET: CRUD/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CRUD/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Product prod = new Product();

                prod.ProductName = collection["ProductName"];
                prod.Price = Convert.ToDecimal(collection["Price"]);
                prod.Stock = Convert.ToDecimal(collection["Stock"]);
                prod.Active = true;

                db.Product.Add(prod);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult BatchUpdate()
        {
            var data = db.Product.Where(p => p.ProductName.StartsWith("C"));

            foreach (var item in data)
            {
                item.Price = item.Price * 2;
            }

            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                throw ex;
            }

            return RedirectToAction("Index");
        }


        // GET: CRUD/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CRUD/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CRUD/Delete/5
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
