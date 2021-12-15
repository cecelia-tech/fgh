using System;
using TrainingManagementSystem.PracticalLessons;

namespace TrainingManagementSystem.Trainings
{
    public class Training
    {
        public const int ARRAY_SIZE = 10;
        public int Index { get; private set; } = 0;

        public string Description { get; set; } = string.Empty;

        public Training(string description)
        {
            Description = description;
        }

        public Training[] lecturesAndPracticalLessons = new Training[ARRAY_SIZE];

        public void Add(Training lesson)
        {
            lecturesAndPracticalLessons[Index] = lesson;
            Index++;
        }

        public bool IsPractical()
        {
            for (int i = 0; i < Index; i++)
            {
                if (!(lecturesAndPracticalLessons[i] is PracticalLesson))
                {
                    return false;
                }
            }
            return true;
        }

        public Training Clone()
        {
            Training clonedTraining = (Training) this.MemberwiseClone();
            clonedTraining.lecturesAndPracticalLessons = new Training[ARRAY_SIZE];
            Array.Copy(this.lecturesAndPracticalLessons, clonedTraining.lecturesAndPracticalLessons,Index);

            clonedTraining.Index = this.Index;

            return clonedTraining;
        }
    }
}
