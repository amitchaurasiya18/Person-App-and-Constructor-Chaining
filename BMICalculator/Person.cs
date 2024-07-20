using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public int Weight { get; set; }

        public const int HEIGHT = 5;
        public const int WEIGHT = 50;
        public const double FOOT_DIVISOR = 3.281;
        public const double UNDER_WEIGHT = 18.4;
        public const double NORMAL_WEIGTH_MAX = 24.9;
        public const double OVER_WEIGHT_MAX = 29.9;

        public static double MaxBMI = 0.0;
        public double maxBMI;


        public Person(int id, string name, int age) : this(id, name, age, HEIGHT, WEIGHT)
        {
        }

        public Person(int id, string name, int age, double height, int weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Height = height;
            Weight = weight; 
        }

        public double CalculateBMIScore(double height, int weight)
        {
            double bmiScore = weight / Math.Pow((height / FOOT_DIVISOR), 2);
            return bmiScore;
        }

        public string PrintBMIStatus(Person person)
        {
            double bmiScore = person.CalculateBMIScore(person.Height, person.Weight);
            person.maxBMI = bmiScore;

            if (bmiScore <= UNDER_WEIGHT)
                return $"Name : {person.Name} => BMI Score : {bmiScore} => You're Under-Weight";
            if (bmiScore > UNDER_WEIGHT && bmiScore <= NORMAL_WEIGTH_MAX)
                return $"Name : {person.Name} => BMI Score : {bmiScore} => You're normal";
            if (bmiScore > NORMAL_WEIGTH_MAX && bmiScore <= OVER_WEIGHT_MAX)
                return $"Name : {person.Name} => BMI Score : {bmiScore} => You're Over-Weight";
            
            return $"Name : {person.Name} => BMI Score : {bmiScore} => You're suffering from Obesity";
        }

        public double ReturnMaxBMI(Person[] persons)
        {   
            foreach(Person person in persons)
            {
                if (person.maxBMI > MaxBMI)
                {
                    MaxBMI = person.maxBMI;
                }
            }
            return MaxBMI;
        }


    }
}
