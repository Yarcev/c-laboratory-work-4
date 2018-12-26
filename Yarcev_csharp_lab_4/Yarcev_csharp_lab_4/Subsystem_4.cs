using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    /// <summary>
    /// узнать Сколько было жалоб поступило на каждую машину
    /// </summary>
    class Subsystem_4
    {
        public void Procedutre()
        {
            Yarcev_csharp_lab_4DataContext context = new Yarcev_csharp_lab_4DataContext();
            Console.WriteLine(" (групировка и сортировка)");

            var rows = from n in context.complaints
                          join s in context.list_car on n.id_list_car equals s.Id
                          group n by s.number_car into g
                          select new {
                              NUMBER_CAR = g.Key,
                              COUNT = g.Count()
                          };

            Console.WriteLine("\n SELECT NUMBER_CAR, COUNT(*)");
            Console.WriteLine(" FROM COMPLAINTS S1 JOIN LIST_CAR S2 ON S1.ID_LIST_CAR = S2.ID");
            Console.WriteLine(" GROUP BY NUMBER_CAR;\n");
            Console.WriteLine(" {NUMBER_CAR, COUNT(*)}(");
            foreach (var group in rows)
            {
                Console.WriteLine(" (" + group.NUMBER_CAR.ToString()
                    + ") (" + group.COUNT.ToString() + "),");
            }
            Console.WriteLine(");");
        }
    }
}
