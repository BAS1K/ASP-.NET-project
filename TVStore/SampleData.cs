using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVStore.Models;

namespace TVStore
{
    public static class SampleData
    {
        public static void Initialize(TVContext context)
        {
            if (!context.TVs.Any())
            {
                context.TVs.AddRange(
                    new TV
                    {
                        Name = "LG X54T-2019",
                        Company = "LG",
                        Price = 1000
                    },
                    new TV
                    {
                        Name = "Samsung UltraTV-v.3",
                        Company = "Samsung",
                        Price = 950
                    },
                    new TV
                    {
                        Name = "Sony XD-555",
                        Company = "Sony",
                        Price = 660
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
