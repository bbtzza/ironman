using CalculateLibrary;
namespace DllTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a =10; int b = 20; int c = 30;
            //實體化
            CalculateLibrary.Class1 CalculateLibrary = new CalculateLibrary.Class1();
            
            // 使用DLL中的方法
            int result_Add = CalculateLibrary.Add(a, b);
            int result_Subtract = CalculateLibrary.Subtract(a, b);
            int result_Multiply = CalculateLibrary.Multiply(a, b);

            Console.WriteLine($"Add: {result_Add}");
            Console.WriteLine($"Subtract: {result_Subtract}");
            Console.WriteLine($"Multiply: {result_Multiply}");
        }
    }
}