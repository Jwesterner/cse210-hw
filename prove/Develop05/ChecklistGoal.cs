namespace Develop05 {

    public class ChecklistGoal : Goal {

        private int _bonusPoints;
        private int _timesCompleted;
        private int _target;

        public ChecklistGoal(string name, string description, int pointsPer, int bonusPoints, int target, int timesCompleted) : base(name, description, pointsPer) {
            _bonusPoints = bonusPoints;
            _target = target;
            _timesCompleted = timesCompleted;
        }

        public override int GetPoints() {
            if (_timesCompleted == _target) {
                return _pointsPer + _bonusPoints;
            } else {
                return _pointsPer;
            }
        }

        public override int CalculateScore() {

            int points = _timesCompleted * _pointsPer;
            if (_timesCompleted == _target) {
                points += _bonusPoints;
            }
            return points;
        }

        public override void Complete() {
            
            if (_timesCompleted < _target) {
                _timesCompleted++;
            }

        }

        public override string GetInfo() {

            bool status = _timesCompleted == _target;
            return $"[{(status?"X": " ")}] {_name} ({_description}) -- Currently Complete: {_timesCompleted}/{_target}";
        }

        public override string Serialize() {
            return $"ChecklistGoal|{_name}|{_description}|{_pointsPer}|{_bonusPoints}|{_target}|{_timesCompleted}\n";
        }
    }
}