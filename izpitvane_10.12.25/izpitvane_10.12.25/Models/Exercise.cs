using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitvane_10._12._25.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CaloriesBurned { get; set; }

        public Exercise(int id, string name, int caloriesBurned)
        {
            Id = id;
            Name = name;
            CaloriesBurned = caloriesBurned;
        }
    }
}
