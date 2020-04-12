namespace ObjectsAndDataStructures.OOorProceduralShapes
{
    public class PolymorphicShape
    {
        public class Square : IShape
        {
            private double _side;
            public Square(double side)
            {
                _side = side;
            }
        
            public double Area()
            {
                return _side * _side;
            }
        }

        public class Retangle : IShape
        {
            private double _height;
            private double _width;

            public Retangle(double height, double width)
            {
                _height = height;
                _width = width;
            }

            public double Area()
            {
                return _height * _width;
            }
        }

        public class Circle : IShape
        {
            private double _radius;
            private const double PI = 3.141592653589793;

            public Circle(double radius)
            {
                _radius = radius;
            }

            public double Area()
            {
                return PI * _radius * _radius;
            }
        }
    }

    public interface IShape {
        double Area();
    }
}