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
                leader.MoveAndClickOn(GameObject.ContributionExchanger);
                leader.MoveAndClickOn(Position.IWantToRedeemNow);
                leader.MoveAndClickOn(Position.TollItem);
                leader.MoveAndClickOn(Position.ImSureToExchangeIt);
                leader.MoveAndClickOn(Position.ClosePopup);
            }
        }
    }
}