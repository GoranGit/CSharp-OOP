namespace _09StudentGroups
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
using System.Text;
    using System.Collections;

    public class TestProgram
    {
        public static void Main()
        {
            List<Student> listStudents = new List<Student>();
            listStudents.Add(new Student("Marko", "Jakov", "423606", "359 29840303", "abv.bg", new List<int>() { 1, 2, 3, 2, 4, 3 },2));
            listStudents.Add(new Student("Bobi", "Petrov", "423673", "534762387", "abv.bg", new List<int>() { 1, 2, 5, 2, 2, 3 },2));
            listStudents.Add(new Student("Petko", "Popov", "423606", "359 534762387", "hdsjk@yahoo.com", new List<int>() { 1, 2, 6, 6, 3, 3 }, 4));
            listStudents.Add(new Student("Gosho", "Gorgiev", "423673", "534762387", "hdsjk@yahoo.com", new List<int>() { 1, 2, 3, 5, 6, 5 },  4));

            List<Group> groups = new List<Group>() { new Group(2, "Mathematics"), new Group(4, "Biology") };
            Console.WriteLine("Groups:");
            PrintOnConsole(groups);

            Console.WriteLine();
            Console.WriteLine("Students:");
            PrintOnConsole(listStudents);

            Console.WriteLine();
            Console.WriteLine("9-10. Extract by students in group 2");
            //List<Student> s = new List<Student>(GroupTwo(listStudents));
            List<Student> s = new List<Student>(GroupTwoExtension(listStudents));
            PrintOnConsole(s);

            Console.WriteLine();
            Console.WriteLine("11. Extaract by e-main abv.bg");
            List<Student> std = new List<Student>(ExtractByEmail(listStudents));
            PrintOnConsole(std);

            Console.WriteLine();
            Console.WriteLine("12. Extract by phone number in Sofia");
            List<Student> st = new List<Student>(ExtractByTel(listStudents));
            PrintOnConsole(st);

            Console.WriteLine();
            Console.WriteLine("13. Extract with excelent mark");
            Console.WriteLine(ExtractByMarkExcelent(listStudents));

            Console.WriteLine();
            Console.WriteLine("14. Extract with exactly two marks 2");
            List<Student> k = new List<Student>(ExtractExactlyTwoMarksTwo(listStudents));
            PrintOnConsole(k);


            Console.WriteLine();
            Console.WriteLine("15. Extract marks to all students in 2006 ");
            Console.WriteLine(ExtractMarks(listStudents));

            Console.WriteLine();
            Console.WriteLine("16. Extract students in department Mathematics");
            List<Student> math = new List<Student>(ExtractFromMathematicsDep(listStudents, groups));
            PrintOnConsole(math);

            Console.WriteLine();
            Console.WriteLine("17. Longest string of haha, hihihi, huhu is:");
            Console.WriteLine(LongestString(new List<string>() {"haha","hihihi","huhu"}));

            Console.WriteLine();
            Console.WriteLine("18. Students grouped by GroupNumber");
            IEnumerable<IGrouping<int, Student>> groupsGroupNumber = GroupByGroupNumber(listStudents);
            foreach (var group in groupsGroupNumber)
            {
                Console.WriteLine("Group:{0}",group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }

            Console.WriteLine();
            Console.WriteLine("19. Students grouped by GroupNumber extension");
            IEnumerable<IGrouping<int, Student>> groupsGroupNumberExt = GroupByGroupNumberExtension(listStudents);
            foreach (var group in groupsGroupNumberExt)
            {
                Console.WriteLine("Group:{0}", group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
            }


        }
        public static void PrintOnConsole<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static List<Student> GroupTwo(List<Student> list)
        {
            var result = from student in list
                         where (student.GroupNumber == 2)
                         orderby(student.FirstName)
                         select (student);
              return  result.ToList<Student>();
        }
        public static List<Student> GroupTwoExtension(List<Student> list)
        {
            return list.Where(x => x.GroupNumber == 2).OrderBy(s => s.FirstName).ToList<Student>();
        }
        public static List<Student> ExtractByEmail(List<Student> list)
        {
            var result = from student in list
                         where (student.Email.Equals("abv.bg"))
                         select (student);
            return result.ToList();
        }
        public static List<Student> ExtractByTel(List<Student> list)
        {
            var result = from student in list
                         where (student.Tel.Substring(0, 3).Equals("359"))
                         select student;
            return result.ToList();
        }
        public static StringBuilder ExtractByMarkExcelent(List<Student> list)
        {
            var result = from student in list
                         where (student.Marks.Contains(6))
                         select (new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks });

            StringBuilder res = new StringBuilder();

            
            foreach (var item in result)
            {
                res.Append(item.FullName);
                res.Append(" ");
                foreach (var item2 in item.Marks)
                {
                    res.Append(item2);
                    res.Append(" ");
                }
                res.Append("\n");
	       
            }
            return res;
	{
		 
	}
        }
        public static List<Student> ExtractExactlyTwoMarksTwo(List<Student> list)
        {
            var res = list.Where(s => s.Marks.Count(x => x == 2) == 2);
            return res.ToList();
        }
        public static StringBuilder ExtractMarks(List<Student> list)
        {
            var res = list.Where(s => s.FN.Substring(4, 2).Equals("06")).SelectMany(m=>m.Marks);
            StringBuilder result = new StringBuilder();

            foreach (var item in res)
            {
                result.Append(item);
                result.Append(" ");
            }
            return result;
        }
        public static List<Student> ExtractFromMathematicsDep(List<Student> list,List<Group> groups)
        {
            var res = from student in list
                      join g in groups on student.GroupNumber equals g.GroupNumber
                      where g.DepartmentName.Equals("Mathematics")
                      select student ;

            return res.ToList();
        }
        public static string LongestString(List<string> list)
        {
                  var res = from str in list
                      orderby str.Length
                      select str;
                return res.Last();
        }
        public static IEnumerable<IGrouping<int,Student>> GroupByGroupNumber(List<Student> list)
        {
            var k = from student in list
                    group student by student.GroupNumber;
            return k;
        }
        public static IEnumerable<IGrouping<int, Student>> GroupByGroupNumberExtension(List<Student> list)
        {
            return list.GroupBy(x => x.GroupNumber);
        }
    }
}
