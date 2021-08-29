/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Forex.Model;

namespace Forex.Pages
{
    public partial class Portfolio : ComponentBase
    {
        public string account = "101-004-16583730-001";
        *//*private async Task GetHistoricDataAsync()
        {
            try
            {

                {
                    //https://api-fxpractice.oanda.com/v3/instruments/EUR_USD/candles?count=6&price=M&granularity=S5

                    string uri = "https://api-fxpractice.oanda.com/v3/instruments/" + instrument + "/candles?count=" + count + "&price=M&granularity=" + granularity;
                    //   Console.WriteLine(uri);
                    Mains = await Http.GetJsonAsync<Root>(uri);
                    // Console.WriteLine(Mains);
                    ErrorMessage = String.Empty;
                    // Console.WriteLine(ErrorMessage);
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
            await GetHistoricDataAsync();


        }*//*
    }
}
*/