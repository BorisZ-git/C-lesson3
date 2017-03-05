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

            Console.ReadLine();            
        }

        struct Complex
        {
            double bi;
            double ci;
            //Realize Constructor(Пишем конструктор задающий переменные при создании объекта)
            Complex(double bi, double ci)
            {
                this.bi = bi;
                this.ci = ci;
            }
            /*Realize method Plus(Реализуем метод сложения)
             *создаем объект "y" присваиваем его переменным значения 
             *передавая в метод данные присвоенные уже созданному объекту(через конструктор)
             *Возвращает объект c полученными переменными.
            */ 
            Complex Plus(Complex x)
            {
                Complex y;
                y.bi = bi + x.bi;
                y.ci = ci + x.ci;
                return y;
            }
        }
    }
}
