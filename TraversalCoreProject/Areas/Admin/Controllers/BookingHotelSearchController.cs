using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-10-27&filter_by_currency=EUR&dest_id=-1456928&locale=tr&checkout_date=2023-10-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
                Headers =
                    {
                        { "X-RapidAPI-Key", "9c1f5e3edemsha947e7020e966d6p129c50jsne27cfc0ac843" },
                        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                    },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);

                return View(values.results);
            }
        }

        [HttpGet]
        public IActionResult GetCityId()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCityId(string city)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={city}&locale=en-gb"),
                Headers =
                    {
                        { "X-RapidAPI-Key", "9c1f5e3edemsha947e7020e966d6p129c50jsne27cfc0ac843" },
                        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                    },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                return View(body);
            }
        }
    }
}
