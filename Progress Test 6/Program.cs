using Progress_Test_6;
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, IUserPro> users = new Dictionary<int, IUserPro>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Check User");
            Console.WriteLine("3. Display all Users");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Console.WriteLine();


            switch (choice)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    CheckUser();
                    break;
                case "3":
                    DisplayAllUsers();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    static void AddUser()
    {
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Password:");
        string password = Console.ReadLine();

        User newUser = new User(users.Count + 1, name, password);

        Console.WriteLine("Enter number of phones:");
        int numPhones = int.Parse(Console.ReadLine());
        for (int i = 0; i < numPhones; i++)
        {
            Console.WriteLine($"Enter phone {i + 1}:");
            int phone = int.Parse(Console.ReadLine());
            newUser[i] = phone;
        }

        users.Add(newUser.ID, newUser);
    }

    static void CheckUser()
    {
        Console.WriteLine("Enter ID:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Password:");
        string password = Console.ReadLine();

        if (users.ContainsKey(id) && users[id].Name == name && users[id].Password == password)
        {
            Console.WriteLine("User Checked");
        }
        else
        {
            Console.WriteLine("User not found");
        }
    }

    static void DisplayAllUsers()
    {
        foreach (var user in users.Values)
        {
            user.Display();
        }
    }
}
