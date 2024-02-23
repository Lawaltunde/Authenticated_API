namespace AUTHENTICATED_API.Model;

public class ShoppingCartModel : ProductModel{
    //Id property will be inherited from CategoryModel
    //public int Id{get; set;}
    public string User{get; set;} = string.Empty;
    public ShoppingCartModel<ProductModel>productModel{get; set;};

    public CategoryModel(string User, ShoppingCartModel<ProductModel>productModel):base(User, productModel<ProductModel>){
        //this.Id = ID;
        this.User = description;
        this.productModel = productModel;
    } 
       
}