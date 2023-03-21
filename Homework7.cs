/* Homework 7 
By Sebastian Gonzalez */
namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer(110,"Alice",28);
        Customer Bob = new Customer(111,"Bob",30);
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();
        
        Alice.ChangeID(220);
        Bob.ChangeID(221);

        Alice.PrintCusInfo();
        Bob.PrintCusInfo();
        
        Alice.CompareAge(Bob);
    }

    class Customer{
        private int cus_id = 0;
        public string cus_name = string.Empty;
        public int cus_age = 0;

        public Customer(int cus_id, string cus_name, int cus_age){
            this.cus_id = cus_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }

        public void ChangeID(int new_id){
            cus_id = new_id;
        }
        public void PrintCusInfo(){
            Console.WriteLine($"Customer:{cus_id},name:{cus_name},age:{cus_age}");
          
        }
        public void CompareAge(Customer objcustomer){
            if(this.cus_age < objcustomer.cus_age){
                Console.WriteLine($"{objcustomer.cus_name} is older");
            }else if(this.cus_age > objcustomer.cus_age){
                Console.WriteLine($"{this.cus_name} is older");
            }else{
                Console.WriteLine($"Alice and Bob are the same age");
            }

        }


    }



}
