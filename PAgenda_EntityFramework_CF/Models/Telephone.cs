using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgenda_EntityFramework_CF.Models
{
    internal class Telephone
    {   
        public int Id {get;set;}
        public string phone { get; set; }
        public string mobile { get; set; }
        public Person name { get; set; }

    }
}
