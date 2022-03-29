using System;

namespace _29Mart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your username:");
            string accountName = Console.ReadLine();
            User newUser = new User(accountName);
            Console.WriteLine("Write you password:");
            newUser.PassWord = Console.ReadLine();
            newUser.GetInfo(newUser.UserNameTool, newUser.PassWord);


        }
    }
}
