using Fittness.Data.Models;

namespace Fittness.Repository.IRepo
{
    public interface IPalatePrepareRepostory
    {
        Task<PalatePrepare> GetAsync(int Id);
        Task<List<PalatePrepare>> GetListAsync();
        Task AddPrepare(PalatePrepare Prepare);
        Task UpdatePrepare(PalatePrepare Prepare);
        Task DeletePrepare(int Id);
    }
}