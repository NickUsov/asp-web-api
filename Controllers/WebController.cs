using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication9.DAL;
using WebApplication9.Models;
using System.Data.Entity;

namespace WebApplication9.Controllers
{
    public class WebController : ApiController
    {
        readonly IRepository<Person> db;
        public WebController(IRepository<Person> repo)
        {
            db = repo;
        }

        //StaffRepository db = new StaffRepository();
        // GET api/web
        public IEnumerable<Person> GetAll()
        {
            return db.GetAll();
        }

        // GET api/web/3
        public Person Get(int id)
        {
            return db.Get(id);
        }

        //POST api/web
        public Person PostPerson(Person person)
        {
            return db.Create(person);
        }

        //PUT api/web
        public void PutPerson( Person person)
        {
            db.Update(person);
        }

        //DELETE api/web/id
        public void DeletePerson(int id)
        {
            db.Delete(id);
        }
    }
}
