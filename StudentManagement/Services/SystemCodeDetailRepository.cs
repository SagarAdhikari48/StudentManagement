using Microsoft.EntityFrameworkCore;
using StudentManagement_Shared.Models;
using StudentManagement.Client.Repository;
using StudentManagement.Data;

namespace StudentManagement.Services;

public class SystemCodeDetailRepository : ISystemCodeDetailRepository
{
    private readonly ApplicationDbContext _context;
    
    public SystemCodeDetailRepository(ApplicationDbContext context)
    {
        this._context = context;
    }
    public async Task<List<SystemCodeDetail>> GetAllSystemCodeDetailsAsync()
    {
        var systemCodeDetails = await _context.SystemCodeDetails.ToListAsync();
        return systemCodeDetails;
    }

    public async Task<SystemCodeDetail> GetSystemCodeDetailByIdAsync(int id)
    {
        var systemCodeDetail = await _context.SystemCodeDetails.Where(s => s.Id == id).FirstOrDefaultAsync();
        return systemCodeDetail;
    }

    public async Task<SystemCodeDetail> AddSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail)
    {
        var newSystemCodeDetail = _context.SystemCodeDetails.Add(systemCodeDetail).Entity;
        await _context.SaveChangesAsync();
        return newSystemCodeDetail;
    }

    public async Task<SystemCodeDetail> UpdateSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail)
    {
        var updatedSystemCodeDetails = _context.SystemCodeDetails.Update(systemCodeDetail).Entity;
        await _context.SaveChangesAsync();
        return updatedSystemCodeDetails;
    }

    public async Task<SystemCodeDetail> DeleteSystemCodeDetailAsync(int id)
    {
        var deletedSystemCodeDetails = await _context.SystemCodeDetails.Where(s => s.Id == id).FirstOrDefaultAsync();
        _context.SystemCodeDetails.Remove(deletedSystemCodeDetails);
        await _context.SaveChangesAsync();
        return deletedSystemCodeDetails;

    }
}