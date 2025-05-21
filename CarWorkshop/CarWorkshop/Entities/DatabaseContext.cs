using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Entities
{
    public class DatabaseContext : DbContext
    {
        // Creation of tables.
        public DbSet<CarWorkshopEntity> CarWorkshops { get; set; }

        // Connection to the database.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarWorkshop;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }

    // ---
    // Migration Tasks
    // ---
    // > Creates a script thats tnds with _Init. Manages the creation and delation of the database.
    //  add-migration  Init
    // > Based on the connection string will execute all of the defined migrations.
    //  update-database

    // Created class -> DatabaseContextModelSnapshot -> helpful for
    //  comparison between old and updated migration.

}
