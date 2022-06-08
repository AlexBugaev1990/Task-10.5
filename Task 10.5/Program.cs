using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программка для подсчета суммы двух чисел");
        while (true)
        {
            try
            {
                ICalculator calculator = new Calc();
                                
                Console.WriteLine("Введите 1-ое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2-ое число");
                int b = Convert.ToInt32(Console.ReadLine());

                calculator.Summ(a, b);

            }
            catch (OverflowException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine($"Вы ввели слишком большое число");
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine($"Не верный формат данных");
            }

        }
    }

    public interface ICalculator
    {
        void Summ(int a, int b);

    }


    public class Calc : ICalculator
    {
        void ICalculator.Summ(int a, int b)
        {
            Console.WriteLine("Ответ = {0}", a + b);
        }
    }

}  