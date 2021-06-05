using DevFitnes.API.Controllers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitnes.API.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, decimal height, decimal weight, DateTime birthDate) : base()
        {
            FullName = fullName;
            Height = height;
            Weight = weight;
            BirthDate = birthDate;
            Meals = new List<Meal>();
        }

        public string FullName { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public DateTime BirthDate { get; set; }

        public IEnumerable<Meal> Meals { get; set; }

        public void Update(decimal height, decimal weight)
        {
            Height = height;
            Weight = weight;
        }
    }
}
