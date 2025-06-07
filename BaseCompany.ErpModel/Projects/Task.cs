using BaseCompany.ErpModel.Base;
using BaseCompany.ErpModel.HumanRessource;

namespace BaseCompany.ErpModel.Projects;

/// <summary>
/// Represents a task that is part of a project.
/// </summary>
public class Task : AuditableEntity
{
    /// <summary>
    /// Gets or sets the project ID this task belongs to.
    /// </summary>
    public Guid ProjectId { get; set; }

    /// <summary>
    /// Gets or sets the project this task belongs to.
    /// </summary>
    public Project Project { get; set; }

    /// <summary>
    /// Gets or sets the task name.
    /// </summary>
    public string TaskName { get; set; }

    /// <summary>
    /// Gets or sets the task status (e.g., Not Started, In Progress, Done).
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the task start date.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the task due date.
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Gets or sets the estimated hours for the task.
    /// </summary>
    public decimal EstimatedHours { get; set; }

    /// <summary>
    /// Gets or sets the actual hours spent on the task.
    /// </summary>
    public decimal ActualHours { get; set; }

    /// <summary>
    /// Gets or sets the employee ID assigned to this task.
    /// </summary>
    public Guid? AssignedToEmployeeId { get; set; }

    /// <summary>
    /// Gets or sets the employee assigned to this task.
    /// </summary>
    public Employee AssignedToEmployee { get; set; }

    /// <summary>
    /// Gets or sets the task priority (e.g., Low, Medium, High).
    /// </summary>
    public string Priority { get; set; }

    /// <summary>
    /// Gets or sets the task description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the parent task ID if this is a sub-task.
    /// </summary>
    public Guid? ParentTaskId { get; set; }

    /// <summary>
    /// Gets or sets the parent task if this is a sub-task.
    /// </summary>
    public Task ParentTask { get; set; }
}
