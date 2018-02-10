using BapesTwitterBot.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BapesTwitterBot.Domain
{
    public class BapesTwitterBotContext : DbContext
    {
        private const string ConnectionString = "";
        
        public DbSet<TwitterUser> TwitterUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}