using AutoMapper;
using Fittness.Data.Models;
using Fittness.Dtos.CredDtos;
using Fittness.Dtos.UserDtos;

namespace Fittness.AutoMapper;

public class AutoMapperConfig
{
    public static IMapper CreateMapper()
    {
        var MapConfig = new MapperConfiguration(M =>
        {
            M.CreateMap<Card, ReadCardDto>().ReverseMap();
            M.CreateMap<Card, WriteCardDto>().ReverseMap();
            M.CreateMap<PalateIngredient, ReadPalateIngredientDto>().ReverseMap();
            M.CreateMap<PalateIngredient, WritePalateIngredientDto>().ReverseMap();
            M.CreateMap<User, UserDto>().ReverseMap();
            M.CreateMap<User, LoginDto>().ReverseMap();
            M.CreateMap<User, WriteUserDto>().ReverseMap();
            M.CreateMap<Frequently_question, WriteFrequentlyDto> ().ReverseMap();
            M.CreateMap<Home, WriteHomeDto>().ReverseMap();
            M.CreateMap<PalateRecipe, WriteResipeDto>().ReverseMap();
            M.CreateMap<PalatePrepare, WritePrepareDto>().ReverseMap();
            M.CreateMap<PalateNutrition, WritepalitnutritonDto> ().ReverseMap();


        });
        return MapConfig.CreateMapper();
    }
}

