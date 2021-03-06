﻿using System;
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
 * 1.Если & - означает И. А | - означает ИЛИ. То почему в данном примере работает | ?
 * for (int i = 1; i % den != 0 | i % x.den != 0; EqualDen = ++i); (метод Plus)
 * Я так понимаю это из-за результата логической операции, что он возвращает False
 * как только одно из условий перестает выполняться. Но в голове это не укладывается.
 * Ведь логически должно быть: выполняй пока это условие истинно И пока это условие истинно. 
*/

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Дроби
            int a1;
            int b1;
            int a2;
            int b2;
            #endregion            
            //Hello
            Console.WriteLine("Привет! Данная программа поможет" +
"осуществить вычисления между дробями");
            Console.Write("Введите числитель первой дроби: ");
            int.TryParse(Console.ReadLine(), out a1);
            Console.Write("Введите знаменатель первой дроби: ");
            int.TryParse(Console.ReadLine(), out b1);
            Console.Write("Введите числитель второй дроби: ");
            int.TryParse(Console.ReadLine(), out a2);
            Console.Write("Введите знаменатель второй дроби: ");
            int.TryParse(Console.ReadLine(), out b2);
            Fractions frs1 = new Fractions(a1, b1);
            Fractions frs2 = new Fractions(a2, b2);
            Fractions frs3 = new Fractions();

                frs3 = frs1.Plus(frs2);
                frs3.ShowRes();
                frs3 = frs2.Minus(frs1);
                frs3.ShowRes();
                frs3 = frs2.Multiplication(frs1);
                frs3.ShowRes();
                frs3 = frs2.Division(frs1);
                frs3.ShowRes();


            Console.ReadLine();

        }
        class Fractions
        {
            #region Переменные
            //знак
            char minus = ' ';
            // целое число
            int integer;
            // числитель
            int num;
            // знаменатель 
            int den;
            #endregion

            //constructor empty (Пустой контсруктор)
            public Fractions()
            {

            }
            //constructor take value(Принимающий значения)
            public Fractions(int numerator, int denominator)
            {
                den = denominator;
                num = numerator;
            }
            //Realize methods (Методы вычислений)
            public Fractions Plus(Fractions x)
            {
                Fractions y = new Fractions();
                Console.WriteLine("Сумма дробей: ");

                if (den==x.den)
                {
                    y.den = den;
                    y.num = num + x.num;
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
                }
                //simplifying fractions
                SetSimply(y);
                GetInteger(y);
                return y;
            }            
            public Fractions Minus(Fractions x)
            {
                Fractions y = new Fractions();
                Console.WriteLine("Разница дробей: ");
                if (den == x.den)
                {
                    y.den = den;
                    y.num = num - x.num;
                }                
                else
                {
                    Count(this, x, y);

                }                
                if (y.num < 0)
                {
                    y.num = Math.Abs(y.num);
                    y.minus = '-';
                }
                //simplifying fractions
                SetSimply(y);                
                GetInteger(y);
                return y;
            }
            public Fractions Multiplication(Fractions x)
            {
                Fractions y = new Fractions();
                Console.WriteLine("Произведенние дробей: ");
                y.num = num * x.num;
                y.den = den * x.den;
                //simplifying fractions
                SetSimply(y);
                GetInteger(y);
                return y;
            }
            public Fractions Division(Fractions x)
            {
                Fractions y = new Fractions();
                Console.WriteLine("Отношение дробей: ");
                y.num = num * SwapNum(x.num,x.den);
                y.den = den * SwapDen(x.num,x.den);
                //simplifying fractions
                SetSimply(y);
                GetInteger(y);
                return y;
            }            
            //Realize method ShowRes (Метод выводящий значение на консоль)
            public void ShowRes()
            {
                if (integer != 0)
                {
                    Console.WriteLine($"Целая: {minus}{integer} Дробная: {num}/{den}");
                }
                else
                Console.WriteLine($"Дробь: {minus} {num}/{den}");
            }
            //Методы для вычеслений            
            static int NOD(int a,int b)
            {
                while (a != b)
                {
                    if (a > b) a = a - b; else b = b - a;
                }
                return a;
            }            
            static int NOK(int a,int b)
            {
                return (a * b) / NOD(a, b);
            }
            static int Comm(int a,int b, int nok)
            {
                return a = a * nok / b;
            }
            static void Count (Fractions a, Fractions x, Fractions y)
            {
                int nok = NOK(a.den, x.den);
                y.den = nok;
                y.num = Comm(a.num,a.den, nok) - Comm(x.num,x.den, nok);
            }
            static int SwapNum(int num, int den)
            {
                num = num + den;
                den = num - den;
                num = num - den;
                return num;
            }
            static int SwapDen(int num, int den)
            {
                num = num + den;
                den = num - den;
                num = num - den;
                return den;
            }
            //Получение целого
            static void GetInteger(Fractions y)
            {
                for (int i = 0; y.num > y.den; y.integer = ++i) y.num -= y.den;
            }
            //Simplifying fractions(Упрощение дроби)
            static void SetSimply(Fractions y)
            {
                int nod = NOD(y.den, y.num);
                y.den = y.den / nod;
                y.num = y.num / nod;                
            }
        }
    }
}
