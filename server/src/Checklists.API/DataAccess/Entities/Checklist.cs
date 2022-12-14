using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Qwist.API.DataAccess.Models;

/// <summary>
/// The checklist data model
/// </summary>
public class Checklist
{
    /// <summary>
    /// The checklist id
    /// </summary>
    [BsonId]
    public string Id { get; set; } = String.Empty;

    /// <summary>
    /// The name of the checklist
    /// </summary>
    [BsonElement]
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// The id of the checklist creator's account
    /// </summary>
    [BsonElement]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? CreatorId { get; set; } = null;

    /// <summary>
    /// The list of checklist items
    /// </summary>
    [BsonElement]
    public List<ChecklistItem> Items { get; set; } = new List<ChecklistItem>();
}
