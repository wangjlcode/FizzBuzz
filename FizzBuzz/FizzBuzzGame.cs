﻿using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int number)
        {
            if (number % 3 == 0)
            {
                if (number % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else
                {
                    return "Fizz";
                }
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
