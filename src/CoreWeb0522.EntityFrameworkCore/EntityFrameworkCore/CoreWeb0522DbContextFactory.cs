using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CoreWeb0522.Configuration;
using CoreWeb0522.Web;

namespace CoreWeb0522.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CoreWeb0522DbContextFactory : IDesignTimeDbContextFactory<CoreWeb0522DbContext>
    {
        public CoreWeb0522DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CoreWeb0522DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CoreWeb0522DbContextConfigurer.Configure(builder, configuration.GetConnectionString(CoreWeb0522Consts.ConnectionStringName));

            return new CoreWeb0522DbContext(builder.Options);
        }
    }
}
