using System;

namespace PerfectNumbers
{
  
  public class HelloWorld
  {
      public static void Main(string[] args)
      {
          Console.WriteLine("enter first number");
          int s=int.Parse(Console.ReadLine());
        
          Console.WriteLine("enter second number");
          int e=int.Parse(Console.ReadLine());
          int sum = 0;
          for(int x= s; x<= e;x++)
          {
              sum = 0;
              for(int i=1;i<=x; i++)
              {
                  if (x % i==0)
                    sum +=i;
              }
              if (sum==x)
                  Console.WriteLine(x+"is a perfect number");       
         
          }               
      }   
  }
}