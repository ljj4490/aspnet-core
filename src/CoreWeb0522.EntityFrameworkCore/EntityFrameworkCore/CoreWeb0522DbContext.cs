using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CoreWeb0522.Authorization.Roles;
using CoreWeb0522.Authorization.Users;
using CoreWeb0522.MultiTenancy;

namespace CoreWeb0522.EntityFrameworkCore
{
    public class CoreWeb0522DbContext : AbpZeroDbContext<Tenant, Role, User, CoreWeb0522DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CoreWeb0522DbContext(DbContextOptions<CoreWeb0522DbContext> options)
            : base(options)
        {
        }
    }
}
