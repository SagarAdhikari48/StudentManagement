using StudentManagement_Shared.Models;

namespace StudentManagement.Client.Repository;

public interface ISystemCodeRepository
{
    public Task<List<SystemCode>> GetAllSystemCodeAsync();
    public Task<SystemCode> GetSystemCodeByIdAsync(int id);
    public Task<SystemCode> AddSystemCodeDetailAsync(SystemCode systemCode);
    public Task<SystemCode> UpdateSystemCodeAsync(SystemCode systemCode);
    public Task<SystemCode> DeleteSystemCodeDetailAsync(int id);
}