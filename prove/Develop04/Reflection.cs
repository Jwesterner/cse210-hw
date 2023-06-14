using System.Threading;
using System;
namespace Develop04 {

    public class Reflection : Activity {

        private string[] _prompts = {"Think of a time when you stood up for someone else.", 
                                    "Think of a time when you did something really difficult.", 
                                    "Think of a time when you helped someone in need.", 
                                    "Think of a time when you did something truly selfless."};

        private string[] _questions = {"Why was this experience meaningful to you?", 
                                        "Have you ever done anything like this before?",
                                        "How did you get started?",
                                        "How did you feel when it was complete?",
                                        "What made this time different than other times when you were not as successful?",
                                        "What is your favorite thing about this experience?",
                                        "What could you learn from this experience that applies to other situations?",
                                        "What did you learn about yourself through this experience?",
                                        "How can you keep this experience in mind in the future?"};

        public Reflection(int seconds) : base(seconds) {
            base.SetType("Reflection");
            base.SetStartMsg("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }

        public Reflection() : base(30) {
            base.SetType("Reflection");
            base.SetStartMsg("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }

        private void DisplayRandomPrompt() {
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, _prompts.Length);
            Console.WriteLine(_prompts[rndIndex]);
        }

        private void DisplayRandomQuestion() {
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, _questions.Length);
            Console.WriteLine(_questions[rndIndex]);
        }

        public override void Start() {
            double timeLeft = base.GetTime();
            string[] animation = base.GetAnimationString();

            DisplayRandomPrompt();
            Thread.Sleep(5000);

            DisplayRandomQuestion();

            while (timeLeft > 0) {
                foreach (string s in animation) {
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    timeLeft-=0.5;
                    if (timeLeft % 5 == 0) {
                        DisplayRandomQuestion();
                    }
                }
            }
        }
    }
}