using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherellCodingQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            // Test with A1, C6, E7, F12
            // get the coordinates from the row and columns
            Coordinates coords1 = triangle.GetCoordinates(RowLetter.A, 1);
            Coordinates coords2 = triangle.GetCoordinates(RowLetter.C, 6);
            Coordinates coords3 = triangle.GetCoordinates(RowLetter.E, 7);
            Coordinates coords4 = triangle.GetCoordinates(RowLetter.F, 12);

            // output the results.
            Console.WriteLine(string.Format("A1: v1({0},{1}), v2({2},{3}), v3({4},{5})",
                coords1.V1.X, coords1.V1.Y, coords1.V2.X, coords1.V2.Y, coords1.V3.X, coords1.V3.Y));

            Console.WriteLine(string.Format("C6: v1({0},{1}), v2({2},{3}), v3({4},{5})",
                coords2.V1.X, coords2.V1.Y, coords2.V2.X, coords2.V2.Y, coords2.V3.X, coords2.V3.Y));

            Console.WriteLine(string.Format("E7: v1({0},{1}), v2({2},{3}), v3({4},{5})",
                coords3.V1.X, coords3.V1.Y, coords3.V2.X, coords3.V2.Y, coords3.V3.X, coords3.V3.Y));

            Console.WriteLine(string.Format("F12: v1({0},{1}), v2({2},{3}), v3({4},{5})",
                coords4.V1.X, coords4.V1.Y, coords4.V2.X, coords4.V2.Y, coords4.V3.X, coords4.V3.Y));

            // create the coordinates for A1, C6, E7, F12
            Coordinates coordA1 = new Coordinates();
            coordA1.V1.X = 0;
            coordA1.V1.Y = 10;
            coordA1.V2.X = 0;
            coordA1.V2.Y = 0;
            coordA1.V3.X = 10;
            coordA1.V3.Y = 10;

            Coordinates coordC6 = new Coordinates();
            coordC6.V1.X = 30;
            coordC6.V1.Y = 20;
            coordC6.V2.X = 20;
            coordC6.V2.Y = 20;
            coordC6.V3.X = 30;
            coordC6.V3.Y = 30;

            Coordinates coordE7 = new Coordinates();
            coordE7.V1.X = 30;
            coordE7.V1.Y = 50;
            coordE7.V2.X = 30;
            coordE7.V2.Y = 40;
            coordE7.V3.X = 40;
            coordE7.V3.Y = 50;

            Coordinates coordF12 = new Coordinates();
            coordF12.V1.X = 60;
            coordF12.V1.Y = 50;
            coordF12.V2.X = 50;
            coordF12.V2.Y = 50;
            coordF12.V3.X = 60;
            coordF12.V3.Y = 60;

            // get the row and column for those coordinates and verify they are corrctly retrieved
            RowAndColumn rowColA1 = triangle.GetRowAndColumn(coordA1);
            RowAndColumn rowColC6 = triangle.GetRowAndColumn(coordC6);
            RowAndColumn rowColE7 = triangle.GetRowAndColumn(coordE7);
            RowAndColumn rowColF12 = triangle.GetRowAndColumn(coordF12);

            // output the results
            Console.WriteLine(rowColA1.Row.ToString() + rowColA1.Column);
            Console.WriteLine(rowColC6.Row.ToString() + rowColC6.Column);
            Console.WriteLine(rowColE7.Row.ToString() + rowColE7.Column);
            Console.WriteLine(rowColF12.Row.ToString() + rowColF12.Column);

            Console.Read();
        }
    }
}
