using System;

namespace Foundation4 {

    public class Cycling: Activity {

        public double _speed;

        public Cycling(int time, string date, double speed) : base(time, date) {
            _speed = speed;
        }

        public override double GetDistance() {
            return base.GetTime() / GetPace();
        }

        public override double GetPace() {
            return 60/_speed;
        }

        public override double GetSpeed() {
            return _speed;
        }

        public override string GetSummary() {
            return $"{base.GetDate()} Cycling ({base.GetTime()} min) - Distance: {GetDistance():N1} km, Speed: {GetSpeed():N1} kph, Pace: {GetPace():N1} min per km";
        }
    }
}