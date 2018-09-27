using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    [Serializable]
    public class Student
    {
        public int rollno;
        public  string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class Serialization1
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\abc.txt", FileMode.OpenOrCreate);
            BinaryFormatter f1 = new BinaryFormatter();

            Student s1 = new Student(1, "Bhuvanesh");
            Student s2 = new Student(2, "Madhu");
            Student s3 = new Student(3, "Rajesh");
            Student s4 = new Student(4, "Mahesh");
            Student s5 = new Student(5, "Anji");
            f1.Serialize(stream, s1);
            f1.Serialize(stream, s2);
            f1.Serialize(stream, s3);
            f1.Serialize(stream, s4);
            f1.Serialize(stream, s5);

            stream.Close();
            Console.Read();
        }
    }
        
}
