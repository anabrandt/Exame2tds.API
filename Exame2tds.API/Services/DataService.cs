using Exame2tds.API.Models;
using Exame2tds.API.Repositories;

namespace Exame2tds.API.Services;

public class DataService
{
    private readonly IDataRepository _repository;

    public DataService(IDataRepository repository) => _repository = repository;

    public Task<List<DataModel>> GetAllAsync() => _repository.GetAllAsync();

    public Task<DataModel> GetByIdAsync(string id) => _repository.GetByIdAsync(id);

    public Task AddAsync(DataModel model) => _repository.AddAsync(model);

    public Task UpdateAsync(string id, DataModel model) => _repository.UpdateAsync(id, model);

    public Task DeleteAsync(string id) => _repository.DeleteAsync(id);
}
