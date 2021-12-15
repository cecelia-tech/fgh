using System;
using TrainingManagementSystem.PracticalLessons;

namespace TrainingManagementSystem.Trainings
{
    public class Training
    {
        public const int ARRAY_SIZE = 10;
        private int index = 0;

        public string Description { get; set; } = string.Empty;

        public Training(string description)
        {
            Description = description;
        }

        Training[] allTrainings = new Training[ARRAY_SIZE];

        public void Add(Training lesson)
        {
            allTrainings[index] = lesson;
            index++;
        }

        public bool IsPractical()
        {
            for (int i = 0; i <= index; i++)
            {
                if (!(allTrainings[i] is PracticalLesson))
                {
                    return false;
                }
            }
            return true;
        }

        public Training Clone(Training trainingToClone)
        {
            Training clonedTraining = new Training(Description);
            clonedTraining.allTrainings = this.allTrainings;

            return clonedTraining;
        }
    }
}
