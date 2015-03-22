namespace Structure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    public class Matrix<T> where T: IComparable
    {
        private T[,] elements;
        private int rows;
        private int cols;
        const int InitialRowCol = 4;

        public Matrix(int row, int col)
        {
            this.elements = new T[row, col];
            this.rows = row;
            this.cols = col;
        }

        public Matrix()
            : this(InitialRowCol, InitialRowCol)
        {

        }


        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                this.cols = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.elements[row, col];
            }
            set
            {
                this.elements[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)
        {
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            if (typeof(T) == typeof(string) || typeof(T) == typeof(char) || typeof(T) == typeof(string[]))
            {
                throw new ArgumentException(" string[,] is not alowed in substraction!");
            }
            else
            {
                if (a.Cols != b.Cols || a.Rows != b.Rows)
                {
                    throw new ArgumentException("Both matrixs must be  with equal number of rows and colums!");
                }
                else
                {
                    for (int i = 0; i < a.Rows; i++)
                    {
                        for (int j = 0; j < a.Cols; j++)
                        {
                            result[i, j] = (dynamic)a[i, j] + b[i, j];
                        }
                    }
                }
                return result;
            }

        }

        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            if (typeof(T) == typeof(string) || typeof(T) == typeof(char) || typeof(T) == typeof(string[]))
            {
                throw new ArgumentException(" string[,] is not alowed in substraction!");
            }
            else
            {
                if (a.Cols != b.Cols || a.Rows != b.Rows)
                {
                    throw new ArgumentException("Both matrixs must be  with equal number of rows and colums!");
                }
                else
                {
                    for (int i = 0; i < a.Rows; i++)
                    {
                        for (int j = 0; j < a.Cols; j++)
                        {
                            result[i, j] = (dynamic)a[i, j] - b[i, j];
                        }
                    }
                }
                return result;
            }

        }

        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            Matrix<T> result = new Matrix<T>(a.Rows, a.Cols);

            if (typeof(T) == typeof(string) || typeof(T) == typeof(char) || typeof(T) == typeof(string[]))
            {
                throw new ArgumentException(" string[,] is not alowed in substraction!");
            }
            else
            {
                if (a.Rows != b.Cols || a.Cols != b.Rows)
                {
                    throw new ArgumentException("First matrix must have equal number of rows as the number of colums of the second matrix(colums same)!");
                }
                else
                {
                    for (int j = 0; j < a.Rows; j++)
                    {
                        for (int i = 0; i < a.Cols; i++)
                        {
                            result[j, i] += (dynamic)a[j, i] * b[i, j];
                        }
                    }
                    return result;
                }

            }
        }

        public static bool operator true(Matrix<T> a)
        {
            for (int i = 0; i < a.Rows;i++ )
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    if (a[i, j] == (dynamic)0)
                        return false;
                    
                }

            }
            return true;
        }
            
        public static bool operator false(Matrix<T> a)
        {
            for (int i = 0; i < a.Rows;i++ )
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    if (a[i, j] == (dynamic)0)
                        return true;
                    
                }

            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder k = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    k.Append(this.elements[i, j]);
                    k.Append(" ");
                }
                k.Append("\n");
            }
           return k.ToString();
        }
    }
}
