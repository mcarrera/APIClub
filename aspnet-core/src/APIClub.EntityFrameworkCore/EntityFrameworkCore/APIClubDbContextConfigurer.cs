using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace APIClub.EntityFrameworkCore
{
    public static class APIClubDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<APIClubDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<APIClubDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
