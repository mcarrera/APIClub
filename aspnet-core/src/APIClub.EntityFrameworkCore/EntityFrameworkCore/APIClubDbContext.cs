using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using APIClub.Authorization.Roles;
using APIClub.Authorization.Users;
using APIClub.MultiTenancy;

namespace APIClub.EntityFrameworkCore
{
    public class APIClubDbContext : AbpZeroDbContext<Tenant, Role, User, APIClubDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public APIClubDbContext(DbContextOptions<APIClubDbContext> options)
            : base(options)
        {
        }
    }
}
