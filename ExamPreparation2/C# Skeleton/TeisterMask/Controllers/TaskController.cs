using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
        [ValidateInput(false)]
	public class TaskController : Controller
	{
	    [HttpGet]
            [Route("")]
	    public ActionResult Index()
	    {
            using (var database = new TeisterMaskDbContext())
            {
                List<Task> tasks = database.Tasks.ToList();
                return View(tasks);
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
		public ActionResult Create(Task task)
		{
            using (var database = new TeisterMaskDbContext())
            {
                database.Tasks.Add(task);
                database.SaveChanges();
                return Redirect("/");
            }
        }

		[HttpGet]
		[Route("edit/{id}")]
        public ActionResult Edit(int id)
		{
            using (var database = new TeisterMaskDbContext())
            {
               Task taskFromDataBase = database.Tasks.Find(id);
               return View(taskFromDataBase);
            }           
        }

		[HttpPost]
		[Route("edit/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult EditConfirm(int id, Task taskModel)
		{
            using (var database = new TeisterMaskDbContext())
            {
                var taskFromDataBase = database.Tasks.Find(id);

                taskFromDataBase.Title = taskModel.Title;
                taskFromDataBase.Status = taskModel.Status;

                database.SaveChanges();
            }
            return Redirect("/");
        }
	}
}