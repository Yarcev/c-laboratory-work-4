using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    /// <summary>
    /// узнать когда на маршруте id='X' было меньше 'Y' машин
    /// </summary>
    class Subsystem_3
    {
        public void Procedutre()
        {
            Yarcev_csharp_lab_4DataContext context = new Yarcev_csharp_lab_4DataContext();
            Console.WriteLine(" (фильтрация, сортировка)");

            Console.Write(" <= Введите idway пути: ");
            int in_idway = Int32.Parse(Console.ReadLine());
            Console.Write(" <= Введите num машин: ");
            int in_num = Int32.Parse(Console.ReadLine());

            var rows = from n in context.number_on_way
                       where n.idway == in_idway && n.number < in_num
                       orderby n.Id
                       select new
                       {
                           ID = n.Id,
                           IDway = n.idway,
                           NUMBER = n.number,
                           DATA = n.date
                       };

            Console.WriteLine(" SELECT ID, IDWAY, NUMBER, DATA");
            Console.WriteLine(" FROM NUMBER_ON_WAY");
            Console.WriteLine(" WHERE IDWAY = '" + in_idway + "' && NUMBER > "+in_num);
            Console.WriteLine(" ORDER BY DATA ASC;\n");
            Console.WriteLine(" {ID, IDway, NUMBER, DATA}(");
            foreach (var group in rows)
            {
                Console.WriteLine(" (" + group.ID.ToString()
                    + ") (" + group.IDway.ToString() + ") (" + group.NUMBER.ToString()
                    + ") (" + group.DATA.ToString() + "),");
            }
            Console.WriteLine(");");
        }
    }
}
