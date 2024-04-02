using System;
using static System.Console;
using System.Linq;


namespace Week9HW___Arrays

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] make3 = new string[5];
            string[] model3 = new string[5];
            double[] price3 = new double[5];


            for (int x = 0; x < make3.Length; x++)
            {


                WriteLine("Please enter the make of your vehicle");
                make3[x] = ReadLine();

                WriteLine("Please enter the model of your vehicle {0}", make3[x]);
                model3[x] = ReadLine();

                WriteLine("Please enter the price your vehicle {0}", model3[x]);
                price3[x] = Convert.ToDouble(ReadLine());

            }

           

            for (int x = 0; x < make3.Length; x++)
            {

                WriteLine("{0,20}{1,20}{2,20}", make3[x], model3[x], price3[x]);


            }           


            double m = price3.Max();

            int p = Array.IndexOf(price3,m);

            WriteLine("The highest price is the {0} {1}", make3[p], model3[p]);

            WriteLine(m);


            ReadKey();

        }
    }
}
