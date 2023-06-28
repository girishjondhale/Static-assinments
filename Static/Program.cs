using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Static.Employee1;

namespace Static
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Employee1 e1 = new Employee1("girish", 10000,Dept.testing);
            e1.Calculatesal();
            //Console.WriteLine(Employee1.GetCount());
            Console.WriteLine(e1);

            Salesmanager salesManager = new Salesmanager("sachin", 30000, 5000);
            salesManager.Calculatesal();
            Console.WriteLine(salesManager);

            Ceo ceo = new Ceo("girish", 10000,4000);
            ceo.Calculatesal();
            Console.WriteLine(ceo);

            Rectangle r = new Rectangle(5,8);
            r.CalculateArea();
            Console.WriteLine(r.ToString());


            Calculation c1 = new Calculation();
            int result1 = c1.Addition(15, 20);
            double result2 = c1.Addition(30, 40);
            // c1.Addition(1, 2, 3);
            Console.WriteLine(result1);
            Console.WriteLine(result2);


            double result3 = c1.Substraction(15.22, 20.33);
            double result4 = c1.Substraction(250.11, 44.11);
            // c1.Substraction(2, 4, 5);
            Console.WriteLine(result3);
            Console.WriteLine(result4);


        }
    }
}
