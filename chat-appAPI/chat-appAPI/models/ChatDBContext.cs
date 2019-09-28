using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chat_appAPI.models {
    public class ChatDBContext : DbContext {
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // Set User Display Name to unique
            modelBuilder.Entity<User>()
                .HasIndex(u => u.DisplayName)
                .IsUnique();
        }

        public ChatDBContext(DbContextOptions options) : base(options) {

        }
    }
}
