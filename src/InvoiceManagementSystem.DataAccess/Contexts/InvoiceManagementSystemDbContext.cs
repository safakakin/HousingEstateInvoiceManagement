using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Contexts
{
    public class InvoiceManagementSystemDbContext : DbContext
    {
        public InvoiceManagementSystemDbContext()
        {
            #region PostgreSql EnableLegacyTimestampBehavior
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            #endregion
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(getConnectionString("PostgreSql"));
        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<User> User { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Role[] roleEntitySeeds = {
                new() {Id=1,RoleName="Admin"},
                new() {Id=2,RoleName="Customer"},
            };

            modelBuilder.Entity<Role>().HasData(roleEntitySeeds);

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("12345", out passwordHash, out passwordSalt);
            User[] userEntitySeeds = {
                new() {Id=1,RoleId=1,
                    FirstName="Ahmet",LastName="Safak",
                    Email="asdfasd1@hotmail.com",
                    PasswordHash=passwordHash,
                    PasswordSalt=passwordSalt,
                    TC="11111111111",
                    Plate="61 AC 61",
                    PhoneNumber="5320000000"},
                new() {Id=2,RoleId=2,
                    FirstName="Koc",LastName="Soy",
                    Email="asdfasd2@hotmail.com",
                    PasswordHash=passwordHash,
                    PasswordSalt=passwordSalt,
                    TC="11111111112",
                    Plate="61 AC 62",
                    PhoneNumber="5320000001"},
                new() {Id=3,RoleId=2,
                    FirstName="Zafer",
                    LastName="Kara",
                    Email="asdfasd3@hotmail.com",
                    PasswordHash=passwordHash,
                    PasswordSalt=passwordSalt,
                    TC="11111111113",
                    Plate="61 AC 63",
                    PhoneNumber="5320000002"},
            };

            modelBuilder.Entity<User>().HasData(userEntitySeeds);

            Apartment[] apartmentEntitySeeds = {
                new() {Id=1,BlockID=1,IsEmpty=true,StyleID=1,Floor=18,CustomerID=1},
                new() {Id=2,BlockID=2,IsEmpty=true,StyleID=2,Floor=19,CustomerID=2},
                new() {Id=3,BlockID=3,IsEmpty=true,StyleID=3,Floor=20,CustomerID=3},
            };

            modelBuilder.Entity<Apartment>().HasData(apartmentEntitySeeds);

            Block[] blockEntitySeeds = {
                new() {Id=1,Name="A Block"},
                new() {Id=2,Name="B Block"},
                new() {Id=3,Name="C Block"},
            };

            modelBuilder.Entity<Block>().HasData(blockEntitySeeds);

            Card[] cardEntitySeeds = {
                new() {Id=1,CustomerID=1,CardNumber=11223344,CardPassword=1234,Balance=3000},
                new() {Id=2,CustomerID=2,CardNumber=11112222,CardPassword=4321,Balance=4000},
                new() {Id=3,CustomerID=3,CardNumber=33334444,CardPassword=1221,Balance=5000},
            };

            modelBuilder.Entity<Card>().HasData(cardEntitySeeds);

            Style[] styleEntitySeeds = {
                new() {Id=1,Name="1+1"},
                new() {Id=2,Name="2+1"},
                new() {Id=3,Name="3+1"},
                new() {Id=4,Name="4+1"},
                new() {Id=5,Name="5+1"},
            };

            modelBuilder.Entity<Style>().HasData(styleEntitySeeds);
        }

        private string getConnectionString(string name)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            IConfigurationRoot configurationManager = builder.Build();

            return configurationManager.GetConnectionString(name);
        }
    }
}
