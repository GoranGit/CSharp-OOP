namespace _09StudentGroups
{
    using System;

     public class Group
    {
         public int GroupNumber { get; set; }
         public string DepartmentName { get; set; }

         public Group(int gNumber,string depName)
         {
             this.GroupNumber = gNumber;
             this.DepartmentName = depName;
         }
         public Group(Group group):this(group.GroupNumber,group.DepartmentName)
         { }

         public override string ToString()
         {
             return String.Format("Group number={0}  Department={1}",this.GroupNumber,this.DepartmentName);
         }
    }
}
