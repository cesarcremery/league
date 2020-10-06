using DataLayer.Diagram;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer {
    public class dbModel : DbContext {
        public DbSet<Speler> Spelers { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Transfer> Transfers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder option) {
            option.UseSqlServer("Data Source=DESKTOP-HTU1SDE\\SQLEXPRESS;Initial Catalog=ef;Integrated Security=True");

        }
    }
}
