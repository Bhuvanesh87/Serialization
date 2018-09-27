using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp1
{
    public class Serialization4
    {
             
        public static void ReadXML()
        {
            XmlSerializer reader = new XmlSerializer(typeof(Book));
            StreamReader file = new StreamReader(@"F:\FileIo\abc.xml");
            Book overview = (Book)reader.Deserialize(file);
            file.Close();
            Console.WriteLine(overview.title); 
            Console.Read();

        }
        static void Main(string[] args)
        {
            ReadXML();
        }
    }
}
