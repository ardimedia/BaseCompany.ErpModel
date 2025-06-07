using BaseCompany.ErpModel.Base;
using System;

namespace BaseCompany.ErpModel.HumanRessource;

/// <summary>
/// Represents an employee's attendance record.
/// </summary>
public class Attendance : AuditableEntity
{
    /// <summary>
    /// Gets or sets the employee ID for this attendance record.
    /// </summary>
    public Guid EmployeeId { get; set; }

    /// <summary>
    /// Gets or sets the employee for this attendance record.
    /// </summary>
    public Employee Employee { get; set; }

    /// <summary>
    /// Gets or sets the date of attendance.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Gets or sets whether the employee was present.
    /// </summary>
    public bool IsPresent { get; set; }

    /// <summary>
    /// Gets or sets any remarks for the attendance.
    /// </summary>
    public string Remarks { get; set; }
}
