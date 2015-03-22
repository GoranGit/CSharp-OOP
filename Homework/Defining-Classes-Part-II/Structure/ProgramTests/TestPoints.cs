namespace Test.ProgramTests
{
    using System;
    using System.Collections.Generic;
    using Structure;

   public static class TestPoints
    {
       public static void Test()
       {

           // test a PathStorage functionality
           Path k = new Path();
           k.Points[0] = new Point3D(5, 5, 5);
           k.Points[1] = new Point3D(6, 6, 6);
           Path p = new Path();
           p.Points[0] = new Point3D(4, 5, 5);
           p.Points[1] = new Point3D(1, 6, 6);

           PathStorage.Save(k);
           PathStorage.Save(p);
           List<Path> l = PathStorage.Load();
           foreach (Path path in l)
           {
               Console.WriteLine(path.Points[0].ToString());
               Console.WriteLine(path.Points[1].ToString());
           }  
       }
    }
}
