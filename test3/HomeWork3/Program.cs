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
/* ВОПРОСЫ:
 * 
*/

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {            
            Fractions frs1 = new Fractions(5, 10);
            Fractions frs2 = new Fractions(7, 10);
            Fractions frs3 = new Fractions();
            frs3 = frs1.Plus(frs2);
            frs3.ShowRes();
            //REALIZE NEGATIVE VALUE
            //REALIZE METHOD SIMPLYFYING
            frs3 = frs2.Minus(frs1);
            frs3.ShowRes();

            Console.ReadLine();

        }
        class Fractions
        {
            // целое число
            int integer;
            // числитель
            int num;
            // знаменатель 
            int den;
            //constructor empty
            public Fractions()
            {

            }
            //constructor take value
            public Fractions(int numerator, int denominator)
            {
                den = denominator;
                num = numerator;
            }
            //Realize method Plus
            public Fractions Plus(Fractions x)
            {
                Fractions y = new Fractions();
                //int ComMul;

                if (den==x.den)
                {
                    y.den = den;
                    y.num = num + x.num;
                    //simplifying fractions
                    int nod = NOD(y.den, y.num);
                    y.den = y.den / nod;
                    y.num = y.num / nod;

                }
                //We need to set all fractions to one denominator
                else
                {
                    //find equal denominator
                    int EqualDen = 0;
                    for (int i = 1; i % den != 0 | i % x.den != 0; EqualDen = ++i);                    
                    //reduce to a common denominator
                    y.num = (num * (EqualDen / den)) + (x.num * (EqualDen / x.den));
                    y.den = EqualDen;
                    //simplifying fractions
                    int nod = NOD(y.den, y.num);
                    y.den = y.den / nod;
                    y.num = y.num / nod;
                }
                return y;
            }
            //Realize method Minus
            public Fractions Minus(Fractions x)
            {
                Fractions y = new Fractions();
                //int ComMul;

                if (den == x.den)
                {
                    y.den = den;
                    y.num = num - x.num;
                    //simplifying fractions
                    int nod = NOD(y.den, y.num);
                    y.den = y.den / nod;
                    y.num = y.num / nod;

                }
                //We need to set all fractions to one denominator
                else
                {
                    //find equal denominator
                    int EqualDen = 0;
                    for (int i = 1; i % den != 0 | i % x.den != 0; EqualDen = ++i) ;
                    //reduce to a common denominator
                    y.num = (num * (EqualDen / den)) - (x.num * (EqualDen / x.den));
                    y.den = EqualDen;
                    //simplifying fractions
                    int nod = NOD(y.den, y.num);
                    y.den = y.den / nod;
                    y.num = y.num / nod;
                }
                return y;
            }
            //Realize method ShowRes
            public void ShowRes()
            {
                Console.WriteLine($"{num}/{den}");
            }
            //Get NOD
            static int NOD(int a,int b)
            {
                while (a != b)
                {
                    if (a > b) a = a - b; else b = b - a;
                }
                return a;
            }            
            //Simplifying fractions NEED REALIZE
            static void SetSimply()
            {

            }
        }
    }
}
