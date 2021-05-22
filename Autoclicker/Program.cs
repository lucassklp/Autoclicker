using System;
using System.Linq;
using System.Threading;
using Autoclicker.Core;
using Autoclicker.Game;
using Desktop.Robot;
using Desktop.Robot.Extensions;

namespace Autoclicker
{
    class Program
    {
        static void Main(string[] args)
        {

            //Carrega as janelas dos personagens
            var characters = GameWindowController.GetGameWindows("Kaeser", "Atlantas", "Robotwings", "Rothbard", "Arkantos");

            //Pega o Kaeser, que é o primeiro nesse caso. (A ordem dos personagens obedece a ordem dos nomes passado acima)
            var kaeser = characters.First();

            while (true)
            {
                kaeser.MoveAndClickOn(Position.GiveButton);
                kaeser.MoveAndClickOn(GameObject.Drowcrusher);

                Thread.Sleep(500);
                if (kaeser.IsNotThere(GameObject.MaleCent_Shoe))
                {
                    kaeser.MoveAndClickOn(GameObject.CloseButton);
                    kaeser.MoveAndClickOn(Position.InventoryButton);
                    kaeser.MoveAndRightClickOn(GameObject.ConvenienceStore);
                    kaeser.MoveAndClickOn(Position.ConvenienceShop_CentStore);

                    Thread.Sleep(500);
                    kaeser.MoveAndClickOn(GameObject.MaleCent_Shoe);
                    
                    for (int i = 0; i < 21; i++)
                    {
                        kaeser.Click();
                    }

                    kaeser.MoveAndClickOn(Position.ConfirmPurchaseConvinienceStore);
                    kaeser.MoveAndClickOn(GameObject.CloseButton);
                    kaeser.MoveAndClickOn(GameObject.CloseButton);

                    kaeser.MoveAndClickOn(Position.GiveButton);
                    kaeser.MoveAndClickOn(GameObject.Drowcrusher);
                }

                kaeser.MoveAndClickOn(GameObject.MaleCent_Shoe);
                kaeser.MoveAndClickOn(Position.ConfirmGiveItem);
                kaeser.MoveAndClickOn(Position.ClosePopup);

                Thread.Sleep(3000);
                //Waiting end of battle
                while (kaeser.IsNotThere(GameObject.Out_Of_Battle))
                {
                    Thread.Sleep(1000);
                    continue;
                }
                Thread.Sleep(1000);
                kaeser.Click();
            }
        }
    }
}
