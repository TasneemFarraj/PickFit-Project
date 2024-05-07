using Fittness.Data;
using Fittness.Data.Models;
using Fittness.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Fittness.Repository.Repo;

public class CertificateRepository : ICertificateRepository
{
    private readonly AppDBContext _db;

    public CertificateRepository(AppDBContext db)
    {
        _db = db;
    }
    public async Task AddCertificate(Certificate certificate)
    {

        await _db.Certificates.AddAsync(certificate);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteCertificate(int Id)
    {
        var data = await _db.Certificates.FindAsync(Id);
        if (data != null)
        {
            _db.Certificates.Remove(data);
            await _db.SaveChangesAsync();
        }
    }

    public async Task<Certificate> GetAsync(int Id)
    {
        var data = await _db.Certificates.FindAsync(Id);
        return data;
    }

    public async Task<List<Certificate>> GetListAsync()
    {
        var data = await _db.Certificates.ToListAsync();
        return data;
    }

    public async Task UpdateCertificate(Certificate certificate)
    {

        var data = await _db.Certificates.FindAsync(certificate.Id);
        if (data != null)
        {
            data.Id = certificate.Id;
            data.Img = certificate.Img;
        }
    }
}

