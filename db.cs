using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace sign_up
{
    public class db:DbContext
    {
        public db():base("rt")
        {

        }
        public DbSet<sign_up> sign_Ups { get; set; }
    }
}
