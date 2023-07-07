namespace Foundation3 {

    public class LectureEvent: Event {
        private string _speaker;
        private int _capacity;

        public LectureEvent(string speaker, int capacity, string title, string desc, string date, string time, string address): base(title, desc, date, time, address) {
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string GetShortInfo() {
            return $"Lecture Event\n{_title}\n{_date}\n";
        }

        public override string GetFullInfo() {
            return $"{_title}\n{_description}\nDate: {_date}\n Time: {_time}\nAddress: {_address}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n";
        }
    }
}