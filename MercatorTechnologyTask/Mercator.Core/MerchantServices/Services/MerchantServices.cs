using Mercator.Core.MerchantServices.Interface;
using Mercator.Data.Domain.AggregateModel.Entities;
using Mercator.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Core.MerchantServices.Services
{
    public class MerchantServices : IMerchantServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public MerchantServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Merchant entity)
        {
            _unitOfWork.Marchants.Add(entity);
        }

        public void Delete(long id)
        {
            _unitOfWork.Marchants.Delete(id);
        }

        public Merchant Get(long id)
        {
            return _unitOfWork.Marchants.Get(id);
        }

        public List<Merchant> GetAll()
        {
            return _unitOfWork.Marchants.GetAll();
        }

        public void Update(Merchant entity)
        {
            _unitOfWork.Marchants.Update(entity);
        }
    }

}

