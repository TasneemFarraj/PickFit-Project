using Fittness.Data.Models;

namespace Fittness.Repository.IRepo
{
    public interface IPalateImgRepository
    {
        Task<PalateImg> GetAsync(int Id);
        Task<List<PalateImg>> GetListAsync();
        Task AddPalateImg(PalateImg palateimg);
        Task UpdatePalateImg(PalateImg palateimg);
        Task DeletePalateImg(int Id);
    }
}
