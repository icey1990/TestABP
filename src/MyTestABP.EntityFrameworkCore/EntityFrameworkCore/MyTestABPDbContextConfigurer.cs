using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyTestABP.EntityFrameworkCore
{
    public static class MyTestABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyTestABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyTestABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
