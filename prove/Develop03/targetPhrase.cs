using System.Collections.Generic;
using System;

namespace Develop03 {

        public class TargetPhrase {
            List<Word> _verse;
            string _reference;

            // Initializes current class and Word class.
            public TargetPhrase(string reference, string scripture) {
                _reference = reference;
                _verse = new List<Word>();

                string[] words = scripture.Split(" ");
                foreach (string item in words) {
                    _verse.Add(new Word(item));
                }
            }

            // Hides given number of words from verse.
            // DOES NOT REMOVE HIDDEN WORDS FROM POSSIBILITIES
            public void HideWords(int count) {
                Random rnd = new Random();
                for (int i = 0; i<count; i++) {
                    int rndIndex = rnd.Next(0, _verse.Count);
                    _verse[rndIndex].SetHidden();
                }
            }

            // Concats modified verse.
            public string GetModifiedVerse() {
                string modifiedVerse = "";
                foreach (Word word in _verse) {
                    modifiedVerse += " " + word.GetConditionalWord();
                }

                return modifiedVerse;
            }
        }
}