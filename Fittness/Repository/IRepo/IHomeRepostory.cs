using Fittness.Data.Models;

namespace Fittness.Repository.IRepo;
public interface IHomeRepostory
{
    Task<Home> GetAsync(int Id);
    Task<List<Home>> GetListAsync();
    Task Addhome(Home home);
    Task Updatehome(Home home);
    Task Deletehome(int Id);
}