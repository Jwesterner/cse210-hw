using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02 {

    ///<summary>
    ///Load journal data to and from a specified filename
    ///</summary>

    public class DataStore {


        public void SaveToFile(string filename, List<Entry> list) {
            
            using (TextWriter tw = new StreamWriter(filename)) {

                foreach (Entry item in list) {
                    tw.WriteLine(item.GetAsString());
                }
            }
        }

        public Journal LoadFile(string filename, Journal journal) {


            using (TextReader tr = new StreamReader(filename)) {
                string[] text = tr.ReadToEnd().Split( new string[] {"\n\n"}, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string chunk in text) {
                    Entry storageEntry = new Entry();

                    string[] line = chunk.Split('\n');
                    journal.StoreEntry(new Entry() {
                        prompt = line[2],
                        response = line[1],
                        date = line[0]
                    });
                    
                }


            }

            return journal;

        }

    }
}