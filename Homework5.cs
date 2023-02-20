/* 
Author: Sebastian Gonzalez
Homework 4
*/

namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
    //Question 1
    Console.WriteLine("Please input two integers");
    string Integer = Console.ReadLine();
    int a = Convert.ToInt32(Integer);
    string Integer2 = Console.ReadLine();
    int b = Convert.ToInt32(Integer2);
    int result = Question1(a, b);
    Console.WriteLine($"a = {a}, b = {b}");
    Console.WriteLine($"The largest number is {result}");
    //Question 2
    Console.WriteLine("Please input four integers");
    int n1 = Convert.ToInt32(Console.ReadLine()); 
    int n2 = Convert.ToInt32(Console.ReadLine()); 
    int n3 = Convert.ToInt32(Console.ReadLine()); 
    int n4 = Convert.ToInt32(Console.ReadLine()); 
    int result2 = Question2(n1,n2,n3,n4);
    Console.WriteLine($"a = {n1}, b = {n2}, c = {n3}, d = {n4}");
    Console.WriteLine($"The largest number is {result2}");
    //Question3
    createAccount();
    }
    //Question 1
    static int Question1(int numA, int numB){
        if (numA>numB){
            return numA;
        }
        else{ 
            return numB;
        }
    }
    //Question 2
    static int Question2(int nB, int nA, int nC, int nD){
        int m1 = Question1(nA, nB);
        int m2 = Question1(nC,nD);
        int result2 = Question1(m1, m2);
        return result2;
    }
    //Question 3
    static bool checkAge(int birth_year){
      int age = 2022-birth_year;

      if(age >= 18){
        return true;

      }else{
        return false;
      }
        

    }
    //Question3
    static void createAccount(){
        Console.WriteLine("Enter your Username:");
        string Username = Console.ReadLine();
        //int numA = Convert.ToInt32(Integer);
        Console.WriteLine("Enter your Password:");
        string Password = Console.ReadLine();
        //int numA = Convert.ToInt32(Integer);
        Console.WriteLine("Enter your Password Again:");
        string Password1 = Console.ReadLine();
        //int numA = Convert.ToInt32(Integer);
        Console.WriteLine("Enter your Birthyear:");
        string Integer = Console.ReadLine();
        int birth_year = Convert.ToInt32(Integer);
        bool pwd_result = PasswordVerify(Password, Password1);
        bool age_result = checkAge(birth_year);
        AccountCreation(pwd_result,age_result);
    }
    //Question3
     static bool PasswordVerify(string Password, string Password1){
    if(Password == Password1){
        return true;
    }else{
        return false;
    }

    }
    //Question3

    static void AccountCreation(bool PasswordVerify, bool checkAge){
        if(checkAge == true)
        {
            if(PasswordVerify == true)
            {
                Console.WriteLine("Account is created sucessfully");
            }

            else //PasswordVerify = false
            {
                
                Console.WriteLine("Wrong password");
                
            }
        }
        else //checkAge = false
        {
            
            Console.WriteLine("Could not create an account");
            
        }
    }
 
    

}
