// using System.Net.Http.Json;
// using System.Text.Json;
// using StudentManagement_Shared.Models;
// using StudentManagement.Client.Repository;
//
// namespace StudentManagement.Client.Services;
//
// public class StudentService: IStudentRepository
// {
//     private HttpClient _httpClient;
//     public StudentService(HttpClient httpClient)
//     {
//         this._httpClient = httpClient;
//     }
//
//     public async Task<Student> AddStudentAsync(Student student)
//     {
//         // var newStudent = await _httpClient.PostAsJsonAsync("/api/student/Add-Student",student);
//         // var response = await newStudent.Content.ReadFromJsonAsync<Student>();
//         var response = await _httpClient.PostAsJsonAsync("/api/student/Add-Student", student);
//         var content = await response.Content.ReadAsStringAsync();
//         Console.WriteLine($"API Response: {content}");
//         if (response.IsSuccessStatusCode && !string.IsNullOrWhiteSpace(content))
//         {
//             return JsonSerializer.Deserialize<Student>(content);
//         }
//         else
//         {
//             throw new Exception($"Failed to add student. Status Code: {response.StatusCode}, Response: {content}");
//         }
//     }
//
//     public async Task<Student> UpdateStudentAsync(Student student)
//     {
//         var updatedStudent = await _httpClient.PostAsJsonAsync("/api/Student/Update-Student",student);
//         var response = await updatedStudent.Content.ReadFromJsonAsync<Student>();
//         return response;
//     }
//
//     public async Task<Student> DeleteStudentAsync(int studentId)
//     {
//         var student = await _httpClient.DeleteAsync($"/api/Student/{studentId}");
//         var response = await student.Content.ReadFromJsonAsync<Student>();
//         return response;
//     }
//
//     public async Task<List<Student>> GetAllStudentsAsync()
//     {
//         var allStudents = await _httpClient.GetAsync("api/Student/All-Students");
//         var response = await allStudents.Content.ReadFromJsonAsync<List<Student>>();
//         return response;
//     }
//
//     public async Task<Student> GetStudentByIdAsync(int studentId)
//     {
//         var singleStudent = await _httpClient.GetAsync($"api/Student/Single-Student");
//         var response = await singleStudent.Content.ReadFromJsonAsync<Student>();
//         return response;
//     }
// }