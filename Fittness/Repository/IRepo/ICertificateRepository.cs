using Fittness.Data.Models;

namespace Fittness.Repository.IRepo
{
    public interface ICertificateRepository
    {
        Task<Certificate> GetAsync(int Id);
        Task<List<Certificate>> GetListAsync();
        Task AddCertificate(Certificate certificate);
        Task UpdateCertificate(Certificate certificate);
        Task DeleteCertificate(int Id);
    }
}
