using CIPS.Core;

using Microsoft.EntityFrameworkCore;

namespace CIPS.Repository
{
    public class CIPSContext : DbContext
    {
        public CIPSContext(DbContextOptions<CIPSContext> options) : base(options)
        {

        }
        public DbSet<Gradjanin> Gradjani { get; set; }
    }
}