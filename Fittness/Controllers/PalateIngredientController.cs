﻿using AutoMapper;
using Fittness.AutoMapper;
using Fittness.Data;
using Fittness.Data.Enum;
using Fittness.Data.Models;
using Fittness.Dtos.CredDtos;
using Fittness.Repository.Repo;
using Fittness.Response;
using Fittness.UnitOfWork;
using Fittness.Upload;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fittness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalateIngredientController : ControllerBase
    {
        private readonly AppDBContext _db;
        private readonly IUOW _uOW;
        public PalateIngredientController(AppDBContext db, IUOW uOW)
        {
            _db = db;
            _uOW = uOW;
        }


        [HttpGet(nameof(GetPalateIngrads))]
        public async Task<ResponseStandardJsonApi> GetPalateIngrads()
        {
            var apiResponse = new ResponseStandardJsonApi();

            try
            {
            var mapper = AutoMapperConfig.CreateMapper();
            var result = await _uOW.PalateIngredient.GetListAsync();
            var Palate = mapper.Map<List<ReadPalateIngredientDto>>(result);

            
                if (Palate is not null)
                {
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = Palate;
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


        [HttpGet(nameof(GetPalateIngradsById))]
        public async Task<ResponseStandardJsonApi> GetPalateIngradsById(int Id)
        {
            var apiResponse = new ResponseStandardJsonApi();

            try
            {
            var mapper = AutoMapperConfig.CreateMapper();
            var result = await _uOW.PalateIngredient.GetAsync(Id);
            var Palate = mapper.Map<ReadCardDto>(result);

            
                if (Palate is not null)
                {
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = Palate;
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



        [HttpPost(nameof(AddPalateIngrads))]
        public async Task<ResponseStandardJsonApi> AddPalateIngrads([FromForm] WritePalateIngredientDto dto)
        { 
            var apiResponse = new ResponseStandardJsonApi();

            try
            {
            var mapper = AutoMapperConfig.CreateMapper();
            var Palate = mapper.Map<PalateIngredient>(dto);
            await _uOW.PalateIngredient.AddPalateIngredient(Palate);

          
                if (Palate is not null)
                {
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = Palate;
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

        [HttpPut(nameof(UpdatePalateIngrads))]
        public async Task<ResponseStandardJsonApi> UpdatePalateIngrads([FromForm] WritePalateIngredientDto dto)
        {
            var apiResponse = new ResponseStandardJsonApi();

            try
            {
                var mapper = AutoMapperConfig.CreateMapper();
                var Palate = mapper.Map<PalateIngredient>(dto);
                await _uOW.PalateIngredient.UpdatePalateIngredient(Palate);

                if (Palate is not null)
                {
                    apiResponse.Message = "Show Rows";
                    apiResponse.Code = Ok().StatusCode;
                    apiResponse.Success = true;
                    apiResponse.Result = Palate;
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

        [HttpDelete(nameof(id))]
        public async Task<ResponseStandardJsonApi> RemovePalateIngrads(int id)
        {
            {
                await _uOW.PalateIngredient.DeletePalateIngredient(id);

                var apiResponse = new ResponseStandardJsonApi();

                try
                {
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
}
    
