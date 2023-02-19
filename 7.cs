/*C#程序7：数组*/
using System;

namespace Program_7{
    class Program{
        static void Main(string[] args){
            int[] array=new int[10];
            for(int i=0;i<10;i++){
                array[i]=i;
            }
            
            foreach(int a in array){
                Console.WriteLine("{0}",a);
            }
        }
    }
}