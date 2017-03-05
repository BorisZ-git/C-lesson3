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
            Fractions frs1 = new Fractions(3, 4);
            Fractions frs2 = new Fractions(3, 5);
            Fractions frs3 = new Fractions();
            frs3 = frs1.Plus(frs2);

        }
        class Fractions
        {
            // числитель
            int numerator;
            // знаменатель 
            int denominator;
            //constructor empty
            public Fractions()
            {

            }
            //constructor take value
            public Fractions(int numerator, int denominator)
            {
                this.denominator = denominator;
                this.numerator = numerator;
            }
            //Realize method Plus
            public Fractions Plus(Fractions x)
            {
                Fractions y = new Fractions();

                return y;
            }

        }
    }
}
