﻿using InternetBanking.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Domain.Entities
{
    public class Ingredient:AuditableBaseEntity
    {
        public string Name { get; set; }

        #region Navigation Props
        public ICollection<Dish> Dishes { get; set; }
        public List<IngredientDish> IngredientDishes { get; set; }
        #endregion
    }
}
