using EccomUpload.DAL;
using EccomUpload.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace EccomUpload.Controllers
{
    public class Customer_Reg_TableController : Controller
    {
        private MaliMaliEntities db = new MaliMaliEntities();

        // GET: Customer_Reg_Table
        public ActionResult Index()
        {
            return View(db.Customer_Reg_Table.ToList());
        }

        // GET: Customer_Reg_Table/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_Reg_Table customer_Reg_Table = db.Customer_Reg_Table.Find(id);
            if (customer_Reg_Table == null)
            {
                return HttpNotFound();
            }
            return View(customer_Reg_Table);
        }

        // GET: Customer_Reg_Table/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer_Reg_Table/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Customer_ID,Customer_First_Name,Customer_Second_Name,Customer_Phone_Number,Customer_Nearest_Primary")] Customer_Reg_Table customer_Reg_Table)
        {
            if (ModelState.IsValid)
            {
                db.Customer_Reg_Table.Add(customer_Reg_Table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer_Reg_Table);
        }

        // GET: Customer_Reg_Table/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_Reg_Table customer_Reg_Table = db.Customer_Reg_Table.Find(id);
            if (customer_Reg_Table == null)
            {
                return HttpNotFound();
            }
            return View(customer_Reg_Table);
        }

        // POST: Customer_Reg_Table/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Customer_ID,Customer_First_Name,Customer_Second_Name,Customer_Phone_Number,Customer_Nearest_Primary")] Customer_Reg_Table customer_Reg_Table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer_Reg_Table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer_Reg_Table);
        }

        // GET: Customer_Reg_Table/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_Reg_Table customer_Reg_Table = db.Customer_Reg_Table.Find(id);
            if (customer_Reg_Table == null)
            {
                return HttpNotFound();
            }
            return View(customer_Reg_Table);
        }

        // POST: Customer_Reg_Table/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer_Reg_Table customer_Reg_Table = db.Customer_Reg_Table.Find(id);
            db.Customer_Reg_Table.Remove(customer_Reg_Table);
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
