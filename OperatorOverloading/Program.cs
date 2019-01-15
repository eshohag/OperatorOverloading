using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorClass operatorClass1 = new OperatorClass();
            operatorClass1.Salary = 50000;

            OperatorClass operatorClass2 = new OperatorClass();
            operatorClass2.Salary = 30000;

            OperatorClass aOperatorClass = new OperatorClass();
            aOperatorClass = operatorClass1 - operatorClass2;

            Console.WriteLine(aOperatorClass.Salary);

            Console.ReadKey();
        }
    }
}
