namespace AUTHENTICATED_API.Model;

public class CategoryModel{
    public int Id{get; set;}
    public string description{get; set;} = string.Empty;

    public CategoryModel(int ID, string description){
        this.Id = ID;
        this.description = description;
    }
}