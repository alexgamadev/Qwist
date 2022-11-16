using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Qwist.API.DataAccess.DatabaseSettings;
using Qwist.API.DataAccess.Models;

namespace Qwist.API.DataAccess.Repositories;

/// <inheritdoc/>
public class DbChecklistRepository : IChecklistRepository
{
    private readonly IMongoCollection<Checklist> _checklistCollection;

    /// <summary>
    /// The in memory checklist repository contstructor
    /// </summary>
    public DbChecklistRepository(IOptions<ChecklistDatabaseSettings> databaseSettings)
    {
        var client = new MongoClient(databaseSettings.Value.ConnectionString);
        var database = client.GetDatabase(databaseSettings.Value.DatabaseName);

        _checklistCollection = database.GetCollection<Checklist>(databaseSettings.Value.CollectionName);
    }

    /// <inheritdoc/>
    public async Task CreateAsync(Checklist checklist)
    {
        await _checklistCollection.InsertOneAsync(checklist);
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Checklist>> GetAllAsync()
    {
        var items = await _checklistCollection.Find(_ => true).ToListAsync();
        return items;
    }

    /// <inheritdoc/>
    public async Task<Checklist> GetAsync(Guid id)
    {
        var item = await _checklistCollection.Find(item => item.Id == id).FirstOrDefaultAsync();
        return item;
    }

    /// <inheritdoc/>
    public Task PatchAsync(Guid id, Checklist patch)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public async Task RemoveAsync(Guid id)
    {
        await _checklistCollection.FindOneAndDeleteAsync(item => item.Id == id);
    }

    /// <inheritdoc/>
    public Task UpdateAsync(Checklist checklist)
    {
        throw new NotImplementedException();
    }
}
