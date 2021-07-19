using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Autoclicker.Game;

namespace Autoclicker.Quests
{
    public class Drowncrusher : IQuest
    {
        private GameObject item = GameObject.FemaleBorg_Weap;
        private Point positionStore = Position.ConvenienceShop_BorgStore;
        private int quantity = 90;
        private int delay = 1000;
        private GameWindowController leader = null;
        
        public void BuyItems()
        {
            leader.ClickOn(Position.InventoryButton)
                .RightClickOn(GameObject.ConvenienceStore)
                .ClickOn(positionStore)
                .ClickOn(item)
                .SetAutoDelay(200);
                
            for (int i = 0; i < quantity - 1; i++)
            {
                leader.Click();
            }

            leader.ClickOn(Position.ConvinienceStore_ConfirmPurchase)
                .ClickOn(GameObject.CloseButton)
                .Wait(500)
                .ClickOn(GameObject.CloseButton)
                .SetAutoDelay(delay);
        }

        public void GiveAndBattle() 
        {
            leader.ClickOn(item)
                .ClickOn(Position.ConfirmGiveItem)
                .ClickOn(Position.MiddleOfDialogBox)
                .Wait(3000)
                .WaitFor(GameObject.Out_Of_Battle)
                .Wait(1000)
                .ClickOn(Position.MiddleOfDialogBox);

        }

        public void Execute(List<GameWindowController> party)
        {
            this.leader = party.First();

            while (true)
            {
                leader.SetAutoDelay(delay)
                    .ClickOn(Position.GiveButton)
                    .ClickOn(GameObject.Drowcrusher)
                    .Wait(300);

                while (leader.IsNotThere(item))
                {
                    leader.Wait(500);
                    if(leader.IsThere(GameObject.CloseButton))
                    {
                        leader.ClickOn(GameObject.CloseButton);
                    }
                    
                    leader.NextInventory();
                    
                    leader.Wait(300)
                        .ClickOn(Position.GiveButton)
                        .ClickOn(GameObject.Drowcrusher)
                        .Wait(300);

                    if(leader.IsThere(item))
                    {
                        break;
                    }

                    if(leader.IsThere(GameObject.ConvenienceStore))
                    {
                        BuyItems();
                        leader.ClickOn(Position.GiveButton)
                            .ClickOn(GameObject.Drowcrusher);
                        break;
                    }
                }

                GiveAndBattle();
            }
        }
    }
}