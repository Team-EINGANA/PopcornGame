using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Popcorn.Classes;
using Popcorn.Interfaces;

namespace Popcorn
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            IDrawingInterface drawer = new Drawer(this);
            drawer.AddObject(new Ball(50, 50, 40, 40));

            int panStartX = this.Width/2;
            int panStartY = this.Height - 50;
            drawer.AddObject(new Pan(panStartX, panStartY, 74, 6));
            
            
        }
    }
}
