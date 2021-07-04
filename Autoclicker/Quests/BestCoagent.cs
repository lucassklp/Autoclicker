using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
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
                if(!leader.IsNotThere(GameObject.Out_Of_Battle))
                {
                    leader.ClickOn(new Point(toggle?300:600, 300));
                    Thread.Sleep(toggle? 2000 : 500);
                    toggle = !toggle;
                }
            }
        }
    }
}