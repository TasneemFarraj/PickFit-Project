using Fittness.Data;
using Fittness.Data.Models;
using Fittness.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Fittness.Repository.Repo
{
    public class HomeRepostory : IHomeRepostory
    {
        private readonly AppDBContext _db;

        public HomeRepostory(AppDBContext db)
        {
            _db = db;
        }

        public async Task Addhome(Home home)
        {

            await _db.Homes.AddAsync(home);
            await _db.SaveChangesAsync();

        }

        public async Task Deletehome(int Id)
        {
            var data = await _db.Homes.FindAsync(Id);
            if (data != null)
            {
                _db.Homes.Remove(data);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<Home> GetAsync(int Id)
        {
            var data = await _db.Homes.FindAsync(Id);
            return data;
        }

        public async Task<List<Home>> GetListAsync()
        {
            var data = await _db.Homes.ToListAsync();
            return data;
        }

        public async Task Updatehome(Home home)
        {
            var data = await _db.Homes.FindAsync(home.Id);
            if (data != null)
            {
                data.Id = home.Id;
                data.Name = home.Name;
                _db.Homes.Update(data);
                _db.SaveChanges();
            }
        }
    }
}
