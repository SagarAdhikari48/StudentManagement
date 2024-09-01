// using System.Net.Http.Json;
// using StudentManagement_Shared.Models;
// using StudentManagement.Client.Repository;
//
// namespace StudentManagement.Client.Services;
//
// public class CountryService : ICountryRepository
// {
//     private HttpClient _httpClient;
//     public CountryService(HttpClient httpClient)
//     {
//         this._httpClient = httpClient;
//     }
//     public async Task<Country> AddCountryAsync(Country country)
//     {
//         var response = await _httpClient.PostAsJsonAsync("/api/Country/Add-Country", country);
//         var content = await response.Content.ReadFromJsonAsync<Country>();
//         return content;
//     }
//
//     public async Task<Country> UpdateCountryAsync(Country country)
//     {
//         var updatedCountry = await _httpClient.PostAsJsonAsync("/api/Country/Update-Country",country);
//         var response = await updatedCountry.Content.ReadFromJsonAsync<Country>();
//         return response;
//     }
//
//     public async Task<Country> DeleteCountryAsync(int countryId)
//     {
//         var deletedCountry = await _httpClient.DeleteAsync($"/api/Country/{countryId}");
//         var response = await deletedCountry.Content.ReadFromJsonAsync<Country>();
//         return response;
//     }
//
//     public async Task<List<Country>> GetAllCountriesAsync()
//     {
//         var countries = await _httpClient.GetAsync("api/Country/Countries");
//         var response =  await countries.Content.ReadFromJsonAsync<List<Country>>();
//         return response;
//     }
//
//     public async Task<Country> GetCountryByIdAsync(int countryId)
//     {
//         var country = await _httpClient.GetAsync($"api/Country/country/{countryId}");
//         var response = await country.Content.ReadFromJsonAsync<Country>();
//         return response;
//     }
// }