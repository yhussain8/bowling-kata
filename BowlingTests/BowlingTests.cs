using Xunit;
using BowlingApp;
using System.Configuration.Assemblies;

public class BowlingTests
{
    [Fact]
    public void RollOnce()
    {
        Game game = new Game();
        
        game.Roll(7);

        Assert.Equal(7, game.Score());
    }

    [Fact]
    public void RollTwice()
    {
        Game game = new Game();
        
        game.Roll(3);
        game.Roll(2);

        Assert.Equal(5, game.Score());
    }

    [Fact]
    public void RollFullGameWithOnes()
    {
        Game game = new Game();
        
        for (int i = 0; i < 20; i++)
        {
            game.Roll(1);
        }

        Assert.Equal(20, game.Score());
    }

        [Fact]
    public void RollTwoFramesWithSpare()
    {
        Game game = new Game();
        
        game.Roll(7);
        game.Roll(3);
        game.Roll(1);
        game.Roll(1);

        Assert.Equal(13, game.Score());
    }
}