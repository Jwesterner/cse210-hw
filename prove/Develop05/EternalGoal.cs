namespace Develop05 {

    public class EternalGoal : Goal {
        int _timesCompleted;


        public EternalGoal(string name, string description, int pointsPer, int timesCompleted) : base(name, description, pointsPer) {
            _timesCompleted = timesCompleted;
        }

        public override int CalculateScore() {

            return _pointsPer * _timesCompleted;
        }

        public override void Complete() {
            _timesCompleted++;
        }

        public override string GetInfo() {
            return $"[ ] {_name} ({_description} - Times Completed: {_timesCompleted})";
        }

        public override string Serialize() {
            return $"EternalGoal|{_name}|{_description}|{_pointsPer}|{_timesCompleted}\n";
        }

    }
}