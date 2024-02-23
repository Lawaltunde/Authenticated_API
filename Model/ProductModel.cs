namespace AUTHENTICATED_API.Model;
public class ProductModel: CategoryModel{
    //Id property will be inherited from CategoryModel
    //public int Id{get; set;}
    public decimal price{get; set;}
    public string Name{get; set;} = string.Empty;
    public string Description{get; set;} = string.Empty;

    public ProductModel(decimal price, string Name, string Description): base(price, Name, Description){
        //this.Id = Id;
        this.price = price;
        this.Name = Name;
        this.Description = Description;
    }

}