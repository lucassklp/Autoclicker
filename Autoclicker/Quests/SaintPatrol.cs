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
                leader.SetAutoDelay(500)
                    .ClickOn(GameObject.SaintPatrol)
                    .WaitFor(GameObject.PatrolSaintMsg)
                    .ClickOn(Position.SaintPatrolConfirm)
                    .Wait(2000)
                    .WaitFor(GameObject.Out_Of_Battle);
            }
        }
    }
}