
namespace AltTicTacToeTests;
public class FlowCasesTests: BaseTest
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

    [TestCase("Player X wins!", new string[] {"1", "5", "9", "7", "3", "6", "2"})]
    [TestCase("It's a draw!", new string[] {"8", "5", "9", "7", "3", "6", "4", "1", "2"})]
    [TestCase("Player O wins!", new string[] {"9", "7", "5", "1", "6", "4"})]
    public void TestFlowCases(string result, string[] slots)
    {
        Assert.NotNull(helperMethods.PlayButton);
        helperMethods.PlayButton.Click();

        helperMethods.FlowSlotsPlayed(slots);

        helperMethods.AssertWinInfo(result);
    }
}