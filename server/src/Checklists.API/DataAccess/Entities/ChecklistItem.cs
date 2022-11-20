using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Qwist.API.DataAccess.Models;

/// <summary>
/// The checklist item data model
/// </summary>
public class ChecklistItem
{
    /// <summary>
    /// The name of the checklist item
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// Whether the item has been ticked or not
    /// </summary>
    public bool Ticked { get; set; } = false;
}
