using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static SportClubStart.Models.DB;

namespace SportClubStart
{
    internal class ConnectDB : DbContext
    {
        public DbSet<Attendances> Attendances { get; set; }
        public DbSet<Coaches> Coaches { get; set; }
        public DbSet<Sportsmen> Sportsmen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.GetFullPath(
                Path.Combine(AppContext.BaseDirectory, @"..\..\..\DataBase.db")
            );

            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}