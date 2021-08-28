using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forex.Shared;
using Microsoft.AspNetCore.Components;
using System.IO;
using System.Net;
using Forex.Model;
//using Forex.Service;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Text;
//using Nancy.Json;
namespace Forex.Pages
{

    public partial class Trade : ComponentBase
    {


        /*public object PostFromBuy()
        {

            TradeInfo tradeInfo = new TradeInfo()
            {
               *//* units = 100,
                instrument = "EUR_USD",
                timeInForce = "FOK",
                type = "MARKET",
                positionFill = "DEFAULT"*//*
            };

            string uri = "https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders";

            string stringjson = JsonConvert.SerializeObject(tradeInfo);
            Console.WriteLine(stringjson);

            var response = Http.PostAsJsonAsync(uri, stringjson);
            // var response = Http.PostAsJsonAsync("https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders", stringjson);
            Console.WriteLine(response);
            return null;
        }*/

       



        

        public async Task Post()
        {
            {

                /* TradeInfo tradeInfo = new TradeInfo()
                 {

                     units = 100,
                     instrument = "EUR_USD",
                     timeInForce = "FOK",
                     type = "MARKET",
                     positionFill = "DEFAULT"
                 };*/

                TradeInfo trade = new TradeInfo()
                {
                    order = new Order()
                    {

                        units = 100,
                        instrument = "EUR_USD",
                        timeInForce = "FOK",
                        type = "MARKET",
                        positionFill = "DEFAULT"
                    }
                };



                string uri = "https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders";

                string stringjson = JsonConvert.SerializeObject(trade);
                Console.WriteLine(stringjson);

                try
                {

                    var response = await Http.PostBuyJsonAsync2<RootTrade>(uri, stringjson);
                    Console.WriteLine(response);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                // await Http.SendJsonAsync(Http.PostAsync, "https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders", tradeInfo);
            }

           

        }

        public async Task PostSellAsync()
        {

            TradeInfo trade = new TradeInfo()
            {
                order = new Order()
                {

                    units = -50,
                    instrument = "EUR_USD",
                    timeInForce = "FOK",
                    type = "MARKET",
                    positionFill = "DEFAULT"
                }
            };

            

            string uri = "https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders";

            string stringjson = JsonConvert.SerializeObject(trade);
            Console.WriteLine(stringjson);

            try
            {

                var response = await Http.PostBuyJsonAsync2<RootTrade>(uri, stringjson);
                Console.WriteLine(response);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // await Http.SendJsonAsync(Http.PostAsync, "https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders", tradeInfo);
        }
    }
    
}
