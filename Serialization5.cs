using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
namespace ConsoleApp1
{
    [Serializable]
    public class Serialization5
    {
        private int myaccountnumber = 0;
        [NonSerialized()]
        private string password = "bhuna56789";
        public int MyAccNum { set; get; }
        public string Passwd { set; get; }
        public Serialization5()
        {
        }
        static void Main()
        {
            try
            {
                Serialization5 obj1 = new Serialization5();
                obj1.MyAccNum = 123321456;
                //Soap serialization technique
                SoapFormatter formatter = new SoapFormatter();
                Stream objfilestream = new FileStream("F:\\FileIo\\soap1.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(objfilestream, obj1);
                objfilestream.Close();

                //deserialization
                Stream obj2 = new FileStream("F:\\FileIo\\soap1.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Serialization5 objSecrete2 = (Serialization5)formatter.Deserialize(obj2);
                int Myaccno = objSecrete2.MyAccNum;
                Console.WriteLine("Account number is " + Myaccno.ToString());
                Console.Read();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
