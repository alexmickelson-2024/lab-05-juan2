namespace TestProject;

using FluentAssertions;
using MainProgram;

public class Program
{
    [Fact]
    public void VerticalWin1()
    {
        char[] board = new char[9] { 'O', 'b', 'c', 'O', 'e', 'f', 'O', 'h', 'i' };
        MainProgram.Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void VerticalWin2()
    {
        char[] board = new char[9] { 'a', 'O', 'c', 'd', 'O', 'f', 'g', 'O', 'i' };
        MainProgram.Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void VerticalWin3()
    {
        char[] board = new char[9] { 'a', 'b', 'O', 'd', 'e', 'O', 'g', 'h', 'O' };
        MainProgram.Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void HorizontalWin1()
    {
        char[] board = new char[9] { 'O', 'O', 'O', 'd', 'e', 'f', 'g', 'h', 'i' };
        MainProgram.Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void HorizontalWin2()
    {
        char[] board = new char[9] { 'a', 'b', 'c', 'O', 'O', 'O', 'g', 'h', 'i' };
        MainProgram.Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void HorizontalWin3()
    {
        char[] board = new char[9] { 'a', 'b', 'c', 'd', 'e', 'f', 'O', 'O', 'O' };
        MainProgram.Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void DiagonalWin1()
    {
        char[] board = new char[9] { 'O', 'b', 'c', 'd', 'O', 'f', 'g', 'h', 'O' };
        MainProgram.Program.HasWinner(board).Should().Be(true);
    }
    [Fact]
    public void DiagonalWin2()
    {
        char[] board = new char[9] { 'a', 'b', 'O', 'd', 'O', 'f', 'O', 'h', 'i' };
        MainProgram.Program.HasWinner(board).Should().Be(true);
    }
}