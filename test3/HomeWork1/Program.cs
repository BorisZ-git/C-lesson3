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
            // 1
            Console.WriteLine("Используем структуру:");
            ComplexStruct num1 = new ComplexStruct(1, 2);
            ComplexStruct num2 = new ComplexStruct(9, 8);
            ComplexStruct num3 = new ComplexStruct();
            // 1.1
            Console.WriteLine("\tСложение:");
            num3 = num1.Plus(num2);
            num3.ShowRes();
            Console.WriteLine("\tВычитание:");
            num3 = num2.Minus(num1);
            num3.ShowRes();
            // 1.2
            Console.WriteLine("Используем класс:");
            ComplexClass val1 = new ComplexClass(42, 23);
            ComplexClass val2 = new ComplexClass(21, 77);
            ComplexClass val3 = new ComplexClass();

            Console.WriteLine("\tУмножение:");
            val3 = val1.Multi(val2);
            val3.ShowRes();
            Console.WriteLine("\tВычитание:");
            val3 = val2.Minus(val1);
            val3.ShowRes();
            //Pause
            Console.ReadLine();            
        }
        //structure
        struct ComplexStruct
        {
            double bi;
            double ci;
            //Realize Constructor(Пишем конструктор задающий переменные при создании объекта)
            public ComplexStruct(double bi, double ci)
            {
                this.bi = bi;
                this.ci = ci;
            }
            /*Realize method Plus(Реализуем метод сложения)
             *создаем объект "y" присваиваем его переменным значения 
             *передавая в метод данные присвоенные уже созданному объекту(через конструктор)
             *Возвращает объект c полученными переменными.
            */ 
            public ComplexStruct Plus(ComplexStruct x)
            {
                ComplexStruct y;
                y.bi = bi + x.bi;
                y.ci = ci + x.ci;
                return y;
            }
            //Realize method Minus(Реализуем метод вычитания)
            public ComplexStruct Minus(ComplexStruct x)
            {
                ComplexStruct y;
                y.bi = bi - x.bi;
                y.ci = ci - x.ci;
                return y;
            }

            //Realize method that show value of variables (Выводит значение переменных на экран)
            public void ShowRes()
            {
               Console.WriteLine($"Первое: {bi}\tВторое: {ci}");
            }
        }
        //class
        class ComplexClass
        {
            double bi;
            double ci;
            public ComplexClass(double bi,double ci)
            {
                this.bi = bi;
                this.ci = ci;
            }
            //need to create new constructor(нужно создать пустой контсруктор)
            public ComplexClass()
            {

            }
            public ComplexClass Multi(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.bi = bi * x.bi;                
                y.ci = ci * x.bi;
                return y;
            }
            public ComplexClass Minus(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.bi = bi - x.bi;
                y.ci = ci - x.ci;
                return y;
            }
            public void ShowRes()
            {
                Console.WriteLine($"Первое: {bi}\tВторое: {ci}");
            }
        }
    }
}
