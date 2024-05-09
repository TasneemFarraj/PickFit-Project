using Fittness.Data;
using Fittness.Data.Models;
using Fittness.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Fittness.Repository.Repo
{
    public class PalateNutritionRepostory : IpalateNutritionRepository
    {

        private readonly AppDBContext _db;

        public PalateNutritionRepostory(AppDBContext db)
        {
            _db = db;
        }
        public async Task AddPalateNutrition(PalateNutrition Nutrition)
        {

            await _db.PalateNutritions.AddAsync(Nutrition);
            await _db.SaveChangesAsync();
        }

        public async Task DeletePalateNutrition(int Id)
        {
            var data = await _db.PalateNutritions.FindAsync(Id);
            if (data != null)
            {
                _db.PalateNutritions.Remove(data);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<PalateNutrition> GetAsync(int Id)
        {
            var data = await _db.PalateNutritions.FindAsync(Id);
            return data;
        }

        public async Task<List<PalateNutrition>> GetListAsync()
        {
            var data = await _db.PalateNutritions.ToListAsync();
            return data;
        }

        public async Task UpdatePalateNutrition(PalateNutrition Nutrition)
        {
            var data = await _db.PalateNutritions.FindAsync(Nutrition.Id);
            if (data != null)
            {
                data.Id = Nutrition.Id;
                data.Fats = Nutrition.Fats;
                data.protein = Nutrition.protein;
                data.carbohydrates = Nutrition.carbohydrates;
                data.calories = Nutrition.calories;

                _db.PalateNutritions.Update(data);
                _db.SaveChanges();
            }
        }
    }
}
