﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WatchOnline_.Context;
using WatchOnline_.Models;

namespace WatchOnline_.Controllers
{
    public class RecommendationsController : Controller
    {
        private WatchOnline_Context db = new WatchOnline_Context();

        // GET: Recommendations
        public ActionResult Index()
        {
            var recommendations = db.Recommendations.Include(r => r.Watch);
            return View(recommendations.ToList());
        }

        // GET: Recommendations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recommendation recommendation = db.Recommendations.Find(id);
            if (recommendation == null)
            {
                return HttpNotFound();
            }
            return View(recommendation);
        }

        // GET: Recommendations/Create
        public ActionResult Create()
        {
            ViewBag.WatchId = new SelectList(db.Watches, "WatchId", "Picture");
            return View();
        }

        // POST: Recommendations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecommendationId,UserId,WatchId,Recommendations")] Recommendation recommendation)
        {
            if (ModelState.IsValid)
            {
                db.Recommendations.Add(recommendation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.WatchId = new SelectList(db.Watches, "WatchId", "Picture", recommendation.WatchId);
            return View(recommendation);
        }

        // GET: Recommendations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recommendation recommendation = db.Recommendations.Find(id);
            if (recommendation == null)
            {
                return HttpNotFound();
            }
            ViewBag.WatchId = new SelectList(db.Watches, "WatchId", "Picture", recommendation.WatchId);
            return View(recommendation);
        }

        // POST: Recommendations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecommendationId,UserId,WatchId,Recommendations")] Recommendation recommendation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recommendation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.WatchId = new SelectList(db.Watches, "WatchId", "Picture", recommendation.WatchId);
            return View(recommendation);
        }

        // GET: Recommendations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recommendation recommendation = db.Recommendations.Find(id);
            if (recommendation == null)
            {
                return HttpNotFound();
            }
            return View(recommendation);
        }

        // POST: Recommendations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recommendation recommendation = db.Recommendations.Find(id);
            db.Recommendations.Remove(recommendation);
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
