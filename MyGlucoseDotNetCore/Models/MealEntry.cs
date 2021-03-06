﻿using System;
using System.Collections.Generic;

namespace MyGlucoseDotNetCore.Models
{
    public class MealEntry
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public ApplicationUser User { get; set; }
        public int TotalCarbs { get; set; }
        public DateTime Date { get; set; }
        public long Timestamp { get; set; }

        public List<MealItem> MealItems { get; set; }

        public MealEntry()
        {
            MealItems = new List<MealItem>();

        }

    }
}