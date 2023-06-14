using System;
using System.Threading;
namespace Develop04 {

    public class Breathing : Activity {

        public Breathing(int seconds) : base(seconds) {
            base.SetType("Breathing");
            base.SetStartMsg("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            }

        public Breathing() : base(30) {
        base.SetType("Breathing");
        base.SetStartMsg("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }

        public override void Start() {
            int timeLeft = base.GetTime();
            int cycle = 0;

            Console.WriteLine();

            while (timeLeft > 0) {
                if (cycle % 2 == 0) {
                    Console.Write("Breathe in... ");
                } else {
                    Console.Write("Breathe out... ");
                }

                for (int i = 5; i > 0; i--) {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    timeLeft--;
                }

                cycle++;
                Console.WriteLine();
            }
        }

    }
}