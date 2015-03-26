namespace School
{
    using System;
    using School.People;
    public class Discipline : IComents
    {
        private string name;
        private string comment;
        private int numOfLectures;
        private int numOfExercises;
        public Discipline(string name,int numOfLectures,int numOfExercises)
        {
            this.NumberOfExercises = numOfExercises;
            this.Name = name;
            this.NumberOfLectures = numOfLectures; 
        }
        public string Name 
        {
            get 
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Name  can't be  null or white space!");
                else
                    this.name = value;
            }
        }
        public int NumberOfLectures 
        {
            get 
            {
                return this.numOfLectures;
            }
            set
            {
                if (value <0)
                    throw new ArgumentOutOfRangeException("Parameter number of lectures can't be negative!");
                else
                    this.numOfLectures = value;
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numOfExercises;
            }
            set
            {
                if (value <0)
                    throw new ArgumentOutOfRangeException("Parameter number of excersise can't be <0!");
                else
                    this.numOfExercises = value;
            }
        }
        public string CommentText
        {
            get
            {
                if (String.IsNullOrEmpty(this.comment))
                    return "No comment";
                else
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        public override string ToString()
        {
            return String.Format("\n Discipline  name: {0} \n Lecture numbers:{1} \n Excersise numbers: {2}",this.Name,this.NumberOfLectures,this.NumberOfExercises);
        }

        
    }
}
