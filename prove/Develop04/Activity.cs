using System.Threading;
using System;

namespace Develop04 {

    public abstract class Activity {
        
        private int _time;
        private string _startMsg;
        private string _type;
        private string[] _animationString = {"|", "/", "-", "\\"}; 

        public Activity(int seconds) {
            _time = seconds;
        }

        public int GetTime() {
            return _time;
        }

        public void SetTime(int time) {
            _time = time;
        }

        public string[] GetAnimationString() {
            return _animationString;
        }

        public void SetStartMsg(string startMsg) {
            _startMsg = startMsg;
        }

        public void SetType(string type) {
            _type = type;
        }

        public void DisplayStartMsg() {
            Console.WriteLine($"Welcome to the {_type} Activity!\n");
            Console.WriteLine(_startMsg + "\n");
            Console.WriteLine("How long, in seconds, would you like for your session? ");
        }

        public void DisplayEndMsg() {
            Console.WriteLine("Well Done!! \n");
            Console.WriteLine($"You have completed another {_time} seconds of the {_type} Activity!");
        }

        public void BeginPrep() {
            double prepTime = 3;

            Console.Write("\nGet Ready... ");
            while (prepTime > 0) {
                foreach (string s in _animationString) {
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b \b");
                    prepTime-=0.5;
                }
            }
            Console.WriteLine("\n");
        }

        public abstract void Timer();
    }
}