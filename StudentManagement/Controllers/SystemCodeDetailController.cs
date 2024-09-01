﻿using Microsoft.AspNetCore.Mvc;
using StudentManagement_Shared.Models;
using StudentManagement.Client.Repository;

namespace StudentManagement.Controllers;
[Route("/api/[controller]")]
[ApiController]

public class SystemCodeDetailController : Controller
{
    private readonly ISystemCodeDetailRepository _systemCodeDetailRepository;

    public SystemCodeDetailController(ISystemCodeDetailRepository systemCodeDetailRepository)
    {
        this._systemCodeDetailRepository = systemCodeDetailRepository;
    }

    [HttpGet("All-System-Code-Details")]
    public async Task<ActionResult<List<SystemCodeDetail>>> GetAllSystemCodeDetailsAsync()
    {
        var allSystemCodeDetails = await _systemCodeDetailRepository.GetAllAsync();
        return Ok(allSystemCodeDetails);
    }

    [HttpGet("System-Code-Detail/{id}")]
    public async Task<ActionResult<SystemCodeDetail>> GetSystemCodeDetail(int id)
    {
        var systemCodeDetail = await _systemCodeDetailRepository.GetByIdAsync(id);
        return Ok(systemCodeDetail);
    }
    
    [HttpGet("AllByCode/{code}")]
    public async Task<ActionResult<IEnumerable<SystemCodeDetail>>> GetSystemCodeDetailsByCode(string code)
    {
        var systemCodeDetail = await _systemCodeDetailRepository.GetByCodeAsync(code);
        return Ok(systemCodeDetail);
    }

    [HttpPost("Add-System-Code-Detail")]
    public async Task<ActionResult<SystemCodeDetail>> AddSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail)
    {
        var newSystemCode = await _systemCodeDetailRepository.AddAsync(systemCodeDetail);
        return Ok(newSystemCode);
    }

    [HttpPost("Update-System-Code-Detail")]
    public async Task<ActionResult<SystemCodeDetail>> UpdateSystemCodeDetailAsync(SystemCodeDetail systemCodeDetail)
    {
        var updatedSystemCode = await _systemCodeDetailRepository.UpdateAsync(systemCodeDetail);
        return Ok(updatedSystemCode);
    }

    [HttpDelete("Delete-System-Code-Detail")]
    public async Task<ActionResult<SystemCodeDetail>> DeleteSystemCodeDetailsAsync(int id)
    {
        var deletedSystemCodeDetails = await _systemCodeDetailRepository.DeleteAsync(id);
        return Ok(deletedSystemCodeDetails);
    }

}