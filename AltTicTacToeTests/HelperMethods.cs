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
}