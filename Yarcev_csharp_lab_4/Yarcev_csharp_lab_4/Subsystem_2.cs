using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    /// <summary>
    /// узнать полный список маршрутов в алфавитном порядке:
    /// </summary>
    class Subsystem_2
    {
        public void Procedutre()
        {
            Yarcev_csharp_lab_4DataContext context = new Yarcev_csharp_lab_4DataContext();
            Console.WriteLine(" (сортировка по убыванию)");

            var rows = from n in context.way
                       orderby n.Id
                       select new {ID = n.Id, NAME = n.name };

            Console.WriteLine("\n SELECT ID, NAME");
            Console.WriteLine(" WAY");
            Console.WriteLine(" ORDER BY ID ASC;\n");
            Console.WriteLine(" {ID, NAME}(");
            foreach (var i in rows)
            {
                Console.WriteLine(" ("+i.ID.ToString()+") ("+i.NAME.ToString()+"),");
            }
            Console.WriteLine(");");
        }
    }
}
