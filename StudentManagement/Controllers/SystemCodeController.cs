using Microsoft.AspNetCore.Mvc;
using StudentManagement_Shared.Models;
using StudentManagement.Client.Repository;

namespace StudentManagement.Controllers;
[Route("api/[controller]")]
[ApiController]

public class SystemCodeController : ControllerBase
{
    private readonly ISystemCodeRepository _systemCodeRepository;

    public SystemCodeController(ISystemCodeRepository systemCodeRepository)
    {
        this._systemCodeRepository = systemCodeRepository;
    }

    [HttpGet("All-System-Code")]
    public async Task<ActionResult<List<SystemCode>>> GetAllSystemCodeAsync()
    {
        var systemCodes = await _systemCodeRepository.GetAllSystemCodeAsync();
        return Ok(systemCodes);
    }

    [HttpGet("systemCode/{id}")]
    public async Task<ActionResult<SystemCode>> GetSystemCodeByIdAsync(int id)
    {
        var systemCode = await _systemCodeRepository.GetSystemCodeByIdAsync(id);
        return Ok(systemCode);
    }

    [HttpPost("Add-System-Code")]
    public async Task<ActionResult<SystemCode>> AddSystemCodeAsync(SystemCode systemCode)
    {
        var newSystemCode = await _systemCodeRepository.AddSystemCodeDetailAsync(systemCode);
        return Ok(newSystemCode);
    }

    [HttpPost("Update-System-Code")]
    public async Task<ActionResult<SystemCode>> UpdateSystemCodeAsync(SystemCode systemCode)
    {
        var updatedSystemCode = await _systemCodeRepository.UpdateSystemCodeAsync(systemCode);
        return Ok(updatedSystemCode);

    }

    [HttpDelete("Delete-System-Code/{id}")]
    public async Task<ActionResult<SystemCode>> DeleteSystemCodeAsync(int id)
    {
        var deletedSystemCode = await _systemCodeRepository.DeleteSystemCodeDetailAsync(id);
        return Ok(deletedSystemCode);
    }
}