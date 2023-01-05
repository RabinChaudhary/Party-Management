using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Party_Management.Models;

namespace Party_Management.Controllers
{
    public class Event_detailsController : Controller
    {
        private Party_ManagementEntities1 db = new Party_ManagementEntities1();
      
        // GET: Event_details
      
        public ActionResult Index()
        {
            return View(db.event_details.ToList());
        }

        // GET: Event_details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            event_details event_details = db.event_details.Find(id);
            if (event_details == null)
            {
                return HttpNotFound();
            }
            return View(event_details);
        }

        // GET: Event_details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event_details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,party_type,party_time,Number_of_attendees")] event_details event_details)
        {
            if (ModelState.IsValid)
            {
                db.event_details.Add(event_details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(event_details);
        }

        // GET: Event_details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            event_details event_details = db.event_details.Find(id);
            if (event_details == null)
            {
                return HttpNotFound();
            }
            return View(event_details);
        }

        // POST: Event_details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,party_type,party_time,Number_of_attendees")] event_details event_details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(event_details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(event_details);
        }

        // GET: Event_details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            event_details event_details = db.event_details.Find(id);
            if (event_details == null)
            {
                return HttpNotFound();
            }
            return View(event_details);
        }

        // POST: Event_details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            event_details event_details = db.event_details.Find(id);
            db.event_details.Remove(event_details);
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
