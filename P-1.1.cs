using System;

namespace Practice_1._1
{
    struct Person
    {
        //ex. 1
        public string firstName;
        public string lastName;
        public int age;
        public Person(string _firstName, string _lastName, int _age, Genders _gender)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
            gender = _gender;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " (" + gender + "), age " + age;
        }

        //ex. 2
        public enum Genders: int { Male, Female};
        public Genders gender;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tony", "Alien", 32, Person.Genders.Male);
            Console.WriteLine(p.ToString());
        }
    }
}

