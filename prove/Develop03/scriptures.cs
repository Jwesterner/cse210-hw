using System;
using System.Collections.Generic;



namespace Develop03 {
    
    public class Scriptures {
        string[] _refs = {
            "1 Nephi 1:1",
            "Alma 21:9"
        };
        string[] _verses = {"I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.", "Now Aaron began to open the scriptures unto them concerning the coming of Christ, and also concerning the resurrection of the dead, and that there could be no redemption for mankind save it were through the death and sufferings of Christ, and the atonement of his blood."};

        public int GetRandomIndex() {
            Random rnd = new Random();
            int rndIndex = rnd.Next(0, _verses.Length);
            return rndIndex;
        }

        public string GetRef(int index) {
            return _refs[index];
        }

        public string GetVerse(int index) {
            return _verses[index];
        }
    }
}