using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using FirstApp;

internal class Program { 
    private static void Main(string[] args) 
    {
        Console.WriteLine("Hello, World!");

        string name = Console.ReadLine();
        Console.WriteLine("You entered: " + name);
        int a = Convert.ToInt32(Console.ReadLine());
        int b = 8;
        Console.WriteLine("Initial a " + a);
        Console.WriteLine("Initial b " + b);


        int temp = a;
        a = b;
        b = temp;
        (b,a) = (a,b);
        Console.WriteLine("After swap:");
        Console.WriteLine("The swapped a is " + a);
        Console.WriteLine("The swapped b is " + b);

        //program to find the largest number among the three number
        Console.WriteLine("Enter the value of a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of c");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a < b && b < c)
        {
            Console.WriteLine(c + " is the greatest number");
        }
        else if (b < a && c < a)
        {
            Console.WriteLine(a + " is the greatest number");
        }
        else
        {
            Console.WriteLine(b + " is the greatest number");
        }
        Console.WriteLine(a % 2 == 0 ? "EVEN" : "ODD");
        
        //program to find the sum of n natural number
        Console.WriteLine("Enter the n natural number");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("The sum upto n number " + sum);


        //for finding the sum of arryay
        int[] arr = new int[] { 1, 2, 3 };
        SumOfArray ArrObj = new SumOfArray();
        int total = ArrObj.sum(arr);
        Console.WriteLine("The sum of all element of array is" + total);


        //program to check whether the given year is leap or not.
        Console.WriteLine("Enter year to check leap year.");
        int year = Convert.ToInt32(Console.ReadLine());
        LeapYear yr = new LeapYear();
        if (yr.Leap(year))
        {
            Console.WriteLine("The year " + year + " is leap year\n");
        }
        else
        {
            Console.WriteLine("The year " + year + " is not leap year\n");
        }

        Console.ReadKey();

        //int[] num = [1, 2 , 3 , 4 , 5];
        //int sum = 0;
        //foreach (int i in num)
        //{
        //    sum += i;
        //}
        //    Console.WriteLine(sum);
        
        Class1 obj = new Class1();
        
        //for geting the factorial
        int v = obj.factorial(n);
        Console.WriteLine("the factorial is " + v);
        
        //for checking the prime number
        bool z = obj.prime(a);
        Console.WriteLine("The number is " + ((z)?"Prime":"Not Prime"));
        Console.ReadKey();


    }
}
