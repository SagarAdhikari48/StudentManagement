using Microsoft.EntityFrameworkCore;
using StudentManagement_Shared.Models;
using StudentManagement.Client.Repository;
using StudentManagement.Data;

namespace StudentManagement.Services;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;
    
    public StudentRepository(ApplicationDbContext context)
    {
        this._context = context;
    }
    public async  Task<Student> AddStudentAsync(Student student)
    {
        if (student == null) return null;
        var newstudent = _context.Students.Add(student).Entity;
        await _context.SaveChangesAsync();
        return newstudent;
    }

    public async Task<Student> UpdateStudentAsync(Student mod)
    {
        if (mod == null) return null;
        var newstudent = _context.Students.Update(mod).Entity;
        await _context.SaveChangesAsync();
        return newstudent;
    }

    public async Task<Student> DeleteStudentAsync(int studentId)
    {
        var student = await _context.Students.Where(x => x.Id == studentId).FirstOrDefaultAsync();
        if (student == null) return null;
        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
        return student;
    }

    public async Task<List<Student>> GetAllStudentsAsync()
    {
        var students = await _context.Students.ToListAsync();
        if (students == null) return null;
        return students;
    }

    public async Task<Student> GetStudentByIdAsync(int studentId)
    {
        var singleStudent = await _context.Students.Where(x => x.Id == studentId).FirstOrDefaultAsync();
        if (singleStudent == null) return null;
        return singleStudent;
    }
}