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
    public Guid Id { get; set; }

    /// <summary>
    /// The name of the checklist
    /// </summary>
    [BsonElement]
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// The id of the checklist creator's account
    /// </summary>
    [BsonElement]
    public Guid CreatorId { get; set; }

    /// <summary>
    /// The list of checklist items
    /// </summary>
    [BsonElement]
    public List<bool> Items { get; set; } = new List<bool>();
}
