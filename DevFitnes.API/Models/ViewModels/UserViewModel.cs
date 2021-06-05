using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitnes.API.Models.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string fullName, decimal height, decimal weight, DateTime brithDate)
        {
            Id = id;
            FullName = fullName;
            Height = height;
            Weight = weight;
            BrithDate = brithDate;
        }

        public int Id { get; set; }
        public string FullName { get; private set; }
        public decimal Height { get; private set; }
        public decimal Weight { get; private set; }
        public DateTime BrithDate { get; private set; }
    }
}
