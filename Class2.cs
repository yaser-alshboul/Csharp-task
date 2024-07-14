using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int EmployeeId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public DateTime Birthdate { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public string NationalId { get; set; }
    [Required]
    public string Nationality { get; set; }
    public string MaritalStatus { get; set; }
    public byte[] PersonalPhoto { get; set; }
    [Required]
    public DateTime EntryDate { get; set; }
    [Required]
    public string Password { get; set; }

    
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

 
    public ICollection<Task> Tasks { get; set; }
}
