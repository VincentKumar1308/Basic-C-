using System;
namespace DoWhile;
class Program{
    public static void Main(String [] args){
        string decision=String.Empty;
        bool value;
       //printing odd or even
        do{
            Console.Write("Enter the number:");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0){
                Console.WriteLine($"The entered number {number} is even");
            }
            else{
                 Console.WriteLine($"The entered number {number} is odd");
            }
            Console.Write("Do you want to continue? Yes or No: ");
            decision=Console.ReadLine();
            if(decision=="No"){
                break;
            }
            else if (decision=="Yes"){
                continue;
            }
           if ((decision!="Yes")||(decision!="No")){
               value=true;
               while(value){
                Console.Write("Please enter the correct input: ");
              decision=Console.ReadLine();
              if((decision=="Yes")||(decision=="No")){
                value=false;

              }
               }
           }
           
        }while(decision=="Yes");
    }
    }
