namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Server = your SQL Server; Database = Your DB
            optionsBuilder.UseSqlServer("Server=FRANCISCO\\SQL2019; Database=Superhero-db; Trusted_Connection=true; TrustServerCertificate=true;");
        }

        //SuperHero is the name of the table
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
