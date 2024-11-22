using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CodeGenerate.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GeneratedCode> generatedCode { get; set; }

        public class GeneratedCode
        {
            [Key]
           public int Id { get; set; }
            public int CompanyId { get; set; } // not primary
            public string CompanyName { get; set; }
            public decimal ProductId { get; set; }
            public string ProductName { get; set; }
            public string Code { get; set; }
        }
    }
}
