using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace The_Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов списка: ");
            bool ok;
            int SIZE;
            do
            {
                ok = Int32.TryParse(Console.ReadLine(), out SIZE);
                if (!ok) Console.WriteLine("Ошибка ввода!");
                if (SIZE < 1)
                {
                    Console.WriteLine("Список слишком мал!");
                    ok = false;
                }
            } while (!ok);

            Console.WriteLine("Создаю список: ");

            Random rand = new Random();
            int[] mass = new int[SIZE];
            MyList List = null;

            for (int i = 0; i < SIZE; i++)
            {
                mass[i] = rand.Next(-10,10);
                Console.Write(mass[i] + " ");
            }
       
            MyList P = null;
            List = MakePoint();
         /*   for (int i = 0; i < SIZE; i++)
            {
                if (mass[i] < 0)
                {
                    List = MakePoint(mass[i]);
                    goto P;
                }
            }
            for (int i = 0; i < SIZE; i++)
            {
                if (mass[i] == 0)
                {
                    List = MakePoint(mass[i]);
                    goto P;
                }
            }
            for (int i = 0; i < SIZE; i++)
            {
                if (mass[i] > 0)
                {
                    List = MakePoint(mass[i]);
                    goto P;
                }
            } */
            P:
            for (int i = 0; i < SIZE; i++)
            {
                if (mass[i] < 0)
                {
                        P = MakePoint(mass[i]);
                        P.next = List;
                        List.pred = P;
                        List = P;

                    }
            }
            for (int i = 0; i < SIZE; i++)
            {
                if (mass[i] == 0)
                {
                    P = MakePoint(mass[i]);
                    P.next = List;
                    List.pred = P;
                    List = P;

                }
            }
            for (int i = 0; i < SIZE; i++)
            {
                if (mass[i] > 0)
                {
                    P = MakePoint(mass[i]);
                    P.next = List;
                    List.pred = P;
                    List = P;

                }
            }
            Console.WriteLine();
            Console.WriteLine("Я записал список в нужном порядке, вот он: ");

            ShowList(List);

            Console.ReadKey();

        }
        static MyList MakePoint(int d)
        {
            MyList p = new MyList(d);
            return p;
        }
        static MyList MakePoint()
        {
            MyList p = new MyList();
            return p;
        }

        static void ShowList(MyList beg)
        {
            if (beg == null)
            {
                Console.WriteLine("The List is empty");
                return;
            }
            MyList p = beg;
            while (p.next != null)
            {
                Console.Write(p);
                p = p.next;
            }
            Console.WriteLine();
        }

    }
}
