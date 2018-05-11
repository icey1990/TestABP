using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyTestABP.Authorization.Roles;
using MyTestABP.Authorization.Users;
using MyTestABP.MultiTenancy;

namespace MyTestABP.EntityFrameworkCore
{
    public class MyTestABPDbContext : AbpZeroDbContext<Tenant, Role, User, MyTestABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyTestABPDbContext(DbContextOptions<MyTestABPDbContext> options)
            : base(options)
        {
        }
    }
}
