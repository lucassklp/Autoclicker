using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Autoclicker.Game;

namespace Autoclicker.Quests
{
    public class RedRope : IQuest
    {
        public void Execute(List<GameWindowController> party)
        {
            var leader = party.First();

            while(true)
            {
                leader.MoveAndClickOn(GameObject.MoonElder);
                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.MoonHelderTrouble);
                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.IllFindRedRope);


                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.ClosePopup);

                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.InventoryButton);


                Thread.Sleep(500);
                leader.MoveAndRightClickOn(GameObject.Windseeker);
                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.Hurricane9);
                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.Spot6);

                Thread.Sleep(1500);
                leader.MoveAndClickOn(Position.WalkCloserToRobberChief);

                Thread.Sleep(1500);
                leader.MoveAndClickOn(GameObject.RobberChief);

                leader.WaitForClicking(GameObject.RobberChiefMsg);

                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.GiveMeTheRedRope);

                Thread.Sleep(4000);

                leader.WaitFor(GameObject.Out_Of_Battle);

                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.InventoryButton);

                Thread.Sleep(500);
                leader.MoveAndRightClickOn(GameObject.RedTeleport);

                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.RedTeleport_Wood);

                Thread.Sleep(1500);
                leader.MoveAndClickOn(GameObject.CloseButton);

                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.MapButton);

                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.Minimap_MoonElder);

                Thread.Sleep(500);
                leader.MoveAndClickOn(Position.MapButton);

                Thread.Sleep(9500);
            }
        }
    }
}