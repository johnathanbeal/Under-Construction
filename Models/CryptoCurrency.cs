using CryptocurrencyTrader.Models.Enum;
using System.Security.Cryptography;
using System;

public class CryptoCurrency
{
    public string Plural { get; set; }

    public string Symbol  { get; set; }

    public string Ticker  { get; set; }

    public Subunit Subunits  { get; set; }

    public string Creator { get; set; }

    public string Implementation { get; set; }

    public DateTime InitialReleaseDate { get; set; }

    public Version InitialReleaseVersion  { get; set; }

    public DateTime LatestReleaseDate  { get; set; }

    public Version LatestReleaseVersion  { get; set; }

    public DevelopmentStatus Status  { get; set; }

    public Uri Website  { get; set; }

    public DateTime LedgerStart  { get; set; }

    public string TimestampingScheme { get; set; }

    public HashAlgorithm HashFunction { get; set; }

    private Decimal _blockReward;
    public Decimal Block_Reward { get { return Math.Round(_blockReward, 2);} set { _blockReward = Math.Round(value, 2);} }

    public int BlockTimeMinutes { get; set; }

    public Uri BlockExplorer { get; set; }
    public long CirculatingSupply { get; set; }

    public DateTime CirculatingSupplyDate { get; set; }

    public int SupplyLimit { get; set; }



}