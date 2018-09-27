using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters;
using System.IO;

namespace ConsoleApp1
{
    public class Book
    {
        public String title;
    }
    public class Serialization3 
    {
        static void Main(string[] args)
        {
            WriteXML();
        }
        
        public static void WriteXML()
        {
            Book overview = new Book();
            overview.title = "Serialization Overview";
            XmlSerializer writer = new XmlSerializer(typeof(Book));
            FileStream file = new FileStream("F:\\FileIo\\abc.xml",FileMode.Create);
            writer.Serialize(file, overview);
            file.Close();
        }
    }
}
