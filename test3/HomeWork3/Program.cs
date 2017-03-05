using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 *  Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
 *  Предусмотреть методы сложения, вычитания, умножения и деления дробей.
 *  Написать программу, демонстрирующую все разработанные элементы класса.
 *  Достаточно решить 2 задачи. Все программы сделайть в одном решении. 
 * */

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        class Numbers
        {
            // числитель
            int numerator;
            // знаменатель 
            int denominator;
            //constructor empty
            public Numbers()
            {

            }
            //constructor take value
            public Numbers(int numerator, int denominator)
            {
                this.denominator = denominator;
                this.numerator = numerator;
            }
            //Realize method Plus
            public Numbers Plus(Numbers x)
            {
                Numbers y = new Numbers();
                y.numerator = numerator + x.numerator;
                y.denominator = denominator + x.denominator;
                return y;
            }

        }
    }
}
