
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("программа которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

        void cube(int n)
        {
            for (n = n; n > 0; n--)
            {
                int a = n;
                a = a * a * a;
                Console.WriteLine(a);
            }

        }
        int n=int.Parse (Console.ReadLine());

        cube(n);
        bool sw = true;
        while (sw)
        {

        Console.WriteLine("программа которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        void polindrom(int p)
        {

            int a, b, d, e;
            a = p / 10000;
            b = p / 1000 % 10;
            d = p % 1000 % 100 / 10;
            e = p % 10000 % 1000 % 100 % 10;
            if (a == e & d == b) { Console.WriteLine("число является полиндромом"); }
            else { Console.WriteLine("число НЕ полиндромом"); }
        }
        int pol;
        Console.WriteLine("в ведите 5-и значное число");
        pol = int.Parse(Console.ReadLine());
        if (pol > 9999 & pol <= 99999) { polindrom(pol); }
        else { Console.WriteLine("вы в вели не верное число"); }
        
        Console.WriteLine("хотите продолжить(в ведите да или нет)");
        string swt = Console.ReadLine();     
        if (swt.ToLower() == "нет") { sw = false; }
        }

        bool sw1 = true;
        while (sw1)
        {
            Console.WriteLine("программа которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

            static void dis(double a, double b, double c, double a2, double b2, double c2)
            {
                double j;

                a = a - a2;
                a = a * a;
                b = b - b2;
                b = b * b;
                c = c - c2;
                c = c * c;
                j = a + b + c;
                double i = Math.Sqrt(j);
                Console.WriteLine(i);
            }
            Console.WriteLine("в ведите кординаты точки 1");
            double a = 0, b = 0, c = 0, a2 = 0, b2 = 0, c2 = 0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("в ведите кординаты точки 2");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            c2 = double.Parse(Console.ReadLine());
            dis(a, b, c, a2, b2, c2);
            string swt;
            Console.WriteLine("хотите продолжить ( в ведите да или нет)");
            swt = Console.ReadLine();
            if (swt.ToLower() == "нет") { sw1 = false; }

        }
    }
}