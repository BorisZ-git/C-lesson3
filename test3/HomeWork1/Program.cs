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

namespace HomeWork1
{
    class Program
    {
        static void Main()
        {
            Complex num1 = new Complex(1, 2);
            Complex num2 = new Complex(9, 8);
            Complex num3 = new Complex();

            num3 = num1.Plus(num2);
            num3.ShowRes();

            Console.ReadLine();            
        }

        struct Complex
        {
            double bi;
            double ci;
            //Realize Constructor(Пишем конструктор задающий переменные при создании объекта)
            public Complex(double bi, double ci)
            {
                this.bi = bi;
                this.ci = ci;
            }
            /*Realize method Plus(Реализуем метод сложения)
             *создаем объект "y" присваиваем его переменным значения 
             *передавая в метод данные присвоенные уже созданному объекту(через конструктор)
             *Возвращает объект c полученными переменными.
            */ 
            public Complex Plus(Complex x)
            {
                Complex y;
                y.bi = bi + x.bi;
                y.ci = ci + x.ci;
                return y;
            }
            //Realize method that show value of variables (Выводит значение переменных на экран)
            public void ShowRes()
            {
               Console.WriteLine($"Первое: {bi}\tВторое: {ci}");
            }
        }
    }
}
