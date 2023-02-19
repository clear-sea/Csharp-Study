/*C#程序4：循环*/
using System;

namespace Program_4
{
    class Program{
        static void Main(string[] args){
            int a=0;
            //while循环
            while(a<10){
                System.Console.WriteLine("{0}",a);
                a++;
            }

            Console.WriteLine();
            //for循环
            for(int b=0;b<10;b++){
                System.Console.WriteLine("{0}",b);
            }

            Console.WriteLine();
            //foreach遍历
            int[] c={0,1,2,3,4,5,6,7,8,9};
            foreach(int element in c){
                System.Console.WriteLine("{0}",element);
            }
        }
    }
}