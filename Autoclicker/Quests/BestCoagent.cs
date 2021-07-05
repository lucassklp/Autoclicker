using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Autoclicker.Game;

namespace Autoclicker.Quests
{
    public class BestCoagent : IQuest
    {
        public void Execute(List<GameWindowController> party)
        {
            var leader = party.First();
            var toggle = true;
            while(true)
            {
                leader.WaitFor(GameObject.Out_Of_Battle)
                    .ClickOn(new Point(toggle ? 300 : 600, 300))
                    .Wait(toggle ? 2000 : 500)
                    .ThenRun(() => toggle = !toggle);
            }
        }
    }
}