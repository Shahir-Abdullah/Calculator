using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace backend.Models
{
    public class CalculationContext : DbContext
    {
        public CalculationContext(DbContextOptions<CalculationContext> options)
            : base(options)
        {
        }
        
        public DbSet<Calculation> Calculations { get; set; } = null!;
        
    }
}