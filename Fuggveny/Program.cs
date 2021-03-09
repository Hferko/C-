using System;

namespace Fuggveny
{
    class Program
    {
        static void kor(int r)
        {
            Console.WriteLine(" A kör kerülete = " + (2 * r * Math.PI));
            Console.WriteLine(" A kör területe = " + (r * r * Math.PI));
        }

        static void negyszog(int a, int b)
        {
            Console.WriteLine(" A négyszög kerülete = " + (2 * (a+b)));
            Console.WriteLine(" A négyszög területe = " + ( a * b));
        }

        static void haromszog(int a, int b, int c)
        {
            double h = (a + b + c);
            double s = h / 2;
            double heron = (s * (s - a) * (s - b) * (s - c));
            Console.WriteLine(" A háromszög kerülete: " + h);
            Console.WriteLine(" A háromszög területe: " + Math.Pow(heron, 0.5));
        }

        static void sokszog(int a, int b)
        {
            double szog = 1/ (Math.Tan(Math.PI / b));
            double ter = (b * a * a) / 4;
            double alfa = ((b -2) * (180/ b));
            double rb = a / (2 * (Math.Tan(Math.PI / b)));
            Console.WriteLine(" Belső szögeinek mértéke " + alfa + "°" );
            Console.WriteLine(" A beírt kör sugara: " + rb);
            Console.WriteLine(" Az " + b +" oldalú sokszög kerülete: " + a*b);
            Console.WriteLine(" A szabályos sokszög területe: " + (ter*szog));
        }

        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int r = 0;
            char karak = 'z';

            while (karak != '1' && karak != '2' && karak != '3' && karak != '4')
            {
                Console.WriteLine(" Mit szeretnél számolni? Válassz az alábbiak közül: ");
                Console.WriteLine(" 1 - Kör kerület és terület");
                Console.WriteLine(" 2 - Négyszög kerület és terület");
                Console.WriteLine(" 3 - Háromszög kerület és terület");
                Console.WriteLine(" 4 - Szabályos sokszög kerülete és területe");
                karak = Convert.ToChar(Console.ReadLine());
            }

            if (karak == '1')
            {
                Console.WriteLine(" Add meg a kör sugarát:");
                r = int.Parse(Console.ReadLine());
                kor(r);
            }
            else if (karak == '2')
            {
                Console.WriteLine(" Kérem a négyszög egyik oldalát: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(" Kérem a másik oldalát:");
                b = int.Parse(Console.ReadLine());
                negyszog(a, b);
            }
            else if (karak == '3')
            {
                Console.WriteLine(" Kérem a háromszög egyik oldalát: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(" Kérem a másik oldalát:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine(" Végül a harmadik oldalát:");
                c = int.Parse(Console.ReadLine());
                haromszog(a, b, c);
            }
            else if (karak == '4')
            {
                Console.WriteLine(" Hány oldalú legyen a sokszög:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Milyen hosszú egy oldala:");
                a = Convert.ToInt32(Console.ReadLine());
                sokszog(a, b);
            }
                         


                
        }
    }
}
