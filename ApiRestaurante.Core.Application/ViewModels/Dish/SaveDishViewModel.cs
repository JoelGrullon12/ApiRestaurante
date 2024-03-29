﻿using ApiRestaurante.Core.Application.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiRestaurante.Core.Application.ViewModels.Dish
{
    public class SaveDishViewModel : BaseViewModel
    {
        [JsonIgnore]
        public override int Id { get; set; }

        [Required(ErrorMessage ="Debe proporcionar un nombre")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Debe proporcionar un precio")]
        public double Price { get; set; }
        
        [Required(ErrorMessage ="Debe proporcionar una cantidad de personas maxima")]
        public int People { get; set; }
        
        [Required(ErrorMessage ="Debe proporcionar una categoria")]
        public int Category { get; set; }
        public List<int> IngredientIds { get; set; }
    }
}
