namespace Foundation4 {

    public abstract class Activity {
        
        private int _time;
        private string _date;

        public Activity(int time, string date) {
            _time = time;
            _date = date;
        }

        public string GetDate() {
            return _date;
        }

        public int GetTime() {
            return _time;
        }

        public abstract string GetSummary();

        public abstract double GetDistance();

        public abstract double GetSpeed();

        public abstract double GetPace();
    }
}