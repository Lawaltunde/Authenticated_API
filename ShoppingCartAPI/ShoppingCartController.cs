using AUTHENTICATED_API.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Authorize]
namespace MyApp.Namespace
{
    [Route("[controller]/Action")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        //Instance of shoppingcarclass
        ShoppingCartModel shoppingCartModel = new ShoppingCartModel();
        public ShoppingCartModel GetEndpoint(){
            return (shoppingCartModel.productModel.get());
        }

        public ShoppingCartModel PostEndpoint(int Id){
            if(shoppingCartModel.Id.get() == Id){
                return shoppingCartModel.Empty();
            }

            return shoppingCartModel;
        }
    }
}
