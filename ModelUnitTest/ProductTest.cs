namespace ModelUnitTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Constructor_Sets_Price_Name_And_Description()
    {
        // Arrange
        decimal expectedPrice = 99.99m;
        string expectedName = "Test Product";
        string expectedDescription = "Test Description";

        // Act
        var model = new ProductModel(expectedPrice, expectedName, expectedDescription);

        // Assert
        Assert.AreEqual(expectedPrice, model.price);
        Assert.AreEqual(expectedName, model.Name);
        Assert.AreEqual(expectedDescription, model.Description);
    }

    [TestMethod]
    public void Price_Property_Sets_And_Gets_Value()
    {
        // Arrange
        var model = new ProductModel(0, "", "");
        decimal expectedPrice = 199.99m;

        // Act
        model.price = expectedPrice;

        // Assert
        Assert.AreEqual(expectedPrice, model.price);
    }

    [TestMethod]
    public void Name_Property_Sets_And_Gets_Value()
    {
        // Arrange
        var model = new ProductModel(0, "", "");
        string expectedName = "New Product";

        // Act
        model.Name = expectedName;

        // Assert
        Assert.AreEqual(expectedName, model.Name);
    }

    [TestMethod]
    public void Description_Property_Sets_And_Gets_Value()
    {
        // Arrange
        var model = new ProductModel(0, "", "");
        string expectedDescription = "New Description";

        // Act
        model.Description = expectedDescription;

        // Assert
        Assert.AreEqual(expectedDescription, model.Description);
    }
}