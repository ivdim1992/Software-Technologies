namespace LogNoziroh.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ReportController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var database = new LogNozirohDbContext())
            {
                List<Report> reports = database.Reports.ToList();
                return View(reports);
            }
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            using (var database = new LogNozirohDbContext())
            {
                var report = database.Reports.Find(id);

                return View(report);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Report report)
        {
            using (var database = new LogNozirohDbContext())
            {
                database.Reports.Add(report);
                database.SaveChanges();
                return Redirect("/");
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (var database = new LogNozirohDbContext())
            {
                var report = database.Reports.Find(id);
                return View(report);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Report reportModel)
        {
            using (var database = new LogNozirohDbContext())
            {
                var reportFromDataBase = database.Reports.Find(id);
                database.Reports.Remove(reportFromDataBase);
                database.SaveChanges();

                return Redirect("/");
            }
        }
    }
}