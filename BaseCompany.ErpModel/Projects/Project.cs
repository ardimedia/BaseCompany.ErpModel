using CompanyName.ERPNext.Entities.Base;
using CompanyName.ERPNext.Entities.Projects;
using System;
using System.Collections.Generic;
using CompanyName.ERPNext.Entities.HumanRessource;

namespace CompanyName.ERPNext.Entities.Projects;

/// <summary>
/// Represents a business project composed of tasks.
/// </summary>
public class Project : AuditableEntity
{
    /// <summary>
    /// Gets or sets the project name.
    /// </summary>
    public string ProjectName { get; set; }

    /// <summary>
    /// Gets or sets the project status (e.g., Planned, In Progress, Completed).
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the project start date.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the project end date.
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or sets the project description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the project budget.
    /// </summary>
    public decimal? Budget { get; set; }

    /// <summary>
    /// Gets or sets the project manager's employee ID.
    /// </summary>
    public Guid? ProjectManagerId { get; set; }

    /// <summary>
    /// Gets or sets the project manager.
    /// </summary>
    public Employee ProjectManager { get; set; }

    /// <summary>
    /// Gets or sets the client name for the project.
    /// </summary>
    public string ClientName { get; set; }

    /// <summary>
    /// Gets or sets the collection of tasks in this project.
    /// </summary>
    public ICollection<Task> Tasks { get; set; } = new List<Task>();

    /// <summary>
    /// Gets or sets the collection of team members (employees) assigned to this project.
    /// </summary>
    public ICollection<Employee> TeamMembers { get; set; } = new List<Employee>();
}
