using FlixTv.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace FlixTv.Repositories
{
    public class TestService
    {
        private readonly HttpClient _httpClient = new HttpClient();



        public async Task<Result> GetMoviesWithFilters(Category cat)
        {
            // Construct the API URL with genre parameter
            string apiUrl = $"https://ott-details.p.rapidapi.com/advancedsearch?genre=action";

            // Add the required headers
            _httpClient.DefaultRequestHeaders.Clear(); // Clear existing headers, if any
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", "3564570957msh024c72c33e69c52p1ee450jsna15c77966f6d");
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", "ott-details.p.rapidapi.com");

            // Make the HTTP request
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                // Read the response data
                string responseData = await response.Content.ReadAsStringAsync();
                
                // Process the response data and deserialize it into a List<Movie>
                var result = JsonConvert.DeserializeObject<Result>(responseData);

                return result ;
            }
            return null;
        }

    }
}