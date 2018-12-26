using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    class Subsystem_7
    {
        /// <summary>
        /// Вывести номер маршрутки и имена людей, что на нее пожаловались
        /// </summary>
        public void Procedutre()
        {
            Yarcev_csharp_lab_4DataContext context = new Yarcev_csharp_lab_4DataContext();
            Console.WriteLine(" (join и группировка)");

            var rows = from n in context.complaints
                       join s in context.list_car on n.id_list_car equals s.Id
                       group n by s.number_car 
                       ;
            Console.WriteLine("\n SELECT NUMBER_CAR OVER(PARTITION BY NUMBER_CAR), NAME, END");
            Console.WriteLine(" FROM CON S1 JOIN STARY_END S2 ON S1.ID_LIST_CAR = S2.ID\n");
            Console.WriteLine(" {NUMBER_CAR, NAME}(");
            foreach (var g in rows)
            {
                Console.WriteLine("     ("+g.Key+":");
                foreach (var t in g)
                {
                    Console.WriteLine("         "+t.name+",");
                }
                Console.WriteLine("     ),");
            }
            Console.WriteLine(" );");
        }
    }
}
