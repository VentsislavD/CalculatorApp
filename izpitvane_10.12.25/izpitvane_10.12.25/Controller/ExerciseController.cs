using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izpitvane_10._12._25.Models;
using izpitvane_10._12._25.Services;
using izpitvane_10._12._25.Views;

namespace izpitvane_10._12._25.Controller
{
    public class ExerciseController
    {
        private readonly ExerciseService exerciseService = new();
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("1 add");
                Console.WriteLine("2 list");
                Console.WriteLine("3 max");
                Console.WriteLine("4 total");
                Console.WriteLine("5 exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter exercise name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter calories burned: ");
                        int calories = int.Parse(Console.ReadLine());
                        exerciseService.AddExercise(name, calories);
                        break;
                    case "2":
                        var exercises = exerciseService.GetAllExercises();
                        foreach (var exercise in exercises)
                        {
                            Console.WriteLine($"ID: {exercise.Id}, Name: {exercise.Name}, Calories Burned: {exercise.CaloriesBurned}");
                        }
                        break;
                    case "3":
                        var maxExercise = exerciseService.GetMaxCaloriesExercise();
                        Console.WriteLine($"Exercise with max calories burned: ID: {maxExercise.Id}, Name: {maxExercise.Name}, Calories Burned: {maxExercise.CaloriesBurned}");
                        break;
                    case "4":
                        int totalCalories = exerciseService.GetTotalCalories();
                        Console.WriteLine($"Total calories burned: {totalCalories}");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

    }
}
