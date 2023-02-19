/*C#程序3：判断*/
using System;

namespace Program_3{
    class Program{
        static void Main(string[] args){
            int a=10,b=8;
            if(a==b){
                Console.WriteLine("a等于b");
            }
            else if(a>=b){
                Console.WriteLine("a大于等于b");
            }
            else{
                if(a>=0){
                    Console.WriteLine("a大于等于0");
                }
                else if(a<0){
                    Console.WriteLine("{0}",b);
                }
                Console.WriteLine("其他");
            }
        }
    }
}