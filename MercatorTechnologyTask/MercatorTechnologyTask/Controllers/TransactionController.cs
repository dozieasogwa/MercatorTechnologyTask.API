using Mercator.Core.TerminalServices.Interface;
using Mercator.Core.TerminalServices.Services;
using Mercator.Core.TransactionServices.Interface;
using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Infrastructure;
using MercatorTechnologyTask.API.CreateModels;
using MercatorTechnologyTask.API.ReturnMerchantModel;
using Microsoft.AspNetCore.Mvc;

namespace MercatorTechnologyTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionServices _transactionServices;
        private readonly IUnitOfWork _unitOfWork;

        public TransactionController(ITransactionServices transactionServices, IUnitOfWork unitOfWork)
        {
            _transactionServices = transactionServices;
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateTransactionDTO createTransactionDTO)
        {
            try
            {
                if (createTransactionDTO != null)
                {
                    var transaction = new Transaction()
                    {
                        Amount = createTransactionDTO.Amount,
                        CardType = createTransactionDTO.CardType,
                        RRN = createTransactionDTO.RRN
                    };
                    _transactionServices.Add(transaction);
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
        public async Task<IActionResult> GetATRANSACTION(int id)
        {
            var value = new TransactionReturnDTO();
            try
            {
                if (id != 0)
                {
                    var transaction = _transactionServices.Get(id);
                    if (transaction != null)
                    {
                        value.Id = transaction.Id;
                        value.Amount = transaction.Amount;
                        value.CardType = transaction.CardType;
                        value.RRN = transaction.RRN;

                    }
                }
                return Ok(value);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteATRANSACTION(int id)
        {
            if (id > 0)
            {
                _transactionServices.Delete(id);
                await _unitOfWork.Save();
                return Ok();
            }
            return BadRequest();
        }

    }

}
