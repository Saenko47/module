using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static module.Worker;

namespace module
{
    internal class Task1
    {
        private List<Worker> worker;
        private List<Salary> salary;
        public Task1()
        {
            worker = Deserealizator.DeserializeWorkers();
            salary = Deserealizator.DeserializeSalaries();
        }
        public void FirstTask()
        {
            List<Worker> workersOlderThat35 = worker.Where(n => DateTime.Now.Year - n.DateOfBirth.Year > 35).ToList();
            foreach (var worker in workersOlderThat35)
            {
                Console.WriteLine($"Worker Name: {worker.Name}, Date of Birth: {worker.DateOfBirth.ToShortDateString()}");
            }
        }
        public void SecondTask()
        {
            Salary maxSalary = salary.OrderByDescending(n => n.AmountSecond).FirstOrDefault();
            if (maxSalary != null)
            {
                Worker workerWithMaxSalary = worker.FirstOrDefault(n => n.Id == maxSalary.Id);
                if (workerWithMaxSalary != null)
                {
                    Console.WriteLine($"Worker with highest salary: {workerWithMaxSalary.Name},Szlary: {maxSalary.AmountFirst + maxSalary.AmountSecond}");
                }
            }
        }
        public void ThirdTask()
        {
           decimal averageSalary = salary.Average(n => n.AmountFirst + n.AmountSecond);
          var workserBelowAvarage = worker.Join(salary,
                w => w.Id,
                s => s.Id,
                (w, s) => new { Worker = w, Salary = s })
                .Where(ws => (ws.Salary.AmountFirst + ws.Salary.AmountSecond) < averageSalary)
                .Select(ws => ws.Worker)
                .ToList();
            foreach (var worker in workserBelowAvarage)
            {
                Console.WriteLine($"Worker Name: {worker.Name}");
            }


        }
        public void FourthTask(decimal input)
        {
            var selectedWorkers = worker.Join(salary,
                w => w.Id,
                s => s.Id,
                (w, s) => new { Worker = w, Salary = s })
                .Where(ws => (ws.Salary.AmountFirst + ws.Salary.AmountSecond) > input && ws.Worker.LevelOfEducation == Education.University)
                .Select(ws => ws.Worker)
                .ToList();
            foreach (var worker in selectedWorkers)
                {
                Console.WriteLine($"Worker Name: {worker.Name}");
                }

            }
    }
}
