namespace AUTHENTICATED_API.Model;

public class ProductModel(){
    public int Id{get; set;}
    public decimal price{get; set;}
    public string Name{get; set;} = string.Empty;
    public string Description{get; set;} = string.Empty;
}