using Fittness.Data;
using Fittness.Data.Models;
using Fittness.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Fittness.Repository.Repo
{
    public class PalateRecipeRepostory : IPalateRecipeRepostory
    {
        private readonly AppDBContext _db;

        public PalateRecipeRepostory(AppDBContext db)
        {
            _db = db;
        }
        public async Task AddRecipe(PalateRecipe Recipe)
        {
            await _db.PalateRecipes.AddAsync(Recipe);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteRecipe(int Id)
        {
            var data = await _db.PalateRecipes.FindAsync(Id);
            if (data != null)
            {
                _db.PalateRecipes.Remove(data);
                await _db.SaveChangesAsync();
            }
        }

        public async Task UpdateRecipe(PalateRecipe Recipe)
        {
            var data = await _db.PalateRecipes.FindAsync(Recipe.Id);
            if (data != null)
            {
                data.Id = Recipe.Id;
                data.PreparationTime = Recipe.PreparationTime;
                data.CookingTime = Recipe.CookingTime;
                data.NumberOfPeople = Recipe.NumberOfPeople;
                data.DifficultyLevel = Recipe.DifficultyLevel;
                _db.PalateRecipes.Update(data);
                _db.SaveChanges();

            }
        }

        public async Task<PalateRecipe> GetAsync(int Id)
        {
            var data = await _db.PalateRecipes.FindAsync(Id);
            return data;
        }

        public async Task<List<PalateRecipe>> GetListAsync()
        {
            var data = await _db.PalateRecipes.ToListAsync();
            return data;
        }
    }
}
