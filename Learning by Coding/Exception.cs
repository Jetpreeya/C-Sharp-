using System;

namespace Exception220503
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoSomethings();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catching an exeption from method(){0}", ex.Message);
            }
        }

        private static void DoSomethings()
        {
            try
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                int value = Convert.ToInt32(input);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("The number cannot devide by 0");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index Out Of Range Exception");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
            }
            catch (OverflowException)
            {
                throw new Exception("Format should be a int!");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Arithmetic Exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                Console.WriteLine("Program executed!");
            }
        }
    }
}
