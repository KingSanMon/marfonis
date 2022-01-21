using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Abc Def Ghi";
            int count = 0;

            foreach (char i in a)
            {
                string b = i.ToString();

                if (i == ' ')
                    continue;
                else
                {
                    count++;
                }
            }
            string result = "";
            foreach (char c in a)
                result += (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));

            string tex = "Мой дядя самых честных правил, когда не в шутку занемог, он уважать себя заствил лучше выдумать не мог";

            string[] textMass;
            string text = tex;

            textMass = text.Split(' ');

            Console.WriteLine("Количество слов в тексте: {0}", textMass.Length);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(result);

            string tex1 = "закружилась листва золотая в розоватой воде на пруду, словно бабочек легкая стая с замеранием летит на звезду";
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("количество букв а в тексте {0}", tex1.Count(ch => ch == 'а'));

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("введите ширину и высоту прямоугольника");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int ploc = x * y;
            Console.WriteLine("прощадь прямоугольника равна: {0}",ploc);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("введите диаметр круга");
            int dia = int.Parse(Console.ReadLine());
            double plo2 = Math.PI / 4 * Math.Pow(dia,2);
            Console.WriteLine("площадь круга равна: {0}", plo2);

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("введите стороны треугольника");
            Console.WriteLine("первая сторона");
            double kat1 = double.Parse(Console.ReadLine());
            Console.WriteLine("вторая сторона");
            double kat2 = double.Parse(Console.ReadLine());
            Console.WriteLine("третья сторона");
            double gib3 = double.Parse(Console.ReadLine());

            double ploc2 = kat1 + kat2 + gib3 / 2;

            if (kat1 < gib3+kat2 && kat2 < gib3+kat1 && gib3 < kat1+kat2)
            {
                double ploc3 = Math.Sqrt(ploc2 * (ploc2 - kat1) * (ploc2 - kat2) * (ploc2 - gib3));
                Console.WriteLine(ploc3);
            }

            else
            {
                Console.WriteLine("Треугольник со сторонами: {0}, {1}, {2} не существует", kat1, kat2, gib3);
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("введите стороны прямоугольного параллелепипеда");
            Console.WriteLine("первая сторона");
            double stor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("вторая сторона");
            double stor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("третья сторона");
            double stor3 = double.Parse(Console.ReadLine());

            double obem = stor1 * stor2 * stor3;
            Console.WriteLine("Объём прямоугольного параллелепипеда равен: {0}", obem);

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("введите радиус шара");
            double rad6 = double.Parse(Console.ReadLine());

            double obem2 = 4 / 3 * Math.PI * Math.Pow(rad6, 3);
            Console.WriteLine("Объём куба равен: {0}", obem2); //4/3 * Math.PI * Math.Pow(radiys, 3);

            Console.ReadKey();
        }
    }
}
