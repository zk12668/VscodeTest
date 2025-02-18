using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
   
    class Program
    {       
        static void Main(string[] args)
        {
      
          Person student=new Student();
          student.Eat();
          Person teacher=new teacher();
          teacher.Eat();

          IUsb usbLight=new Light();
          usbLight.Work();
          IUsb usbfun =new Fun();
          usbfun.Work(); 

          Animal myDog = new Dog();
          myDog.Speak();
          Animal myCat = new Cat();
          myCat.Speak();         
        }
  
    }
    #region 接口实现多态
    interface IUsb{
        void Work();
    }
    class Light:IUsb
    {
      public void Work()
       {
         Console.WriteLine("台灯亮了");
       }
    }
    class Fun:IUsb
    {
      public void Work()
       {
         Console.WriteLine("风扇转了");
       }

    }
    #endregion

    #region 虚方法实现多态
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }
    public class Dog:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog 旺旺旺");
        }
    }
    public class Cat:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat 喵喵喵");
        }
    }
    #endregion

    #region 抽象实现多态
   abstract class Person
    {
         public abstract void Eat();

    }
    class Student:Person
    {  
            public override void Eat()
        {

             Console.WriteLine("Student can eat");

        }

    }
        class teacher:Person
    {  
            public override void Eat()
        {

             Console.WriteLine("teacher can eat");

        }

    }
    #endregion
}