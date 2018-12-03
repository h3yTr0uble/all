using Department.BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class AwardController: Controller
    {
        private static AwardBL awards = new AwardBL();

        static AwardController()
        {
            awards.InitList();
        }
        //
        // GET: /Award/

        public ActionResult Index()
        {
            ViewBag.HeaderText = "Awards list";
            return View(awards.GetList());
        }

        //
        // GET: /Award/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Award/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                awards.Add(new Award(collection["Title"], collection["Description"]));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Award/Edit/5

        public ActionResult Edit(int id)
        {
            var currentAward = awards.GetList().FirstOrDefault(u => u.Id == id);
            return View(currentAward);
        }

        //
        // POST: /Award/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                awards.Edit(new Award(int.Parse(collection["Id"]), collection["Title"], collection["Description"]));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Award/Delete/5

        public ActionResult Delete(int id)
        {
            var currentAward = awards.GetList().FirstOrDefault(u => u.Id == id);
            if (currentAward != null)
            {
                awards.Remove(currentAward);
            }

            return RedirectToAction("Index");
        }

      
        
    }
}