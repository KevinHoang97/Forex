using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Forex.Model;
using Forex.Shared;
using System.IO;
using System.Net;

namespace Forex.Pages
{
    public partial class Portfolio : ComponentBase
    {
        private RootOpenTrade accountMain;
        private string ErrorMessage;
        private string accountId = "101-004-16583730-001";
        
        

        private async Task GetOpenTradesDataAsync()
        {
            try
            {

                {
                    //https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/openTrades
                   // string uri = "https://api-fxpractice.oanda.com/v3/instruments/EUR_USD/candles?count=6&price=M&granularity=S5";

                   string uri = "https://api-fxpractice.oanda.com/v3/accounts/" + accountId + "/openTrades";
                       Console.WriteLine(uri);
                    accountMain = await Http.GetJsonAsync<RootOpenTrade>(uri);
                     Console.WriteLine(accountMain);
                    ErrorMessage = String.Empty;
                     Console.WriteLine(ErrorMessage);
                    Console.WriteLine(accountMain);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ErrorMessage = e.Message;
                Console.WriteLine(ErrorMessage);
            }
        }



        protected override async Task OnInitializedAsync()
        {
            await GetOpenTradesDataAsync();


        }
    }
}
