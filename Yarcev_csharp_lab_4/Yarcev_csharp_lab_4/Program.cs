using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_csharp_lab_4
{
    /// <summary>
    /// основной класс программы
    /// </summary>
    class Program
    {
        //рисует линию из символа 'ы'
        static void LineCh(char s)
        {
            for (int i = 0; i < 80; i++)
                Console.Write(s);
            Console.WriteLine();
        }
        //основная функция программы
        static void Main(string[] args)
        {
            Console.WriteLine(" Lab 4 author: Yarcev D.A., group: IS-61");
            Console.WriteLine(" Variant 6");
            LineCh('=');

            //создаем новый экземпляр контекста
            

            //ключ основного цикла программы и сам цикл
            bool keyLoop = true;
            while (keyLoop)
            {
                //основной алгоритм программы
                bool key = true;
                Facade go = new Facade();
                int i1 = 0;
                while (key)
                {
                    key = false;
                    Console.WriteLine(" menu:");
                    Console.WriteLine(" 1 - узнать сколько было машин на пути idway='X' в разные дни:");
                    Console.WriteLine(" 2 - узнать полный список маршрутов в алфавитном порядке:");
                    Console.WriteLine(" 3 - узнать когда на маршруте id='X' было меньше 'Y' машин:");
                    Console.WriteLine(" 4 - узнать Сколько было жалоб поступило на каждую машину:");
                    Console.WriteLine(" 5 - узнать сколько раз машина number_car='X' была на маршруте 'Y':");
                    Console.WriteLine(" 6 - Вывести имена маршрутов с временем начала и конца маршрута:");
                    Console.WriteLine(" 7 - Вывести номер маршрутки и имена людей, что на нее пожаловались:");
                    LineCh('-');
                    Console.Write(" <= Input number: ");
                    i1 = Int32.Parse(Console.ReadLine());
                    LineCh('-');
                    switch (i1)
                    {
                        case 1: go.Subsystem_1(); break;
                        case 2: go.Subsystem_2(); break;
                        case 3: go.Subsystem_3(); break;
                        case 4: go.Subsystem_4(); break;
                        case 5: go.Subsystem_5(); break;
                        case 6: go.Subsystem_6(); break;
                        case 7: go.Subsystem_7(); break;
                        default:
                            Console.WriteLine(" Error");
                            LineCh('-');
                            key = true;
                            break;
                    }
                }
                //вопрос о завершении программы и его ключ
                LineCh('-');
                string answer;
                bool keyEndCycle = true;
                Console.Write(" <= Are you want to rareat this promram? ('y' - yes/'n' - no): ");
                while (keyEndCycle)
                {
                    answer = Console.ReadLine().ToString();
                    if (answer == "y" || answer == "yes" || answer == "Yes" || answer == "YES")
                    {
                        keyLoop = true;
                        keyEndCycle = false;
                    }
                    else if (answer == "n" || answer == "no" || answer == "No" || answer == "NO")
                    {
                        keyLoop = false;
                        keyEndCycle = false;
                    }
                    else
                    {
                        Console.Write(" => Erorr.\n <= Please rapeat you answer ('y' - yes/'n' - no): ");
                        keyEndCycle = true;
                    }
                }
                LineCh('-');
            }

            LineCh('-');
            Console.WriteLine(" Program is ending...");
            LineCh('=');
            Console.ReadLine();
        }
    }
}
