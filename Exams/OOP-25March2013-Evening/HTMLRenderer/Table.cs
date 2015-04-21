using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class Table : Element, ITable, IElement
    {
        private int rows;
        private int cols;
        private IElement[,] elements;

        public Table(int rows, int cols)
            : base("table")
        {
            this.Rows = rows;
            this.Cols = cols;
            this.elements = new Element[this.Rows, this.Cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("You can't create table  with less than 1 rows!");
                else
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

                if (value < 1)
                    throw new ArgumentOutOfRangeException("You can't create table  with less than 1 colums!");
                else
                    this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                CheckInTable(row, col);
                return this.elements[row, col];
            }
            set
            {
                if (value == null)
                    throw new NullReferenceException("Null value for element in table is no allowed!");
                else
                    CheckInTable(row, col);
                this.elements[row, col] = value;
            }
        }

        private bool CheckInTable(int row, int col)
        {
            if (row > this.Rows || row < 0 || col < 0 || col > this.Cols)
                throw new ArgumentOutOfRangeException("Out of table dimensions!");
            else
                return
                   true;

        }
    }
}
