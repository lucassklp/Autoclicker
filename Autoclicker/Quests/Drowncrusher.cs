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
                leader.ClickOn(Position.GiveButton);
                leader.ClickOn(GameObject.Drowcrusher);

                Thread.Sleep(500);
                if (leader.IsNotThere(item))
                {
                    leader.KeyPress(Desktop.Robot.Key.Pause);

                    Thread.Sleep(500);
                    leader.ClickOn(item);
                    
                    for (int i = 0; i < 15; i++)
                    {
                        leader.Click();
                    }

                    leader.KeyPress(Desktop.Robot.Key.Pause);

                    leader.ClickOn(Position.GiveButton);
                    leader.ClickOn(GameObject.Drowcrusher);
                }

                leader.ClickOn(item);
                leader.ClickOn(Position.ConfirmGiveItem);
                leader.ClickOn(Position.ClosePopup);

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