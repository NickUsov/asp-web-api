using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication9.DAL;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class PeopleController : ApiController
    {
        readonly IRepository<Person> db;
        public PeopleController(IRepository<Person> repo)
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
        [HttpPost]
        public Person CreatePerson(Person person)
        {
            return db.Create(person);
        }

        //PUT api/web
        [HttpPut]
        public void UpdatePerson(Person person)
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
