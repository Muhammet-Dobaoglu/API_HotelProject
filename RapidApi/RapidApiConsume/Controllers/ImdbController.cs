using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://advanced-movie-search.p.rapidapi.com/genre/movie/list"),
                Headers =
    {
        { "X-RapidAPI-Key", "358b71d35dmsh5524d1ee3123b0bp10387ajsnda3bf31d70b2" },
        { "X-RapidAPI-Host", "advanced-movie-search.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ApiMovieViewModel>(body);
                return View(values.genres.ToList());

            }
        }
    }
}

