using API.Entities;
using Microsoft.EntityFrameworkCore;


//This allows us to create a DBContext that will be used to interact with the database
namespace API.Data
{
    public class StoreContext : DbContext
    {
        
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }
        

    }
}