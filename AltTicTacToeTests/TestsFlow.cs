
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
}