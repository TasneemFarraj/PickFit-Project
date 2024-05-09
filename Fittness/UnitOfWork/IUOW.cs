using Fittness.Data.Models;
using Fittness.Repository.IRepo;
using Fittness.Repository.Repo;
using Microsoft.Extensions.Hosting;

namespace Fittness.UnitOfWork;
public interface IUOW
{ 
    public IUserRepository User { get; set; }
    public ICardRepository Card { get; set; }
    public IPalateIngredientRepository PalateIngredient { get; set; }
    public IPalate1Repository Palate1 { get; set; }
    public IPalateImgRepository PalateImg { get; set; }
    public ICertificateRepository Certificate { get; set; }
    public IProfileUserRepository ProfileUser { get; set; }
    public IFrequentlyquestionsRepostory frequentlyquestions { get; set; }
    public IHomeRepostory home { get; set; }
    public IPalateRecipeRepostory PalateRecipe { get; set; }
    public IPalatePrepareRepostory PalatePrepare { get; set; }
    public IpalateNutritionRepository PalateNutrition { get; set; }


}
