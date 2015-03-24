namespace _03_19_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TestProgram
    {
        static void Main()
        {
           List<Student> list = new List<Student>();


            list.Add(new Student("Pesho", "Goriev",18));
            list.Add(new Student("Gorgi", "Pesov",17));
            list.Add(new Student("Andrei", "Bogatinov",27));
            list.Add(new Student("Marko", "Jakov",20));
            list.Add(new Student("Ana", "Ann",14));

            Console.WriteLine("All Students");
            foreach (var item in list)
            {
                Console.WriteLine("Student {0}", item);
            }

            Console.WriteLine();
            Console.WriteLine("03.First Name  before Last:");
            List<string> firstBeforeLast = new List<string>(FirstBeforeLast(list));
            foreach (var item in firstBeforeLast)
            {
                Console.WriteLine(item);                
            }

            Console.WriteLine();
            Console.WriteLine("04.Age  between 18 and 24");
            List<string> ageRank = new List<string>(AgeRange(list));
            foreach (var item in ageRank)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("05.Ordered students by first name  then by last name:");
            List<Student> students = new List<Student>(OrderStudents(list));
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("06.Integer array");
            List<int> integers = new List<int>() {1,2,3,4,5,6,7,8,21};
            foreach (var item in integers)
            {
                Console.WriteLine(item);
            }
             Console.WriteLine("Integer numbers that are  devisible  with 7 and 3:");
            integers = DevisibleBySevenAndThree(integers);
            foreach (var item in integers)
            {
                Console.WriteLine(item);
            }

        }

        public static List<string> FirstBeforeLast(List<Student> list)
        {

            var res = from student in list
                      where (string.Compare(student.FirstName, student.LastName) < 0)
                      select (String.Format("First name:{0}   Last name:{1}", student.FirstName, student.LastName));
            return res.ToList();
           // return list.Where(s => (string.Compare(s.FirstName, s.LastName)) < 0).Select(x => String.Format("First name:{0}   Last name:{1}", x.FirstName, x.LastName)).ToList();
        }
        public static List<string> AgeRange(List<Student> list)
        {
            // easy for debug :)
            //Func<Student, bool> k = s => {return (s.Age > 18) && (s.Age < 24);};
            //Func<Student, string> l = s => { return String.Format("First name:{0}  Last name:{1}", s.FirstName, s.LastName); };
            //List<string> result = list.Where(k).Select(l).ToList();

            var res = from student in list
                      where ((student.Age > 18) && (student.Age < 24))
                      select (String.Format("First name:{0}  Last name:{1}", student.FirstName, student.LastName));
          

            return res.ToList();

       }
        public static List<Student> OrderStudents(List<Student> list)
        {
           // return list.OrderBy(s => s.FirstName).ThenBy(s => s.LastName).ToList();
            var result = from student in list
                         orderby(student.FirstName)
                         orderby(student.LastName)
                         select(student);
            return result.ToList();
        }
        public static List<int> DevisibleBySevenAndThree(List<int> list)
        {
            return list.Where(x => (x % 7 == 0) && (x % 3 == 0)).ToList();
        }

    }
}
