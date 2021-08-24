﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forex.Shared;
using Microsoft.AspNetCore.Components;
using System.IO;
using System.Net;
using Forex.Model;
//using Forex.Service;
using System.Net.Http;
//using Nancy.Json;

namespace Forex.Pages
{
  

        public partial class HistoricData : ComponentBase
        {
            private Root Mains;
            private string ErrorMessage;
            public string instrument = "EUR_USD";
            private string type = "anime";
            private int count = 5;
            private int page = 1;
            private async Task GetDataAsync()
            {
                try
                {

                    {
                    //https://api-fxpractice.oanda.com/v3/instruments/EUR_USD/candles?count=6&price=M&granularity=S5



                    // string uri = "https://api.jikan.moe/v3/genre/" + type + "/" + genreId + "/" + page; //anime/1/1
                    // string uri = "https://api.jikan.moe/v3/genre/anime/1/1";


                    // string uri = "https://api.jikan.moe/v3/schedule/" + day;
                    //  string uri = "https://api.jikan.moe/v3/schedule/monday";
                    // string uri = "https://api.jikan.moe/v3/season/" + year + "/" + season; 
                    string uri = "https://api-fxpractice.oanda.com/v3/instruments/" + instrument + "/candles?count=" + count + "&price=M&granularity=S5";
                    Mains = await Http.GetJsonAsync<Root>(uri);
                        ErrorMessage = String.Empty;
                    Console.WriteLine(Mains);
                    }
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                }
            }
            
            protected override async Task OnInitializedAsync()
            {
                await GetDataAsync();
            }



        }
    
}