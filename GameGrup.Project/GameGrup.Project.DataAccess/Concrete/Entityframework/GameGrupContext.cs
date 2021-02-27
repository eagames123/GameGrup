using GameGrup.Project.DataAccess.Concrete.Entityframework.Mappings;
using GameGrup.Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace GameGrup.Project.DataAccess.Concrete.Entityframework
{
    public class GameGrupContext : System.Data.Entity.DbContext
    {
        public GameGrupContext():base(@"Data Source=LAPTOP-E3TF1HQ4\SQLEXPRESS;Initial Catalog=GameGrup;Integrated Security=True")
        {
            Database.SetInitializer<GameGrupContext>(null);
        }

        public System.Data.Entity.DbSet<Product> Product { get; set; }

        public System.Data.Entity.DbSet<Category> Category { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}
