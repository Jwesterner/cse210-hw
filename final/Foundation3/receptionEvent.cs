namespace Foundation3 {

    public class ReceptionEvent: Event {
        private string _email;

        public ReceptionEvent(string email, string title, string desc, string date, string time, string address): base(title, desc, date, time, address) {
            _email = email;
        }

        public override string GetShortInfo() {
            return $"Reception Event\n{_title}\n{_date}\n";
        }

        public override string GetFullInfo() {
            return $"{_title}\n{_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nRSVP at: {_email}\n";
        }
    }
}