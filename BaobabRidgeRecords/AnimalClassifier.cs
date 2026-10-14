using System;
using System.Collections.Generic;
using System.Text;

namespace BaobabRidgeRecords
{
    public static class AnimalClassifier
    {
        public static void ClassifyAnimal(Animal animal)
        {
            if (animal.Score <= 19)
            { animal.Status = "Critical"; animal.HousingUnit = "Intensive Unit Care"; }

            else if (animal.Score <= 39)
            { animal.Status = "Serious"; animal.HousingUnit = "High-dependency Ward"; }

            else if (animal.Score <= 59)
            { animal.Status = "Stable"; animal.HousingUnit = "Recovery Ward"; }

            else if (animal.Score <= 79)
            { animal.Status = "Recovering"; animal.HousingUnit = "Outdoor Enclosure"; }

            else
            {
                animal.Status = "Release-Ready"; animal.HousingUnit = "Pre-Release Camp";
            }

        }
    }
}
