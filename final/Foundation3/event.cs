namespace Foundation3 {

    public abstract class Event {
        protected string _title;
        protected string _description;
        protected string _date;
        protected string _time;
        protected string _address;

        public Event(string title, string desc, string date, string time, string address) {
            _title = title;
            _description = desc;
            _date = date;
            _time = time;
            _address = address;
        }

        public string GetStandardInfo() {
            return $"{_title}\n{_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\n";
        }

        public abstract string GetShortInfo();

        public abstract string GetFullInfo();
    }
}