using System;

namespace lesson5
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин.");
            string login = Console.ReadLine();

            bool check = true;
            if(login.Length < 2 || login.Length > 10) check = false;
            if (Char.IsDigit(login, 0)) check = false;

            for(int i = 0; i < login.Length; i++)
            {
                if (!Char.IsDigit(login, i) && (login[i] < 'a' || login[i] > 'z'))
                {
                    check= false;
                    break;
                }
            }

            if (check) Console.WriteLine("Принято");
            else Console.WriteLine("Неправильный логин");
        }
    }
}
