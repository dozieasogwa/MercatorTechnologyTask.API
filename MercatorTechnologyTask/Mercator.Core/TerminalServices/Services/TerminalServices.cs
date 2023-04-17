using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercator.Core.TerminalServices.Interface;
using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Infrastructure;

namespace Mercator.Core.TerminalServices.Services
{
    public class TerminalServices : ITerminalServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public TerminalServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Terminal entity)
        {
            _unitOfWork.Terminals.Add(entity);
        }

        public void Delete(long id)
        {
            _unitOfWork.Terminals.Delete(id);
        }

        public Terminal Get(long id)
        {
            return _unitOfWork.Terminals.Get(id);
        }

        public List<Terminal> GetAll()
        {
            return _unitOfWork.Terminals.GetAll();
        }

        public void Update(Terminal entity)
        {
            _unitOfWork.Terminals.Update(entity);
        }
    }

}

