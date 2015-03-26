namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TestProgram
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
           {
               new Student("Peso", "Gosev", 4.5),
               new Student("Raso", "Gorev", 2.5),
                new Student("Saso", "Gorev", 3.5),
                 new Student("Taso", "Gorev", 5.5),
                  new Student("Paso", "Gorev", 4),
                   new Student("Risto", "Gorev", 2),
                    new Student("Ivan", "Ivanov", 2.4),
                     new Student("Pero", "Petrov", 3.7),
                      new Student("Dame", "Gruev", 5.3),
                       new Student("Telerik", "Minkov", 2.7),
           };
            List<Worker> workers = new List<Worker>()
           {
               new Worker("Peso", "Gosev",50,5),
               new Worker("Raso", "Gorev",50,5),
                new Worker("Saso", "Gorev", 100.5,6),
                 new Worker("Taso", "Gorev", 60,7),
                  new Worker("Paso", "Gorev", 80,8),
                   new Worker("Risto", "Gorev", 90,6),
                    new Worker("Ivan", "Ivanov", 57.8,7),
                     new Worker("Pero", "Petrov", 80,8),
                      new Worker("Dame", "Gruev", 70,7),
                       new Worker("Telerik", "Minkov", 80,8),
           };
            Console.WriteLine("Students sorted by grade!");
            List<Student> ordered = SortByGrade(students);
            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Workers sorted by MoneyPerHour");
            List<Worker> orderedWorkers = SortByMoneyPerHour(workers);
            foreach (var item in orderedWorkers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Merged students and workers and ordered by first name  and last name!");
            List<Human> mergedCollection = Merge(workers,students);
            foreach (var item in mergedCollection)
            {
                Console.WriteLine(item);
            }
        }
        public static List<Student> SortByGrade(List<Student> students)
        {
            var res = from student in students
                      orderby student.Grade
                      select student;
        return res.ToList<Student>();
        }
        public static List<Worker> SortByMoneyPerHour(List<Worker> workers)
        {
            return workers.OrderByDescending(x => x.MoneyPerHour()).ToList();
        }
        public static List<Human> Merge(List<Worker> workers,List<Student> students)
        {
            List<Human> people = new List<Human>();
            people.AddRange(workers);
            people.AddRange(students);
           List<Human> result = people.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName).ToList();
            return result;
        }
    }
}
