using System;

namespace Foundation4 {

    public class Swimming: Activity {

        private int _laps;
        
        public Swimming(int time, string date, int laps) : base(time, date) {
            _laps = laps;
        }

        public override double GetDistance() {
            return _laps * 0.05;
        }

        public override double GetPace() {
            return base.GetTime() / GetDistance();
        }

        public override double GetSpeed() {
            return (GetDistance() / base.GetTime()) * 60;
        }

        public override string GetSummary() {
            return $"{base.GetDate()} Swimming ({base.GetTime()} min) - Distance: {GetDistance():N1} km, Speed: {GetSpeed():N1} kph, Pace: {GetPace():N1} min per km";
        }
    }
}