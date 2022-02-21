using System;

namespace PlayingWithVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declared and initalized a variable.
            int dogAge = 5;
            string dogName = "Reef";
            bool likesHiking = true;
            char nickName = 'R';
            double bones = 2;
            decimal weight = 50.3m;

            //string interpolation with the $ and { } around variables
            Console.WriteLine($"My dog's name is {dogName}. She is {dogAge} years old and she has {bones} bones and it is {likesHiking} that she loves to hike, which keeps her at her weight of {weight}");


        }
    }
}
