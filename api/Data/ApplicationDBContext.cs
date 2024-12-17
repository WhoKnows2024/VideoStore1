using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    { 
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Inventory> Inventory {get; set;} = null!;
        public DbSet<InvComments> InvComments {get; set;} = null!;
        public DbSet<Customer> CustComment {get; set; } = null!;
        public DbSet<CustComments> CustComments {get; set;} = null!;
        public DbSet<Rentals> Rentals {get; set;} = null!;
        
    }

    
}