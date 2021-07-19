using System.Collections.Generic;
using System.Linq;
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
                leader.SetAutoDelay(1000)
                    .ClickOn(GameObject.MoonElder)
                    .ClickOn(Position.Option_MoonHelderTrouble)
                    .ClickOn(Position.Option_IllFindRedRope)
                    .ClickOn(Position.MiddleOfDialogBox)
                    .ClickOn(Position.InventoryButton)
                    .RightClickOn(GameObject.Windseeker)
                    .ClickOn(Position.Windseeker_Option_Hurricane9)
                    .ClickOn(Position.Windseeker_Option_Spot6)
                    .Wait(1500)
                    .ClickOn(Position.WalkCloserToRobberChief)
                    .Wait(1000)
                    .ClickOn(GameObject.RobberChief)
                    .WaitForClicking(GameObject.RobberChiefMsg)
                    .ClickOn(Position.Option_GiveMeTheRedRope)
                    .Wait(4000)
                    .WaitFor(GameObject.Out_Of_Battle)
                    .ClickOn(Position.InventoryButton)
                    .RightClickOn(GameObject.RedTeleport)
                    .ClickOn(Position.RedTeleport_Wood)
                    .Wait(1500)
                    .ClickOn(GameObject.CloseButton)
                    .ClickOn(Position.MapButton)
                    .ClickOn(Position.Minimap_MoonElder)
                    .ClickOn(Position.MapButton)
                    .Wait(10000);
            }
        }
    }
}