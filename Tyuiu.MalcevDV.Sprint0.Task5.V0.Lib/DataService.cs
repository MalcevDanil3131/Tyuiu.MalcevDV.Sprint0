namespace Tyuiu.MalcevDV.Sprit0.Task4.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Substraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b = {0}, на ноль делиь нельзя ", b);
                return -1;
            }
            else
            {
                return (a / b);
            }
        }
    }
}
