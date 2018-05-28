using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CoreWeb0522.EntityFrameworkCore
{
    public static class CoreWeb0522DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CoreWeb0522DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString, b => b.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<CoreWeb0522DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection,b=>b.UseRowNumberForPaging());
        }
    }
}
