using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ConsoleApp1
{
    class Serialization2
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\abc.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            
            Student s1 = (Student)formatter.Deserialize(stream);
            Student s2 = (Student)formatter.Deserialize(stream);
            Student s3=  (Student)formatter.Deserialize(stream);
            Student s4 = (Student)formatter.Deserialize(stream);
            Student s5 = (Student)formatter.Deserialize(stream);
            Console.Write("Rollno: " + s1.rollno);
            Console.WriteLine(" Name: " + s1.name);
            Console.Write("Rollno: " + s2.rollno);
            Console.WriteLine(" Name: " + s2.name);
            Console.Write("Rollno: " + s3.rollno);
            Console.WriteLine(" Name: " + s3.name);
            Console.Write("Rollno: " + s4.rollno);
            Console.WriteLine(" Name: " + s4.name);
            Console.Write("Rollno: " + s5.rollno);
            Console.WriteLine(" Name: " + s5.name);

            stream.Close();
            Console.Read();

        }
    }
}
