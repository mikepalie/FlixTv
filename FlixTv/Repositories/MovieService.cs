﻿using FlixTv.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace FlixTv.Repositories
{
    public class MovieService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        //-------------------- Year-Filtering Start -----------------
        public List<string> Year(string year)
        {
            List<string> years = new List<string>();
            string start, end;
            if (year == "")
            {
                start = "";
                end = "";               
            }
            else if (year == "20100" || year == "20000" || year == "19900" || year == "19800" || year == "1970")
            {
                start = (Int32.Parse(year) / 10).ToString();
                end = ((Int32.Parse(year) / 10) + 9).ToString();
            }
            else
            {
                start = year;
                end = year;
            }
            years.Add(start);
            years.Add(end);
            return years;
        }
        //-------------------- Year-Filtering End -----------------

        //--------------------Api Call Start-----------------
        public async Task<Data> GetMoviesWithFilters(Filter filter)
        {
            List<string> years = Year(filter.Year);
            // Construct the API URL with filtering parameters
            string apiUrl = $"https://ott-details.p.rapidapi.com/advancedsearch?type=movie&genre={filter.Genre}&start_year={years[0]}&end_year={years[1]}&min_imdb={filter.MinRating}&max_imdb={filter.MaxRating}&sort={filter.SortingBy}";

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
                var data = JsonConvert.DeserializeObject<Data>(responseData);

                return data ;
            }
            return null;
        }
        //-------------------- Api Call End -----------------

    }
}