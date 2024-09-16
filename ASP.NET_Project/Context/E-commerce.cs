using System;
using System.Data.Entity;
using System.Linq;

namespace ASP.NET_Project.Context
{
    public class E_commerce : DbContext
    {
        // Your context has been configured to use a 'E_commerce' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ASP.NET_Project.Context.E_commerce' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'E_commerce' 
        // connection string in the application configuration file.
        public E_commerce()
            : base("name=E-commerce")
        {
        }

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