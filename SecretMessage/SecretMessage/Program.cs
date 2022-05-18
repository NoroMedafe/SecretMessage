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

            while (numberOfAttemptsAvailable >0)
            {
                Console.Write("Чтобы увидеть сообщение, введите пароль:");
                string currentInputPassword = Console.ReadLine();

                if (currentInputPassword != password)
                {
                    numberOfAttemptsAvailable--;
                    Console.WriteLine("Неверный пароль. Осталось попыток:" + numberOfAttemptsAvailable);
                }
                else
                {
                    Console.WriteLine(secretMessage);
                    continue;
                }

            }

            Console.ReadKey();
        }
    }
}
