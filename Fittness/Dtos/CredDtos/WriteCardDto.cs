namespace Fittness.Dtos.CredDtos;

public class WriteCardDto
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string Phone { get; set; }
    public string Addrres { get; set; }
    public string Email { get; set; }
    public string WorkingDay { get; set; }
    public string Rating { get; set; }
    public IFormFile Img { get; set; }
}
public class WritePalateIngredientDto
{
    public int? Id { get; set; }
    public string item_1 { get; set; }
    public string item_2 { get; set; }
    public string item_3 { get; set; }
    public string item_4 { get; set; }
    public string item_5 { get; set; }
    public string item_6 { get; set; }
    public string item_7 { get; set; }
}
public class WritePalate1Dto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IFormFile Img { get; set; }
}
public class WritePalateImgDto
{
    public int Id { get; set; }
    public IFormFile Img { get; set; }
}
public class WriteCertificateDto
{
    public int Id { get; set; }
    public IFormFile Img { get; set; }
}
public class WriteProfileUserDto
{
    public int Id { get; set; }
    public IFormFile Img { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Country { get; set; }
}
public class WriteFrequentlyDto
{
    public int? Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }

}
public class WriteHomeDto
{
    public int? Id { get; set; }
    public string Name { get; set; }

}
public class WriteResipeDto
{
    public int Id { get; set; }
    public string PreparationTime { get; set; }
    public string CookingTime { get; set; }
    public int NumberOfPeople { get; set; }
    public string DifficultyLevel { get; set; }
}
public class WritePrepareDto
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
public class WritepalitnutritonDto
{
    public int Id { get; set; }
    public string Fats { get; set; }
    public string protein { get; set; }
    public string carbohydrates { get; set; }
    public string calories { get; set; }
}

