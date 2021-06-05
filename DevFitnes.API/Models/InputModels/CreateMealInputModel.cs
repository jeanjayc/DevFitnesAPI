using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitnes.API.Models.InputModels
{
    public class CreateMealInputModel
    {
        public CreateMealInputModel(string description, int calories, DateTime date, int userId)
        {
            Description = description;
            Calories = calories;
            Date = date;
            
        }

        public string Description { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
    }
}
