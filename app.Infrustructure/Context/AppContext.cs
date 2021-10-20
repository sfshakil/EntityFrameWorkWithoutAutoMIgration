using app.Infrustructure.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Infrustructure.Context
{
    public class AppContext: DbContext
    {
        public AppContext():base("AppDB")
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
    }
}
