namespace MyLibraryNew
{
    using System;
    using MyLibraryNew.Models;
    using System.Data.Entity;
    using System.Linq;

    public class MyBraryContext : DbContext
    {
        // Your context has been configured to use a 'MyBraryContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MyLibraryNew.MyBraryContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyBraryContext' 
        // connection string in the application configuration file.
        public MyBraryContext(): base("name=MyBraryContext"){ }
        public virtual DbSet<Book> Books { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}