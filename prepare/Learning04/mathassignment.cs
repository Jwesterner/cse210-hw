namespace Learning04 {

    public class MathAssignemnt : Assignment {

        private string _textbookSection;
        private string _problems;

        public MathAssignemnt(string name, string topic, string section, string problems) : base(name, topic) {
            _textbookSection = section;
            _problems = problems;
        }

        public string GetHomeworkList() {
            return $"Section {_textbookSection} problems {_problems}";
        }
    }
}