namespace module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>
{
    new Worker(1, "Ivanov I.I.", Worker.Education.University, Worker.Specialty.Developer, new DateTime(1985, 5, 12)),
    new Worker(2, "Petrov P.P.", Worker.Education.College, Worker.Specialty.Tester, new DateTime(1990, 3, 23)),
    new Worker(3, "Sidorov S.S.", Worker.Education.University, Worker.Specialty.Manager, new DateTime(1978, 7, 5)),
    new Worker(4, "Kovalenko K.K.", Worker.Education.School, Worker.Specialty.Designer, new DateTime(1995, 11, 15)),
    new Worker(5, "Shevchenko S.S.", Worker.Education.University, Worker.Specialty.Analyst, new DateTime(1988, 9, 30)),
    new Worker(6, "Bondarenko B.B.", Worker.Education.College, Worker.Specialty.Developer, new DateTime(1992, 1, 18)),
    new Worker(7, "Tkachenko T.T.", Worker.Education.University, Worker.Specialty.Tester, new DateTime(1980, 4, 10)),
    new Worker(8, "Melnyk M.M.", Worker.Education.School, Worker.Specialty.Manager, new DateTime(1997, 8, 22)),
    new Worker(9, "Fedorov F.F.", Worker.Education.University, Worker.Specialty.Designer, new DateTime(1983, 12, 3)),
    new Worker(10, "Zinchenko Z.Z.", Worker.Education.College, Worker.Specialty.Analyst, new DateTime(1991, 2, 7)),
    new Worker(11, "Kravchenko K.K.", Worker.Education.University, Worker.Specialty.Developer, new DateTime(1975, 6, 14)),
    new Worker(12, "Lysenko L.L.", Worker.Education.School, Worker.Specialty.Tester, new DateTime(2000, 9, 19)),
    new Worker(13, "Moroz M.M.", Worker.Education.University, Worker.Specialty.Manager, new DateTime(1986, 10, 25)),
    new Worker(14, "Hrytsenko H.H.", Worker.Education.College, Worker.Specialty.Designer, new DateTime(1993, 5, 8)),
    new Worker(15, "Marchenko M.M.", Worker.Education.University, Worker.Specialty.Analyst, new DateTime(1982, 7, 29))
};

            List<Salary> salaries = new List<Salary>
{
    new Salary(1, 20000, 22000),
    new Salary(2, 15000, 16000),
    new Salary(3, 30000, 35000),
    new Salary(4, 12000, 13000),
    new Salary(5, 25000, 24000),
    new Salary(6, 18000, 19000),
    new Salary(7, 28000, 30000),
    new Salary(8, 11000, 11500),
    new Salary(9, 26000, 27000),
    new Salary(10, 17000, 18000),
    new Salary(11, 32000, 33000),
    new Salary(12, 9000, 9500),
    new Salary(13, 24000, 26000),
    new Salary(14, 16000, 15000),
    new Salary(15, 27000, 28000)
};
         foreach (var worker in workers)
            {
                Serializator.Serialize(worker);
            }
            foreach (var salary in salaries)
            {
                Serializator.Serialize(salary);
            }
            Task1 task1 = new Task1();
            Console.WriteLine("First Task: Workers older than 35:");
            task1.FirstTask();
            Console.WriteLine();
            Console.WriteLine("Second Task: Worker with highest salary:");
            task1.SecondTask();
            Console.WriteLine();
            Console.WriteLine("Third Task: Workers with below average salary:");
            task1.ThirdTask();
            Console.WriteLine();
            decimal inputSalary = 30000;
            Console.WriteLine($"Fourth Task: Workers with University education and salary above {inputSalary}:");
            task1.FourthTask(inputSalary);
        }
    }
}
