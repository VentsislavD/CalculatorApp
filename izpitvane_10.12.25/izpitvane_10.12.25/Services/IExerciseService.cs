using izpitvane_10._12._25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpitvane_10._12._25.Services
{
    public interface IExerciseService
    {
        void AddExercise(string name, int calories);
        List<Exercise> GetAllExercises();
        Exercise GetMaxCaloriesExercise();
        int GetTotalCalories();
    }

}
