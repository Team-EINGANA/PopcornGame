using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Popcorn.Classes;
using Popcorn.Interfaces;

namespace Popcorn
{
    // Drawer = Works as a painting brush
    public class Drawer : IDrawingInterface
    {
        private const string BallImagePath = @"Resources/ball_purple.png";
        private const string PanImagePath = @"Resources/paddle.png";
        private const string SimpleBrickImagePath = @"Resources/simple_brick.png";

        private Image ballImage, panImage, simpleBrickImage;
        private Form gameWindow;
        private List<PictureBox> pictures;

        public Drawer(Form form)
        {
            this.gameWindow = form;
            this.pictures = new List<PictureBox>();
            LoadResources();
        }

        private void LoadResources()
        {
            this.ballImage = Image.FromFile(BallImagePath);
            this.panImage = Image.FromFile(PanImagePath);
            this.simpleBrickImage = Image.FromFile(SimpleBrickImagePath);
        }

        public void AddObject(IDrawable drawableObject)
        {
            this.CreatePictureBox(drawableObject);
        }

        public void RemoveObject(IDrawable drawableObject)
        {
            PictureBox pictureBox = GetPictureBoxByObject(drawableObject);
            this.gameWindow.Controls.Remove(pictureBox);
            this.pictures.Remove(pictureBox);
        }

        public void RedrawObject(IDrawable drawableObject)
        {
            Point coordinates = new Point(drawableObject.X, drawableObject.Y);
            PictureBox pictureBox = GetPictureBoxByObject(drawableObject);
            pictureBox.Location = coordinates;
        }

        private Image GetImage(IDrawable drawableObject)
        {
            Image img = null;
            switch (drawableObject.Image)
            {
                case ImageType.Ball:
                    img = this.ballImage;
                    break;
                case ImageType.Pan:
                    img = this.panImage;
                    break;
                case ImageType.SimpleBrick:
                    img = this.simpleBrickImage;
                    break;
                default: 
                    break;
            }
            return img;
        }

        private void CreatePictureBox(IDrawable drawableObject)
        {
            Image img = GetImage(drawableObject);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = img;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Parent = this.gameWindow;
            pictureBox.Location = new Point(drawableObject.X, drawableObject.Y);
            pictureBox.Size = new Size(drawableObject.SizeX, drawableObject.SizeY);
            pictureBox.Tag = drawableObject;
            this.pictures.Add(pictureBox);
            this.gameWindow.Controls.Add(pictureBox);
        }

        private PictureBox GetPictureBoxByObject(IDrawable drawableObject)
        {
            return this.pictures.First(p => p.Tag == drawableObject);
        }

    }
}
