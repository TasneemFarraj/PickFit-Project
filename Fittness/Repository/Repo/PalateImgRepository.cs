using Fittness.Data;
using Fittness.Data.Models;
using Fittness.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Fittness.Repository.Repo;

    public class PalateImgRepository : IPalateImgRepository
    {
        private readonly AppDBContext _db;

        public PalateImgRepository(AppDBContext db)
        {
            _db = db;
        }
        public async Task AddPalateImg(PalateImg palateimg)
        {

            await _db.PalatesImg.AddAsync(palateimg);
            await _db.SaveChangesAsync();
        }

        public async Task DeletePalateImg(int Id)
        {
            var data = await _db.PalatesImg.FindAsync(Id);
            if (data != null)
            {
                _db.PalatesImg.Remove(data);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<PalateImg> GetAsync(int Id)
        {
            var data = await _db.PalatesImg.FindAsync(Id);
            return data;
        }

        public async Task<List<PalateImg>> GetListAsync()
        {
            var data = await _db.PalatesImg.ToListAsync();
            return data;
        }

        public async Task UpdatePalateImg(PalateImg palateimg)
        {
            var data = await _db.PalatesImg.FindAsync(palateimg.Id);
            if (data != null)
            {
            data.Id = palateimg.Id;
            data.Img = palateimg.Img;
                _db.PalatesImg.Update(data);
                _db.SaveChanges();
            }
        }
}
