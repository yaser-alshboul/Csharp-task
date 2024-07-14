using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Department
{
    public int DepartmentId { get; set; }
    [Required]
    public string DepartmentName { get; set; }

    // Navigation property for employees
    public ICollection<Employee> Employees { get; set; }
}
