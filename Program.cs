using System;

namespace DailyCalorieTracker
{
    class Program
    {
        // Constant for the recommended daily calorie intake
        const int recommendedDailyIntake = 2000;

        // Read-only variable for calories consumed so far
        private static int _caloriesConsumed = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Daily Calorie Tracker");

            // Display recommended daily intake
            Console.WriteLine($"\nRecommended Daily Calorie Intake: {recommendedDailyIntake} kcal");

            // Ask the user to input calories for meals
            string input;
            do
            {
                Console.Write("\nEnter the calories for the meal (or type 'exit' to finish): ");
                input = Console.ReadLine();

                if (int.TryParse(input, out int mealCalories))
                {
                    // Add the meal's calories to the total consumed calories
                    AddCalories(mealCalories);

                    // Display the current intake and check if it exceeds the recommended limit
                    DisplayCurrentIntake();
                }
                else if (input.ToLower() != "exit")
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (input.ToLower() != "exit");

            // Final message
            Console.WriteLine("\nThank you for using the Daily Calorie Tracker.");
        }

        // Method to add calories to the read-only variable
        static void AddCalories(int mealCalories)
        {
            _caloriesConsumed += mealCalories;
        }

        // Method to display the current intake and compare it with the recommended limit
        static void DisplayCurrentIntake()
        {
            Console.WriteLine($"\nTotal Calories Consumed: {_caloriesConsumed} kcal");

            if (_caloriesConsumed <= recommendedDailyIntake)
            {
                Console.WriteLine("You are within your daily calorie limit.");
            }
            else
            {
                Console.WriteLine("Warning: You have exceeded your daily calorie limit!");
            }
        }
    }
}
