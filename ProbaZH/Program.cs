using System.Text.Json;

namespace ProbaZH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Repository<Student> repository = new Repository<Student>();
            using (JsonDocument jsonInput = JsonDocument.Parse(File.ReadAllText("students.json")))
            {
                foreach (JsonElement studentData in jsonInput.RootElement.EnumerateArray())
                {
                    string name = studentData.GetProperty("Name").GetString()!;
                    int age = studentData.GetProperty("Age").GetInt32();
                    string neptun = studentData.GetProperty("Neptun").GetString()!;
                    int credits = studentData.GetProperty("Credits").GetInt32();

                    Student student = new Student(name, age, neptun, credits);
                    students.Add(student);
                    repository.Add(student);
                }
            }


            Console.WriteLine("2-es feladat\n");
            foreach (var student in students)
            {
                Console.WriteLine(student + "\n");
            }


            Console.WriteLine("3-as feladat\n");
            Console.WriteLine("Összes hallgatók száma: " + new Student().NumberOfStudents + "\n");


            Console.WriteLine("4-es feladat\n");
            Console.WriteLine(repository.Find(x => x.Neptun.Equals("XYZ789")) + "\n");


            Console.WriteLine("5-ös feladat\n");
            StudentCertificate igazolas = new StudentCertificate(students[0]);
            igazolas.Print();
            Console.WriteLine("\n");


            Console.WriteLine("6-os feladat\n");
            var hallgatok40KreditFelett = students.Where(x=> x.Credits >40).OrderBy(x=>x.Name).ToList();
            foreach(var st in hallgatok40KreditFelett)
                Console.WriteLine(st + "\n");

        }
    }
}
