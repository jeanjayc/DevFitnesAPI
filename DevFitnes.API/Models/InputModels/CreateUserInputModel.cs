using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitnes.API.Models.InputModels
{
    public class CreateUserInputModel
    {
        public CreateUserInputModel(string fullName, decimal height, decimal weight, DateTime birthDate)
        {
            FullName = fullName;
            Height = height;
            Weight = weight;
            BirthDate = birthDate;
        }

        public string FullName { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
