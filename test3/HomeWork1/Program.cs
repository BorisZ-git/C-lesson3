using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * 1.1 Дописать структуру Complex, добавив метод вычитания комплексных чисел.
 * Продемонстрировать работу структуры;
 * 1.2 Дописать класс Complex, добавив методы вычитания и произведения чисел.
 * Проверить работу класса;
 * */
#region Комплексное число
//Комплексное число — это выражение вида a + bi, где a, b — действительные числа,
//а i — так называемая мнимая единица, символ, квадрат которого равен –1, то есть i2 = –1.
//Число a называется действительной частью, а число b — мнимой частью комплексного числа z = a + bi.
//Если b = 0, то вместо a + 0i пишут просто a.
//Видно, что действительные числа — это частный случай комплексных чисел.
#endregion

namespace HomeWork1
{
    class Program
    {
        static void Main()
        {
            Complex i1 = new Complex();
            Complex i2 = new Complex();
            Complex i3 = new Complex();


            Console.ReadLine();            
        }

        struct Complex
        {
            public double im;
            public double re;
            // Сonstructor for Complex
            public Complex(double im, double re)
            {
                this.im = im;
                this.re = re;
            }
            // в C# в структурах могут храниться так же действия над данными
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                Console.WriteLine($"{y.im} {y.re}");
                return y;
            }
            // Пример произведения двух комплексных чисел
            Complex Multi(Complex x)
            {
                Complex y;
                y.im = im * x.im + re * x.im;
                y.re = re * x.im - im * x.re;
                return y;
            }
            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }
            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }
    }
}
