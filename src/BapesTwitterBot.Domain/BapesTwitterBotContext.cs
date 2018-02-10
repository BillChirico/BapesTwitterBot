using System;
using BapesTwitterBot.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BapesTwitterBot.Domain
{
    public class BapesTwitterBotContext : DbContext
    {
        public DbSet<TwitterUser> TwitterUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:bapestwitterbot.database.windows.net,1433;Initial Catalog=BapesTwitterBot;Persist Security Info=False;User ID=bapes;Password=Hello123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}