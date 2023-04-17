using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercator.Data.Domain.AggregateModel.Entities;

namespace Mercator.Core.TerminalServices.Interface
{
    public interface ITerminalServices
    {
        Terminal Get(long id);
        void Delete(long id);
        void Add(Terminal entity);
        List<Terminal> GetAll();
        void Update(Terminal entity);
    }
}
