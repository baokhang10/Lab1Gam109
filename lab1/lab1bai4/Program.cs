using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age ) 
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        
    }
}
 class Program
{
    static void Main()
    {
        List<Student> studentList = new List<Student>();
        studentList.Add(new Student("Khang", 18));
        studentList.Add(new Student("khanh", 19));
        studentList.Add(new Student("kha", 20));
        foreach (var student in studentList)
        {
            student.DisplayInfo();
            
        }
        Console.ReadLine();
    }
}
