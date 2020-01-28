using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
using WebApplication9.DAL;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        readonly IRepository<Person> db;
        public HomeController(IRepository<Person> repo)
        {
            db = repo;
        }
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Person> people = db.GetAll();
            return View(people);
        }
    }
}