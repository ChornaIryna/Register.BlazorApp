using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Register.Shared.Domain;

namespace Register.BlazorApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<RoleCategory> RoleCategories { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "Sweden" });
            builder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Germany" });
            builder.Entity<Country>().HasData(new Country { CountryId = 3, Name = "Netherlands" });
            builder.Entity<Country>().HasData(new Country { CountryId = 4, Name = "Denmark" });
            builder.Entity<Country>().HasData(new Country { CountryId = 5, Name = "Finland" });
            builder.Entity<Country>().HasData(new Country { CountryId = 6, Name = "Island" });
            builder.Entity<Country>().HasData(new Country { CountryId = 7, Name = "UK" });
            builder.Entity<Country>().HasData(new Country { CountryId = 8, Name = "France" });
            builder.Entity<Country>().HasData(new Country { CountryId = 9, Name = "Norway" });
            builder.Entity<Country>().HasData(new Country { CountryId = 10, Name = "Belgium" });

            builder.Entity<RoleCategory>().HasData(new RoleCategory { RoleCategoryId = 1, RoleCategoryName = "Management" });
            builder.Entity<RoleCategory>().HasData(new RoleCategory { RoleCategoryId = 2, RoleCategoryName = "Administration" });
            builder.Entity<RoleCategory>().HasData(new RoleCategory { RoleCategoryId = 3, RoleCategoryName = "Finance" });
            builder.Entity<RoleCategory>().HasData(new RoleCategory { RoleCategoryId = 4, RoleCategoryName = "IT" });
            builder.Entity<RoleCategory>().HasData(new RoleCategory { RoleCategoryId = 5, RoleCategoryName = "Consulting" });

            builder.Entity<Person>().HasData(new Person
            {
                PersonId = 1,
                CountryId = 1,
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(DateTime.Now.AddYears(-30).Ticks),
                City = "Stockholm",
                Email = "generated.person@registered.test",
                FirstName = "Anna",
                LastName = "Anderson",
                Gender = Gender.Female,
                PhoneNumber = "070000000",
                Smoker = false,
                Street = "Sveavägen 1",
                Zip = "11157",
                RoleCategoryId = 1,
                Comment = "Generated registration on model creating",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1),
                Latitude = 59.33322,
                Longitude = 18.06488
            });

            var random = new Random();
            for (int i = 1; i < 100; i++)
            {
                builder.Entity<ActivityLog>().HasData(new ActivityLog()
                {
                    ActivityLogId = i,
                    PersonId = 1,
                    StartTime = new DateTime(2024, 1, 1)
                                            .AddDays(random.Next(365))
                                            .AddHours(random.Next(0, 24))
                                            .AddMinutes(random.Next(0, 60))
                                            .AddSeconds(random.Next(0, 60)),
                    EndTime = new DateTime(2024, 1, 1)
                                            .AddDays(random.Next(365))
                                            .AddHours(random.Next(0, 24))
                                            .AddMinutes(random.Next(0, 60))
                                            .AddSeconds(random.Next(0, 60)),
                    PerformedActivityDescription = $"Activity  {i}"
                });
            }
        }
    }
}
