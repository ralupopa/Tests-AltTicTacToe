
namespace AltTicTacToeTests;
public class MyTests
{
  private AltDriver altDriver;
  [OneTimeSetUp]
  public void OneTimeSetUp()
  {
    altDriver = new AltDriver();
  }
  [SetUp]
  public void BeforeEachTest()
  {
    altDriver.LoadScene("StartScene");
  }

  [OneTimeTearDown]
  public void TearDown()
  {
    altDriver.Stop();
  }

  [Test]
  public void TestPlayerXWins()
  {
    var PlayButton = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/PlayButton", enabled: false);
    Assert.NotNull(PlayButton);
    PlayButton.Click();

    var TextTMP = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot1/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP.GetScreenPosition());
    var TextTMP2 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot5/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP2.GetScreenPosition());
    var TextTMP3 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot9/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP3.GetScreenPosition());
    var TextTMP4 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot7/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP4.GetScreenPosition());
    var TextTMP5 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot3/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP5.GetScreenPosition());
    var TextTMP6 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot6/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP6.GetScreenPosition());
    var TextTMP7 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot2/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP7.GetScreenPosition());
    var WinInfo = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/GameOverPanel/WinInfo", enabled: false);
    altDriver.Click(WinInfo.GetScreenPosition());
    var WinInfo2 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/GameOverPanel/WinInfo", enabled: false);
    altDriver.Click(WinInfo2.GetScreenPosition());

    Assert.NotNull(WinInfo2);
    Assert.That(WinInfo2.GetText(), Is.EqualTo("Player X wins!"));
  }

  [Test]
  public void TestDrawResult()
  {
    var PlayButton = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/PlayButton", enabled: false);
    Assert.NotNull(PlayButton);
    PlayButton.Click();

    var TextTMP = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot8/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP.GetScreenPosition());
    var TextTMP2 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot5/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP2.GetScreenPosition());
    var TextTMP3 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot9/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP3.GetScreenPosition());
    var TextTMP4 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot7/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP4.GetScreenPosition());
    var TextTMP5 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot3/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP5.GetScreenPosition());
    var TextTMP6 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot6/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP6.GetScreenPosition());
    var TextTMP7 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot4/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP7.GetScreenPosition());
    var TextTMP8 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot1/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP8.GetScreenPosition());
    var TextTMP9 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot2/Text (TMP)", enabled: false);
    altDriver.Click(TextTMP9.GetScreenPosition());

    var WinInfo2 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/GameOverPanel/WinInfo", enabled: false);
    Assert.NotNull(WinInfo2);
    Assert.That(WinInfo2.GetText(), Is.EqualTo("It's a draw!"));
  }
}
