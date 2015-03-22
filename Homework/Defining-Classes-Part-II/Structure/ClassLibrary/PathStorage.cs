namespace Structure
{
    using System;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Collections.Generic;
   public static class PathStorage
    {
       public static List<Path> listPath = new List<Path>();

       public static void Save(Path path)
       {
           listPath.Add(path);
           IFormatter formatter = new BinaryFormatter();
           Stream stream = new FileStream("Paths.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
           formatter.Serialize(stream, listPath);
           stream.Close();   
       }
       public static List<Path> Load()
       {
           IFormatter formatter = new BinaryFormatter();
           Stream stream = new FileStream("Paths.txt", FileMode.Open, FileAccess.Read, FileShare.Read);        
           List<Path> obj = (List<Path>)formatter.Deserialize(stream);
           stream.Close();
           return obj;

       }
    }
}
