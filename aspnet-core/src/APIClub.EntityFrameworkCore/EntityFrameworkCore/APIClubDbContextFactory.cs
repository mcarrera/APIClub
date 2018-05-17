using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using APIClub.Configuration;
using APIClub.Web;

namespace APIClub.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class APIClubDbContextFactory : IDesignTimeDbContextFactory<APIClubDbContext>
    {
        public APIClubDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<APIClubDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            APIClubDbContextConfigurer.Configure(builder, configuration.GetConnectionString(APIClubConsts.ConnectionStringName));

            return new APIClubDbContext(builder.Options);
        }
    }
}
