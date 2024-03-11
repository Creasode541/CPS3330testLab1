// Michael Banko - CPS3330 Midterm SP24
namespace CircleOperationsLib {
    public class Circle {
        public double Radius { 
            get; 
            set; 
        }
        public Circle(double radius) {
            Radius = radius;
        }
        public double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double Perimeter() {
            return 2 * Math.PI * Radius;
        }
        public double Diameter() {
            return 2 * Radius;
        }
    }
}