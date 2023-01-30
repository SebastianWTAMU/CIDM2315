/* 
    Author: Sebastian Gonzalez
    Homework 2
*/
namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
    //Question #1
    Console.WriteLine("Please input a letter grade");
    string Letter = Console.ReadLine();
   
    string A = "A";
    string B = "B";
    string C = "C";
    string D = "D";
    string F = "F";

        if(Letter == A){
        Console.WriteLine("GPA Point:4");
        } else if (Letter == B){
        Console.WriteLine("GPA Point:3");
        }else if (Letter == C){ 
        Console.WriteLine("GPA Point:2");
        }else if (Letter == D){ 
        Console.WriteLine("GPA Point:1");
        }else if (Letter == F){
        Console.WriteLine("GPA Point:0");
        }else{ 
        Console.WriteLine("Wrong Letter Grade!");
        }
    
    
    //Question 2:
    
    Console.WriteLine("Please input the first number");
    string num1 = Console.ReadLine();
    int x = Convert.ToInt16(num1);
    
    Console.WriteLine("Please input the second number");
     string num2 = Console.ReadLine();
    int y = Convert.ToInt16(num2);
    
    Console.WriteLine("Please input the third number");
     string num3 = Console.ReadLine();
    int z = Convert.ToInt16(num3);
    
    if(x<y){
    if(x<z){   
    Console.WriteLine($"The smallest value is: {x}");
    }else{
    Console.WriteLine($"The smallest value is: {z}");    
    }
    }else{
    if(y<z){
    Console.WriteLine($"The smallest value is: {y}");
    }else{
    Console.WriteLine($"The smallest value is: {z}"); 
    }
    
    }
    }
}
