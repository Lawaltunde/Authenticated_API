namespace AUTHENTICATED_API.Model;

public class ShoppingCartModel : ProductModel{
    public int Id{get; set;}
    public string User{get; set;} = string.Empty;
    public ProductModel productModel<ProductModel>{get; set;};

    public CategoryModel(int ID, string description, ProductModel productModel<ProductModel>){
        this.Id = ID;
        this.User = description;
        this.productModel = productModel;
    }
}