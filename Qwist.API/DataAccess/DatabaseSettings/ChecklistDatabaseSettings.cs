namespace Qwist.API.DataAccess.DatabaseSettings;

/// <summary>
/// The settings for the checklist database
/// </summary>
public class ChecklistDatabaseSettings
{
    /// <summary>
    /// The connection string for the database
    /// </summary>
    public string ConnectionString { get; set; } = string.Empty;

    /// <summary>
    /// The name of the database
    /// </summary>
    public string DatabaseName { get; set; } = string.Empty;

    /// <summary>
    /// The name of the checklist collection within the database
    /// </summary>
    public string CollectionName { get; set; } = string.Empty;
}
