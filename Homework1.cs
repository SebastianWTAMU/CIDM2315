/* 
 Author: Sebastian Gonzalez
 Homework 1
*/



namespace Homework1;
class Program
{
    static void Main(string[] args)
    {
// The linear line Equation is: Z = 4X^2+3Y, when  X = 2.5, Y=3.3

    double X = 2.5;
    double Y = 3.3;
    
    Console.WriteLine("X = 2.5" + "," + " Y = 3.3 ");
    Console.WriteLine( "The value of Z is: " + (4*X*X+3*Y));
    
    }
}
