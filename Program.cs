using System;
using System.IO;
using System.Xml.Serialization;

namespace Practice_5._2
{
    class Person
    {

    }
    class Program
    {
        private static void Serialize(Person sp)
        {
            FileStream fs = new FileStream("Person.XML", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            xs.Serialize(fs, sp);
            fs.Close();
        }

        private static Person Deserialize()
        {
            Person dsp = new Person();
            FileStream fs = new FileStream("Person.XML", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            dsp = (Person)xs.Deserialize(fs);
            fs.Close();
            return dsp;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
