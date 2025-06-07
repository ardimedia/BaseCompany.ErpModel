using BaseCompany.ErpModel.Base;

namespace BaseCompany.ErpModel.Education;

/// <summary>
/// Represents a student enrolled in educational programs.
/// </summary>
public class Student : AuditableEntity
{
    public string StudentName { get; set; }
    public string Email { get; set; }
    public string EnrollmentNumber { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }
    public string Gender { get; set; }
}
