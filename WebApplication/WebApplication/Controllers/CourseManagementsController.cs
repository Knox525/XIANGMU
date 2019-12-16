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
    public class CourseManagementsController : Controller
    {
        private lclEntities db = new lclEntities();

        // GET: CourseManagements
        public ActionResult Index()
        {
            return View(db.CourseManagements.ToList());
        }

        // GET: CourseManagements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseManagements courseManagements = db.CourseManagements.Find(id);
            if (courseManagements == null)
            {
                return HttpNotFound();
            }
            return View(courseManagements);
        }

        // GET: CourseManagements/Create
        public ActionResult Create()
        {
            var teacher = db.teacher.ToList();
            ViewBag.Teacher = teacher;
            var student = db.student.ToList();
            ViewBag.Student = student;
            var classs = db.classsToList();
            ViewBag.Classs = classs;
            var course = db.courseToList();
            ViewBag.Course = course;
            return View();
        }

        // POST: CourseManagements/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ClassId,CourseId,TeacherId")] CourseManagements courseManagements)
        {
            if (ModelState.IsValid)
            {
                db.CourseManagements.Add(courseManagements);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseManagements);
        }

        // GET: CourseManagements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseManagements courseManagements = db.CourseManagements.Find(id);
            if (courseManagements == null)
            {
                return HttpNotFound();
            }
            return View(courseManagements);
        }

        // POST: CourseManagements/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ClassId,CourseId,TeacherId")] CourseManagements courseManagements)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseManagements).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseManagements);
        }

        // GET: CourseManagements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseManagements courseManagements = db.CourseManagements.Find(id);
            if (courseManagements == null)
            {
                return HttpNotFound();
            }
            return View(courseManagements);
        }

        // POST: CourseManagements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseManagements courseManagements = db.CourseManagements.Find(id);
            db.CourseManagements.Remove(courseManagements);
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
