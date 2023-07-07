using System;

namespace Foundation4 {

    public class Running: Activity {

        private double _distance;

        public Running(int time, string date, double distance) : base(time, date) {
            _distance = distance;
        }

        public override double GetDistance() {
            return _distance;
        }

        public override double GetPace() {
            return base.GetTime() / _distance;
        }

        public override double GetSpeed() {
            return (_distance / base.GetTime()) * 60;
        }

        public override string GetSummary() {
            return $"{base.GetDate()} Running ({base.GetTime()} min) - Distance: {GetDistance():N1} km, Speed: {GetSpeed():N1} kph, Pace: {GetPace():N1} min per km";
        }
    }
}