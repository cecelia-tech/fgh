using System;
using TrainingManagementSystem.Lectures;
using TrainingManagementSystem.PracticalLessons;
using TrainingManagementSystem.Trainings;

namespace TrainingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Training training1 = new Training("Training 1");
            Lecture lecture1 = new Lecture("Lecture 1", "Topic 1");
            PracticalLesson practicalLesson1 = new PracticalLesson("Practical lecture 1", "Task 1", "Solution 1");

            training1.Add(lecture1);
            training1.Add(practicalLesson1);

            for (int i = 0; i < training1.Index; i++)
            {
                Console.WriteLine(training1.lecturesAndPracticalLessons[i].Description);
            }

            Console.WriteLine(training1.IsPractical());

            Training training2 = new Training("training 2");

            training2.Add(practicalLesson1);

            Console.WriteLine(training2.IsPractical());

            for (int i = 0; i < training2.Index; i++)
            {
                Console.WriteLine(training2.lecturesAndPracticalLessons[i].Description);
            }

            Training training3 = training1.Clone();

            training3.lecturesAndPracticalLessons[0] = practicalLesson1;

            Console.WriteLine("training 3");
            for (int i = 0; i < training3.Index; i++)
            {
                Console.WriteLine(training3.lecturesAndPracticalLessons[i].Description);
            }

            Console.WriteLine("training 1");
            for (int i = 0; i < training1.Index; i++)
            {
                Console.WriteLine(training1.lecturesAndPracticalLessons[i].Description);
            }

            Console.WriteLine("training3 IsPractical");
            Console.WriteLine(training3.IsPractical());

            Training training4 = new Training(null);

            Console.WriteLine(training4.Description);
        }
    }
}
