namespace Develop03 {
    
    public class Word {

        string _text;
        bool _hidden = false;

        public Word(string text) {
            _text = text;
        }

        public string GetWord() {
            return _text;
        }

        // changes word to underscores if hidden value is true
        public string GetConditionalWord() {
            if (_hidden == true) {
                string condText;
                for (condText = ""; condText.Length < _text.Length; condText += "_") {};
                return condText;
            }

            return _text;
        }

        public void SetHidden() {
            _hidden = true;
        }
    }
}