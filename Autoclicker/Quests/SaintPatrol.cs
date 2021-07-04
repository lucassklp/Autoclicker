using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Autoclicker.Game;

namespace Autoclicker.Quests
{
    public class SaintPatrol : IQuest
    {
        public void Execute(List<GameWindowController> party)
        {
            var leader = party.First();
            while(true)
            {
                leader.ClickOn(GameObject.SaintPatrol);
                while(leader.IsNotThere(GameObject.PatrolSaintMsg))
                {
                    continue;
                }
                leader.ClickOn(Position.SaintPatrolConfirm);
                Thread.Sleep(1000);
                while (leader.IsNotThere(GameObject.Out_Of_Battle))
                {
                    Thread.Sleep(1000);
                    continue;
                }
            }
        }
    }
}