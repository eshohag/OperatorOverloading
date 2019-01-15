namespace OperatorOverloading
{
    class OperatorClass
    {
        public int Salary { get; set; }
        public static OperatorClass operator +(OperatorClass first, OperatorClass second)
        {
            OperatorClass aOperatorClass = new OperatorClass();
            aOperatorClass.Salary = first.Salary + second.Salary;
            return aOperatorClass;
        }

        public static OperatorClass operator -(OperatorClass first, OperatorClass second)
        {
            OperatorClass aOperatorClass = new OperatorClass();
            aOperatorClass.Salary = first.Salary - second.Salary;
            return aOperatorClass;
        }
    }
}