/* 
Author: Sebastian Gonzalez
Homework 4
*/

namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
       // Question 1
       Console.WriteLine("Please input two  integers:");
        string Integer = Console.ReadLine();
        int numA = Convert.ToInt32(Integer);
        string Integer2 = Console.ReadLine();
        int numB = Convert.ToInt32(Integer2);
        int result1 = Question1(numA, numB);
        Console.WriteLine($"a = {numA}, b = {numB}");
        Console.WriteLine($"The largest number is {result1}");
       //Question 2
       Console.WriteLine("Please input an integer N:");
        int N = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Please input a left or right value:");
       string shape = Console.ReadLine();
        Console.WriteLine($"N is : {N}; shape is {shape.ToLower()}");
        Question2(shape, N);

       }
    static int Question1 (int numA, int numB) 
    {
        if(numA>numB){
            return numA;
        }
        else{
            return numB;
        }
    }
    static void Question2(string shape, int N){
        if(shape.ToLower() == "left"){
            for(int row = 0; row<N; row++){
                for(int col = 0; col<N; col++)
                {
                    if(row>=col)
                    Console.Write('*');
                }
                Console.WriteLine("");
            }
        }
            
 
        else if(shape.ToLower() == "right"){ 
      
      for(int row = 1; row<=N; row++){
            for(int col1 = 1; col1<=N - row; col1++)
            { 
                Console.Write(" ");
            }
            for(int col2 = 1; col2<=row; col2++){
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    
        }
    }

}
