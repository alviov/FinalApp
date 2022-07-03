using Microsoft.EntityFrameworkCore;
using FinalApp.Entities;

namespace FinalApp.DB
{
    public class AppDBContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<SurgeryData> SurgeryData { get; set; }
        public DbSet<SpectrometerMeasurements> Spectrometer_measurements { get; set; }
        public DbSet<ChelationTherapyData> Chelation_therapyData { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public AppDBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
