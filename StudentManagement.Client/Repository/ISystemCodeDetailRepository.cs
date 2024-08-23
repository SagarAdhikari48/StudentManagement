using StudentManagement_Shared.Models;

namespace StudentManagement.Client.Repository;

public interface ISystemCodeDetailRepository
{
    public Task<List<SystemCodeDetail>> GetAllSystemCodeDetailsAsync();
    public Task<SystemCodeDetail> GetSystemCodeDetailByIdAsync(int id);
    public Task<SystemCodeDetail> AddSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail);
    public Task<SystemCodeDetail> UpdateSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail);
    public Task<SystemCodeDetail> DeleteSystemCodeDetailAsync(int id);
}