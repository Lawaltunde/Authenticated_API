namespace ModelUnitTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Constructor_Sets_User_And_Products()
    {
        // Arrange
        string expectedUser = "Test User";
        List<ProductModel> expectedProducts = new List<ProductModel> { new ProductModel(99.99m, "Test Product", "Test Description") };

        // Act
        var model = new ShoppingCartModel(99.99m, "Test Product", "Test Description", expectedUser, expectedProducts);

        // Assert
        Assert.AreEqual(expectedUser, model.User);
        Assert.AreEqual(expectedProducts, model.Products);
    }

    [TestMethod]
    public void User_Property_Sets_And_Gets_Value()
    {
        // Arrange
        var model = new ShoppingCartModel(0, "", "", "", new List<ProductModel>());
        string expectedUser = "New User";

        // Act
        model.User = expectedUser;

        // Assert
        Assert.AreEqual(expectedUser, model.User);
    }

    [TestMethod]
    public void Products_Property_Sets_And_Gets_Value()
    {
        // Arrange
        var model = new ShoppingCartModel(0, "", "", "", new List<ProductModel>());
        List<ProductModel> expectedProducts = new List<ProductModel> { new ProductModel(199.99m, "New Product", "New Description") };

        // Act
        model.Products = expectedProducts;

        // Assert
        Assert.AreEqual(expectedProducts, model.Products);
    }

    [TestMethod]
    public void Products_Default_Is_Empty_List()
    {
        // Arrange & Act
        var model = new ShoppingCartModel(0, "", "", "", null);

        // Assert
        Assert.AreEqual(new List<ProductModel>(), model.Products);
    }
}