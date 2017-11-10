using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: validation for input values for coordinates or rows/columns
// TODO: validation for input values for coordinates to check if valid triangle coordinates

namespace CherellCodingQuestion
{
    // each vertex v1, v2, v3 will be a Vector
    public struct Vector
    {
        public int X;
        public int Y;

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    // each coordinate wil contain 3 vectors
    public struct Coordinates
    {
        public Vector V1;
        public Vector V2;
        public Vector V3;
    }

    // row and column representation of the triangle
    public class RowAndColumn
    {
        public RowLetter Row { get; set; }
        public int Column { get; set; }        
    }

    // The rows
    public enum RowLetter
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6
    }

    public class Triangle
    {     
        public RowLetter RowLetter { get; set; }

        public int Column { get; set; }
        public int RowNum { get; set; }

        public Coordinates Coordinates { get; set; }

        // get coordinates for the provided row and column
        public Coordinates GetCoordinates(RowLetter rowLetter, int column)
        {
            int row = Convert.ToInt32(rowLetter);            

            Coordinates coordinates = new Coordinates();
                        
            // v2 is always the top left point whether it is an even or odd column.
            coordinates.V2.Y = (row - 1) * 10;
            coordinates.V2.X = ((column-1) / 2) * 10;

            // v3 is always the bottom right point whether it is an even or odd column.
            coordinates.V3.Y = row * 10;
            coordinates.V3.X = coordinates.V2.X + 10;

            // use this check to properly set the v1
            if (isUpperTriangle(rowLetter, column))
            {
                // will be top right point if upper triangle
                coordinates.V1.Y = coordinates.V2.Y;
                coordinates.V1.X = coordinates.V3.X;
            }
            else
            {
                // will be bottom left point if lower triangle
                coordinates.V1.Y = coordinates.V3.Y;
                coordinates.V1.X = coordinates.V2.X;
            }

            return coordinates;
        }

        // get row and column for provided coordinates
        public RowAndColumn GetRowAndColumn(Coordinates coordinates)
        {
            RowLetter row;
            int column;

            //use this check to properly set the vertex
            if (isUpperTriangle(coordinates))
            {
                row = (RowLetter)(coordinates.V3.Y / 10);
                column = ((coordinates.V2.X / 10) * 2) + 2;
            }
            else
            {
                row = (RowLetter)(coordinates.V1.Y / 10);
                column = ((coordinates.V2.X / 10) * 2) + 1;
            }            

            RowAndColumn rowAndColumn = new RowAndColumn();
            rowAndColumn.Row = row;
            rowAndColumn.Column = column;

            return rowAndColumn;
        }

        // assumption, the top triangle's (even columns) v2 and v3 are same point as shown in image in pdf
        // and v1 is the point where the non-hypotenuse lines meet

        // if column is even, then upper
        private bool isUpperTriangle(RowLetter rowLetter, int column)
        {
            return (column % 2 == 0);            
        }

        // if v1y is same as v2y, then upper
        private bool isUpperTriangle(Coordinates coordinates)
        {
            return (coordinates.V1.Y == coordinates.V2.Y);            
        }
    }
}
