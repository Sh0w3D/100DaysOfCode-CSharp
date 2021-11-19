/*
 * created by Kamil Oberaj on 18.11.2022 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using _100DaysOfCode.Day1LINQ;

namespace _100DaysOfCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Declaration of new test list
            var List = new List<string>();

            Declaration of function that takes int as arg and returns int
            Func<int, int> function = (a) => { return 0; };

            
            Declaration of an Action that Writes some text and does not
            return any type of data
            
            Action function2 = () => { Console.WriteLine("Hello World!"); };

            
            Using the declared function:
            function();
            function2();
            function.Invoke();
            function2.Invoke();
            */

            var listInt = new List<int>
            {
                1, 3, 2, 4, 5, 6
            };

            var listStr = new List<string>
            {
                "100",
                "Days",
                "Of",
                "Code",
                "Day1",
                "LINQ"
            };


            var userList = new List<User>
            {
                new User
                {
                    FirstName = "User1",
                    LastName = "1User",
                    Age = 11
                },
                new User
                {
                    FirstName = "Author",
                    LastName = "Code",
                    Age = 19
                },
                new User
                {
                    FirstName = "Test",
                    LastName = "User",
                    Age = 65,
                    Email = "testuser@linq.com"
                }
            };

            /*
             *  Select data from listInt list
             * var testList = listInt.Select(x => x + 2).ToArray();
             *   Select data from listStr list
             *  userList.Select(x =>new{first = x.FirstName,second = x.LastName});
             *  var listofempty = userList.Where(x => x.LastName == "1User").First();
             *  Console.WriteLine(listofempty.LastName + " " + listofempty.LastName);
             *   Sorting string list
             *  var sortedStrings = listStr.OrderBy(x => x).ToList();
             *  sortedStrings.ForEach(x =>
             *  {
             *      Console.WriteLine(x);
             *  });
             *  userList.Where(x => x != null).GroupBy(x => x.Age).ToList().ForEach(x =>
             *  {
             *      Console.Write(x.Key + " > ");
             *  x.ToList().ForEach(y =>
             *  {
             *      Console.WriteLine(y.FirstName + " " + y.LastName + " " + y.Email);
             *      });
             *  });
             */
        }
    }
}
