using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BaobabRidgeRecords
{
    //Handles reading from and writing to animals.txt.
    public static class AnimalFileHandler                                                            
    {
        //The full path of animals.txt
        public static string FilePath = Path.Combine(Application.StartupPath, "animals.txt");

        //Checks if the ID already exists in the file and returns true if it does, false if it doesn't
        public static bool IdExists(string id)                                                
        {
            if (!File.Exists(FilePath))                                                       
            {
                return false;
            }

            string[] lines = File.ReadAllLines(FilePath);                                   

            foreach (string line in lines)
            {
                // Split the line at each | ; the ID is the first part (parts[0])
                string[] parts = line.Split('|');                                           

                if (parts[0].Trim().ToUpper() == id)
                {
                    return true;
                }
            }
            return false;
        }

        //Appends the animal's data to the file and never deletes what is already there
        public static void AppendAnimalToFile(Animal animal)                                
        {
            string newline = animal.ToFileLine() + Environment.NewLine;                    

            if (File.Exists(FilePath))
            {
                string fileText = File.ReadAllText(FilePath);

                // If the file has text but no line break at the end, add one first,
                // otherwise the new animal would be stuck onto the end of the last line
                if (fileText.Length > 0 && !fileText.EndsWith("\n"))                               
                {
                    newline = Environment.NewLine + newline;                               
                }
            }

            File.AppendAllText(FilePath, newline);
        }

        /* Add SaveAllAnimals method to rewrite animals.txt */
        public static void SaveAllAnimals(List<Animal> animals)
        {
            List<string> lines = new List<string>();
            foreach (Animal animal in animals) 
            {
                lines.Add(animal.ToFileLine());   
            }
            File.WriteAllLines(FilePath,lines );
        }
    }
}
