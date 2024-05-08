using Fittness.AutoMapper;
using Fittness.Data;
using Fittness.Data.Enum;
using Fittness.Data.Models;
using Fittness.Dtos.CredDtos;
using Fittness.Response;
using Fittness.UnitOfWork;
using Fittness.Upload;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fittness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileUserController : ControllerBase
    {

        private readonly AppDBContext _db;
        private readonly IUOW _uOW;
        public ProfileUserController(AppDBContext db, IUOW uOW)
        {
            _db = db;
            _uOW = uOW;
        }

        [HttpGet(nameof(GetUserProfile))]
        public async Task<ResponseStandardJsonApi> GetUserProfile()
        {
            var apiResponse = new ResponseStandardJsonApi();

            try
            {
                var mapper = AutoMapperConfig.CreateMapper();
                var result = await _uOW.ProfileUser.GetListAsync();
                var data = mapper.Map<List<ReadProfileUserDto>>(result);


                if (data is not null)
                {
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = data;
                }
                else
                {
                    apiResponse.Success = false;
                    apiResponse.Message = "No Data";
                    apiResponse.Code = NotFound().StatusCode;
                    apiResponse.Result = new NullColumns[] { };
                }
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                apiResponse.Code = BadRequest().StatusCode;
                apiResponse.Result = new NullColumns[] { };
            }

            return apiResponse;
        }


        [HttpGet(nameof(GetUserProfileById))]
        public async Task<ResponseStandardJsonApi> GetUserProfileById(int Id)
        {
            var apiResponse = new ResponseStandardJsonApi();


            try
            {
                var mapper = AutoMapperConfig.CreateMapper();
                var result = await _uOW.ProfileUser.GetAsync(Id);
                var data = mapper.Map<ReadProfileUserDto>(result);
                if (data is not null)
                {
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = data;
                }
                else
                {
                    apiResponse.Success = false;
                    apiResponse.Message = "No Data";
                    apiResponse.Code = NotFound().StatusCode;
                    apiResponse.Result = new NullColumns[] { };
                }
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                apiResponse.Code = BadRequest().StatusCode;
                apiResponse.Result = new NullColumns[] { };
            }

            return apiResponse;
        }


        [HttpPost(nameof(AddUserProfile))]
        public async Task<ResponseStandardJsonApi> AddUserProfile([FromForm] WriteProfileUserDto dto)
        {
            var apiResponse = new ResponseStandardJsonApi();


            try
            {
                var mapper = AutoMapperConfig.CreateMapper();
                var data = mapper.Map<ProfileUser>(dto);
                if (dto.Img is not null)
                    data.Img = ImageUploader.Upload(dto.Img, FileTypeEnum.Image, "http://localhost:5266/");

                if (data is not null)
                {
                    await _uOW.ProfileUser.AddProfileUser(data);
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = data;
                }
                else
                {
                    apiResponse.Success = false;
                    apiResponse.Message = "No Data";
                    apiResponse.Code = NotFound().StatusCode;
                    apiResponse.Result = new NullColumns[] { };
                }
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                apiResponse.Code = BadRequest().StatusCode;
                apiResponse.Result = new NullColumns[] { };
            }

            return apiResponse;
        }



        [HttpPut(nameof(UpdateUserProfile))]
        public async Task<ResponseStandardJsonApi> UpdateUserProfile([FromForm] WriteProfileUserDto dto)
        {
            var apiResponse = new ResponseStandardJsonApi();

            try
            {
                var mapper = AutoMapperConfig.CreateMapper();
                var data = mapper.Map<ProfileUser>(dto);
                if (dto.Img is not null)
                    data.Img = ImageUploader.Upload(dto.Img, FileTypeEnum.Image, "http://localhost:5266/");
                await _uOW.ProfileUser.UpdateProfileUser(data);

                if (data is not null)
                {
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = data;
                }
                else
                {
                    apiResponse.Success = false;
                    apiResponse.Message = "No Data";
                    apiResponse.Code = NotFound().StatusCode;
                    apiResponse.Result = new NullColumns[] { };
                }
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                apiResponse.Code = BadRequest().StatusCode;
                apiResponse.Result = new NullColumns[] { };
            }

            return apiResponse;

        }


        [HttpDelete(nameof(RemoveUserProfile))]
        public async Task<ResponseStandardJsonApi> RemoveUserProfile(int id)
        {


            var apiResponse = new ResponseStandardJsonApi();

            try
            {
                await _uOW.ProfileUser.DeleteProfileUser(id);
                if (id != 0)
                {
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = Ok("Delete");
                }
                else
                {
                    apiResponse.Success = false;
                    apiResponse.Message = "No Data";
                    apiResponse.Code = NotFound().StatusCode;
                    apiResponse.Result = null;
                }
            }
            catch (Exception ex)
            {
                apiResponse.Success = false;
                apiResponse.Message = ex.Message;
                apiResponse.Code = BadRequest().StatusCode;
                apiResponse.Result = null;
            }

            return apiResponse;

        }
    }
}
   
