using Qwist.API.DataAccess.Models;
using System.Collections;

namespace Qwist.API.DataAccess.Repositories;

/// <summary>
/// The interface for the checklist repository
/// </summary>
public interface IChecklistRepository
{
    /// <summary>
    /// Gets all checklists 
    /// </summary>
    /// <returns>An enumerable of checklists</returns>
    public Task<IEnumerable<Checklist>> GetAllChecklistsAsync();
    
    /// <summary>
    /// Gets a single checklist with a specified id
    /// </summary>
    /// <param name="id">The checklist id</param>
    /// <returns>A single checklist or null</returns>
    public Task<Checklist?> GetChecklistAsync(Guid id);

    /// <summary>
    /// Creates a checklist
    /// </summary>
    /// <param name="checklist">The checklist object</param>
    /// <returns></returns>
    public Task CreateChecklistAsync(Checklist checklist);

    /// <summary>
    /// Updates an entire checklist
    /// </summary>
    /// <param name="checklist">The checklist object</param>
    /// <returns></returns>
    public Task UpdateChecklistAsync(Checklist checklist);

    /// <summary>
    /// Removes a checklist with a specified id
    /// </summary>
    /// <param name="id">The checklist id</param>
    /// <returns></returns>
    public Task RemoveChecklistAsync(Guid id);

    /// <summary>
    /// Partially updates a checklist
    /// </summary>
    /// <param name="id">The checklist id</param>
    /// <param name="patch">The checklist object to patch with</param>
    /// <returns></returns>
    public Task PatchChecklistAsync(Guid id, Checklist patch);
}
