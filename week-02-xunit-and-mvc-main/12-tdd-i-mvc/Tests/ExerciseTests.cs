using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Add_TwoTasks_AssignsIdsAndStoresTitles()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        Assert.Equal(1, first.Id);
        Assert.Equal(2, second.Id);
        Assert.Equal("Sjekk antenne", first.Title);
        Assert.Equal("Lad rover", second.Title);
        Assert.Equal(2, board.Count);
        Assert.False(first.IsCompleted);
        Assert.False(second.IsCompleted);
    }

    [Fact]
    public void Complete_KnownId_CompletesOnlySelectedTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        bool result = board.Complete(second.Id);
        Assert.True(result);
        Assert.False(first.IsCompleted);
        Assert.True(second.IsCompleted);
        Assert.Equal(2, board.Count);
    }

    [Fact]
    public void Complete_UnknownId_DoesNotChangeTasks()
    {
        var board = new MissionBoard();
        var task = board.Add("Lad rover");
        Assert.False(board.Complete(99));
        Assert.False(task.IsCompleted);
        Assert.Equal(1, board.Count);
    }

    [Fact]
    public void GetAll_ReturnsCollectionCopy()
    {
        var board = new MissionBoard();
        board.Add("Lad rover");
        var copy = board.GetAll();
        copy.Clear();
        Assert.Equal(1, board.Count);
    }

    [Fact]
    public void GetPending_MixedBoard_ReturnsOnlyIncompleteTask()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");
        board.Complete(first.Id);
        var pending = board.GetPending();
        Assert.Single(pending);
        Assert.Same(second, pending[0]);
        Assert.Equal(2, board.Count);
    }
    // TODO: Tom, alle ufullførte, alle fullførte, rekkefølge og samlingskopi.
    [Fact]
    public void GetPending_EmptyBoard_ReturnsEmptyList()
    {
        var board = new MissionBoard();
        var actual = board.GetPending();


        Assert.Empty(actual);
    }

    [Fact]
    public void GetPending_AllIncomplete_ReturnsBothTasks()
    {
        var board = new MissionBoard();

        board.Add("Sjekk Antenne");
        board.Add("Lad rover");

        var actual = board.GetPending();

        Assert.Equal(2 ,actual.Count);
    }
   
    [Fact]
    public void GetPending_AllCompleted_ReturnsEmpty()
    {
        var board = new MissionBoard();
        var first = board.Add("Sjekk antenne");
        var second = board.Add("Lad rover");

        board.Complete(first.Id);
        board.Complete(second.Id);

        var actual = board.GetPending();

        Assert.Empty(actual);
        Assert.Equal(2, board.Count);
    }

    [Fact]
    public void GetPending_PreserveOriginalOrder()
    {
        var board = new MissionBoard();

        var firstTask = board.Add("Sjekk antenne");
        var secondTask = board.Add("Lad rover");
        var thirdTask = board.Add("Kontroller drivstoff");

        board.Complete(secondTask.Id);
        var pending = board.GetPending();

        Assert.Equal(2, pending.Count);
        Assert.Same(firstTask, pending[0]);
        Assert.Same(thirdTask, pending[1]);
        Assert.Equal(3, board.Count);
    }

    [Fact]
    public void GetPending_ClearingResult_DoesNotChangeBoard()
    {
    
        var board = new MissionBoard();
        board.Add("Sjekk antenne");
        board.Add("Lad rover");


        var pending = board.GetPending();
        Assert.Equal(2, pending.Count);

        pending.Clear();

        Assert.Equal(2, board.Count);
        Assert.Equal(2, board.GetPending().Count);
    }

}
