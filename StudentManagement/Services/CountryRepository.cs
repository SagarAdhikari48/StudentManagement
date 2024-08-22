using Microsoft.EntityFrameworkCore;
using StudentManagement_Shared.Models;
using StudentManagement.Client.Repository;
using StudentManagement.Data;

namespace StudentManagement.Services;

public class CountryRepository : ICountryRepository
{
    private readonly ApplicationDbContext _context;

    public CountryRepository(ApplicationDbContext context)
    {
        this._context = context;
    }
    
    public async Task<Country> AddCountryAsync(Country country)
    {
        if (country == null) return null;
        var newCountry = _context.Countries.Add(country).Entity;
        await _context.SaveChangesAsync();
        return newCountry;
    }

    public async Task<Country> UpdateCountryAsync(Country country)
    {
        var updatedCountry = _context.Countries.Update(country).Entity;
        await _context.SaveChangesAsync();
        return updatedCountry;
    }

    public async Task<Country> DeleteCountryAsync(int countryId)
    {
        var deletedCountry = await _context.Countries.Where(c => c.Id == countryId).FirstOrDefaultAsync();
        if (deletedCountry == null) return null;
        _context.Countries.Remove(deletedCountry);
        await _context.SaveChangesAsync();
        return deletedCountry;
    }

    public async Task<List<Country>> GetAllCountriesAsync()
    {
        var countries = await _context.Countries.ToListAsync();
        return countries;
    }

    public async Task<Country> GetCountryByIdAsync(int countryId)
    {
        var country = await _context.Countries.Where(c => c.Id == countryId).FirstOrDefaultAsync();
        return country;
    }
}