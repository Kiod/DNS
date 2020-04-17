using DNS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNS.Data
{
    public class MVCExcelContext : DbContext
    {
        public MVCExcelContext(DbContextOptions<MVCExcelContext> options)
    : base(options)
        {
        }

        public DbSet<People> Ppl { get; set; }
    }
}
