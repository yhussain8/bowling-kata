using Xunit;
using BowlingApp;

public class BowlingTests
{
    [Fact]
    public void RollOnce()
    {
        Game game = new Game();
        
        game.Roll(7);

        Assert.Equal(7, game.Score());
    }
}