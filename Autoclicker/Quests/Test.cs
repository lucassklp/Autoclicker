using System.Collections.Generic;
using System.Linq;
using Autoclicker.Game;

namespace Autoclicker.Quests
{
    public class Test : IQuest
    {
        public void Execute(List<GameWindowController> party)
        {
            var leader = party.First();
            while(true)
            {
                var point = leader
                    // .SetCropArea(new System.Drawing.Rectangle(455, 355, 246, 166))
                    .Find(GameObject.FemaleHuman_Shoe);
                
                System.Console.WriteLine(point);
            }
        }
    }
}