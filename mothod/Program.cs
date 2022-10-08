using System;
namespace mothod
{

    


    }

    internal class program
    {


    public static int numbers (int numb1, int numb2)
    
    {

        var sumnums = numb1 * numb2;


        return sumnums;
        
    }

    


        static void Main(string [] args)
        {



        Console.WriteLine("Place your number to multiply :");

        int userImput1 = Convert.ToInt32(Console.ReadLine());

        int userimput2 = Convert.ToInt32(Console.ReadLine());

        var result = numbers(userImput1, userimput2);


        Console.WriteLine($" The Result : {result}");
        Console.ReadLine();

        

        }

    }

