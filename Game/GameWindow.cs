using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using Desktop.Robot;

namespace Autoclicker.Game
{
    public class GameWindow
    {
        public static List<GameWindow> GetGameWindows(params string[] nicks)
        {
            return nicks.Select(nick => 
            {
                var process = Process.GetProcesses()
                    .First(x => x.MainWindowTitle.Contains(nick));

                return new GameWindow(process, nick);
            })
            .ToList();
        }

        private Process process;
        public string Nick {get;set;}

        public GameWindow(Process process, string nick)
        {
            this.process = process;
            this.Nick = nick;
        }

        public Bitmap TakeScreenshot(IRobot robot)
        {
            Focus();
            Thread.Sleep(500);
            Rectangle rect;
            GetWindowRect(this.process.MainWindowHandle, out rect);
            return robot.CreateScreenCapture(rect) as Bitmap;
        }

        public void Focus()
        {
            BringProcessToFront(this.process);
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