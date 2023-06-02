
namespace AltTicTacToeTests;
public class ImprovedTests: BaseTest
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

        AltObject Slot1 = helperMethods.GetSlotByNumber("1");
        Assert.NotNull(Slot1);
        altDriver.Click(Slot1.GetScreenPosition());

        AltObject Slot5 = helperMethods.GetSlotByNumber("5");
        Assert.NotNull(Slot5);
        altDriver.Click(Slot5.GetScreenPosition());

        AltObject Slot9 = helperMethods.GetSlotByNumber("9");
        Assert.NotNull(Slot9);
        altDriver.Click(Slot9.GetScreenPosition());

        AltObject Slot7 = helperMethods.GetSlotByNumber("7");
        Assert.NotNull(Slot7);
        altDriver.Click(Slot7.GetScreenPosition());

        AltObject Slot3 = helperMethods.GetSlotByNumber("3");
        Assert.NotNull(Slot3);
        altDriver.Click(Slot3.GetScreenPosition());

        AltObject Slot6 = helperMethods.GetSlotByNumber("6");
        Assert.NotNull(Slot6);
        altDriver.Click(Slot6.GetScreenPosition());

        AltObject Slot2 = helperMethods.GetSlotByNumber("2");
        Assert.NotNull(Slot2);
        altDriver.Click(Slot2.GetScreenPosition());

        AltObject WinInfo = helperMethods.WinInfo;
        Assert.NotNull(WinInfo);
        Assert.That(WinInfo.GetText(), Is.EqualTo("Player X wins!"));
    }
}