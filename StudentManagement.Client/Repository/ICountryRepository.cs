using StudentManagement_Shared.Models;

namespace StudentManagement.Client.Repository;

public class ICountryRepository
{
    Task<Country> AddCountryAsync(Country country);
    
    Task<Country> UpdateCountryAsync(Country country);

    Task<Country> DeleteCountryAsync(int countryId);

    Task<List<Country>> GetAllCountriesAsync();

    Task<Country> GetCountryByIdAsync(int countryId);
    
}