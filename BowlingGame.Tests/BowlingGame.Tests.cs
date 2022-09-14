namespace BowlingGame.Tests;
using FluentAssertions;


public class Tests
{
    private BowlingGame bowlingGame;

    [SetUp]
    public void Setup()
    {
        bowlingGame = new BowlingGame();
    }

    [Test]
    public void Strike_X_should_return_10()
    {
        bowlingGame.Strike("X").Should().Be(10);
    }

    [Test]
    public void Points_Number_should_return_Points()
    {
        bowlingGame.Strike("9").Should().Be(9);
    }
}