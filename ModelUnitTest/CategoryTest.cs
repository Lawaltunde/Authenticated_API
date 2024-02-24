using AUTHENTICATED_API.Model;
namespace ModelUnitTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Constructor_Sets_Id_And_Description()
    {
        // Arrange
        int expectedId = 1;
        string expectedDescription = "Test Description";

        // Act
        var model = new CategoryModel(expectedId, expectedDescription);

        // Assert
        Assert.AreEqual(expectedId, model.Id);
        Assert.AreEqual(expectedDescription, model.description);
    }

    [TestMethod]
    public void Id_Property_Sets_And_Gets_Value()
    {
        // Arrange
        var model = new CategoryModel(0, "");
        int expectedId = 2;

        // Act
        model.Id = expectedId;

        // Assert
        Assert.AreEqual(expectedId, model.Id);
    }

    [TestMethod]
    public void Description_Property_Sets_And_Gets_Value()
    {
        // Arrange
        var model = new CategoryModel(0, "");
        string expectedDescription = "New Description";

        // Act
        model.description = expectedDescription;

        // Assert
        Assert.AreEqual(expectedDescription, model.description);
    }

    [TestMethod]
    public void Description_Default_Is_Empty_String()
    {
        // Arrange & Act
        var model = new CategoryModel(0, null);

        // Assert
        Assert.AreEqual(string.Empty, model.description);
    }

}