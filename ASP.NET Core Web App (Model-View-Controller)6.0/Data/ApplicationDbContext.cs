using ASP.NET_Core_Web_App__Model_View_Controller_6._0.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_App__Model_View_Controller_6._0.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
