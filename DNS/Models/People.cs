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

        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
    }
}
