using Qwist.API.DataAccess.Models;

namespace Qwist.API.DataAccess.Repositories;

public class InMemChecklistRepository : IChecklistRepository
{
    public InMemChecklistRepository()
    {

    }

    public Task CreateChecklistAsync(Checklist checklist)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Checklist>> GetAllChecklistsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Checklist?> GetChecklistAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task PatchChecklistAsync(Guid id, Checklist patch)
    {
        throw new NotImplementedException();
    }

    public Task RemoveChecklistAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateChecklistAsync(Checklist checklist)
    {
        throw new NotImplementedException();
    }
}
