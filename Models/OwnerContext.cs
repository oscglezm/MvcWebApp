using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvcWebApp.Models
{
    public class OwnerContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }

    }
}