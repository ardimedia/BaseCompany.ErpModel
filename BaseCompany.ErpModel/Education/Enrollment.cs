using BaseCompany.ErpModel.Base;

namespace BaseCompany.ErpModel.Education;

/// <summary>
/// Represents a student's enrollment in a course or program.
/// </summary>
public class Enrollment : AuditableEntity
{
    public Guid StudentId { get; set; }
    public Student Student { get; set; }
    public string Program { get; set; }
    public DateTimeOffset EnrollmentDate { get; set; }
    public string Status { get; set; }
}
