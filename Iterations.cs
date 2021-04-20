using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        /*
           Welcome to Interation
           Down below you will find instructions for code to write.
           As you write and save your code, you can look in your terminal where you
           ran `dotnet watch test` to see if your code is working. The tests continuously check
           your work each time you save. If a test is failing you have not yet completed that method
           Once you finish a method and have it correct, the test will tell you how
           the next method is working.
        */
        //  
        // 0.5) Complete the method named `whispering` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to lowercase.
        //
        public static IEnumerable<string> Whispering(List<string> words)
        {
            var whispers = words.Select(word => word.ToLower());
            return whispers;
        }

        // 
        // 0.6) Complete the method BestDragonOfTheAge that accepts an list of
        //    dragon objects AND an age and returns the colors of dragons that are
        //    from that age AND have a health of 290 or more.
        // 
        // A movie object looks like this:
        // 
        // {
        //   color: "Green",
        //   health: 290,
        //   Age: 1455
        // }
        // 
        public static IEnumerable<string> BestDragonOfTheAge(List<Dragon> data, int age)
        {
            return data.Where(dragon => dragon.Age == age && dragon.Health >= 290).Select(dragon => dragon.Color);
        }

        //  
        // 1) Complete the method named `yelling` that takes an list of
        //    words as an argument and returns a new list with all
        //    the words forced to uppercase.
        //
        public static IEnumerable<string> Yelling(List<string> words)
        {
            return words.Select(word => word.ToUpper());
        }


        // 
        // 2) Complete the method named `Double` that takes an list of
        //    numbers as an argument and returns a new list with all
        //    the numbers multiplied by 2.
        // 
        public static IEnumerable<int> Double(List<int> numbers)
        {
            return numbers.Select(number => number * 2);
        }


        // 
        // 3) Complete the method `StringyIndexes` that takes an list of
        //    strings as an argument and returns a new list with each
        //    string suffixed with " is at index X" where X is the index
        //    of the element.
        // 
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            return data.Select((word, index) => $"{word} is at index {index}");
        }


        // 
        // 4) Complete the method OnlyTheEvenSurvive that accepts an list of
        //    numbers and returns only the elements that are even.
        // 
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            return data.Where((element) => element % 2 == 0);
        }


        // 
        // 5) Complete the method OnlyTheEvenIndexedSurvive that accepts an
        //    list of numbers and returns only the elements at indexes that
        //    are even.
        // 
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            return data.Where((element, index) => index % 2 == 0);
        }


        // 
        // 6) Complete the method BestMoviesOfTheYear that accepts an list of
        //    movie objects AND a year and returns the names of movies that are
        //    from that year AND have a score more than 90.
        // 
        // A movie object looks like this:
        // 
        // {
        //   name: "Get Out",
        //   year: "2017",
        //   score: 99
        // }
        // 
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
            return data.Where((movie) => movie.Year == year && movie.Score >= 90).Select(movie => movie.Name);
        }


        // 
        // 7) Complete the method EveryoneIsOdd that accepts an list of
        //    numbers and returns true if every element of the list is odd.
        // 
        public static bool EveryoneIsOdd(List<int> data)
        {
            return data.All(element => element % 2 != 0);
        }


        // 
        // 8) Complete the method FindTheNeedle that accepts an list of
        //    strings and returns the one string that contains the word
        //    `needle`.
        // 
        public static string FindTheNeedle(List<string> data)
        {
            return data.FirstOrDefault(word => word.Contains("needle"));
        }


        // 
        // 9) Complete the method FindTheNeedleIndex that accepts an list of
        //    strings and returns the index of the string that contains
        //    the word `needle` inside.
        // 
        public static int FindTheNeedleIndex(List<string> data)
        {
            return data.FindIndex(word => word.Contains("needle"));
            // var foundNeedle = data.FirstOrDefault(word => word.Contains("needle"));
            // return data.IndexOf(foundNeedle);
        }


        // 
        // 10) Complete the method SomeoneToLove that accepts an list of
        //     strings and returns true if at least one string is exactly
        //     four characters long.
        // 
        public static bool SomeoneToLove(List<string> data)
        {
            return data.Any(flower => flower.Length == 4);
        }
    }
}