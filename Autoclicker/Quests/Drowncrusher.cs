using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Autoclicker.Game;

namespace Autoclicker.Quests
{
    public class Drowncrusher : IQuest
    {
        public void Execute(List<GameWindowController> party)
        {
            var leader = party.First();

            while (true)
            {
                leader.MoveAndClickOn(Position.GiveButton);
                leader.MoveAndClickOn(GameObject.Drowcrusher);

                Thread.Sleep(500);
                if (leader.IsNotThere(GameObject.MaleCent_Shoe))
                {
                    leader.MoveAndClickOn(GameObject.CloseButton);
                    leader.MoveAndClickOn(Position.InventoryButton);
                    leader.MoveAndRightClickOn(GameObject.ConvenienceStore);
                    leader.MoveAndClickOn(Position.ConvenienceShop_CentStore);

                    Thread.Sleep(500);
                    leader.MoveAndClickOn(GameObject.MaleCent_Shoe);
                    
                    for (int i = 0; i < 21; i++)
                    {
                        leader.Click();
                    }

                    leader.MoveAndClickOn(Position.ConfirmPurchaseConvinienceStore);
                    leader.MoveAndClickOn(GameObject.CloseButton);
                    leader.MoveAndClickOn(GameObject.CloseButton);

                    leader.MoveAndClickOn(Position.GiveButton);
                    leader.MoveAndClickOn(GameObject.Drowcrusher);
                }

                leader.MoveAndClickOn(GameObject.MaleCent_Shoe);
                leader.MoveAndClickOn(Position.ConfirmGiveItem);
                leader.MoveAndClickOn(Position.ClosePopup);

                Thread.Sleep(3000);

                //Waiting end of battle
                while (leader.IsNotThere(GameObject.Out_Of_Battle))
                {
                    Thread.Sleep(1000);
                    continue;
                }
                Thread.Sleep(1000);
                leader.Click();
            }
        }
    }
}