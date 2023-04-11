﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercator.Data.Domain.AggregateModel.Entities
{
    public class Merchant
    {
        public long Id { get; set; }    
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Terminal> Terminals { get; set; }

    }
}
