using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
/* Boris Z
 * Есть задачка следующая: 
 * 1.1 Чертим на консоли квадрат по центру.
 * 1.2 И заставить курсор при приближении к границам квадрата отскакивать от них.
 * То есть курсор не может зайти в этот квадрат.
 * 1.3 Можно усовершенствовать программу по своему усмотрению.
 * */

namespace test3
{
    class Program
    {
        static void Main()
        {
            //1.1
            string Hor = "**********";
            int StrHorLength, width, height, x, y;
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            StrHorLength = Hor.Length;
            x = (width - StrHorLength) / 2;
            y = height / 2;

            DrawLine(x, y, Hor);
            DrawLine(x, y + 5, Hor);

            DrawVerti(x, y);
            DrawVerti(x + 10, y);

            //1.2
            Random rnd = new Random();
            Console.SetCursorPosition(62, 18);
            do
            {
                Console.SetCursorPosition(rnd.Next(30, 60), rnd.Next(5, 20));
                int CursorX = Console.CursorTop;
                int CursorY = Console.CursorLeft;
                Thread.Sleep(1000);
                //не работает условие где то ошибся
                if (CursorX >= x && CursorX <= x + 10 && CursorY >= y && CursorY <= y + 5)
                {
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(rnd.Next(0, 45), rnd.Next(0, 35));
                    Thread.Sleep(1000);
                    Console.WriteLine("Курсор попал в квадрат");
                }
                Thread.Sleep(1000);
            } while (true);



        }
        static void DrawLine(int x,int y, string str)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
        static void DrawHoriz(int x,int y)
        {
            for (int i = 0; i< 10; i++)
            {
                Console.SetCursorPosition(x,y);
                x++;
                Console.Write('*');
            }  
        }
        static void DrawVerti(int x,int y)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.SetCursorPosition(x, y);
                y++;
                Console.Write('*');
            }
        }
    }
}
