 

using System;

namespace MyApplication
{
  class Car
  {  
     
      string color = "red";
    
      static void Main(string[] args)
    {
       Car mercedes = new Car();
       Car Tesla = new Car();
        Console.WriteLine(mercedes.color);
        Console.WriteLine(Tesla.color);
    }
  }   

}  