namespace Develop02 {

    ///<summary>
    ///The responsibility of an Entry is to record (or store) a prompt,
    ///response, and date
    ///</summary>

    public class Entry {

        public string prompt;
        public string response;
        public string date;

        public string GetAsString() {
            return $"Date: {date}\nPrompt: {prompt}\nResponse: {response}\n";
        }

        public void store(string prompt, string response, string date) {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }
    }
}