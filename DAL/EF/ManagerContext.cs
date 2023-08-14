using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class ManagerContext : DbContext
    {
        
            public DbSet<Client> Clients { get; set; }
            public DbSet<Payment> Payments { get; set; }

        
    }
}
