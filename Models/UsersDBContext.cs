using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Role_WebAPI.Models
{
    public class UsersDBContext : DbContext
    {
        public  DbSet<User> User { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ATSLP006\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();

            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();

            });


            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedOnAdd();


                modelBuilder.Entity<User>()
                    .ToTable("User");
                modelBuilder.Entity<User>()
                    .Property(s => s.UserName)
                    .IsRequired(true);
                modelBuilder.Entity<User>()
                    .Property(s => s.FullName)
                    .IsRequired(true);
                modelBuilder.Entity<User>()
                    .HasData(
                        new User
                        {
                            ID = 1,
                            UserName = "Pradip",
                            FullName = "Pradip Lanke"
                        },
                        new User
                        {
                            ID = 2,
                            UserName = "Ram",
                            FullName = "Ram Kale"
                        }
                    );


                modelBuilder.Entity<Roles>()
                     .ToTable("Roles");
                modelBuilder.Entity<Roles>()
                    .Property(s => s.Role)
                    .IsRequired(true);
               
                modelBuilder.Entity<Roles>()
                    .HasData(
                        new Roles
                        {
                            ID = 1,
                            Role = "Manager",
                         
                        },
                        new Roles
                        {
                            ID = 2,
                            Role = "Developer",
                           
                        },
                         new Roles
                         {
                             ID = 3,
                             Role = "Tester",
                           
                         }
                    );


                modelBuilder.Entity<UserRoles>()
                    .ToTable("UserRoles");
                modelBuilder.Entity<UserRoles>()
                    .Property(s => s.USer_ID)
                    .IsRequired(true);
                modelBuilder.Entity<UserRoles>()
                    .Property(s => s.Role_ID)
                    .IsRequired(true);
                modelBuilder.Entity<UserRoles>()
                    .HasData(
                        new UserRoles
                        {
                            ID = 1,
                            USer_ID = 1,
                            Role_ID = 1
                        },
                        new UserRoles
                        {
                            ID = 2,
                            USer_ID = 2 ,
                            Role_ID = 2
                        }
                    );

                

            });
        }
    }
}
