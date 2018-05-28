using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CoreWeb0522.Authorization.Roles;
using CoreWeb0522.Authorization.Users;
using CoreWeb0522.MultiTenancy;
using CoreWeb0522.PhoneBook.Persons;
using CoreWeb0522.PhoneBook.PhoneNumbers;

namespace CoreWeb0522.EntityFrameworkCore
{
    public class CoreWeb0522DbContext : AbpZeroDbContext<Tenant, Role, User, CoreWeb0522DbContext>
    {
        /* Define a DbSet for each entity of the application */





        public CoreWeb0522DbContext(DbContextOptions<CoreWeb0522DbContext> options)
            : base(options)
        {
        }
         


        public DbSet<Person> Persons { get; set; }

        public DbSet<PhoneNumber> PhoneNumbers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");




            base.OnModelCreating(modelBuilder);
        }

    }
}
