using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAgenda_EntityFramework_CF.Models;

namespace PAgenda_EntityFramework_CF.Context
{

    internal class PhoneBook : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
    }
}
