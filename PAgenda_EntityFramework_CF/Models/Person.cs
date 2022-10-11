using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgenda_EntityFramework_CF.Models
{
    internal class Person
    {
        [Key]
        public string name { get; set; } 
        public List<Telephone> telephones { get; set; }
    }
}
