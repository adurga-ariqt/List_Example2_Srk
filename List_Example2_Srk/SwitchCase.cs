using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Example2_Srk
{

    public class SwitchCase : ListMethods
    {
        public void SwitchCaseMethod()
        {
            int n;
           
            Console.WriteLine(" if you want to  enter the employee details "+Environment.NewLine + "Select any list  item ...." + Environment.NewLine + "1.Add" + Environment.NewLine + "2.Search" + Environment.NewLine + "3.Remove" + Environment.NewLine + "4.Insert" + Environment.NewLine + "5.RemoveAt" + Environment.NewLine + "6.Display All Records" + Environment.NewLine + "7.Count" + Environment.NewLine + "8.Exit");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    AddMethod();
                    break;
                case 2:
                    SearchMethod();
                    break;
                case3:
                    RemoveMethod();
                    break;
                case4:
                    InsterMethod();
                    break;
                case 5:
                    RemoveAtMethod();
                    break;
                case 6:
                    DisplayAllRecords();
                    break;
                case7:
                    CountMethod();
                    break;
                case8:
                    ExitMethod();
                
                default:
                    Console.WriteLine("none of the list ");
                    break;

            }
        }
    }
}
