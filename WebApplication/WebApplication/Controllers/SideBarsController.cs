using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class SideBarsController : Controller
    {
        private lclEntities db = new lclEntities();

        // GET: SideBars
        public ActionResult Index()
        {
            return View(db.SideBars.ToList());
        }

        // GET: SideBars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SideBars sideBars = db.SideBars.Find(id);
            if (sideBars == null)
            {
                return HttpNotFound();
            }
            return View(sideBars);
        }

        // GET: SideBars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SideBars/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Controller,Action")] SideBars sideBars)
        {
            if (ModelState.IsValid)
            {
                db.SideBars.Add(sideBars);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sideBars);
        }

        // GET: SideBars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SideBars sideBars = db.SideBars.Find(id);
            if (sideBars == null)
            {
                return HttpNotFound();
            }
            return View(sideBars);
        }

        // POST: SideBars/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Controller,Action")] SideBars sideBars)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sideBars).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sideBars);
        }

        // GET: SideBars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SideBars sideBars = db.SideBars.Find(id);
            if (sideBars == null)
            {
                return HttpNotFound();
            }
            return View(sideBars);
        }

        // POST: SideBars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SideBars sideBars = db.SideBars.Find(id);
            db.SideBars.Remove(sideBars);
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
