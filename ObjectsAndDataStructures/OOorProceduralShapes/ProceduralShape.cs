using System;

namespace ObjectsAndDataStructures.OOorProceduralShapes
{
    public class ProceduralShape
    {
        public class Square {
            public double Side { get; set; }
        }

        public class Rectangle {
            public double Height { get; set; }
            public double Width { get; set; }
        }

        public class Circle {
            public double Radius { get; set; }
        }

        public class Geometry {
            public const double PI = 3.141592653589793;

            public double Area(object shape) {
                
                if(shape is Square s) {
                    return s.Side * s.Side;
                } 
                else if(shape is Rectangle r) {
                    return r.Height * r.Width;
                } 
                else if(shape is Circle c) {
                    return PI * c.Radius  * c.Radius;
                }
                
                throw new Exception("No such shape.");
            }
        }
    }
}