using Exame2tds.API.Models;

namespace Exame2tds.API.Repositories;

public interface IDataRepository
{
    Task<List<DataModel>> GetAllAsync();
    Task<DataModel> GetByIdAsync(string id);
    Task AddAsync(DataModel model);
    Task UpdateAsync(string id, DataModel model);
    Task DeleteAsync(string id);
}
