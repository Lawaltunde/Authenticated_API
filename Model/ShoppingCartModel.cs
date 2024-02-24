namespace AUTHENTICATED_API.Model;

public class ShoppingCartModel : ProductModel{
    public string User{get; set;} = string.Empty;
    public List<ProductModel> Products {get; set;} = new List<ProductModel>();

    public ShoppingCartModel(decimal price, string Name, string Description, string User, List<ProductModel> products)
        :base(price, Name, Description){
        this.User = User;
        this.Products = products;
    } 
}