using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace module
{
    internal class Serializator
    {
        private static string pathToWorkers = @"Task1\Workers.txt";
        private static string pathToSalaries = @"Task1\Salarys.txt";
        private static void CheckForRoot()
        {
            Directory.CreateDirectory("Task1");

            if (!File.Exists(@"Task1\Workers.txt"))
                using (File.Create(@"Task1\Workers.txt")) { }

            if (!File.Exists(@"Task1\Salarys.txt"))
                using (File.Create(@"Task1\Salarys.txt")) { }
        }

        public static void Serialize(Person person)
        {
            CheckForRoot();

            if (person is Worker worker)
            {
                var people = Deserealizator.DeserializeWorkers();
                people.Add(worker);
                string json = JsonSerializer.Serialize(people, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(pathToWorkers, json);
            }
            else if (person is Salary salary)
            {
                var salaries = Deserealizator.DeserializeSalaries();
                salaries.Add(salary);
                string json = JsonSerializer.Serialize(salaries, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(pathToSalaries, json);
            }
        }
    }
}
