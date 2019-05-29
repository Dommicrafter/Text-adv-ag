using TextAdv.helpers;

namespace TextAdv
{
    public static class GameLoop 
    {
        public static void MainLoop(string path)
        {
            StoryStep txt = Reader.ReadFile(Paths.GetRelativePath() + "/assets/" + path);
            foreach(string t in txt.Erzaehlungen)
            {
                System.Console.WriteLine(t);
            }

            System.Console.WriteLine();
            foreach(string s in txt.Antworten)
            {
                System.Console.WriteLine(s);
            }
            MainLoop();

        }
    }
}