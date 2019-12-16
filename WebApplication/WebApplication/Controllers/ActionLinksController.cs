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
    public class ActionLinksController : Controller
    {
        private lclEntities db = new lclEntities();

        // GET: ActionLinks
        public ActionResult Index()
        {
            return View(db.ActionLinks.ToList());
        }

        // GET: ActionLinks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionLinks actionLinks = db.ActionLinks.Find(id);
            if (actionLinks == null)
            {
                return HttpNotFound();
            }
            return View(actionLinks);
        }

        // GET: ActionLinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActionLinks/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Controller,Action")] ActionLinks actionLinks)
        {
            if (ModelState.IsValid)
            {
                db.ActionLinks.Add(actionLinks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actionLinks);
        }

        // GET: ActionLinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionLinks actionLinks = db.ActionLinks.Find(id);
            if (actionLinks == null)
            {
                return HttpNotFound();
            }
            return View(actionLinks);
        }

        // POST: ActionLinks/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Controller,Action")] ActionLinks actionLinks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actionLinks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actionLinks);
        }

        // GET: ActionLinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionLinks actionLinks = db.ActionLinks.Find(id);
            if (actionLinks == null)
            {
                return HttpNotFound();
            }
            return View(actionLinks);
        }

        // POST: ActionLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActionLinks actionLinks = db.ActionLinks.Find(id);
            db.ActionLinks.Remove(actionLinks);
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
