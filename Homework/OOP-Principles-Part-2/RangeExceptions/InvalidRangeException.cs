namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {

        private T startIndex;
        private T endIndex;

        public InvalidRangeException(string message, T startIndex, T endIndex, Exception e)
            : base(String.Format("{0} Invalid range exceprion, range  must be  between {1} and {2}", message, startIndex, endIndex), e)
        {
        }
        public InvalidRangeException(string message, T startIndex, T endIndex)
            : this(message, startIndex, endIndex, null)
        {
        }


        public T StartIndex
        {
            get
            {
                return this.startIndex;
            }

        }

        public T EndIndex
        {
            get
            {
                return this.endIndex;
            }
        }


    }

}