using Microsoft.EntityFrameworkCore;

namespace RiderBugRepro
{
    public class Context : DbContext
    {
        public DbSet<Analyser> Analyser { get; set; }
        public DbSet<Examination> Examination { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("TestDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnalyserExamination>().HasKey(ae => new { ae.AnalyserId, ae.ExaminationId });

            base.OnModelCreating(modelBuilder);
        }
    }
}