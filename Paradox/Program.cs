using System;

namespace Paradox
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int m = 0;
            Random rnd = new Random();
            for (int i=0; i<10000; i++)
            {
                int winDoor = rnd.Next(0, 3);
                int selected = rnd.Next(0, 3);
                int openDoor = winDoor;
                while (openDoor == winDoor || openDoor==selected) openDoor = rnd.Next(0, 3);
                if (selected == winDoor) k++;
                if (selected != winDoor) m++;
            }
            Console.WriteLine(k);
            Console.WriteLine(m);
        }
    }
}
