namespace Learning05 {

    public class Sqaure : Shape {

        private double _side;

        public Sqaure(string color, double side) : base(color) {
            _side = side;
        }

        public override double GetArea() {
            return _side * _side;
        }
    }
}