using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TurizmUygulama.Data;
using TurizmUygulama.Models;

namespace TurizmUygulama.Controllers
{
    public class tur_bilgisiController : Controller
    {
        private ProcessContext db = new ProcessContext();

        // GET: tur_bilgisi
        public ActionResult Index()
        {
            return View(db.TurBilgileri.ToList());
        }

        // GET: tur_bilgisi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tur_bilgisi tur_bilgisi = db.TurBilgileri.Find(id);
            if (tur_bilgisi == null)
            {
                return HttpNotFound();
            }
            return View(tur_bilgisi);
        }

        // GET: tur_bilgisi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tur_bilgisi/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TurID,TurAdi,BaslangicTarihi,BaslangicSehri,TurSuresi")] tur_bilgisi tur_bilgisi)
        {
            if (ModelState.IsValid)
            {
                db.TurBilgileri.Add(tur_bilgisi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tur_bilgisi);
        }

        // GET: tur_bilgisi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tur_bilgisi tur_bilgisi = db.TurBilgileri.Find(id);
            if (tur_bilgisi == null)
            {
                return HttpNotFound();
            }
            return View(tur_bilgisi);
        }

        // POST: tur_bilgisi/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TurID,TurAdi,BaslangicTarihi,BaslangicSehri,TurSuresi")] tur_bilgisi tur_bilgisi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tur_bilgisi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tur_bilgisi);
        }

        // GET: tur_bilgisi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tur_bilgisi tur_bilgisi = db.TurBilgileri.Find(id);
            if (tur_bilgisi == null)
            {
                return HttpNotFound();
            }
            return View(tur_bilgisi);
        }

        // POST: tur_bilgisi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tur_bilgisi tur_bilgisi = db.TurBilgileri.Find(id);
            db.TurBilgileri.Remove(tur_bilgisi);
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
