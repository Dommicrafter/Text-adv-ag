using System.Collections.Generic;

namespace TextAdv
 {
     public class StoryStep
     {
         public List<string> Erzaehlungen { get; set; }

         public Dictionary<string, string> Antworten { get; set; }

         public StoryStep(List<string> erzaehlungen, Dictionary<string, string> antworten)
         {
            Erzaehlungen = erzaehlungen;
            Antworten = antworten;
         }

     }
 }