using izpitvane_10._12._25.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izpitvane_10._12._25.Models;

namespace izpitvane_10._12._25.Services
{
    public class ExerciseService : IExerciseService
    {
        private List<Exercise> exercises;
        private int Id;
        private int MaxCalories = 0;
        private int TotalCalories = 0;
        public void Add(string name, int calories)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("naem cannot be null or empty");
            }
            if(calories <= 0)
            {
                throw new ArgumentException("calories must be negative number or zero");
            }
            exercises.Add(new Exercise(Id++, name, calories));
        }
        public List<Exercise> GetAllExercises()
        {
           if(exercises.Count <= 0)
            {
                throw new InvalidOperationException("no exercises available");
            }
              return exercises;
        }
        public int GetCaloriesExersice()
        {
            for(int i = 0; i < exercises.Count; i++)
            {
                if (exercises[i].CaloriesBurned > MaxCalories)
                {
                    MaxCalories = exercises[i].CaloriesBurned;
                }
            }
            return MaxCalories;
        }
        public int GetTotalCalories()
        {
           foreach(var exersice in exercises)
            {
                TotalCalories += exersice.CaloriesBurned;
                if (exersice.CaloriesBurned <= 0)
                {
                    throw new ArgumentException(GetCaloriesExersice "cannot be negative or zero");
                }
            }
            return TotalCalories;
        }
    }
}
