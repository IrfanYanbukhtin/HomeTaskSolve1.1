
namespace HomeTaskSolve._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    var arrayTasks = new ArrayTasks();
        //    int[] mass = arrayTasks.EnterArray();
        //    arrayTasks.print(mass);
        //    int[] sqrtArray = arrayTasks.SqrtArray(mass); 
        //       arrayTasks.print(sqrtArray);


            var numberTasks = new NumberTasks();
            int number = numberTasks.EnterNumber();
            int reverseNumber = numberTasks.GetReverseNumber(number);
            Console.WriteLine($"{number}=>{reverseNumber}");

        }
    }
}