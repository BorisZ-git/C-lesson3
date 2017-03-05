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
            Console.WriteLine(3 % 5);
            Console.WriteLine(3 / 4);

            Fractions frs1 = new Fractions(2, 5);
            Fractions frs2 = new Fractions(3, 4);
            Fractions frs3 = new Fractions();
            frs3 = frs1.Plus(frs2);
            frs3.ShowRes();
            Console.ReadLine();

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
                if (denominator==x.denominator)
                {
                    y.denominator = denominator;
                    y.numerator = numerator + x.numerator;
                }
                //We need to set all fractions to one denominator
                else
                {
                    //find equal denominator
                    int EqualDenominator = 0;
                    for (int i = 1; i % denominator != 0 
                        | i % x.denominator != 0; EqualDenominator = ++i) ;                    
                    //reduce to a common denominator
                    y.numerator = (numerator * (EqualDenominator / denominator)) +
                        (x.numerator * (EqualDenominator / x.denominator));
                    y.denominator = EqualDenominator;
                }
                return y;
            }
            //Realize method ShowRes
            public void ShowRes()
            {
                Console.WriteLine($"{numerator}/{denominator}");
            }

        }
    }
}
