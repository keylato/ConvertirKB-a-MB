using System;

namespace TC_1
{
    class Program
    {
        static void Main(string[] args)
        {
           //solicitar kilobytes
           //transformar kilobytes a megabytes 
           // 1 megabyte= 1024 kilobytes
           Console.WriteLine("Por favor ijntroduce el numero de Kylobytes"); 
        
           {
            int megabyte= 0;
            int kilobyte= 1024;

            if( megabyte/ 1024== 0)
            {
                kilobyte= megabyte; 
            }
            else if( megabyte/ (1024* 1024) ==0)
            {
                kilobyte= 1;
            Console.WriteLine (kilobyte + "mb =");

            }   
              

           }

            

        }
    }
}
