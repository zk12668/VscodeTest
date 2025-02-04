namespace ConsoleApp1;

public class Student
{
    public string StudentName{ get; set;}
    public int Sex{get;set;}
    public static int studentNo{get;set;}
    public int CurrentStudentNo{get;set;}

     static Student()
    {
         studentNo=13;
    }
    public Student(string studentName,int sex )
    {
           StudentName=studentName;
           Sex=sex;
           //StudentNo=StudentNo+1;
           CurrentStudentNo=studentNo;

    }
    public static void GetStudentNo()
    {
        studentNo=new Random().Next(1,100);
    }
    public string GetName()
    {
        return StudentName;
    }
}
