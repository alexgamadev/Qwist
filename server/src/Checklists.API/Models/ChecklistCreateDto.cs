using Qwist.API.DataAccess.Models;

namespace Checklists.API.Models;

/// <summary>
/// The data transfer object for checklist creation
/// </summary>
public class ChecklistCreateDto
{
    /// <summary>
    /// The name of the checklist
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// The id of the checklist creator's account
    /// </summary>
    public string? CreatorId { get; set; } = null;

    /// <summary>
    /// The list of checklist items
    /// </summary>
    public List<ChecklistItem> Items { get; set; } = new List<ChecklistItem>();
}
