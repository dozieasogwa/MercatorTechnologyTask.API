using Mercator.Core.MerchantServices.Interface;
using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Infrastructure;
using MercatorTechnologyTask.API.CreateModels;
using MercatorTechnologyTask.API.ReturnMerchantModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MercatorTechnologyTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchantServices _merchantServices;
        private readonly IUnitOfWork _unitOfWork;

        public MerchantController(IMerchantServices merchantServices, IUnitOfWork unitOfWork)
        {
            _merchantServices = merchantServices;
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateMerchantDTO createMerchantDTO)
        {
            try
            {
                if (createMerchantDTO != null)
                {
                    var merchant = new Merchant()
                    {
                        Name = createMerchantDTO.Name,
                        Adress = createMerchantDTO.Adress,
                        PhoneNumber = createMerchantDTO.PhoneNumber,
                        Email = createMerchantDTO.Email,
                    };
                    _merchantServices.Add(merchant);
                    await _unitOfWork.Save();
                  
                }
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);  
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAMerchant(int id)
        {
            var value = new MerchantReturnDTO();
            try
            {
                if (id != 0)
                {
                    var merchant = _merchantServices.Get(id);
                    if (merchant != null)
                    {

                        value.Id = merchant.Id;
                        value.Name = merchant.Name;
                        value.Adress = merchant.Adress;
                        value.PhoneNumber = merchant.PhoneNumber;
                        value.Email = merchant.Email;
                    }
                }
                return Ok(value);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
