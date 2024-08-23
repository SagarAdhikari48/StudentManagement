using System.Net.Http.Json;
using StudentManagement_Shared.Models;
using StudentManagement.Client.Repository;

namespace StudentManagement.Client.Services;

public class SystemCodeService : ISystemCodeRepository
{
    private readonly HttpClient _httpClient;

    public SystemCodeService(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }
    public async Task<List<SystemCode>> GetAllSystemCodeAsync()
    {
        var systemCodes = await _httpClient.GetAsync("api/SystemCode/All-System-Code");
        var response = await  systemCodes.Content.ReadFromJsonAsync<List<SystemCode>>();
        return response;
    }

    public async Task<SystemCode> GetSystemCodeByIdAsync(int id)
    {
        var systemCode = await _httpClient.GetAsync($"api/SystemCode/systemCode/{id}");
        var response = await systemCode.Content.ReadFromJsonAsync<SystemCode>();
        return response;
    }

    public async Task<SystemCode> AddSystemCodeDetailAsync(SystemCode systemCode)
    {
        var newSystemCode = await _httpClient.PostAsJsonAsync("api/SystemCode/Add-System-Code", systemCode);
        var response = await newSystemCode.Content.ReadFromJsonAsync<SystemCode>();
        return response;
    }

    public async Task<SystemCode> UpdateSystemCodeAsync(SystemCode systemCode)
    {
        var updatedSystemCode = await _httpClient.PostAsJsonAsync("api/SystemCode/Update-System-Code", systemCode);
        var response = await updatedSystemCode.Content.ReadFromJsonAsync<SystemCode>();
        return response;
    }
    public async Task<SystemCode> DeleteSystemCodeDetailAsync(int id)
    {
        var deletedSystemCode = await _httpClient.DeleteAsync($"api/SystemCode/Delete-System-Code/{id}");
        var response = await deletedSystemCode.Content.ReadFromJsonAsync<SystemCode>();
        return response;
    }
}