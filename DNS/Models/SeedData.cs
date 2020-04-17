using DNS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNS.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCExcelContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCExcelContext>>()))
            {
                // Look for any movies.
                if (context.Ppl.Any())
                {
                    return;   // DB has been seeded
                }

                context.Ppl.AddRange(
                    new People
                    {
                        Name = "Harry",
                        //ReleaseDate = DateTime.Parse("1989-2-12"),
                        LastName = "Romantic",
                        Age = 177
                    },

                    new People
                    {
                        Name = "Parry",
                        //ReleaseDate = DateTime.Parse("1989-2-12"),
                        LastName = "Romanic",
                        Age = 175
                    },

                    new People
                    {
                        Name = "Sharry",
                        //ReleaseDate = DateTime.Parse("1989-2-12"),
                        LastName = "Romant",
                        Age = 170
                    },

                    new People
                    {
                        Name = "Carry",
                        //ReleaseDate = DateTime.Parse("1989-2-12"),
                        LastName = "Rotic",
                        Age = 18
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
