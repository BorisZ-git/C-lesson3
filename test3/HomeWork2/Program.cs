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
            Console.WriteLine("Введите число.Введите 0 если хотите остановиться: ");
            if (int.TryParse(Console.ReadLine(), out UserNum))
            {

            }
        }
    }
}
