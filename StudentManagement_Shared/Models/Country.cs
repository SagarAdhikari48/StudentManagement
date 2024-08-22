using System.ComponentModel.DataAnnotations;

namespace StudentManagement_Shared.Models;

public class Country
{
    [Key]
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
}