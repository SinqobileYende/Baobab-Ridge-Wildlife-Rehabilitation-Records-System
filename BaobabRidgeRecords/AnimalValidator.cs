using System;
using System.Collections.Generic;
using System.Text;

namespace BaobabRidgeRecords
{
    public static class AnimalValidator  //Validation rules for the Animal class 
    {
        public static bool IsValidId(string id) //  Validates that the ID is in the correct format: WR-0000, e.g WR-0007
        {
            if (string.IsNullOrEmpty(id))
            {
                return false;

            }


            if (id.Length != 7)
            {
                return false;
            }


            if (!id.StartsWith("WR-"))
            {
                return false;
            }


            for (int i = 3; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i]))
                {
                    return false;
                }
            }


            return true;
        }
        public static bool IsValidText(string text)
        {
            if (text.Length < 1 || text.Length > 30)
            {
                return false;
            }


            if (text.Contains("|"))
            {
                return false;
            }


            return true;
        }

        public static bool IsValidNumber(string text, out int number) //Validates that the text is a whole number : Age and Recovery Score
        {
            if (!int.TryParse(text, out number)) // Check if the text can be parsed to a number, and if its a "abc" or "12.3" it will return false
            {
                return false;
            }


            if (number < 0 || number > 100)
            {
                return false;
            }

            return true;

        }
    }
}

