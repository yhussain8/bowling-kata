using Xunit;
using BowlingApp;

public class BowlingTests
{
    [Fact]
    public void Roll_Once()
    {
        Game game = new Game();
        
        game.Roll(7);

        Assert.Equal(7, game.Score());
    }

    [Fact]
    public void Roll_Twice()
    {
        Game game = new Game();
        
        game.Roll(3);
        game.Roll(2);

        Assert.Equal(5, game.Score());
    }

    [Fact]
    public void Roll_Full_Game_With_Ones()
    {
        Game game = new Game();
        
        for (int i = 0; i < 20; i++)
        {
            game.Roll(1);
        }

        Assert.Equal(20, game.Score());
    }

    [Fact]
    public void Roll_Two_Frames_With_Spare()
    {
        Game game = new Game();
        
        game.Roll(7);
        game.Roll(3);
        game.Roll(1);
        game.Roll(1);

        Assert.Equal(13, game.Score());
    }

    [Fact]
    public void Roll_Full_Game_With_Spares_Each_Round_Without_Bonus_Round()
    {
        Game game = new Game();
        
        for (int i = 0; i < 20; i++)
        {
            game.Roll(5);
        }

        Assert.Equal(145, game.Score());
    }

    [Fact]
    public void Roll_Full_Game_With_Spares_Each_Round_With_Bonus_Round()
    {
        Game game = new Game();
        
        for (int i = 0; i < 21; i++)
        {
            game.Roll(5);
        }

        Assert.Equal(150, game.Score());
    }

    [Fact]
    public void Roll_Full_Game_With_Spares_Each_Round_With_Maximum_Points()
    {
        Game game = new Game();
        
        for (int i = 0; i < 10; i++)
        {
            game.Roll(9);
            game.Roll(1);
        }
        game.Roll(9);

        Assert.Equal(190, game.Score());
    }

    [Fact]
    public void Roll_Full_Game_With_Spares_Each_Round_With_Minimum_Points()
    {
        Game game = new Game();
        
        for (int i = 0; i < 10; i++)
        {
            game.Roll(1);
            game.Roll(9);
        }
        game.Roll(1);

        Assert.Equal(110, game.Score());
    }

    [Fact]
    public void Roll_Two_Frames_With_Strike()
    {
        Game game = new Game();
        
        game.Roll(10);
        game.Roll(3);
        game.Roll(3);

        Assert.Equal(22, game.Score());
    }

    [Fact]
    public void Roll_Strike_Spare_Strike_Spare_Seven()
    {
        Game game = new Game();
        
        game.Roll(10);
        game.Roll(7);
        game.Roll(3);
        game.Roll(10);
        game.Roll(3);
        game.Roll(7);
        game.Roll(7);

        Assert.Equal(84, game.Score());
    }

    [Fact]
    public void Roll_Full_Game_With_Strikes_Without_Bonus_Rounds()
    {
        Game game = new Game();
        
        for (int i = 0; i < 10; i++)
        {
            game.Roll(10);
        }

        Assert.Equal(270, game.Score());
    }

    [Fact]
    public void Roll_Perfect_Game()
    {
        Game game = new Game();
        
        for (int i = 0; i < 12; i++)
        {
            game.Roll(10);
        }

        Assert.Equal(300, game.Score());
    }

    [Fact]
    public void Roll_Full_Game_With_Variability()
    {
        Game game = new Game();
        
        game.Roll(10);
        game.Roll(10);
        game.Roll(7);
        game.Roll(3);
        game.Roll(0);
        game.Roll(6);
        game.Roll(5);
        game.Roll(5);
        game.Roll(10);
        game.Roll(0);
        game.Roll(0);
        game.Roll(8);
        game.Roll(1);
        game.Roll(10);
        game.Roll(3);
        game.Roll(7);
        game.Roll(4);

        Assert.Equal(136, game.Score());
    }
}