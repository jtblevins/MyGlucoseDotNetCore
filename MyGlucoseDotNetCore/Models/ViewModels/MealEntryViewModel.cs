using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGlucoseDotNetCore.Models.ViewModels
{
    public class MealEntryViewModel
    {
        public string UserName { get; set; }
        public ApplicationUser User { get; set; }
        public int TotalCarbs { get; set; }
        public DateTime Date { get; set; }
        public long Timestamp { get; set; }
        public List<MealItem> MealItems { get; set; }

		public MealEntry GetNewMealEntry()
		{
			return new MealEntry
			{
    			UserName = UserName,
    			User = User,
    			TotalCarbs = TotalCarbs,
    			Date = Date,
    			Timestamp = Timestamp
			};

		} // GetNewMealEntry

    } // Class

} // Namespace