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
                Draw();
         
        }
        static void Draw()
        {
            int x = Console.BufferHeight / 4;
            int y = Console.WindowWidth / 4;
            Console.SetCursorPosition(x, y);
        }
    }
}
