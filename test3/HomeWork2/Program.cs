using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * 2.1  С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
 * Требуется подсчитать сумму всех нечетных положительных чисел.
 * Сами числа и сумму вывести на экран; Используя tryParse;
 * 2.2 Добавить обработку исключительных ситуаций на то, что могут быть введены не корректные данные.
 *  При возникновении ошибки вывести сообщение. 
 *  */

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello
            Console.WriteLine("Вводите числа.Введите 0 если хотите остановиться: ");

            //2.1            
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {DoWhileParse()}");
            Console.ReadLine();
            //2.2
        }

        static int DoWhileParse()
        {
            int sum = 0;
            int UserNum;
            bool flag;
            do
            {
                Console.Write("Введите число: ");
                flag = int.TryParse(Console.ReadLine(), out UserNum);
                if (flag)
                {
                    if (UserNum % 2 != 0 && UserNum % 2 > 0)
                    {
                        sum = sum + UserNum;
                    }
                    if (UserNum == 0)
                    {
                        Console.WriteLine("Осуществляем выход");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка вы ввели не число");
                    flag = true;
                }
            } while (flag);
            return sum;
        }
    }
}
