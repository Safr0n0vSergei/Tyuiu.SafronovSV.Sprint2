using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SafronovSV.Sprint2.Task6.V15.Lib;

namespace Tyuiu.SafronovSV.Sprint2.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Сафронов С. В. | АСОиУб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт2                                                                   *");
            Console.WriteLine("*Тема: Получение результата из switch                                      *");
            Console.WriteLine("*Задание #6                                                                *");
            Console.WriteLine("*Вариант #15                                                               *");
            Console.WriteLine("*Выполнил: Сафронов Сергей Владимирович| АСОиУб-23-2                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели        *");
            Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й    *");
            Console.WriteLine("* день не високосного года, в котором 1 января понедельник.                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите номер дня ");
            int numDay = Convert.ToInt32(Console.ReadLine());
            string res;
            if (numDay < 1 || numDay > 365)
            {
                res = "Введено не верное значение";
            }
            else
            {
                res = ("День недели = " + ds.FindDayName(numDay % 7));

            }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
