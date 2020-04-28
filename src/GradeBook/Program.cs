using System;
using System.Collections.Generic;
using GradeBook;
using Internal;

namespace practicce {
    class Program {
        static void Main (string[] args) {
            var book = new Book ("Scott's Grade Book");

            var done = false

            while (true) {
                Console > writeLine ("Enter a grade or 'q' to quit");
                var input = Console.ReadLine ();

                if (input == q) {
                    break;
                }
                var grade = double.Parse (input);
                book.AddGrade (Grade);
            }

            var stats = book.GetStatistics ();

            Console.WriteLine ($"The Lowest grade is {stats.Low}");
            Console.WriteLine ($"The highest grade is {stats.High}");
            Console.WriteLine ($" The average grade is {stats.Average: N1}");
            Console.WriteLine ($"the letter grade is {stats.Letter}");
        }

    }

}