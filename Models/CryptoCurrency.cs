using CryptocurrencyTrader.Models.Enum;
using System.Security.Cryptography;
using System;

public class CryptoCurrency
{
    public int Id {get; set;} = 1;
    public string Name {get; set; } = "Bitcoin";
    ///public string Plural { get; set; } = "BealCoinz";

    public string Symbol  { get; set; } = "₿";

    public string Ticker  { get; set; } = "BTC";

    public Subunit Subunits  { get; set; } = Subunit.millibitcoin;

    ///public string Creator { get; set; } = "Satoshi Nakamoto";

    ///public string Implementation { get; set; } = "Bitcoin Core";

    ///public DateTime InitialReleaseDate { get; set; } = new DateTime(2009, 01, 09);

    ///public Version InitialReleaseVersion  { get; set; } = new Version(0,1,0);

    ///public DateTime LatestReleaseDate  { get; set; } = new DateTime(2020, 08, 02);

    ///public Version LatestReleaseVersion  { get; set; } = new Version(0,20,1);

    ///public DevelopmentStatus Status  { get; set; } = DevelopmentStatus.Active;

    ///public Uri Website  { get; set; } = new Uri("bitcoin.org");

    ///public DateTime LedgerStart  { get; set; } = new DateTime(2009,1,03);

    public string TimestampingScheme { get; set; } = "PKI";

    public String HashFunction { get; set; } = "SHA256";

    private Decimal _blockReward {get; set; } = 6.25m;
    public Decimal Block_Reward { get { return Math.Round(_blockReward, 2);} set { _blockReward = Math.Round(value, 2);} }

    public int BlockTimeSeconds { get; set; } = 600;

    ///public Uri BlockExplorer { get; set; } = new Uri("https://www.beal-planet.com/en/history/");
    ///public long CirculatingSupply { get; set; } = 1;

    ///public DateTime CirculatingSupplyDate { get; set; } = new DateTime(2020, 02, 29);

    ///public int SupplyLimit { get; set; } = 21000000;

}