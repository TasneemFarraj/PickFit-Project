using Fittness.Data.Models;

namespace Fittness.Repository.IRepo
{
    public interface IPalateRecipeRepostory
    {
        Task<PalateRecipe> GetAsync(int Id);
        Task<List<PalateRecipe>> GetListAsync();
        Task AddRecipe(PalateRecipe Recipe);
        Task UpdateRecipe(PalateRecipe Recipe);
        Task DeleteRecipe(int Id);
    }
}
