
public class SaveoneInfoData
{
    public string Name { get; set; } = "";
    public decimal WalletBalance { get; set; }
    public List<SaveoneMarketData> MarketData { get; set; } = new();
}
public class SaveoneMarketData
{
    public string MarketName { get; set; } = "";
    public  int Rank { get; set; }
    public decimal Score { get; set; }
    public string Star { get; set; }
    public string ReservationTimeStart { get; set; }
    public string ReservationTimeEnd { get; set; }

}

