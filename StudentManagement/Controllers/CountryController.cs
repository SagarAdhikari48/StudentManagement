using Microsoft.AspNetCore.Mvc;
using StudentManagement_Shared.Models;
using StudentsManagement.Client.Repository;

namespace StudentManagement.Controllers;
[Route("api/[controller]")]
[ApiController]

public class CountryController : ControllerBase
{
    private readonly ICountryRepository _countryRepository;
    public CountryController(ICountryRepository countryRepository)
    {
        this._countryRepository = countryRepository;
    }

    [HttpGet("Countries")]
    public async Task<ActionResult<List<Country>>> GetAllCountriesAsync()
    {
        var countries = await _countryRepository.GetAllAsync();
        return Ok(countries);
    }

    [HttpGet("country/{id}")]
    public async Task<ActionResult<Country>> GetCountryById(int id)
    {
        var country = await _countryRepository.GetByIdAsync(id);
        return Ok(country);
    }

    [HttpPost("Add-Country")]
    public async Task<ActionResult<Country>> AddNewCountry(Country country)
    {
        var newCountry = await _countryRepository.AddAsync(country);
        return Ok(newCountry);
    }

    [HttpPost("Update-Country")]
    public async Task<ActionResult<Country>> UpdateCountry(Country country)
    {
        var updatedCountry = await _countryRepository.UpdateAsync(country);
        return updatedCountry;
    }

    [HttpDelete("Delete-Country/{id}")]
    public async Task<ActionResult<Country>> DeleteCountry(int id)
    {
        var deletedCountry = await _countryRepository.DeleteAsync(id);
        return Ok(deletedCountry);
    }
}