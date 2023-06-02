public class HelperMethods: BaseTest
{
    public HelperMethods(AltDriver driver)
    {
    }
    public void LoadScene()
    {
        altDriver.LoadScene("StartScene");
    }

    public AltObject PlayButton { get => altDriver.WaitForObject(By.PATH, "/Canvas/MainContainer/PlayButton"); }
    public AltObject WinInfo { get => altDriver.WaitForObject(By.PATH, "/Canvas/MainContainer/GameOverPanel/WinInfo"); }
    public AltObject GetSlotByNumber(string number)
    {
        AltObject altObject = altDriver.WaitForObject(By.PATH, $"/Canvas/MainContainer/Board/Slots/Slot{number}/Text (TMP)", enabled: false);
        return altObject;
    }

    public void FlowSlotsPlayed(string[] slots)
    {
        foreach (string slot in slots)
        {
            AltObject Slot = GetSlotByNumber(slot);
            Assert.NotNull(Slot);
            altDriver.Click(Slot.GetScreenPosition());
        }
    }
    public void AssertWinInfo(string msgResult)
    {
        Assert.NotNull(WinInfo);
        Assert.That(WinInfo.GetText(), Is.EqualTo(msgResult));
    }
}