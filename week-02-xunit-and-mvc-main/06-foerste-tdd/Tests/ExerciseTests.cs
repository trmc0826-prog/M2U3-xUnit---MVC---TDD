using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_PreservesDataAndStartsIncomplete()
    {
        var task = new MissionTask(7, "Sjekk antenne");
        Assert.Equal(7, task.Id);
        Assert.Equal("Sjekk antenne", task.Title);
        Assert.False(task.IsCompleted);
    }
    // TODO: Skriv fullføringstesten før du implementerer Complete.

    [Fact]
    public void Constructor_CallComplete_Status()
    {
        var task = new MissionTask(7, "Sjekk antenne");

        task.Complete();

        Assert.True(task.IsCompleted);
    }

    [Fact]
    public void Constructor_CallCompleteTwice_Status()
    {
        var task = new MissionTask(7, "Sjekk antenne");

        task.Complete();
        task.Complete();

        Assert.True(task.IsCompleted);
        Assert.Equal(7, task.Id);
        Assert.Equal("Sjekk antenne", task.Title);
    }
}
