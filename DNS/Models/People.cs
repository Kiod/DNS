using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DNS.Models
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Departmen { get; set; }
        public string Position { get; set; }
        public string Boss { get; set; }
        public int Age { get; set; }
    }
}
