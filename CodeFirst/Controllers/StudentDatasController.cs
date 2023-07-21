using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class StudentDatasController : Controller
    {
        private EFCodeFirstStudent db = new EFCodeFirstStudent();
        public ActionResult Index()
        {
            return View(db.studentDatas.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentData studentData = db.studentDatas.Find(id);
            if (studentData == null)
            {
                return HttpNotFound();
            }
            return View(studentData);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudID,StudName,StudAge,City")] StudentData studentData)
        {
            if (ModelState.IsValid)
            {
                db.studentDatas.Add(studentData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentData);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentData studentData = db.studentDatas.Find(id);
            if (studentData == null)
            {
                return HttpNotFound();
            }
            return View(studentData);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudID,StudName,StudAge,City")] StudentData studentData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentData);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentData studentData = db.studentDatas.Find(id);
            if (studentData == null)
            {
                return HttpNotFound();
            }
            return View(studentData);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentData studentData = db.studentDatas.Find(id);
            db.studentDatas.Remove(studentData);
            db.SaveChanges();
            return RedirectToAction("Create");
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
