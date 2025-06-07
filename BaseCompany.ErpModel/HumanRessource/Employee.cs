using BaseCompany.ErpModel.Base;

namespace BaseCompany.ErpModel.HumanRessource;

/// <summary>
/// Represents an employee in the organization.
/// Maps to schema.org/Person and schema.org/Employee concepts.
/// </summary>
public class Employee : AuditableEntity
{
    /// <summary>
    /// Gets or sets the employee's first name.
    /// Maps to schema.org/givenName
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the employee's last name.
    /// Maps to schema.org/familyName
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the unique employee identifier.
    /// Maps to schema.org/identifier
    /// </summary>
    public string EmployeeId { get; set; }

    /// <summary>
    /// Gets or sets the department ID the employee belongs to.
    /// </summary>
    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// Gets or sets the department the employee belongs to.
    /// Maps to schema.org/worksFor
    /// </summary>
    public Department Department { get; set; }

    /// <summary>
    /// Gets or sets the employee's designation.
    /// Maps to schema.org/jobTitle
    /// </summary>
    public string Designation { get; set; }

    /// <summary>
    /// Gets or sets the date the employee joined.
    /// Maps to schema.org/startDate
    /// </summary>
    public DateTime JoiningDate { get; set; }

    /// <summary>
    /// Gets or sets the employee's email address.
    /// Maps to schema.org/email
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the employee's phone number.
    /// Maps to schema.org/telephone
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the employee's middle name.
    /// Maps to schema.org/additionalName
    /// </summary>
    public string MiddleName { get; set; }
}