namespace School
{
    using System;
    using School.People;
    using System.Collections.Generic;
    public class TestProgram
    {
        static void Main()
        {

            List<IPerson> people = new List<IPerson>();
            SchoolClass schoolClass = new SchoolClass("FirstClass", 2);
            Student pesho = new Student(2, "Pesho", "Very good student!");
            Teacher gosho = new Teacher("Gosho");
            Discipline disciplina = new Discipline("Mathematics", 4, 4);
            Discipline disciplina2 = new Discipline("Biology", 4, 5);
            gosho.AddDiscipline(disciplina);
            gosho.AddDiscipline(disciplina2);
            people.Add(pesho);
            people.Add(gosho);
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

        }
    }
}
