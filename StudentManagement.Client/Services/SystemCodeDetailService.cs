// using System.Net.Http.Json;
// using StudentManagement_Shared.Models;
// using StudentManagement.Client.Repository;
//
// namespace StudentManagement.Client.Services;
//
// public class SystemCodeDetailService : ISystemCodeDetailRepository
// {
//     private readonly HttpClient _httpClient;
//     
//     public SystemCodeDetailService(HttpClient httpClient)
//     {
//         this._httpClient = httpClient;
//     }
//     public async Task<List<SystemCodeDetail>> GetAllAsync()
//     {
//         var allSystemCodeDetails = await _httpClient.GetAsync("api/SystemCodeDetail/All-System-Code-Details");
//         var response = await allSystemCodeDetails.Content.ReadFromJsonAsync<List<SystemCodeDetail>>();
//         return response;
//     }
//
//     public async Task<SystemCodeDetail> GetByIdAsync(int id)
//     {
//         var systemCodeDetail = await _httpClient.GetAsync($"api/SystemCodeDetail/System-Code-Detail/{id}");
//         var response = await systemCodeDetail.Content.ReadFromJsonAsync<SystemCodeDetail>();
//         return response;
//     }
//
//     public async Task<SystemCodeDetail> AddAsync(SystemCodeDetail systemCodeDetail)
//     {
//         var newSystemCodeDetail = await _httpClient.PostAsJsonAsync("/api/SystemCodeDetail/Add-System-Code-Detail", systemCodeDetail);
//         var response = await newSystemCodeDetail.Content.ReadFromJsonAsync<SystemCodeDetail>();
//         return response;
//     }
//
//     public async Task<SystemCodeDetail> UpdateAsync(SystemCodeDetail systemCodeDetail)
//     {
//         var updatedSystemCodeDetails =
//             await _httpClient.PostAsJsonAsync("/api/SystemCodeDetail/Update-System-Code-Detail", systemCodeDetail);
//         var response = await updatedSystemCodeDetails.Content.ReadFromJsonAsync<SystemCodeDetail>();
//         return response;
//
//     }
//
//     public async Task<SystemCodeDetail> DeleteAsync(int id)
//     {
//         var deletedSystemCodeDetails =
//             await _httpClient.DeleteAsync($"api/SystemCodeDetail/Delete-System-Code-Detail/{id}");
//         var response = await deletedSystemCodeDetails.Content.ReadFromJsonAsync<SystemCodeDetail>();
//         return response;
//     }
//
//     public async Task<SystemCodeDetail> GetByCodeAsync(string code)
//     {
//         var systemCodeDetail = await _httpClient.GetAsync($"api/SystemCodeDetail/AllByCode/{code}");
//         var response = await systemCodeDetail.Content.ReadFromJsonAsync<SystemCodeDetail>();
//         return response;
//     }
// }