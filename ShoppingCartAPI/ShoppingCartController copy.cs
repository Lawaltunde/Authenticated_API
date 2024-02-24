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

        //Get endpoint that returns all products in the user's shopping cart.
        public ShoppingCartModel GetEndpoint(){
            return (shoppingCartModel.productModel.get());
        }

        //Add a Post endpoint that takes a single ID and removes the item from the shopping cart.
        public ShoppingCartModel PostEndpoint(int Id){
            if(shoppingCartModel.Id.get() == Id){
                return shoppingCartModel.Empty();
            }

            return shoppingCartModel;
        }

        public IActionResult AddToCart(int itemId)
        {
            // Assume you have authentication implemented to get the current user's email
            string currentUserEmail = "user@example.com"; // Replace with actual logic

            // Check if the cart exists for the current user
            var cart = AppDataContext.shoppingCartModel.FirstOrDefault(c => c.UserEmail == currentUserEmail);
            if (cart == null)
            {
                // Create a new cart if not found
                cart = new shoppingCartModel
                {
                    UserEmail = currentUserEmail,
                    CreatedAt = DateTime.UtcNow
                };
                AppDataContext.ShoppingCarts.Add(cart);
            }

            // Add the item to the cart (you'll need to adjust this based on your data model)
            var item = new Id
            {
                ItemId = itemId,
                Quantity = 1 // You can adjust the quantity as needed
            };
            cart.Items.Add(item);

            AppDataContext.SaveChanges(); // Save changes to the database

            return Ok(new { Message = "Item added to cart successfully!" });
        }
    }
}
