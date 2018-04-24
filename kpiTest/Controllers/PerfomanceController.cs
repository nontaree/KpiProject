using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using kpiTest.Models;

namespace kpiTest.Controllers
{
    public class PerfomanceController : Controller
    {
        private KPIEntities db = new KPIEntities();

        // GET: Perfomance
        public ActionResult Index()
        {

            //kpi_Perfomance p = new kpi_Perfomance();

            //p.KPM_Event = "E-dokkkkkkkkk";

            //var data = (from p in db.kpi_Perfomance
            //            join k in db.kpi_PerfomanceKey on p.KPM_ID equals k.KPM_ID into d1
            //            from f in d1.DefaultIfEmpty()
            //            join y in db.kpi_Year on p.KPY_ID equals y.KPY_ID into d2
            //            from c in d2.DefaultIfEmpty()
            //            select new
            //            {
            //                p.KPM_ID,
            //                p.KPM_Event,
            //                p.KPM_FPercent,
            //                p.KPM_SPercent,
            //                c.KPY_ID,
            //                f.KPK_ID,
            //                f.KPK_Number,
            //                f.KPK_Name,
            //                f.KPK_Comment,
            //                c.KPY_Name,
            //                c.KPY_StartDate,
            //                c.KPY_EndDate
            //            }).GroupBy(m => new
            //            {
            //                performance_no = m.KPM_ID,
            //                performance_event = m.KPM_Event,
            //                performance_first_no = m.KPM_FPercent,
            //                performance_second_no = m.KPM_SPercent,
            //                year_no = m.KPY_ID,
            //                perforkey_no = m.KPK_ID,
            //                perforkey_num = m.KPK_Number,
            //                perforkey_name = m.KPK_Name,
            //                perforkey_comment = m.KPK_Comment,
            //                year_name = m.KPY_Name,
            //                year_start = m.KPY_StartDate,
            //                year_end = m.KPY_EndDate
            //            }).Select(s => new
            //            {
            //                PerforNo = s.Key.performance_no,
            //                PerforEvent = s.Key.performance_event,
            //                PerforNoFirst = s.Key.performance_first_no,
            //                PerFoSecond = s.Key.performance_second_no,
            //                YearNo = s.Key.year_no,
            //                PerKeyNo = s.Key.perforkey_no,
            //                PerKeyNum = s.Key.perforkey_num,
            //                PerKeyName = s.Key.perforkey_name,
            //                PerKeyComment = s.Key.perforkey_comment,
            //                YearName = s.Key.year_name,
            //                YearStart = s.Key.year_start,
            //                YearEnd = s.Key.year_end
            //            }).OrderBy(p => p.PerforNo).ToList(); 

            //kpi_Perfomance performanceData;
            //List<kpi_Perfomance> RenderData = new List<kpi_Perfomance>();

            //int i = 0;
            //foreach (var item in data)
            //{
            //    performanceData = new kpi_Perfomance();
            //    performanceData.KPM_ID = item.PerforNo;
            //    performanceData.KPM_Event = item.PerforEvent;
            //    performanceData.KPM_FPercent = item.PerforNoFirst;
            //    performanceData.KPM_SPercent = item.PerFoSecond;
            //    performanceData.KPY_ID = item.YearNo;
            //    performanceData.KPK_ID = item.PerKeyNo;

            //}

            var dataindex = (from p in db.kpi_Perfomance
                             join k in db.kpi_PerfomanceKey on p.KPM_ID equals k.KPM_ID into d1
                             from f in d1.DefaultIfEmpty()
                             join y in db.kpi_Year on p.KPY_ID equals y.KPY_ID into d2
                             from c in d2.DefaultIfEmpty()
                             select new
                             {
                                 PerforNo = p.KPM_ID,
                                 PerforEvent = p.KPM_Event,
                                 PerforNoFirst = p.KPM_FPercent,
                                 PerFoSecond = p.KPM_SPercent,
                                 YearNo = c.KPY_ID,
                                 PerKeyNo = f.KPK_ID,
                                 PerKeyNum = f.KPK_Number,
                                 PerKeyName = f.KPK_Name,
                                 PerKeyComment = f.KPK_Comment,
                                 YearName = c.KPY_Name,
                                 YearStart = c.KPY_StartDate,
                                 YearEnd = c.KPY_EndDate
                             }).ToList();



            kpi_Perfomance performanceData;
            List<kpi_Perfomance> RenderData = new List<kpi_Perfomance>();
            List<SelectListItem> test = new List<SelectListItem>();

            int i = 0;
            foreach (var item in dataindex)
            {
                performanceData = new kpi_Perfomance();
                performanceData.KPM_ID = item.PerforNo;
                performanceData.KPM_Event = item.PerforEvent;
                performanceData.KPM_FPercent = item.PerforNoFirst;
                performanceData.KPM_SPercent = item.PerFoSecond;
                performanceData.KPY_ID = item.YearNo;
                performanceData.KPK_ID = item.PerKeyNo;
                performanceData.KPK_Number = item.PerKeyNum;
                performanceData.KPK_Name = item.PerKeyComment;
                performanceData.KPY_Name = item.YearName;
                performanceData.KPY_StartDate = item.YearStart;
                performanceData.KPY_EndDate = item.YearEnd;
                RenderData.Add(performanceData);
            }

            var queryList = from x in db.kpi_Perfomance select x;
            foreach(var n in queryList)
            {
                test.Add(new SelectListItem { Text = n.KPM_Event, Value = n.KPM_ID.ToString() });
            }
            ViewBag.EventKpi = (IEnumerable<SelectListItem>)test;

            //TempData["CL_REF_NO_TEMP"] = cLIS_HEADER.CL_REFERENCE_NO;
            //var refNo = (string)TempData["CL_REF_NO_TEMP"];
            //ViewBag.KP = TempData["CL_REF_NO_TEMP"];

            ////DrowdownList Page Create : kpievent
            //var kpievent = db.kpi_Perfomance.ToDictionary(c => c.KPM_ID, c => c.KPM_ID + "\xA0\xA0" + c.KPM_Event);
            //ViewData["eventkpi"] = new SelectList(kpievent, "Key", "Value");



            //return View(kpi_Perfomance.ToList());
            //return View();
            //return View(dataindex);
            return View(RenderData.OrderByDescending(p => p.KPM_ID).ToList());

            //return View(kpi_Perfomance.ToList());



        }




        // GET: Perfomance/Details/5
        public ActionResult Details(int? id)
        {

           // //DrowdownList Page Create: kpievent
           //var kpievent = db.kpi_Perfomance.ToDictionary(c => c.KPM_ID, c => c.KPM_ID + "\xA0\xA0" + c.KPM_Event);
           // ViewData["eventkpi"] = new SelectList(kpievent, "Key", "Value");

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kpi_Perfomance kpi_Perfomance = db.kpi_Perfomance.Find(id);
            if (kpi_Perfomance == null)
            {
                return HttpNotFound();
            }
            return View(kpi_Perfomance);


        }

        // GET: Perfomance/Create
        public ActionResult Create()
        {
            ViewBag.KPY_ID = new SelectList(db.kpi_Year, "KPY_ID", "KPY_Name");
            return View();
        }

        // POST: Perfomance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KPM_ID,KPM_Event,KPM_FPercent,KPM_SPercent,KPY_ID")] kpi_Perfomance kpi_Perfomance)
        {
            if (ModelState.IsValid)
            {
                db.kpi_Perfomance.Add(kpi_Perfomance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KPY_ID = new SelectList(db.kpi_Year, "KPY_ID", "KPY_Name", kpi_Perfomance.KPY_ID);
            return View(kpi_Perfomance);
        }

        // GET: Perfomance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kpi_Perfomance kpi_Perfomance = db.kpi_Perfomance.Find(id);
            if (kpi_Perfomance == null)
            {
                return HttpNotFound();
            }
            ViewBag.KPY_ID = new SelectList(db.kpi_Year, "KPY_ID", "KPY_Name", kpi_Perfomance.KPY_ID);
            return View(kpi_Perfomance);
        }

        // POST: Perfomance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KPM_ID,KPM_Event,KPM_FPercent,KPM_SPercent,KPY_ID")] kpi_Perfomance kpi_Perfomance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kpi_Perfomance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KPY_ID = new SelectList(db.kpi_Year, "KPY_ID", "KPY_Name", kpi_Perfomance.KPY_ID);
            return View(kpi_Perfomance);
        }

        // GET: Perfomance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kpi_Perfomance kpi_Perfomance = db.kpi_Perfomance.Find(id);
            if (kpi_Perfomance == null)
            {
                return HttpNotFound();
            }
            return View(kpi_Perfomance);
        }

        // POST: Perfomance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            kpi_Perfomance kpi_Perfomance = db.kpi_Perfomance.Find(id);
            db.kpi_Perfomance.Remove(kpi_Perfomance);
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
