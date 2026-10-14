using System;
using System.Collections.Generic;
using System.Text;

namespace BaobabRidgeRecords
{
    public class Animal
    {
        public string Id { get; set; } = ""; 
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";

        public int Age { get; set; }

        public int Score { get; set; }

        public string Status { get; set; } = "";

        public string HousingUnit { get; set; } = "";

        public string ToFileLine() //Set animal data to a line for animal.txt while fields are separated by a pipe | character
        {
            return $"{Id} | {Name} | {Species} | {Age} | {Score} | {Status} | {HousingUnit}";
        }

    }

}
