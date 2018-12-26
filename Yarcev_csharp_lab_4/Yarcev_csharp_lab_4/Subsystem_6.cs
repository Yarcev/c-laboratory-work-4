using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    /// <summary>
    /// Вывести имена маршрутов с временем начала и конца маршрута:
    /// </summary>
    class Subsystem_6
    {
        public void Procedutre()
        {
            Yarcev_csharp_lab_4DataContext context = new Yarcev_csharp_lab_4DataContext();
            Console.WriteLine(" (join и сортировка, concat)");

            var rows = from se in context.start_end
                       join w in context.way on se.idway equals w.Id
                       select new
                       {
                           WAY = w.name,
                           START_END = string.Concat(se.start,se.end)
                       };

            Console.WriteLine("\n SELECT NAME, START, END");
            Console.WriteLine(" FROM WAY S1 JOIN STARY_END S2 ON S1.IDWAY = S2.ID");
            Console.WriteLine(" ORDER BY NAME;\n");
            Console.WriteLine(" {NAME, START_END}(");
            foreach (var group in rows)
            {
                Console.WriteLine(" (" + group.WAY.ToString()
                    + ") (" + group.START_END + "),");
            }
            Console.WriteLine(");");
        }
    }
}
