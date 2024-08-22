using Microsoft.AspNetCore.Mvc;
using StudentManagement_Shared.Models;
using StudentManagement.Client.Repository;

namespace StudentManagement.Controllers;
[Route("api/[controller]")]
[ApiController]

public class StudentController : ControllerBase
{
  private readonly IStudentRepository _studentRepository;

  public StudentController(IStudentRepository studentRepository)
  {
    this._studentRepository = studentRepository;
  }

  [HttpGet("All-Student")]
  public async Task<ActionResult<List<Student>>> GetAllStudentAsync()
  {
    var students = await _studentRepository.GetAllStudentsAsync();
    return Ok(students);
  }

  [HttpGet("/Single-Student/{id}")]
  public async Task<ActionResult<Student>> GetStudentById(int id)
  {
    var student = await _studentRepository.GetStudentByIdAsync(id);
    return Ok(student);
  }

  [HttpPost("Add-Student")]
  public async Task<ActionResult<Student>> AddStudentAsync(Student student)
  {
    var newStudent = await _studentRepository.AddStudentAsync(student);
    return Ok(newStudent);
  }

  [HttpPost("Update-Student")]
  public async Task<ActionResult<Student>> UpdateStudentAsync(Student student)
  {
    var updatedStudent = await _studentRepository.UpdateStudentAsync(student);
    return Ok(updatedStudent);
  }

  [HttpDelete("Delete-Student")]
  public async Task<ActionResult<Student>> DeleteStudentAsync(int id)
  {
    var deletedStudent = await _studentRepository.DeleteStudentAsync(id);
    return Ok(deletedStudent);
  }
}