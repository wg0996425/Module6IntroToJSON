using M6JSONIntro;
using Newtonsoft.Json;
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {

            List<Person> people = [];

            Person person1 = new()
            {
                Name = "John Doe",
                Age = 30,
                Email = "johndoe1234@companya.com",
                IsStudent = true
            };
            people.Add(person1);

            Person person2 = new Person
            {
                Name = "Joe Loser",
                Age = 22,
                Email = "joeloser4321@companyb.com",
                IsStudent = true
            };
            people.Add(person2);

            // SERIALIZE LIST
            string json = JsonConvert.SerializeObject(people);
            Console.WriteLine("Serialized JSON: " + json);

            // DESERIALIZE LIST
            var deserializedPeople = JsonConvert.DeserializeObject<List<Person>>(json);
            Console.WriteLine($"Deserialized JSON: \n{String.Join("\n", deserializedPeople)}");
        }
        catch (JsonReaderException jre)
        {
            Console.WriteLine($"Invalid JSON Error: {jre}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"No JSON File Found!");
        }
    }
}