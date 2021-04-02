using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class Class1
    {
        //Task1
        public static List<object> GetIntegersFromList(List<object> input)
        {
            return input.Where(b => b is int).ToList();
        }
        //Task2
        public static string FirstNonRepeatingLetter(string input)
        {
            string upper = input.ToUpper();
            string lower = input.ToLower();
            char answer = input.FirstOrDefault(b=> lower.Count(f => f == b) == 1 || upper.Count(f => f == b) == 1);
            if (answer == '\0') { return ""; }
            return answer.ToString();
        }
        //Task3

        public static int FindDigitalRoot(int input)
        {
            string inputString = input.ToString();
            if(inputString.Length == 1)
            {
                return input;
            }
            else
            {
                int sum = 0;
                foreach(char num in inputString)
                {
                    sum += int.Parse(num.ToString());
                }
                return FindDigitalRoot(sum);
            }
        }

        //Task4

        public static int FindSumCount(int[] input, int target)
        {
            int ans = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == target)
                    {
                        ans++;
                    }
                }
            }
            return ans;
        }


        //Task5

        public static string SortByLast(string input)
        {
            string[] stringPeople = input.ToUpper().Split(';');
            if (stringPeople.Length == 1)
            {
                return "";
            }
            List<Person> people = new List<Person>();

            foreach(string name in stringPeople)
            {
                people.Add(new Person(name));
            }

            List<Person> sortedPeople = people.OrderBy(b=>b.Name).OrderBy(b => b.Surname).ToList();

            string answer = "";

            foreach(Person person in sortedPeople)
            {
                answer += person.NameWithBrackets();
            }

            return answer;
        }

        //Bonus Task1

        public static int FindNextBiggerNum(int input)
        {
            string inputString = input.ToString();
            for(int i = inputString.Length - 1; i >= 1; i--)
            {
                string lastChar = inputString[i].ToString();
                string firstChar = inputString[i - 1].ToString();

                if (int.Parse(lastChar) > int.Parse(firstChar))
                {
                    inputString = inputString.Remove(i - 1, 2).Insert(i-1, lastChar + firstChar);
                    return int.Parse(inputString);
                }
            }
            return -1;
        }

        //Bonus Task2


        public static string IntegerToIP(uint input)
        {
            byte bits1 = (byte)((input & 4278190080) >> 24);
            byte bits2 = (byte)((input & 16711680) >> 16);
            byte bits3 = (byte)((input & 65280) >> 8);
            byte bits4 = (byte)((input & 255));
            return bits1.ToString() + "." + bits2.ToString() + "." + bits3.ToString() + "." + bits4.ToString();
        }

    }


    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string fullName)
        {
            string[] names = fullName.Split(':');
            Name = names[0];
            Surname = names[1];
        }

        public string NameWithBrackets()
        {
            return "(" + Surname + ", " + Name + ")";
        }

    }


}
