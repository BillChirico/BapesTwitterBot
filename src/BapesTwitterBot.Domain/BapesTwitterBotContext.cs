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
            optionsBuilder.UseSqlServer(@"");
        }
    }
}