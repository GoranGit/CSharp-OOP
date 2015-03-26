namespace _03_Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public  class TestProgram
    {
      public  static void Main()
        {
            List<Animal> animals = new List<Animal>();
            Cat mara = new Cat("Mara", "Female", 12);
            Cat lopa = new Cat("Lopa", "Female", 10);
            Cat miropa = new Cat("Miropa","Female",12);
            Dog kroki = new Dog("Kroki", "Male", 13);
            Frog krek = new Frog("Kreki", "Male", 15);
            TomCat tom = new TomCat("Tom", "Male", 25);
            Kitten kitten = new Kitten("Kitten", "Female", 22);
            animals.Add(mara);
            animals.Add(lopa);
            animals.Add(krek);
            animals.Add(kitten);
            animals.Add(miropa);
            animals.Add(kroki);
            animals.Add(tom);
            foreach (var item in animals)
            {
                Console.WriteLine(item.Sound());
            }

           Dictionary<string,double> averageAge =  AverageAgeForEach(animals);
           foreach (var item in averageAge)
           {
               Console.WriteLine(item.Key+" average age: "+ item.Value);
           }
        }
        public static Dictionary<string,double> AverageAgeForEach(List<Animal> animals)
      {
          Dictionary<string,double> result = new Dictionary<string,double>();
          var res = animals.GroupBy(x => x.GetType().Name);
          foreach (var item in res)
          {
              result[item.Key.ToString()]= item.Average(x => x.Age);      
          }
          return result;                             
      }
    }
}
