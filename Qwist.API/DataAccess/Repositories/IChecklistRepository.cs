using Qwist.API.DataAccess.Models;
using System.Collections;

namespace Qwist.API.DataAccess.Repositories;

public interface IChecklistRepository
{
    public Task<IEnumerable<Checklist>> GetAllChecklistsAsync(); 
    public Task<Checklist> GetChecklistAsync(Guid id);
    public Task CreateChecklistAsync(Checklist checklist);
    public Task UpdateChecklistAsync(Checklist checklist);
    public Task RemoveChecklistAsync(Guid id);
    public Task PatchChecklistAsync(Guid id, Checklist patch);
}
