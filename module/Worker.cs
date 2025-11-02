using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module
{
    internal class Worker :Person
    {
        public enum Education
        {
          School,
          College,
            University
        }
        public enum Specialty
        {
            Developer,
            Tester,
            Manager,
            Designer,
            Analyst
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public Education LevelOfEducation { get; set; }
        public Specialty JobSpecialty { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Worker() { }
        public Worker(int id, string name, Education education, Specialty specialty, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            LevelOfEducation = education;
            JobSpecialty = specialty;
            DateOfBirth = dateOfBirth;
        }
    }
}
