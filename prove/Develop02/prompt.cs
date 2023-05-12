using System;

namespace Develop02 {

    ///<summary>
    ///Store premade prompts and provide one at random
    ///</summary>

    public class Prompt {
        public string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
            };


        public string GetRandomString() {
            return prompts[new Random().Next(prompts.Length)];
        }
    }
}