using System.ComponentModel.DataAnnotations;

namespace StudentManagement_Shared.Models;

public class SystemCode
{
    [Key] public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }

}