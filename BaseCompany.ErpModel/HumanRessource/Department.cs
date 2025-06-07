using BaseCompany.ErpModel.Base;
using System.Collections.Generic;

namespace BaseCompany.ErpModel.HumanRessource;

/// <summary>
/// Represents a department within the organization.
/// </summary>
public class Department : AuditableEntity
{
    /// <summary>
    /// Gets or sets the department name.
    /// </summary>
    public string DepartmentName { get; set; }

    /// <summary>
    /// Gets or sets the description of the department.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the collection of employees in this department.
    /// </summary>
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
