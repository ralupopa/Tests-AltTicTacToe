
namespace AltTicTacToeTests;
public class FlowTests: BaseTest
{
    HelperMethods helperMethods;
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        altDriver = new AltDriver();
        helperMethods = new HelperMethods(altDriver);
    }
    [SetUp]
    public void BeforeEachTest()
    {
        helperMethods.LoadScene();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }
    [Test]
    public void TestPlayerXWins()
    {
        Assert.NotNull(helperMethods.PlayButton);
        helperMethods.PlayButton.Click();

        string[] slots = {"1", "5", "9", "7", "3", "6", "2"};
        helperMethods.FlowSlotsPlayed(slots);

        helperMethods.AssertWinInfo("Player X wins!");
    }
    [Test]
    public void TestDrawResult()
    {
        Assert.NotNull(helperMethods.PlayButton);
        helperMethods.PlayButton.Click();

        string[] slots = {"8", "5", "9", "7", "3", "6", "4", "1", "2"};
        helperMethods.FlowSlotsPlayed(slots);

        helperMethods.AssertWinInfo("It's a draw!");
    }
    [Test]
    public void TestPlayerOWins()
    {
        Assert.NotNull(helperMethods.PlayButton);
        helperMethods.PlayButton.Click();

        string[] slots = {"9", "7", "5", "1", "6", "4"};
        helperMethods.FlowSlotsPlayed(slots);

        helperMethods.AssertWinInfo("Player O wins!");
    }
}