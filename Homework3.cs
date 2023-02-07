/* 
 Author: Sebastian Gonzalez
 Homework 3
*/

namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
    
    // Question 1
    Console.WriteLine("Input An Integer:");
      string Integer = Console.ReadLine();
      int number = Convert.ToInt32(Integer);

      for(int x = 2; x <= number / 2; x++){
   
      if (number % x ==0){
   
      Console.WriteLine($"{number} is non-prime");
      return;
      }
      }
      Console.WriteLine($"{number} is prime");

     //Question 2
    Console.WriteLine("Assign an int value to N: ");
      string Integer = Console.ReadLine();
      int N = Convert.ToInt32(Integer);
   
      for(int row = 0; row<N; row++){
      for(int col = 0; col<N; col++)
      {
      Console.Write('*');
      }
      Console.WriteLine("");
      }

    //Question 3
    Console.WriteLine("Assign an int value to N: ");
      string Integer = Console.ReadLine();
      int n = Convert.ToInt32(Integer);

      for(int row = 0; row<n; row++){
      for(int col = 0; col<n; col++)
      {
      if(row>=col)
      Console.Write('*');
      }
      Console.WriteLine("");
      }

    }
}
