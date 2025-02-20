using System;
using System.Net;
using System.Runtime.InteropServices;
using 里氏替换;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus  bus=new Bus();
            bus.Color="黄色";
            bus.Length=9;
            bus.Run();
        //    Car car =new Car();
        //    car.Color="红色";
        //    car.Length=5;
        //    car.Run();

           Truck truck=new Truck();
           truck.Color="蓝色";
           truck.Length=8;
           truck.Carriage="渣土";
           //truck.Freight();
           RunCar(truck);

        //    Car car1=new Truck();//如果用父类的变量接收子类的对象，拿到的是父类的属性
        //    car1.Color="绿色";
        //    car1.Length=3;
        //    car1.Run();

           SUV suv=new SUV();
           suv.Color="白色";
           suv.Length=3;
           suv.seat="6";
           RunCar(suv);
        
        }

        private static void RunCar(Car car)//好处可以方便父类接收不同子类对象
        {
            car.Run();
        }
    }
}