using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Autoclicker.Game;

namespace Autoclicker.Quests
{
    public class ExchangeConstructionPoints : IQuest
    {
        public void Execute(List<GameWindowController> party)
        {
            var leader = party.First();
            while(true)
            {
                leader.SetAutoDelay(1000)
                    .ClickOn(GameObject.ContributionExchanger)
                    .ClickOn(Position.IWantToRedeemNow)
                    .ClickOn(Position.TollItem)
                    .ClickOn(Position.ImSureToExchangeIt)
                    .ClickOn(Position.MiddleOfDialogBox);
            }
        }
    }
}