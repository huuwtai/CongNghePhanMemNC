using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineTestWeb.Models;

namespace OnlineTestWeb.Controllers
{
    public class Nhóm_Câu_HỏiController : Controller
    {
        private QL_HeThongThiTracNghiemEntities db = new QL_HeThongThiTracNghiemEntities();

        // GET: Nhóm_Câu_Hỏi
        public ActionResult Index()
        {
            var nhóm_Câu_Hỏi = db.Nhóm_Câu_Hỏi.Include(n => n.Môn_Học);
            return View(nhóm_Câu_Hỏi.ToList());
        }

        // GET: Nhóm_Câu_Hỏi/Details/5
        public ActionResult DetailsQuesGroup(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhóm_Câu_Hỏi nhóm_Câu_Hỏi = db.Nhóm_Câu_Hỏi.Find(id);
            if (nhóm_Câu_Hỏi == null)
            {
                return HttpNotFound();
            }
            return View(nhóm_Câu_Hỏi);
        }

        // GET: Nhóm_Câu_Hỏi/Create
        public ActionResult CreateQuesGroup()
        {
            ViewBag.MaMon = new SelectList(db.Môn_Học, "MaMon", "TenMon");
            return View();
        }

        // POST: Nhóm_Câu_Hỏi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateQuesGroup([Bind(Include = "MaNhom,TenNhom,MaMon,SoCauHoi")] Nhóm_Câu_Hỏi nhóm_Câu_Hỏi)
        {
            if (ModelState.IsValid)
            {
                db.Nhóm_Câu_Hỏi.Add(nhóm_Câu_Hỏi);
                db.SaveChanges();
                return RedirectToAction("QuanLyNhomCauHoi");
            }

            ViewBag.MaMon = new SelectList(db.Môn_Học, "MaMon", "TenMon", nhóm_Câu_Hỏi.MaMon);
            return View(nhóm_Câu_Hỏi);
        }

        // GET: Nhóm_Câu_Hỏi/Edit/5
        public ActionResult EditQuesGroup(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhóm_Câu_Hỏi nhóm_Câu_Hỏi = db.Nhóm_Câu_Hỏi.Find(id);
            if (nhóm_Câu_Hỏi == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaMon = new SelectList(db.Môn_Học, "MaMon", "TenMon", nhóm_Câu_Hỏi.MaMon);
            return View(nhóm_Câu_Hỏi);
        }

        // POST: Nhóm_Câu_Hỏi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditQuesGroup([Bind(Include = "MaNhom,TenNhom,MaMon,SoCauHoi")] Nhóm_Câu_Hỏi nhóm_Câu_Hỏi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhóm_Câu_Hỏi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("QuanLyNhomCauHoi");
            }
            ViewBag.MaMon = new SelectList(db.Môn_Học, "MaMon", "TenMon", nhóm_Câu_Hỏi.MaMon);
            return View(nhóm_Câu_Hỏi);
        }

        // GET: Nhóm_Câu_Hỏi/Delete/5
        public ActionResult DeleteQuesGroup(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhóm_Câu_Hỏi nhóm_Câu_Hỏi = db.Nhóm_Câu_Hỏi.Find(id);
            if (nhóm_Câu_Hỏi == null)
            {
                return HttpNotFound();
            }
            return View(nhóm_Câu_Hỏi);
        }

        // POST: Nhóm_Câu_Hỏi/Delete/5
        [HttpPost, ActionName("DeleteQuesGroup")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Nhóm_Câu_Hỏi nhóm_Câu_Hỏi = db.Nhóm_Câu_Hỏi.Find(id);
            db.Nhóm_Câu_Hỏi.Remove(nhóm_Câu_Hỏi);
            db.SaveChanges();
            return RedirectToAction("QuanLyNhomCauHoi");
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
