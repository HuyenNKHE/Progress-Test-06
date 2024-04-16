using Progress_Test_6;
using System;
using System.Collections.Generic;

public class User : IUserPro, IUserMethod
{
    private List<int?> PhoneList = new List<int?>();

    public int ID { get; private set; }
    public string Name { get; private set; }
    public string Password { get; private set; }

    public int? this[int index]
    {
        get
        {
            if (index >= 0 && index < PhoneList.Count)
                return PhoneList[index];
            else
                return null;
        }
        set
        {
            if (index >= 0 && index < PhoneList.Count)
                PhoneList[index] = value;
            else if (index == PhoneList.Count)
                PhoneList.Add(value);
        }
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Password: {Password}");
        Console.WriteLine("Phone Numbers:");
        foreach (var phone in PhoneList)
        {
            Console.WriteLine(phone);
        }
    }

    public User(int id, string name, string password)
    {
        ID = id;
        Name = name;
        Password = password;
    }
}
