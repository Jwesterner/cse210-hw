namespace Foundation3 {

    public class OutdoorEvent: Event {
        private string _weather;

        public OutdoorEvent(string weather, string title, string desc, string date, string time, string address): base(title, desc, date, time, address) {
            _weather = weather;
        }

        public override string GetShortInfo() {
            return $"Outdoor Event\n{_title}\n{_date}\n";
        }

        public override string GetFullInfo() {
            return $"{_title}\n{_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nWeather: {_weather} - Dress appropriately\n";
        }
    }
}