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
                leader.ClickOn(GameObject.ContributionExchanger);
                leader.ClickOn(Position.IWantToRedeemNow);
                leader.ClickOn(Position.TollItem);
                leader.ClickOn(Position.ImSureToExchangeIt);
                leader.ClickOn(Position.ClosePopup);
            }
        }
    }
}