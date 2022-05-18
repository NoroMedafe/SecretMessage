using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = "Ты отгадал пароль!";
            string password = "123";
            int numberOfAttemptsAvailable = 3;

            for (int i = 0; i < numberOfAttemptsAvailable; i++)
            {

                Console.Write("Чтобы увидеть сообщение, введите пароль:");
                string currentInputPassword = Console.ReadLine();

                if (currentInputPassword != password)
                {
                    Console.WriteLine("Неверный пароль. Использовано попыток:" + (i+1));
                }
                else
                {
                    Console.WriteLine(secretMessage);
                    Console.ReadKey();

                    return;
                }
            }

        }
    }
}
