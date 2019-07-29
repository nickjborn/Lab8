using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> studentList = MakeStudentList();
            Console.WriteLine(studentList[2]);

            //bool shouldContinue = false;
            //do
            //{
            //    Console.Clear();
            //    List<string[]> studentList = MakeStudentList();
            //    Console.WriteLine(studentList[2]);

            //    Dictionary<int, string[]> studentDicionary = MakeDictionary();
            //    int selectedStudent = AskUserForStudent();
            //    InterpretStudentData(selectedStudent, studentDicionary);
            //    shouldContinue = AskToContinue();

            //} while (shouldContinue);

            //Console.WriteLine("Alrighy then! See ya!");

        }

        static Dictionary<int, string[]> MakeDictionary()
        {
            string[] studentData = new string[3];
            Dictionary<string, string[]> studentDictionary = new List<string[]>();

            studentDictionary["name"] = new[] { "FavoriteColor", "Hometown", "FavoriteFood" };

            studentDictionary["Bob"] = new[] { "Red", "Denver", "Pizza" };
            studentDictionary["Frank"] = new[] { "Blue", "Tucson", "Burritos" };
            studentDictionary["Debbie"] = new[] { "Green", "Flagstaff", "Carrots" };
            studentDictionary["Sue"] = new[] { "Yellow", "Chicago", "Mayonnaise" };
            studentDictionary["Mark"] = new[] { "Orange", "New York", "Tuna sandwich" };
            studentDictionary["Damien"] = new[] { "Pink", "Boston", "Bread" };
            studentDictionary["Angie"] = new[] { "Red", "Los Angles", "Pasta" };
            studentDictionary["Carol"] = new[] { "Blue", "Anchorage", "Hummus" };
            studentDictionary["Luke"] = new[] { "Blue", "Melbourne", "Cheese" };
            studentDictionary["Stan"] = new[] { "Black", "Detroit", "Beans" };
            studentDictionary["Karen"] = new[] { "Purple", "Seattle", "Chicken" };
            studentDictionary["Amy"] = new[] { "Red", "Portland", "Eggs" };
            studentDictionary["Derek"] = new[] { "Blue", "Nashville", "Toast" };
            studentDictionary["John"] = new[] { "Yellow", "Jacksonville", "Cookies" };
            studentDictionary["Ellen"] = new[] { "Blue", "Birmingham", "Cake" };
            studentDictionary["Courtney"] = new[] { "Orange", "Aberdeen", "Egg rolls" };
            studentDictionary["Fred"] = new[] { "Red", "London", "Rice" };
            studentDictionary["Zed"] = new[] { "Green", "Toronto", "Baklava" };
            studentDictionary["Mariah"] = new[] { "Blue", "Lima", "Candy" };
            studentDictionary["Lauren"] = new[] { "Red", "Bismark", "Beef" };


            return studentDictionary;
        }

        static List<string[]> MakeStudentList()
        {
          
            List<string[]> studentList = new List<string[]>();

            studentList.add("name","Name", "Hometown", "FavoriteFood");

            studentList.add("Bob", "Red", "Denver", "Pizza");
            studentList.add("Frank", "Blue", "Tucson", "Burritos");
            studentList.add("Debbie", "Green", "Flagstaff", "Carrots");
            studentList.add("Sue", "Yellow", "Chicago", "Mayonnaise");
            studentList.add("Mark", "Orange", "New York", "Tuna sandwich");
            studentList.add("Damien", "Pink", "Boston", "Bread");
            studentList.add("Angie", "Red", "Los Angles", "Pasta");
            studentList.add("Carol", "Blue", "Anchorage", "Hummus");
            studentList.add("Luke", "Blue", "Melbourne", "Cheese");
            studentList.add("Stan", "Black", "Detroit", "Beans");
            studentList.add("Karen", "Purple", "Seattle", "Chicken");
            studentList.add("Amy", "Red", "Portland", "Eggs");
            studentList.add("Derek", "Blue", "Nashville", "Toast");
            studentList.add("John", "Yellow", "Jacksonville", "Cookies");
            studentList.add("Ellen", "Blue", "Birmingham", "Cake");
            studentList.add("Courtney", "Orange", "Aberdeen", "Egg rolls");
            studentList.add("Fred", "Red", "London", "Rice");
            studentList.add("Zed", "Green", "Toronto", "Baklava");
            studentList.add("Mariah", "Blue", "Lima", "Candy");
            studentList.add("Lauren", "Red", "Bismark", "Beef");

            return studentList;

        }

        static int AskUserForStudent()
        {
            Console.WriteLine("Which student would you like to learn more about? (enter a  number 1-20):");
            int studentNumber = 0;
            bool validNumber = false;

            do
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out studentNumber))
                {
                    if (studentNumber <= 20 && studentNumber > 0)
                    {
                        validNumber = true;
                    }
                    else
                    {
                        validNumber = false;
                        Console.WriteLine("Hmm... that doesn't seem to be a student in this class... try another number, 1-20");
                    }
                }
                else
                {
                    Console.WriteLine("That's not even a number... try that again.");
                    validNumber = false;
                }

            } while (!validNumber);


            return studentNumber;

        }

        static void InterpretStudentData(int student, Dictionary<int, string[]> studentDicionary)
        {
            string[] studentData = studentDicionary[student];
            bool validInput = false;
            int desiredInfo = 0;

            Console.WriteLine($"Ah yes, {studentData[0]}. What would you like to know about them? (hometown/favorite food)");

            do
            {
                string userInput = Console.ReadLine().ToLower();
                    if (userInput == "hometown")
                    {
                        Console.WriteLine($"Oh, {studentData[0]}? They're from {studentData[1]}.");
                        return;
                    }
                    else if (userInput == "favorite food")
                    {
                         Console.WriteLine($"Oh, {studentData[0]}? Their favorite food is {studentData[2]}.");
                         return;
                    }
                    else
                    {
                        Console.WriteLine("Hmm... this is embarrising, I don't know what you mean. You'll need to type either 'hometown' or 'favorite food'.");
                        validInput = false;
                    }

            } while (!validInput);

            
        }

        static bool AskToContinue()
        {
            bool shouldContinue = true;
            bool validInput = false;

            Console.WriteLine("Want to go again? (y/n)");
            do
            {
                string input = Console.ReadLine().ToLower();
                if(input == "y")
                {
                    validInput = true;
                    shouldContinue = true;
                }
                else if (input == "n")
                {
                    validInput = true;
                    shouldContinue = false;
                }
                else
                {
                    Console.WriteLine("Well, that's not the answer I was looking for... type either 'y' or 'n' to continue");
                    validInput = false;
                }


            } while (!validInput);
            


            return shouldContinue;
        }
        


    }
}
