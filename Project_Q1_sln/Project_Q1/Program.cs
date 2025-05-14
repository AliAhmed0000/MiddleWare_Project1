using System;
using System.Collections.Generic;
using System.IO;

namespace Project_Q1
{
    internal class Program
    {

        //===== Question 1 =====//
        #region question1
        static void StudentMarkCalculator_arr()
        {
            Console.Write("Please enter number of students: ");
            int students_count = int.Parse(Console.ReadLine());

            double[] students_grades = new double[students_count];
            string[] students_names = new string[students_count];

            //=== Grades Entry ===//
            for (int i = 0; i < students_count; i++)
            {
                Console.Write("Student #" + (i + 1) + " name: ");
                students_names[i] = Console.ReadLine();
                Console.Write("Student " + students_names[i] + "\'s grade: ");
                students_grades[i] = double.Parse(Console.ReadLine());
            }

            //=== Highest, Lowest and Average ===//
            double min = 101, max = 0, avg = 0;
            for (int i = 0; i < students_count; i++)
            {
                avg += students_grades[i];
                if (students_grades[i] <= min)
                {
                    min = students_grades[i];
                }
                if (students_grades[i] >= max)
                {
                    max = students_grades[i];
                }

            }
            avg /= students_count;

            Console.WriteLine($"Highest mark = {max}, Lowest mark = {min}, Average = {avg}");
        }
        static void StudentMarkCalculator_list()
        {
            
            List<double> students_grades = new List<double>();
            List<string> students_names = new List<string>();

            //=== Grades Entry ===//
            Console.WriteLine("Press \'x\' to exit operation");
            char key = '0';
            int count = 0;
            while (key != 'x')
            {
                Console.Write("Student #" + (count + 1) + " name: ");
                students_names.Add(Console.ReadLine());
                Console.Write("Student " + students_names[count] + "\'s grade: ");
                students_grades.Add(double.Parse(Console.ReadLine()));
                count++;
                Console.Write("Press \'Enter\' to continue or \'x\' to exit operation: ");
                key = char.Parse(Console.ReadLine());
            }
            
            //=== Highest, Lowest and Average ===//
            double min = 101, max = 0, avg = 0;
            foreach (var student in students_grades)
            {
                avg += student;
                if (student <= min)
                {
                    min = student;
                }
                if (student >= max)
                {
                    max = student;
                }
            }
            avg /= count;

            Console.WriteLine($"Highest mark = {max}, Lowest mark = {min}, Average = {avg}");
        }
        #endregion
        //===== End of Question 1 =====//
        //===== Question 2 =====//
        #region question2
        static void QuizGame()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Quiz Game!");
                StreamReader sr = new StreamReader("C:\\Users\\20114\\source\\repos\\Project_Q1_sln\\Project_Q1\\Q2_q_and_a.txt");
                string line = sr.ReadLine();
                int score = 0;
                while (line != null)
                {
                    Console.WriteLine(line);
                    //ToUpper() is used to give the user the freedom to use any case
                    //so that the format won't affect the correct answer
                    string user_ans = Console.ReadLine().ToUpper();
                    string ans = sr.ReadLine().ToUpper();
                    int result = String.Compare(ans, user_ans);
                    if (result == 0)
                        score += 10;
                    line = sr.ReadLine();
                }
                Console.WriteLine("Your score is: " + score);
                Console.WriteLine("Press any key to restart or press \'x\' to exit...");

                Console.WriteLine();
                //ReadKey() is used here instead of ReadLine()
                //as ReadLine throws an exception if enter, escape or other special keys are pressed
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.KeyChar == 'x' || key.KeyChar == 'X')
                {
                    sr.Close();
                    break;
                }
                else
                {
                    continue;
                }
                
            }
        }
        #endregion
        //===== End of Question 2 =====//
        //===== Question 3 =====//
        #region question3
        static void BudgetTracker()
        {
            Dictionary<string, int> incomes = new Dictionary<string, int>();
            Dictionary<string, int> expenses = new Dictionary<string, int>();

            //Recording incomes
            Console.WriteLine("Welcome to Basic Budget Tracker!");
            Console.WriteLine("Please enter the income values and their sources:");
            while (true)
            {
                //reading the key name and value
                Console.Write("Enter income source: ");
                string key = Console.ReadLine();
                Console.Write("Enter income value: ");
                incomes[key] = int.Parse(Console.ReadLine());
                Console.WriteLine("Press \'n\' to record expenses or any key to keep recording income...");

                ConsoleKeyInfo next_key = Console.ReadKey(true);
                if (next_key.KeyChar == 'n')
                    break;
            }

            //Recording expenses
            Console.WriteLine();
            Console.WriteLine("Please enter your expenses values and their sources:");
            while (true)
            {
                //reading the key name and value
                Console.Write("Enter expense source: ");
                string key = Console.ReadLine();
                Console.Write("Enter expense value: ");
                expenses[key] = int.Parse(Console.ReadLine());
                Console.WriteLine("Press \'n\' to finish recording or any key to keep recording income...");

                ConsoleKeyInfo next_key = Console.ReadKey(true);
                if (next_key.KeyChar == 'n')
                    break;
            }
            Console.WriteLine();
            int current_balance = 0, total_income = 0, total_expenditure = 0;
            //current balance = total income - total expenditure
            //total expenditure = total expenses
            //Calculating total income
            foreach (var income in incomes)
            {
                total_income += income.Value;
            }
            //Calculating total expenses
            foreach (var expense in expenses)
            {
                total_expenditure += expense.Value;
            }
            current_balance = total_income - total_expenditure;

            //writintg in a text file
            StreamWriter sw = new StreamWriter("C:\\Users\\20114\\source\\repos\\Project_Q1_sln\\Project_Q1\\budget_data.txt");
            sw.WriteLine("Income: ");
            foreach (var income in incomes)
            {
                sw.WriteLine($"\t{income.Key}: {income.Value}");
            }
            sw.WriteLine("===================");
            sw.WriteLine($"Total income: {total_income}");
            sw.WriteLine("===================");
            sw.WriteLine("Expenses:");
            foreach (var expense in expenses)
            {
                sw.WriteLine($"\t{expense.Key}: {expense.Value}");
            }
            sw.WriteLine("===================");
            sw.WriteLine($"Total expenditure: {total_expenditure}");
            sw.WriteLine("===================");
            sw.WriteLine($"Current balance: {current_balance}");
            sw.Close();
        }
        #endregion
        //===== End of Question 3 =====//
        //===== Question 4 =====//
        static void TemperatureConverter()
        {
            //char x = '0';
            while (true) {
                Console.Clear();
                Console.WriteLine("Welcome to the Temperature Converter!");
                Console.Write("1. Celsius to Fahrenheit\n2. Celsius to Kelvin\n" +
                    "3. Fahrenheit to Celsius\n4. Fahrenheit to Kelvin\n" +
                    "5. Kelvin to Celsius\n6. Kelvin to Fahrenheit\n");

                Console.Write("Please choose a conversion from the menu above: ");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Enter Temperature's value: ");
                double temp = double.Parse(Console.ReadLine());
                TempConvert tempConvert;
                switch (choice)
                {
                    case 1:
                        tempConvert = Celsius_To_Fahrenheit;
                        Console.WriteLine($"Celsius (before): {temp}, Converted to Fahrenheit: {tempConvert(temp):F3}");
                        break;
                    case 2:
                        tempConvert = Celsius_To_Kelvin;
                        Console.WriteLine($"Celsius (before): {temp}, Converted to Kelvin: {tempConvert(temp):F3}");
                        break;
                    case 3:
                        tempConvert = Fahrenheit_To_Celsius;
                        Console.WriteLine($"Fahrenheit (before): {temp}, Converted to Celsius: {tempConvert(temp):F3}");
                        break;
                    case 4:
                        tempConvert = Fahrenheit_To_Kelvin;
                        Console.WriteLine($"Fahrenheit (before): {temp}, Converted to Kelvin: {tempConvert(temp):F3}");
                        break;
                    case 5:
                        tempConvert = Kelvin_To_Celsius;
                        Console.WriteLine($"Kelvin (before): {temp}, Converted to Celsius: {tempConvert(temp):F3}");
                        break;
                    case 6:
                        tempConvert = Kelvin_To_Fahrenheit;
                        Console.WriteLine($"Kelvin (before): {temp}, Converted to Kelvin: {tempConvert(temp):F3}");
                        break;

                    default:
                        Console.WriteLine("Out of range value chosen, default configuration is activated");
                        Console.Write($"Celsius (before): {temp}");
                        tempConvert = Celsius_To_Fahrenheit;
                        Console.WriteLine($"Converted to Fahrenheit: {tempConvert(temp):F3}");
                        break;
                }
                //Console.WriteLine($"Before: {temp}, Converted: {tempConvert(temp):F3}");
                Console.WriteLine("Press any key to continue or \'x\' to exit:");
                
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.KeyChar == 'x' || key.KeyChar == 'X')
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        #region question4
        public delegate double TempConvert(double temperature);

        public static double Celsius_To_Fahrenheit(double c) => (c * (9.0/5)) + 32;
        public static double Celsius_To_Kelvin(double c) => c + 273.15;
        public static double Fahrenheit_To_Celsius(double f) => (f - 32) * (5.0/9);
        public static double Fahrenheit_To_Kelvin(double f) => Fahrenheit_To_Celsius(f) + 273.15;
        public static double Kelvin_To_Celsius(double k) => k - 273.15;
        public static double Kelvin_To_Fahrenheit(double k) => Celsius_To_Fahrenheit(Kelvin_To_Celsius(k));
        #endregion
        //===== End of Question 4 =====//
        static void Main(string[] args)
        {

            //StudentMarkCalculator_arr();
            Console.WriteLine();


            //QuizGame();
            //
            //BudgetTracker();

            TemperatureConverter();
        }
    }
}
