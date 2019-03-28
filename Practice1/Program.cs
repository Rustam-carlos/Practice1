using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Написать приложение, которое выведет на экран Ваше имя и фамилию
            string name, second_name;
            name = "Рустам";
            second_name = "Галеев";

            Console.WriteLine("Практическое задание 1");
            Console.WriteLine("Вас приветствует");
            Console.WriteLine();
            Console.WriteLine("Имя \t\t- " + name);
            Console.WriteLine("Фамилия \t- " + second_name);

            //2.	Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму.

            int cnt;
            cnt = 1;
            Console.WriteLine("Plese input " + cnt + "\t numer");
            int x = int.Parse(Console.ReadLine());
            cnt++;
            Console.WriteLine("Plese input " + cnt + "\t numer");
            int y = int.Parse(Console.ReadLine());
            cnt++;
            Console.WriteLine("Plese input " + cnt + "\t numer");
            int z = int.Parse(Console.ReadLine());
            cnt++;
            Console.WriteLine("Plese input " + cnt + "\t numer");
            int k = int.Parse(Console.ReadLine());
            int sum = x + y + z + k;
            Console.WriteLine("Sum of " + cnt + "\t numers is equal to \t" + sum);
            Console.WriteLine("Good Luck");
        }
    }
}
