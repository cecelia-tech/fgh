using System;
using TrainingManagementSystem.Trainings;

namespace TrainingManagementSystem.Lectures
{
    public class Lecture : Training
    {
        public string Topic { get; set; } = string.Empty;

        public Lecture(string description, string topic) : base(description)
        {
            Topic = topic;
        }
    }
}
