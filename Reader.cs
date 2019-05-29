
using System.Collections.Generic;
using System.IO;

namespace TextAdv
{
    public static class Reader
    {
        public static StoryStep ReadFile(string path)
        {
            StreamReader r = new StreamReader(path);
            List<string> Ausgabe = new List<string>();
            Dictionary<string,string> Antworten = new Dictionary<string,string>();
            bool isAntworten = false;
            while(!r.EndOfStream)
            {
                string temp = r.ReadLine();

                if (temp == ">")
                {
                    isAntworten = true;
                }
                else if (!isAntworten)
                {
                    Ausgabe.Add(temp);
                } else
                {
                    string[] split = temp.Split('|');
                    Antworten.Add(split[0], split[1]);
                    //TODO: Die verschieden Inputs falls Zeile leer bspw. interpretiern
                }
            }
            StoryStep result = new StoryStep(Ausgabe, Antworten);

            return result;
        }
    }
}