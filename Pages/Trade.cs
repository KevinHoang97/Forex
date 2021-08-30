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
using Microsoft.AspNetCore.Mvc;
//using Nancy.Json;
namespace Forex.Pages
{

    public partial class Trade : ComponentBase
    {
        public int units;
        public string instrument;




        public async Task PostBuy(int unit, string instrument)
        {
            {
                Order order = new Order()
                {

                    units = unit,
                    instrument = instrument,
                    timeInForce = "FOK",
                    type = "MARKET",
                    positionFill = "DEFAULT"
                };

                TradeInfo trade = new TradeInfo()
                {
                    order = order
                };



                string uri = "https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders";

                string stringjson = JsonConvert.SerializeObject(trade);
                Console.WriteLine(stringjson);

                try
                {

                    var response = await Http.PostBuyJsonAsync2<RootMarket>(uri, stringjson);
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

            TradeInfo trade = new TradeInfo
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

                var response = await Http.PostBuyJsonAsync2<RootMarket>(uri, stringjson);
                Console.WriteLine(response);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // await Http.SendJsonAsync(Http.PostAsync, "https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders", tradeInfo);
        }
        public async Task PostTestBuy()
        {
            int units;
            string instrument;
            string timeInForce = "FOK";
            string type = "MARKET";
            string positionFill = "DEFAULT";


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

                var response = await Http.PostBuyJsonAsync2<RootMarket>(uri, stringjson);
                Console.WriteLine(response);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // await Http.SendJsonAsync(Http.PostAsync, "https://api-fxpractice.oanda.com/v3/accounts/101-004-16583730-001/orders", tradeInfo);




        }
        public ActionResult TradeAction(int option)
        {
            if(option == 1)
            {
                 PostBuy(this.units, this.instrument);
                Console.WriteLine(option);
                
            }
            else if(option == 2)
            {
                PostSellAsync();
                Console.WriteLine(option);
            }
            else
            {
                Console.WriteLine("Action not working");
            }
            return null;
        }
    }
    
}
