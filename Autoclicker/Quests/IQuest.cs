using System.Collections.Generic;
using Autoclicker.Game;

namespace Autoclicker.Quests
{
    public interface IQuest
    {
         void Execute(List<GameWindowController> party);
    }
}