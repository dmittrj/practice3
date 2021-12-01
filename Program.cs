using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace P_5._1
{
    class Person
    {

    }
    class Program
    {
        private static void Serialize(Person sp)
        {
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, sp);
            fs.Close();
        }
        private static Person Deserialize()
        {
            Person dsp = new Person();
            FileStream fs = new FileStream("Person.Dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            dsp = (Person) bf.Deserialize(fs);
            fs.Close();
            return dsp;
        }

    static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
