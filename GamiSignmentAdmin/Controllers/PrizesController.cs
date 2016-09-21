using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GamisignmentDll;
using GamisignmentDll.Context;
using GamisignmentDll.Entities;

namespace GamiSignmentAdmin.Controllers
{
    public class PrizesController : Controller
    {
        private IManager<Prize> _pm = new DllFacade().GetPrizeManager();

        // GET: Prizes
        public ActionResult Index()
        {
            return View(_pm.Read());
        }

        // GET: Prizes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prize prize = _pm.Read(id.Value);
            if (prize == null)
            {
                return HttpNotFound();
            }
            return View(prize);
        }

        // GET: Prizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Points,Title,Description")] Prize prize)
        {
            if (ModelState.IsValid)
            {
                _pm.Create(prize);
                return RedirectToAction("Index");
            }

            return View(prize);
        }

        // GET: Prizes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prize prize = _pm.Read(id.Value);
            if (prize == null)
            {
                return HttpNotFound();
            }
            return View(prize);
        }

        // POST: Prizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Points,Title,Description")] Prize prize)
        {
            if (ModelState.IsValid)
            {
                _pm.Update(prize);
                return RedirectToAction("Index");
            }
            return View(prize);
        }

        // GET: Prizes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prize prize = _pm.Read(id.Value);
            if (prize == null)
            {
                return HttpNotFound();
            }
            return View(prize);
        }

        // POST: Prizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _pm.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
