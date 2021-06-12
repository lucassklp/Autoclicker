using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using Autoclicker.Core;
using Autoclicker.Game;
using Autoclicker.Quests;
using Desktop.Robot;
using Desktop.Robot.Extensions;

namespace Autoclicker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carrega as janelas dos personagens
            //Por padrão, o primeiro da lista deve ser o lider
            var characters = GameWindowController.GetGameWindows("Atlantas");
            
            var type = Type.GetType($"Autoclicker.Quests.{args[0]}");
            var quest = (IQuest)Activator.CreateInstance(type);
            quest.Execute(characters);
        }
    }
}
