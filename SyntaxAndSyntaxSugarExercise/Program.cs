using System.Runtime.CompilerServices;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Type a number to see if its less than 9");
            var answer = Convert.ToInt32(Console.ReadLine());

            //var response= "";           
            /*
            if (answer < 9)
            {
                response = $"{answer} is less than nine";
                Console.WriteLine(response);
            }
            else
            {
                response = $"{answer} is greater than or equal to nine";
                Console.WriteLine(response);
            }
            */

            // can turn into this using inferred tyoing, string interpolation and the ternery operator
            var message = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(message);
           
            
        }
    }
}
