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
    public void NewMissionBoard_StartsEmpty()
    {
    
        var board = new MissionBoard();

        Assert.Equal(0, board.Count);
        Assert.Empty(board.GetAll());
    }

    [Fact]
    public void Complete_SameTaskTwice_RemainsCompleted()
    {

        var board = new MissionBoard();
        var task = board.Add("Sjekk antenne");

        bool first = board.Complete(task.Id);
        bool second = board.Complete(task.Id);

        Assert.True(first);
        Assert.True(second);
        Assert.True(task.IsCompleted);
        Assert.Equal(1, board.Count);
    }

    [Fact]
    public void TwoMissionBoards_HaveIndependentState()
    {   

        var board1 = new MissionBoard();
        var board2 = new MissionBoard();

        board1.Add("Sjekk antenne");

        Assert.Equal(1, board1.Count);
        Assert.Equal(0, board2.Count);

        // Add first mission to second board
        var task2 = board2.Add("Lad rover");

        Assert.Equal(1, task2.Id);
    }


    [Fact]
    public void GetAll_ContainsSameTaskObjects()
    {
        var board = new MissionBoard();
        var task = board.Add("Sjekk antenne");

        var tasks = board.GetAll();

        Assert.Same(task, tasks[0]);
    }

}
