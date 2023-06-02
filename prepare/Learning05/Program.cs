using System;
using System.Collections.Generic;

namespace Learning05 {
class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Sqaure sq = new Sqaure("Red", 2.5);
            Rectangle rc = new Rectangle("Blue", 4.5, 2.3);
            Circle cr = new Circle("Yellow", 2.7);

            shapes.Add(sq);
            shapes.Add(rc);
            shapes.Add(cr);

            foreach (Shape shape in shapes) {
                Console.WriteLine(shape.GetArea());
            }
        }
    }
}