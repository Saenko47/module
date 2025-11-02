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
            decimal avgSal = salary.Average(n => n.AmountFirst + n.AmountSecond);
            List<int> sal = salary.Where(n => n.AmountFirst + n.AmountSecond < avgSal).Select(n => n.Id).ToList();
            List<Worker> workersWithBelowAvgSalary = worker.Where(n => sal.Contains(n.Id)).ToList();
            foreach (var worker in workersWithBelowAvgSalary)
            {
                Console.WriteLine($"Worker Name: {worker.Name}");
            }

        }
        public void FourthTask(decimal input)
        {
            List<int> ints = salary.Where(n => n.AmountFirst + n.AmountSecond > input).Select(n => n.Id).ToList();
            List<Worker> workersWithSalaryAboveInput = worker.Where(n => ints.Contains(n.Id) && n.LevelOfEducation == Education.University).ToList();
            foreach (var worker in workersWithSalaryAboveInput)
            {
                Console.WriteLine($"Worker Name: {worker.Name}, Education Level: {worker.LevelOfEducation}");
            }
        }
    }
}
