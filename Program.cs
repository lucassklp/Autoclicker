using System;
using System.Linq;
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
            var comparer = new Comparer();
            var robot = new Robot();
            robot.AutoDelay = 500;

            //Carrega as janelas dos personagens
            var characters = GameWindow.GetGameWindows("Kaeser", "Atlantas", "Robotwings", "Rothbard", "Arkantos");

            //Pega o Kaeser, que é o primeiro nesse caso. (A ordem dos personagens obedece a ordem dos nomes passado acima)
            var kaeser = characters.First();

            
            //A partir daqui, tudo que tá nesse bloco será repetido
            // while(true)
            // {
                //Tira o print da tela do Kaeser
                robot.OnMouseMove().Subscribe(p => Console.WriteLine(p));
                var screenshot = kaeser.TakeScreenshot(robot);
                screenshot.Save("teste.bmp");
                var point = comparer.Search(screenshot, GameObject.Give_Button.AsBitmap());
                System.Console.WriteLine(point);
                robot.QuadraticBezierMoviment(new System.Drawing.Point(point.X, point.Y), TimeSpan.FromMilliseconds(500));
            // }
        }
    }
}
