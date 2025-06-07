using CompanyName.ERPNext.Entities.Base;
using System;

namespace CompanyName.ERPNext.Entities.HumanRessource;

/// <summary>
/// Represents an employee in the organization.
/// </summary>
public class Employee : AuditableEntity
{
    /// <summary>
    /// Gets or sets the employee's first name.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the employee's last name.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the unique employee identifier.
    /// </summary>
    public string EmployeeId { get; set; }

    /// <summary>
    /// Gets or sets the department ID the employee belongs to.
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// Gets or sets the department the employee belongs to.
    /// </summary>
    public Department Department { get; set; }

    /// <summary>
    /// Gets or sets the employee's designation.
    /// </summary>
    public string Designation { get; set; }

    /// <summary>
    /// Gets or sets the date the employee joined.
    /// </summary>
    public DateTime JoiningDate { get; set; }

    /// <summary>
    /// Gets or sets the employee's email address.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the employee's phone number.
    /// </summary>
    public string Phone { get; set; }
}
