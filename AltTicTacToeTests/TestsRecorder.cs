
namespace AltTicTacToeTests;
public class MyTests
{
  private AltDriver altDriver;
  [OneTimeSetUp]
  public void OneTimeSetUp()
  {
    altDriver = new AltDriver();
  }

  [OneTimeTearDown]
  public void TearDown()
  {
    altDriver.Stop();
  }

  [Test]
  public void Test()
  {
    var PlayButton = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/PlayButton", enabled: false);
    altDriver.Click(PlayButton.GetScreenPosition());
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
    var BackButton = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/BottomButtons/BackButton", enabled: false);
    altDriver.Click(BackButton.GetScreenPosition());
  }
}
