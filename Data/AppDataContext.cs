using AUTHENTICATED_API.Model;
namespace AUTHENTICATED_API.Data;

public AppDataContext : DbContext{
    
    public AppDataContext(DbContextOptions<AppDataContext> options): base(options){

    }

    public DbSet<CategoryModel> categoryModel{get; set;}
    public DbSet<ProductModel> productModel{get; set;}

    public DbSet<ShoppingCartModel> shoppingCartModel{get; set;}

}