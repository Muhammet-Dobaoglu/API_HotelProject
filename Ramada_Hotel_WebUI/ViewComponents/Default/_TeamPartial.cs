using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Ramada_Hotel_WebUI.Dtos.StaffDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace Ramada_Hotel_WebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _TeamPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:20089/api/Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }    }
}
