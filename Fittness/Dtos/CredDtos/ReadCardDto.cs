
using System.ComponentModel.DataAnnotations;

namespace Fittness.Dtos.CredDtos;

public class ReadCardDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string Phone { get; set; }
    public string Addrres { get; set; }
    public string Email { get; set; }
    public string WorkingDay { get; set; }
    public string Rating { get; set; }
    public string Img { get; set; }


}
public class ReadPalateIngredientDto
{
    public int Id { get; set; }
    public string item_1 { get; set; }
    public string item_2 { get; set; }
    public string item_3 { get; set; }
    public string item_4 { get; set; }
    public string item_5 { get; set; }
    public string item_6 { get; set; }
    public string item_7 { get; set; }
}
public class ReadPalate1Dto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Img { get; set; }

}
public class ReadPalateImgDto
{
    public int Id { get; set; }
    public string Img { get; set; }
}
public class ReadCertificateDto
{
    public int Id { get; set; }
    public string Img { get; set; }
}
    public class ReadProfileUserDto
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
public class ReadfrequentlyquestionsDto
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
}
public class ReadHomeDto
{

    public int Id { get; set; }
    public string Name { get; set; }

}
public class ReadRecipeDto
{

    public int Id { get; set; }
    public string PreparationTime { get; set; }
    public string CookingTime { get; set; }
    public int NumberOfPeople { get; set; }
    public string DifficultyLevel { get; set; }


}
public class ReadPrepareDto
{
    public int Id { get; set; }
    public string step_1 { get; set; }
    public string step_2 { get; set; }
    public string step_3 { get; set; }
    public string step_4 { get; set; }
    public string step_5 { get; set; }
    public string step_6 { get; set; }
    public string step_7 { get; set; }
}
public class ReadpalitNutritonDto
{
    public int Id { get; set; }
    public string Fats { get; set; }
    public string protein { get; set; }
    public string carbohydrates { get; set; }
    public string calories { get; set; }
}


