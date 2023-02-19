/*C#程序2：运算符*/
using System;

namespace Program_2{
    class Program{
        static void Main(string[] args){
            int a=10;
            int b=2;
            //算数运算符
            //+ - * / %
            Console.WriteLine("加法{0}",a+b);
            Console.WriteLine("减法{0}",a-b);
            Console.WriteLine("乘法{0}",a*b);
            Console.WriteLine("除法{0}",a/b);
            Console.WriteLine("求余数{0}",a%b);
            //赋值运算符
            //= += -= /= *= %= <<= >>= &= ~= ^= |=
            int c=0;
            c+=a;
            c*=2;
            c/=5;
            c%=3;
            Console.WriteLine("{0}",c);
            //左移和右移运算符
            //>> <<
            int d=6;
            Console.WriteLine("左移{0}",d>>2);
            Console.WriteLine("右移{0}",d<<2);
            //位运算符
            //& | ^ ~
            int e=10;
            Console.WriteLine(e&2);
            //逻辑运算符
            //&& || ！ == ！= < > <= >=
            bool f=true,g=false;
            Console.WriteLine("{0}",f&&g);
            Console.WriteLine("{0}",f==g);
            Console.WriteLine("{0}",!f);
            Console.WriteLine("{0}",f!=g);

            return;
        } 
    }
} 