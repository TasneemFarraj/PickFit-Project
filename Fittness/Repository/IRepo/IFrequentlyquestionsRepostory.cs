using Fittness.Data.Models;

namespace Fittness.Repository.IRepo
{
    public interface IFrequentlyquestionsRepostory
    {
        Task<Frequently_question> GetAsync(int Id);
        Task<List<Frequently_question>> GetListAsync();
        Task Addquestion(Frequently_question question);
        Task Updatequestion(Frequently_question question);
        Task Deletequestion(int Id);
    }
}
