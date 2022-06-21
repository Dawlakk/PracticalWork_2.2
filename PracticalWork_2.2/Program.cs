using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Александр Васильевич Суворов";
            int age = 69;
            string Email = "victory@mail.ru";
            int ScoresProgramming = 98;
            int ScoresMath = 100;
            int ScoresPhysics = 97;

            Console.WriteLine("Ф.И.О.: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}",
                FullName, age, Email, ScoresProgramming, ScoresMath, ScoresPhysics);

            Console.ReadKey();

            int TotalScore = ScoresProgramming + ScoresMath + ScoresPhysics;
            double AverageScore = (double)TotalScore / 3;
            string fAverageScore = AverageScore.ToString("#.##");

            Console.WriteLine("\nОбщий балл: {0} \nСредний балл: {1}", TotalScore, fAverageScore);
            
            Console.ReadLine();
        }
    }
}
