using Fittness.Data.Models;

namespace Fittness.Repository.IRepo
{
    public interface IProfileUserRepository
    {
        Task<ProfileUser> GetAsync(int Id);
        Task<List<ProfileUser>> GetListAsync();
        Task AddProfileUser(ProfileUser profileuser);
        Task UpdateProfileUser(ProfileUser profileuser);
        Task DeleteProfileUser(int Id);
    }
}
