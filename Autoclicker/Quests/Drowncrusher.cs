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

            //Colocar aqui o item do Drown
            var item = GameObject.FemaleMage_Helm;
            var positionStore = Position.ConvenienceShop_MageStore;

            while (true)
            {
                leader.SetAutoDelay(500)
                    .ClickOn(Position.GiveButton)
                    .ClickOn(GameObject.Drowcrusher);

                if (leader.IsNotThere(item))
                {
                    leader.ClickOn(GameObject.CloseButton)
                        .ClickOn(Position.InventoryButton)
                        .RightClickOn(GameObject.ConvenienceStore)
                        .ClickOn(positionStore)
                        .ClickOn(item);
                    
                    for (int i = 0; i < 15; i++)
                    {
                        leader.Click();
                    }

                    leader.ClickOn(Position.ConvinienceStore_ConfirmPurchase)
                        .ClickOn(GameObject.CloseButton)
                        .ClickOn(Position.GiveButton)
                        .ClickOn(GameObject.Drowcrusher);
                }

                leader.ClickOn(item)
                    .ClickOn(Position.ConfirmGiveItem)
                    .ClickOn(Position.MiddleOfDialogBox)
                    .Wait(3000)
                    .WaitFor(GameObject.Out_Of_Battle)
                    .Wait(1000)
                    .ClickOn(Position.MiddleOfDialogBox);
            }
        }
    }
}