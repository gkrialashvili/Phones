namespace Phones.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EFDBContext : DbContext
    {
        // Your context has been configured to use a 'EFDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Phones.EFDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EFDBContext' 
        // connection string in the application configuration file.
        public EFDBContext(): base("name=EFDBContext")
        {
            Database.SetInitializer<EFDBContext>(new CreateDatabaseIfNotExists<EFDBContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<PhoneData> PhoneDatas { get; set; }
        public DbSet<Brand> Brands { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}