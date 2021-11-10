using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pr_32_prakt16_1_OAP_ZhuravlevTimofeyVasilievich
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>()
            {
             new People { Name = "Иванов Сергей Николаевич", Age = 21, Ves=64},
             new People { Name = "Петров Игорь Юрьевич", Age = 45, Ves=88},
             new People { Name = "Семёнов Михаил Алексеевич", Age = 20, Ves=70},
             new People { Name = "Пиманов Александр Дмитриевич", Age = 53, Ves=101}
            };
            var sortedPeoples = from p in peoples
                                orderby p.Age descending
                                select p;
            foreach (People p in sortedPeoples)
            {
                Console.WriteLine(p.Age);
            }
            var selectedPeoples = peoples.Where(p => p.Age < 40);
            foreach (People p in selectedPeoples)
            {
                Console.WriteLine($"{p.Name} - {p.Age} - {p.Ves}");
            }
            Console.ReadLine();
        }
    }
    internal class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Ves { get; set; }
    }
}
