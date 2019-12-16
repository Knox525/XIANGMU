using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.BLL.Class;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class classsesController : Controller
    {
        private lclEntities db = new lclEntities();

        private IClassRepository _repository = new ClassRepository();
        // GET: classses
        public ActionResult Index()
        {

            return View(db.classs.ToList());
        }

        // GET: classses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classs classs = db.classs.Find(id);
            if (classs == null)
            {
                return HttpNotFound();
            }
            return View(classs);
        }

        // GET: classses/Create
        public ActionResult Create()
        {
            var teacher = db.teacher.ToList();
            ViewBag.Teacher = teacher;
            return View();
        }

        // POST: classses/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,TeacherId")] classs classs)
        {
            if (ModelState.IsValid)
            {
                db.classs.Add(classs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var teacher = db.teacher.ToList();
            ViewBag.Teacher = teacher;
            return View(classs);
        }

        // GET: classses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classs classs = db.classs.Find(id);
            if (classs == null)
            {
                return HttpNotFound();
            }
            var teacher = db.teacher.ToList();
            ViewBag.Teacher = teacher;
            return View(classs);
        }

        // POST: classses/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,TeacherId")] classs classs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classs);
        }

        // GET: classses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classs classs = db.classs.Find(id);
            if (classs == null)
            {
                return HttpNotFound();
            }
            return View(classs);
        }

        // POST: classses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            classs classs = db.classs.Find(id);
            db.classs.Remove(classs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult ShowCourseManagement(int id)
        {
            return View(_repository.GetClassCourse(id));
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
