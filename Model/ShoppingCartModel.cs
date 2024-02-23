namespace AUTHENTICATED_API.Model;

public class ShoppingCartModel : ProductModel{
    //Id property will be inherited from CategoryModel
    //public int Id{get; set;}
    public string User{get; set;} = string.Empty;
    public ProductModel productModel<ProductModel>{get; set;};

    public CategoryModel(string User, ProductModel productModel<ProductModel>):base(User, productModel<ProductModel>){
        //this.Id = ID;
        this.User = description;
        this.productModel = productModel;
    } 
       
}