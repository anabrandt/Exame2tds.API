using Exame2tds.API.Models;
using MongoDB.Driver;

namespace Exame2tds.API.Repositories;

public class DataRepository : IDataRepository
{
    private readonly IMongoCollection<DataModel> _collection;

    public DataRepository(IMongoDatabase database)
    {
        _collection = database.GetCollection<DataModel>("Data");
    }

    public async Task<List<DataModel>> GetAllAsync() => await _collection.Find(_ => true).ToListAsync();

    public async Task<DataModel> GetByIdAsync(string id) =>
        await _collection.Find(d => d.Id == id).FirstOrDefaultAsync();

    public async Task AddAsync(DataModel model) => await _collection.InsertOneAsync(model);

    public async Task UpdateAsync(string id, DataModel model) =>
        await _collection.ReplaceOneAsync(d => d.Id == id, model);

    public async Task DeleteAsync(string id) => await _collection.DeleteOneAsync(d => d.Id == id);
}
