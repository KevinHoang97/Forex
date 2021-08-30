using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Trade
{
    public string id { get; set; }
    public string instrument { get; set; }
    public string price { get; set; }
    public string openTime { get; set; }
    public string initialUnits { get; set; }
    public string initialMarginRequired { get; set; }
    public string state { get; set; }
    public string currentUnits { get; set; }
    public string realizedPL { get; set; }
    public string financing { get; set; }
    public string dividendAdjustment { get; set; }
    public string unrealizedPL { get; set; }
    public string marginUsed { get; set; }
}

public class ClientExtensions
{
    public string id { get; set; }
}

public class OpenTrade
{
    public string currentUnits { get; set; }
    public string financing { get; set; }
    public string id { get; set; }
    public string initialUnits { get; set; }
    public string instrument { get; set; }
    public string openTime { get; set; }
    public string price { get; set; }
    public string realizedPL { get; set; }
    public string state { get; set; }
    public string unrealizedPL { get; set; }
    public ClientExtensions clientExtensions { get; set; }
}

public class RootOpenTrade
{
    public string lastTransactionID { get; set; }
    public List<OpenTrade> openTrades { get; set; }
}


public class RootAccount
{
    public List<Trade> trades { get; set; }
    public string lastTransactionID { get; set; }
}