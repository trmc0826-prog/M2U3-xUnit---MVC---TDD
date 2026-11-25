using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Pop_EmptyStack_ThrowsInvalidOperationException()
    {
        var stack = new CargoStack<string>();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
        Assert.Equal(0, stack.Count);
    }
    // TODO: Test LIFO, telling, gjenbruk og en annen type.
    [Fact]
    public void CargoStack_Lifo()
    {
        var stack = new CargoStack<string>();

        stack.Push("A");
        Assert.Equal(1, stack.Count);

        stack.Push("B");
        string actual = stack.Pop();
        Assert.Equal(1, stack.Count);
        Assert.Equal("B", actual);

        
        string actual2 = stack.Pop();
        Assert.Equal("A", actual2);
        Assert.Equal(0, stack.Count);
    }

    [Fact]
    public void Lifo_Int_CargoStacks()
    {
        var stack = new CargoStack<int>();

        stack.Push(7);
        int actual = stack.Pop();
        Assert.Equal(0, stack.Count);
        Assert.Equal(7, actual);
    }
    [Fact]
    public void Lifo_ReusableStack_CargoStacks()
    {
        var stack = new CargoStack<string>();

        stack.Push("A");
        stack.Pop();
        Assert.Equal(0, stack.Count);

        stack.Push("C");
        string actual = stack.Pop();
        Assert.Equal("C", actual);
        Assert.Equal(0, stack.Count);

        


    }
}

