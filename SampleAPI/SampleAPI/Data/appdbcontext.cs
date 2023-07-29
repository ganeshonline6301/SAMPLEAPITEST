using Microsoft.EntityFrameworkCore;
using SampleAPI.Models;

namespace SampleAPI.Data
{
    public class appdbcontext : DbContext
    {
        public appdbcontext(DbContextOptions<appdbcontext> options) : base(options)
        {
            
        }

        public DbSet<NameSample> Samples { get; set; }
    }
}
