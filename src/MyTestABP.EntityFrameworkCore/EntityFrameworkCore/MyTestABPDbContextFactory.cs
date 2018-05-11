using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyTestABP.Configuration;
using MyTestABP.Web;

namespace MyTestABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyTestABPDbContextFactory : IDesignTimeDbContextFactory<MyTestABPDbContext>
    {
        public MyTestABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyTestABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyTestABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyTestABPConsts.ConnectionStringName));

            return new MyTestABPDbContext(builder.Options);
        }
    }
}
