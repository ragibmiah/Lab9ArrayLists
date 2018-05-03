using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class!");
            //Here are the arrays set for the code
            ArrayList students = new ArrayList();
            ArrayList hometown = new ArrayList();
            ArrayList favoriteFood = new ArrayList();
            ArrayList colors = new ArrayList();

            students.Add("Ragib");
            students.Add("Jerald");
            students.Add("Anamul");
            students.Add("Dannyelle");
            students.Add("Noelle");

            hometown.Add("Detroit");
            hometown.Add("Jupiter");
            hometown.Add("Atlanta");
            hometown.Add("Dearborn");
            hometown.Add("New York");

            favoriteFood.Add("Candy");
            favoriteFood.Add("Jam");
            favoriteFood.Add("Apples");
            favoriteFood.Add("Donuts");
            favoriteFood.Add("Nectarines");

            colors.Add("Purple");
            colors.Add("Blue");
            colors.Add("Red");
            colors.Add("Yellow");
            colors.Add("Orange");



            bool success = true;
            //I set the while loop to true so i can loop back around
            while (success)
            {
                Console.Write("Which student would you like to learn more about? (enter a number 1-5) or do you want to add another student? (Type add): ");
                string input = Console.ReadLine();
                int num;
                int.TryParse(input, out num);

                if (input.ToLower() == "add")
                {
                    Regex Validation = new Regex(@"[0-9]");
                    bool goTo = true;


                    //I used a while loop inside an if statement to add the new student.
                    //I tried to account for the validation of an empty space and numbers within the inputs.
                    while (goTo)
                    {
                        Console.Write("Please enter a name: ");
                        string newStudent = Console.ReadLine();
                        if (newStudent == "")
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                        else if (Validation.IsMatch(newStudent))
                        {
                            Console.WriteLine("Thats not a name");
                            break;
                        }
                        else
                        {
                            students.Add(newStudent);
                        }
                        Console.Write("Please enter hometown: ");
                        string newHometown = Console.ReadLine();
                        if (newHometown == "")
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                        else if (Validation.IsMatch(newHometown))
                        {
                            Console.WriteLine("Thats not a hometown.");
                            break;
                        }
                        else
                        {
                            hometown.Add(newHometown);
                        }
                        Console.Write("Please enter favorite food: ");
                        string newFood = Console.ReadLine();
                        if (newFood == "")
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                        else if (Validation.IsMatch(newFood))
                        {
                            Console.WriteLine("Thats not a food.");
                            break;
                        }
                        else
                        {
                            favoriteFood.Add(newFood);
                        }
                        Console.Write("Please enter a favorite color: ");
                        string newColor = Console.ReadLine();
                        if (newColor == "")
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                        else if (Validation.IsMatch(newColor))
                        {
                            Console.WriteLine("Thats not a color.");
                            break;
                        }
                        else
                        {
                            //I wanted to show that the adds were apart of the arraylist.
                            colors.Add(newColor);
                            Console.WriteLine($"Count(Logical Size): {students.Count}");
                            Console.WriteLine($"Count(Logical Size): {hometown.Count}");
                            Console.WriteLine($"Count(Logical Size): {favoriteFood.Count}");
                            Console.WriteLine($"Count(Logical Size): {colors.Count}");
                            goTo = false;
                        }
                    }
                }
                else
                {
                    success = true;
                }
                num--;
                if (num >= 0 && num < students.Count)
                {
                    //Allows the user to input what data they want
                    Console.Write($"Student {num + 1} is {students[num]}. What would you like to know about {students[num]}? (enter \"hometown\" or \"favorite food\" or \"favorite color\"):  ");
                    string answer = Console.ReadLine().ToLower();
                    //Based on the input i allowed a few methods of validation to either start over or exit/
                    if (answer == "hometown")
                    {
                        Console.WriteLine($"{students[num]} is from {hometown[num]}. Would you like to know more? (enter \"yes\" or \"no\"): ");
                        string answertwo = Console.ReadLine().ToLower();

                        if (answertwo == "yes")
                        {
                            success = true;
                        }
                        else
                        {
                            success = false;
                        }
                    }
                    else if (answer == "favorite food")
                    {
                        Console.Write($"{students[num]} favorite food is {favoriteFood[num]}. Would you like to know more? (enter \"yes\" or \"no\"): ");
                        string answertwo = Console.ReadLine().ToLower();

                        if (answertwo == "yes")
                        {
                            success = true;
                        }
                        else
                        {
                            success = false;
                        }

                    }
                    else if (answer == "favorite color")
                    {
                        Console.Write($"{students[num]} favorite color is {colors[num]}. Would you like to know more? (enter \"yes\" or \"no\"): ");
                        string answertwo = Console.ReadLine().ToLower();

                        if (answertwo == "yes")
                        {
                            success = true;
                        }
                        else
                        {
                            success = false;
                        }
                    }
                    else
                    {
                        //Here for validation
                        //TODO fix the try again
                        Console.WriteLine("That data does not exist. Please try again.");
                        return;
                    }
                }
            }
        }
    }
}

