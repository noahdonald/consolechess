using System;
namespace ReallyDumbChess
{
    public class Cell
    {
        public int rowNum { get; set; }
        public int columnNum { get; set; }
        public bool occupied { get; set; }
        public bool legalMove { get; set; }

        public Cell(int x,int y)
        {
            rowNum = x;
            columnNum = y; 
        }
    }
}

