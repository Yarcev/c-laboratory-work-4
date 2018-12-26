using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    /// <summary>
    /// узнать сколько раз машина number_car='X' была на маршруте 'Y'
    /// </summary>
    class Subsystem_5
    {
        public void Procedutre()
        {
            Yarcev_csharp_lab_4DataContext context = new Yarcev_csharp_lab_4DataContext();
            Console.WriteLine(" (групировка и фильтр)");

            Console.Write(" <= Введите number_car машины(00-00-06FB): ");
            string in_number_car = Console.ReadLine();
            Console.Write(" <= Введите idway(2): ");
            int in_idway = Int32.Parse(Console.ReadLine());

            var rows = from n in context.list_car
                       where n.idway == in_idway && n.number_car == in_number_car
                       group n by n into g
                       select new
                       {
                           NUMBER_CAR = g.Key.number_car,
                           COUNT = g.Count()
                       };

            Console.WriteLine("\n SELECT NUMBER_CAR, COUNT(*)");
            Console.WriteLine(" FROM LIST_CAR");
            Console.WriteLine(" GROUP BY NUMBER_CAR;\n");
            Console.WriteLine(" {NUMBER_CAR, COUNT(*)}(");
            foreach (var group in rows)
            {
                Console.WriteLine(" (" + group.NUMBER_CAR
                    + ") (" + group.COUNT.ToString() + "),");
            }
            Console.WriteLine(");");
        }
    }
}
