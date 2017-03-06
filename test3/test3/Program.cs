using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            x = (width - StrHorLength)  / 2;
            y = height / 2;

            DrawLine(x, y, Hor);
            DrawLine(x, y+5, Hor);

            DrawVerti(x,y);
            DrawVerti(x+10, y);
            
            //1.2



            Console.ReadLine();
            
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
