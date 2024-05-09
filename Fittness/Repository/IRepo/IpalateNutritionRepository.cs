using Fittness.Data.Models;

namespace Fittness.Repository.IRepo;
public interface IpalateNutritionRepository
{
    Task<PalateNutrition> GetAsync(int Id);
    Task<List<PalateNutrition>> GetListAsync();
    Task AddPalateNutrition(PalateNutrition Nutrition);
    Task UpdatePalateNutrition(PalateNutrition Nutrition);
    Task DeletePalateNutrition(int Id);

}
