using Asteroids.GameProcess;
using System;
using System.Windows.Forms;

namespace Asteroids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Width = 1024;
            form.Height = 768;
            form.Show();
            Game.Init(form);
            Game.Draw();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
