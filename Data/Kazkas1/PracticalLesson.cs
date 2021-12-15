using System;
using TrainingManagementSystem.Trainings;

namespace TrainingManagementSystem.PracticalLessons
{
    public class PracticalLesson : Training
    {
        public string Task { get; set; } = string.Empty;
        public string Solution { get; set; } = string.Empty;

        public PracticalLesson(string description, string task, string solution) :
                               base(description)
        {
            Task = task;
            Solution = solution;
        }
    }
}
