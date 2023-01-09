using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Write the phone number: ");
        var phonenumber = Console.ReadLine();
        CheckMatch(phonenumber);
    }

    public static void CheckMatch(string phonenumber)
    {
        var reg = new Regex("^\\+(420|\\+421) ?[0-9]{3} ?[0-9]{3} ?[0-9]{3}$");
        if (!reg.IsMatch(phonenumber))
        {
            Console.WriteLine($"{phonenumber} is an incorrect format");
        }
        else
        {
            Console.WriteLine($"{phonenumber} is correct format");
        }
        Console.ReadLine();
    }
}