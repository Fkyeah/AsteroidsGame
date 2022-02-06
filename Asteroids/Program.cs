using System;
using System.Windows.Forms;

namespace Asteroids
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form();
            form.Height = 769;
            form.Width = 1024;
            Game.Init(form);
            Application.Run(form);
        }
    }
}
