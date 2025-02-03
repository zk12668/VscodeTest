// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        #region  静态成员
        //Console.WriteLine("Hello, World!");
        Student student1 = new Student("Ace", 1);
        //student1.StudentName="Ace";
        //student1.Sex=1;
        //student1.StudentNo=0;

        Student student2 = new Student("Taro", 1);
        //student2.StudentName="Taro";
        //student2.Sex=1;
        //student2.StudentNo=1;
        #endregion

        #region  静态方法
        Student.GetStudentNo();
        #endregion

         Console.WriteLine(Student.studentNo);
        #region 静态类的扩展方法
       // Console.WriteLine( );

        #endregion

    }
}



