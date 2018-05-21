namespace APIClub.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly APIClubDbContext _context;

        public InitialHostDbBuilder(APIClubDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new DefaultStocksCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
