using FoodRecipe.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodRecipe.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reciepe> Reciepes { get; set;}
        public DbSet<AlergicMaterial> AlergicMaterials { get; set; }
        public DbSet<Material> Materials { get; set; }

    }
}
