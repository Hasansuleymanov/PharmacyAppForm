using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAppNew.Models
{
    public class PharmacyContext:DbContext
    {
        public PharmacyContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseSqlServer("Data Source=DESKTOP-9HU6DH7\\MSSQLSERVER01;DataBase=PharmacyDB;Trusted_Connection=true;TrustServerCertificate=True");
        public DbSet<Medicine>Medicines { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MedicineToCategory> MedicineToCategories { get; set; }
        public DbSet<MedicineToFirm> MedicineToFirms { get; set; }
    }
}
