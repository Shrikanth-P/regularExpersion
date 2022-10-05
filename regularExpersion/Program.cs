using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class RegularExpression
    {
        public static void Main()
        {
            ValidateMobileNumber("9625432156");
            ValidateMobileNumber("96254326");
            ValidateMobileNumber("6254321568");
        }
        public static void ValidateMobileNumber(string mobileNumber)
        {
            
            int count  = mobileNumber.Length;
            if (count < 10 || count > 10)
            {
                Console.WriteLine("Pls Enter 10 digits phone number ");
            }
            else
            {
                var validate_mobile = Regex.IsMatch(mobileNumber, @"^([7-9]{1})([0-9]{9})$");

                if (validate_mobile)
                {
                    Console.WriteLine($"Valid Mobile Number : {mobileNumber}");
                }
                else
                {
                    Console.WriteLine($"Invalid Mobile Number Because  Number Must starts with 9 or 8 or 7");
                }
            }
        }
    }
}