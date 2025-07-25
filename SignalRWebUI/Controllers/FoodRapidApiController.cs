﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.RapidApiDto;

namespace SignalRWebUI.Controllers
{
    public class FoodRapidApiController : Controller
    {
        public async Task<IActionResult> Index() // async ekledik
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://tasty.p.rapidapi.com/recipes/list?from=0&size=60&tags=under_30_minutes"),
                Headers =
                {
                    { "x-rapidapi-key", "630ce9cc86msh271c60cffe62d5ep1b514djsn0fe292593744" },
                    { "x-rapidapi-host", "tasty.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request)) // await kullanımı doğru
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var root = JsonConvert.DeserializeObject<RootTastyApi>(body);
                var values = root.Results;

                return View(values.ToList());
            }
        }
    }
}
