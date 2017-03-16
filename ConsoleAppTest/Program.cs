using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("勞保投保薪資分級表");

            XmlDocument doc = new XmlDocument();
            doc.Load(@"./test.xml");


            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;

            //
            string t1 = root.SelectSingleNode("FIELDS/colum_1").InnerText;
            string t2 = root.SelectSingleNode("FIELDS/colum_2").InnerText;
            string t3 = root.SelectSingleNode("FIELDS/colum_3").InnerText;
            string t4 = root.SelectSingleNode("FIELDS/colum_4").InnerText;
            Console.WriteLine("{0, -20} {1, -20} {2, -20} {3, -20}", t1, t2, t3, t4);


            //
            nodeList = root.SelectNodes("DATA");

            foreach (XmlNode nd in nodeList)
            {
                string C1 = nd.SelectSingleNode("colum_1").InnerText;
                string C2 = nd.SelectSingleNode("colum_2").InnerText;
                string C3 = nd.SelectSingleNode("colum_3").InnerText;
                string C4 = nd.SelectSingleNode("colum_4").InnerText;
                Console.WriteLine("{0, -20} {1, -20} {2, -20} {3, -20}", C1, C2, C3, C4);
            }

            Console.Read();

        }
    }
}
