/*C#程序5：类（封装）*/
using System;

namespace Program_5{
    class Rectangle{
        public double height;
        public double width;

        public void set(double width,double height){
            this.height=height;
            this.width=width;
        }
        public double getArea(){
            return height*width;
        }
        public void show(){
            Console.WriteLine("{0}",height);
            Console.WriteLine("{0}",width);
            Console.WriteLine("{0}",this.getArea());
        }
    }

    class Program{
        static void Main(string[] args){
            Rectangle r=new Rectangle();
            r.set(10.5,5.5);
            r.show();
            return;
        }
    }
}