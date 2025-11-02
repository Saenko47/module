using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace module
{
    internal class Deserealizator
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
        public static List<Worker> DeserializeWorkers()
        {
            CheckForRoot();
            string json = File.ReadAllText(pathToWorkers);
            if (string.IsNullOrWhiteSpace(json) || json == "[]")
                return new List<Worker>();
            return JsonSerializer.Deserialize<List<Worker>>(json)!;
        }

        public static List<Salary> DeserializeSalaries()
        {
            CheckForRoot();
            string json = File.ReadAllText(pathToSalaries);
            if (string.IsNullOrWhiteSpace(json) || json == "[]")
                return new List<Salary>();
            return JsonSerializer.Deserialize<List<Salary>>(json)!;
        }
    }
}
