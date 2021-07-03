using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Autoclicker.Core;
using Desktop.Robot;
using Desktop.Robot.Clicks;
using Desktop.Robot.Extensions;

namespace Autoclicker.Game
{
    public class GameWindowController
    {
        public static List<GameWindowController> GetGameWindows(params string[] nicks)
        {
            var comparer = new Comparer();
            var robot = new Robot();
            robot.AutoDelay = 500;

            return nicks.Select(nick => 
            {
                var process = Process.GetProcesses()
                    .First(x => x.MainWindowTitle.Contains(nick));

                return new GameWindowController(robot, comparer, process, nick);
            })
            .ToList();
        }

        private Process process;
        public string Nick {get;set;}

        private IRobot robot;

        private Comparer comparer;

        public GameWindowController(IRobot robot, Comparer comparer, Process process, string nick)
        {
            this.process = process;
            this.Nick = nick;
            this.robot = robot;
            this.comparer = comparer;
        }

        private Bitmap TakeScreenshot()
        {
            var rect = GetWindowRectangle();
            rect.X += + 3;
            rect.Width = 800;
            return robot.CreateScreenCapture(rect) as Bitmap;
        }

        public Point Find(GameObject gameObject)
        {
            Rectangle objRect;            
            using var screenshot = TakeScreenshot();
            objRect = comparer.Search(screenshot, gameObject.AsBitmap());
            return new Point(objRect.X + objRect.Width / 2, objRect.Y + objRect.Height / 2);
        }

        public bool IsNotThere(GameObject gameObject)
        {
            return Find(gameObject) == default;
        }

        public void MoveAndClickOn(GameObject gameObject)
        {
            Focus();
            Thread.Sleep(250);
            Point point;
            do
            {
                point = Find(gameObject);
            } while (point == default(Point));
            MoveAndClickOn(point);
        }

        public void MoveAndClickOn(GameObject gameObject, TimeSpan interval)
        {
            Focus();
            Point point;
            do
            {
                point = Find(gameObject);
            } while (point == default(Point));
            MoveAndClickOn(point, interval);
        }


        public void Click()
        {
            this.robot.Click();
        }

        public void Click(int interval)
        {
            this.robot.Click(Mouse.RightButton(interval));
        }


        public void RightClick()
        {
            this.robot.Click(Mouse.RightButton());
        }

        public void MouseMove(Point position)
        {
            Thread.Sleep(250);
            var rect = GetWindowRectangle();
            position.Offset(rect.X, rect.Y);
            this.robot.LinearMoviment(position, TimeSpan.FromMilliseconds(100));
        }


        public void MoveAndRightClickOn(GameObject gameObject)
        {
            Focus();
            Thread.Sleep(500);
            Point point;
            do
            {
                point = Find(gameObject);
            } while (point == default(Point));
            MoveAndRightClickOn(point);
        }

        public void MoveAndClickOn(Point position)
        {
            Focus();
            MouseMove(position);
            Click();
        }

        public void MoveAndClickOn(Point position, TimeSpan interval)
        {
            Focus();
            MouseMove(position);
            int timing = (int)interval.TotalMilliseconds / 2;
            Thread.Sleep(timing);
            Click();
            Thread.Sleep(timing);
        }

        public void MoveAndRightClickOn(Point position)
        {
            Focus();
            MouseMove(position);
            RightClick();
        }


        public void KeyPress(Key key)
        {
            Focus();
            this.robot.KeyPress(key);
        }

        public void Focus()
        {
            BringProcessToFront(this.process);
        }

        private Rectangle GetWindowRectangle()
        {
            Rectangle rect;
            GetWindowRect(this.process.MainWindowHandle, out rect);
            return rect;
        }

        const int SW_RESTORE = 9;
        
        [DllImport("user32.dll")]
        private static extern int GetWindowRect(IntPtr hwnd, out Rectangle rect);

        private static void BringProcessToFront(Process process)
        {
            IntPtr handle = process.MainWindowHandle;
            if (IsIconic(handle))
            {
                ShowWindow(handle, SW_RESTORE);
            }

            SetForegroundWindow(handle);
        }

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handle);
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handle, int nCmdShow);
        [DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handle);
    }
}