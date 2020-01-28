using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication9.Models
{
    public class StaffContext:DbContext
    {
        public DbSet<Person> People { get; set; }
    }
    public class StaffDbInitializer:DropCreateDatabaseIfModelChanges<StaffContext>
    {
        protected override void Seed(StaffContext context)
        {
            context.People.Add(new Person { Id = 1, Name = "Vasya", Age = 25, Married = false });
            context.People.Add(new Person { Id = 2, Name = "Ivan", Age = 21, Married = false });
            context.People.Add(new Person { Id = 3, Name = "Sveta", Age = 20, Married = true });
        }
    }
}