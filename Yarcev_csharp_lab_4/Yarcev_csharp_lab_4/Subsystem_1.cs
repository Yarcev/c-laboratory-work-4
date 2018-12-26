using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    /// <summary>
    /// узнать сколько было машин на пути idway='X' в разные дни
    /// </summary>
    class Subsystem_1
    {
        public void Procedutre()
        {
            Yarcev_csharp_lab_4DataContext context = new Yarcev_csharp_lab_4DataContext();
            Console.WriteLine(" (Используется фильтрация и сортировка)");
            int int_idway = 0;
                
                Console.Write(" <= Введите idway пути: ");
                int_idway = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
            var Groups2 = from n in context.number_on_way
                          where n.idway == int_idway
                               select new {
                                   ID = n.Id,
                                   IDway = n.idway,
                                   NUMBER = n.number,
                                   DATA = n.date
                               };
            Console.WriteLine(" SELECT ID, IDWAY, NUMBER, DATA");
            Console.WriteLine(" FROM NUMBER_ON_WAY");
            Console.WriteLine(" WHERE IDWAY = '"+int_idway+"'");
            Console.WriteLine(" ORDER BY DATA ASC;\n");
            Console.WriteLine(" {ID, IDway, NUMBER, DATA}(");
            foreach (var group in Groups2)
            {
                Console.WriteLine(" (" + group.ID.ToString() 
                    + ") (" + group.IDway.ToString() + ") (" + group.NUMBER.ToString()
                    + ") (" + group.DATA.ToString() + "),");
            }
            Console.WriteLine(");");
            //------------------------------------------------------------------
            /*
            Yarcev_csharp_lab_4DataContext context = new Yarcev_csharp_lab_4DataContext();
            Console.WriteLine(" (Используется фильтрация и сортировка по убыванию)");
            int int_idway = 0;

            Console.Write(" Введите id пути: ");
            int_idway = Int32.Parse(Console.ReadLine());

            var Groups2 = from n in context.number_on_way
                          where n.idway == int_idway
                          group n by n.idway into g
                          select new { SUM = g.Sum(d => d.number), ID = g.Key };
            foreach (var group in Groups2)
                Console.WriteLine(" id={0} : sum={1}", group.SUM, group.ID);
                */
        }
    }
}
