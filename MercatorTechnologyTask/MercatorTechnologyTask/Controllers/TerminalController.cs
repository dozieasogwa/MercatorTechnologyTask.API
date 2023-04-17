using Mercator.Core.MerchantServices.Interface;
using Mercator.Core.MerchantServices.Services;
using Mercator.Core.TerminalServices.Interface;
using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Infrastructure;
using MercatorTechnologyTask.API.CreateModels;
using MercatorTechnologyTask.API.ReturnMerchantModel;
using Microsoft.AspNetCore.Mvc;

namespace MercatorTechnologyTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private readonly ITerminalServices _terminalServices;
        private readonly IUnitOfWork _unitOfWork;

        public TerminalController(ITerminalServices terminalServices, IUnitOfWork unitOfWork)
        {
            _terminalServices = terminalServices;
            _unitOfWork = unitOfWork;
        }

        //[HttpGet]
        // public IActionResult Index()
        [HttpPost]
        public async Task<IActionResult> Add(CreateTerminalDTO createTerminalDTO)
        {
            var terminal = new Terminal();
            try
            {
                if (createTerminalDTO != null)
                {


                    terminal.Location = createTerminalDTO.Location;
                    terminal.Terminaltype = createTerminalDTO.Terminaltype;
                    terminal.MerchantId = createTerminalDTO.MerchantId;

                    _terminalServices.Add(terminal);
                    await _unitOfWork.Save();

                }
                return Ok(terminal);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetATERMINAL(int id)
        {
            var value = new TerminalReturnDTO();
            try
            {
                if (id != 0)
                {
                    var terminal = _terminalServices.Get(id);
                    if (terminal != null)
                    {

                        value.Id = terminal.Id;
                        value.Terminaltype = terminal.Terminaltype;
                        value.Location = terminal.Location;
                        value.MerchantId = terminal.MerchantId;
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
        public async Task<IActionResult> DeleteATRANSACTION(long id)
        {
            if (id > 0)
            {
                _terminalServices.Delete(id);
                await _unitOfWork.Save();
                return Ok();
            }
            return BadRequest();
        }

    }
}
