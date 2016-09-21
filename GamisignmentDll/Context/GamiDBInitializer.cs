using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamisignmentDll.Entities;

namespace GamisignmentDll.Context
{
    public class GamiDbInitializer : DropCreateDatabaseAlways<GamiSignmentContext>
    {
        protected override void Seed(GamiSignmentContext context)
        {
            context.Prizes.Add(new Prize
            {
                Description = "Legoland Trip",
                Points = 20000,
                Title = "Legoland"
            });
            context.Prizes.Add(new Prize
            {
                Description = "Ice Cream",
                Points = 20,
                Title = "Ice Cream"
            });
            context.Users.Add(new User() {FirstName = "Lars", LastName = "Bilde"});

            base.Seed(context);
        }
    }
    
}
