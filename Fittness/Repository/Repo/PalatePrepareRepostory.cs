using Fittness.Data;
using Fittness.Data.Models;
using Fittness.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Fittness.Repository.Repo
{
    public class PalatePrepareRepostory : IPalatePrepareRepostory
    {
        private readonly AppDBContext _db;

        public PalatePrepareRepostory(AppDBContext db)
        {
            _db = db;
        }
        public async Task AddPrepare(PalatePrepare Prepare)
        {
            await _db.PalatePrepares.AddAsync(Prepare);
            await _db.SaveChangesAsync();
        }

        public async Task DeletePrepare(int Id)
        {
            var data = await _db.PalatePrepares.FindAsync(Id);
            if (data != null)
            {
                _db.PalatePrepares.Remove(data);
                await _db.SaveChangesAsync();
            }
        }

        public Task<PalatePrepare> GetAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PalatePrepare>> GetListAsync()
        {
            var data = await _db.PalatePrepares.ToListAsync();
            return data;
        }

        public async Task UpdatePrepare(PalatePrepare Prepare)
        {
            var data = await _db.PalatePrepares.FindAsync(Prepare.Id);
            if (data != null)
            {
                data.step_1 = Prepare.step_1;
                data.step_2 = Prepare.step_2;
                data.step_3 = Prepare.step_3;
                data.step_4 = Prepare.step_4;
                data.step_5 = Prepare.step_5;
                data.step_6 = Prepare.step_6;
                data.step_7 = Prepare.step_7;


                _db.PalatePrepares.Update(data);
                _db.SaveChanges();
            }
        }
    }
}
