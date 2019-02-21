using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OneDollar.DAL;
using OneDollar.Models;

namespace OneDollar.Controllers
{
    public class CinemaProductsController : Controller
    {
         private CinemaProductsContext db = new CinemaProductsContext();

        // GET: CinemaProducts
        public ActionResult Index()
        {
            return View(db.CinemaProducts.ToList());
        }

        // GET: CinemaProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaProduct cinemaProduct = db.CinemaProducts.Find(id);
            if (cinemaProduct == null)
            {
                return HttpNotFound();
            }
            return View(cinemaProduct);
        }

        // GET: CinemaProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Description,Duration,Year,IMDB,ImagePath,Countries,Genries")] CinemaProduct cinemaProduct)
        {
            if (ModelState.IsValid)
            {
                db.CinemaProducts.Add(cinemaProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cinemaProduct);
        }

        // GET: CinemaProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaProduct cinemaProduct = db.CinemaProducts.Find(id);
            if (cinemaProduct == null)
            {
                return HttpNotFound();
            }
            return View(cinemaProduct);
        }

        // POST: CinemaProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Description,Duration,Year,IMDB,ImagePath,Countries,Genries")] CinemaProduct cinemaProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cinemaProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cinemaProduct);
        }

        // GET: CinemaProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaProduct cinemaProduct = db.CinemaProducts.Find(id);
            if (cinemaProduct == null)
            {
                return HttpNotFound();
            }
            return View(cinemaProduct);
        }

        // POST: CinemaProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CinemaProduct cinemaProduct = db.CinemaProducts.Find(id);
            db.CinemaProducts.Remove(cinemaProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
