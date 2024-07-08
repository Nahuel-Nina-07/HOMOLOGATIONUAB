using Homologation.Domain.Common;
using Homologation.Domain.Models;

namespace Homologation.Domain.Repositories;

public interface IHomologationRepository:IRepository
{
    Task<HomologationModel> CreateHomologationAsync(HomologationModel model);
    Task<HomologationModel> UpdateAsync(HomologationModel model);
    Task DeleteAsync(HomologationModel model);
    Task<HomologationModel> GetByIdAsync(Guid id);
    Task<HomologationModel> GetByStateAsync(string state);
}