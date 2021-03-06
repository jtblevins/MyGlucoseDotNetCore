﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGlucoseDotNetCore.Models
{
    public class MealItem
    {
        public Guid Id { get; set; }
        public Guid MealId { get; set; }
        public MealEntry Meal { get; set; }
        public string Name { get; set; }
        public int Carbs { get; set; }
        public int Servings { get; set; }

        public MealItem()
        {
            Meal = new MealEntry();
        }

    }
}
