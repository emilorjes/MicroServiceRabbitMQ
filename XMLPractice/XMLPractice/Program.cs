using System.Xml.Linq;

namespace XMLPractice
{
    class Program
    {
        public static void Main()
        {
            XDocument doc = new(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Product Information"),
                new XElement("Products"));

            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}