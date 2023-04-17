using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercator.Core.TerminalServices.Interface;
using Mercator.Core.TransactionServices.Interface;
using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Infrastructure;

namespace Mercator.Core.TransactionServices.Services
{
    public class TransactionServices : ITransactionServices
    {

        private readonly IUnitOfWork _unitOfWork;

        public TransactionServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Transaction entity)
        {
            _unitOfWork.Transactions.Add(entity);
        }

        public void Delete(long id)
        {
            _unitOfWork.Transactions.Delete(id);
        }

        public Transaction Get(long id)
        {
            return _unitOfWork.Transactions.Get(id);
        }

        public List<Transaction> GetAll()
        {
            return _unitOfWork.Transactions.GetAll();
        }

        public void Update(Transaction entity)
        {
            _unitOfWork.Transactions.Update(entity);
        }
    }
}

