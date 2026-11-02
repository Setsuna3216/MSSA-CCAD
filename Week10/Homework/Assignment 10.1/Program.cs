
using System;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;

namespace Assignment_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            

            student.Id = 1;
            student.Name = "John";
            student.Age = 25;

            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            string json = JsonSerializer.Serialize(student);


            Console.WriteLine(json);
            File.WriteAllText("student.json", json);
            string jsonData = File.ReadAllText("student.json");

            Student? loadedStudent =
                JsonSerializer.Deserialize<Student>(jsonData);

            Console.WriteLine("Deserialized Student:");

            if (loadedStudent != null)
            {
                Console.WriteLine(loadedStudent.Id);
                Console.WriteLine(loadedStudent.Name);
                Console.WriteLine(loadedStudent.Age);
            }

            Console.WriteLine("JSON file saved successfully!");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
            using (FileStream stream = File.Create("student.xml"))
            {
                xmlSerializer.Serialize(stream, student);
            }

            Console.WriteLine("XML file saved successfully!");


            using (FileStream stream = File.OpenRead("student.xml"))
            {
                Student? xmlStudent =
                    (Student?)xmlSerializer.Deserialize(stream);

                if (xmlStudent != null)
                {
                    Console.WriteLine("Deserialized XML Student:");
                    Console.WriteLine(xmlStudent.Id);
                    Console.WriteLine(xmlStudent.Name);
                    Console.WriteLine(xmlStudent.Age);
                }
            }


            using (BinaryWriter writer = new BinaryWriter(
                File.Open("student.bin", FileMode.Create)))
            {
                writer.Write(student.Id);
                writer.Write(student.Name);
                writer.Write(student.Age);
            }

            Console.WriteLine("Binary file saved successfully!");


            Student binaryStudent = new Student();

            using (BinaryReader reader = new BinaryReader(
                File.Open("student.bin", FileMode.Open)))
            {
                binaryStudent.Id = reader.ReadInt32();
                binaryStudent.Name = reader.ReadString();
                binaryStudent.Age = reader.ReadInt32();
            }

            Console.WriteLine("Deserialized Binary Student:");
            Console.WriteLine(binaryStudent.Id);
            Console.WriteLine(binaryStudent.Name);
            Console.WriteLine(binaryStudent.Age);

        }
    }
}
