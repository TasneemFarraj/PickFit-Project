using Fittness.Data;
using Fittness.Data.Models;
using Fittness.Repository.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Fittness.Repository.Repo
{
    public class FrequentlyquestionRepostory : IFrequentlyquestionsRepostory
    {
        private readonly AppDBContext _db;

        public FrequentlyquestionRepostory(AppDBContext db)
        {
            _db = db;
        }
        public async Task Addquestion(Frequently_question question)
        {
            await _db.Frequently_questions.AddAsync(question);
            await _db.SaveChangesAsync();
        }
        public async Task Deletequestion(int Id)
        {
            var data = await _db.Frequently_questions.FindAsync(Id);
            if (data != null)
            {
                _db.Frequently_questions.Remove(data);
                await _db.SaveChangesAsync();
            }
        }
        public async Task<Frequently_question> GetAsync(int Id)
        {
            var data = await _db.Frequently_questions.FindAsync(Id);
            return data;
        }
        public async Task<List<Frequently_question>> GetListAsync()
        {
            var data = await _db.Frequently_questions.ToListAsync();
            return data;
        }
        public async Task Updatequestion(Frequently_question question)
        {
            var data = await _db.Frequently_questions.FindAsync(question.Id);
            if (data != null)
            {
                data.Question = question.Question;
                data.Answer = question.Answer;

                _db.Frequently_questions.Update(data);
                _db.SaveChanges();
            }
        }
    }
}
