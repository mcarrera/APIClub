using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using APIClub.Authorization.Roles;
using APIClub.Authorization.Users;
using APIClub.MultiTenancy;
using APIClub.Domain;

namespace APIClub.EntityFrameworkCore
{
    public class APIClubDbContext : AbpZeroDbContext<Tenant, Role, User, APIClubDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Transanction> Transanctions { get; set; }

        public APIClubDbContext(DbContextOptions<APIClubDbContext> options) : base(options)
        {
        }
    }
}
