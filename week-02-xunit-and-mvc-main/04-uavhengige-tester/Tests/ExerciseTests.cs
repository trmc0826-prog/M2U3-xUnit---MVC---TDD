using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_StartsEmpty()
    {
        var bay = new CargoBay();
        Assert.Equal(0, bay.Count);
    }
    
    [Fact]
    public void TryAdd_FirstItem_ReturnsTrue()
    {
        // Arrange
        var bay = new CargoBay();

        // Act
        bool actual = bay.TryAdd("mat");

        // Assert
        Assert.True(actual);
        Assert.Equal(1, bay.Count);
    }

    [Fact]
    public void TryAdd_SecondItem_ReturnsTrue()
    {
        // Arrange
        var bay = new CargoBay();

        // Act
        bay.TryAdd("mat");
        bool actual = bay.TryAdd("vann");

        // Assert
        Assert.True(actual);
        Assert.Equal(2, bay.Count);
    }

   [Fact]
    public void TryAdd_ThirdItem_ReturnsFalse()
    {
        // Arrange
        var bay = new CargoBay();

        // Act
        bay.TryAdd("mat");
        bay.TryAdd("vann");
        bool actual = bay.TryAdd("verktøy");
        // Assert
        Assert.False(actual);
        Assert.Equal(2, bay.Count);
    }

    [Fact]
    public void TwoCargoBays_HaveIndependentCounts()
    {
        // Arrange
        var bay = new CargoBay();
        var bay2 = new CargoBay();

        // Act
        bay.TryAdd("mat");

        // Assert
        Assert.Equal(1, bay.Count);
        Assert.Equal(0, bay2.Count);
    }
        // TODO: Flere tester. Opprett et nytt CargoBay i hver test.
}
