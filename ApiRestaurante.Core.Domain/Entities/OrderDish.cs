﻿using InternetBanking.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class OrderDish : AuditableBaseEntity
    {
        public int DishId { get; set; }
        public int OrderId { get; set; }
        public Dish JDish { get; set; }
        public Order JOrder { get; set; }
    }
}
