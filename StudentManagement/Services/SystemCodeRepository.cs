using Microsoft.EntityFrameworkCore;
using StudentManagement_Shared.Models;
using StudentManagement.Client.Repository;
using StudentManagement.Data;

namespace StudentManagement.Services;

public class SystemCodeRepository : ISystemCodeRepository
{
    private readonly ApplicationDbContext _context;
    
    public SystemCodeRepository(ApplicationDbContext context)
    {
        this._context = context;
    }
    public async Task<List<SystemCode>> GetAllSystemCodeAsync()
    {
        var systemCodes = await _context.SystemCodes.ToListAsync();
        return systemCodes;
    }

    public async Task<SystemCode> GetSystemCodeByIdAsync(int id)
    {
        var systemCode = await _context.SystemCodes.Where(c => c.Id == id).FirstOrDefaultAsync();
        return systemCode;

    }

    public async Task<SystemCode> AddSystemCodeDetailAsync(SystemCode systemCode)
    {
        var newSystemCode = _context.SystemCodes.Add(systemCode).Entity;
        await _context.SaveChangesAsync();
        return newSystemCode;
    }

    public async Task<SystemCode> UpdateSystemCodeAsync(SystemCode systemCode)
    {
        var updatedSystemCode = _context.SystemCodes.Update(systemCode).Entity;
        await _context.SaveChangesAsync();
        return updatedSystemCode;
    }

    public async Task<SystemCode> DeleteSystemCodeDetailAsync(int id)
    {
        var deletedSystemCode = await _context.SystemCodes.Where(c => c.Id == id).FirstOrDefaultAsync(); 
        _context.SystemCodes.Remove(deletedSystemCode);
        await _context.SaveChangesAsync();
        return deletedSystemCode;
    }
}