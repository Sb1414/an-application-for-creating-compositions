using creatingCompositions.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace creatingCompositions
{
    public partial class Form1 : Form
    {
        private bool flag = false;

        static string path1 = AppDomain.CurrentDomain.BaseDirectory.ToString();
        static string str = path1.Remove(path1.Length - 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        Point lastPoint;
        private void panelUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btMaximiz_Click(object sender, EventArgs e)
        {
            if (!flag)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            flag = !flag;
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string imgC1 = ClassMemory.centerImg;
            string imgL1 = ClassMemory.leftImg;
            string imgR1 = ClassMemory.RightImg;

            if (imgC1 == "")
            {
                label1.Text = "Выберите 1 изображение!";
            } else
            {
                label1.Text = "";
                Bitmap result = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                using (Graphics graphics = Graphics.FromImage(result))
                {
                    graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    
                    graphics.DrawImage(Image.FromFile(imgC1), 0, 0, result.Width, result.Height);
                    if (imgL1 != "")
                    {
                        Image img = Image.FromFile(imgL1);
                        graphics.DrawImage(img, 0, 0, result.Width, result.Height);
                    }
                    if (imgR1 != "")
                    {
                        Image img3 = Image.FromFile(imgR1);
                        graphics.DrawImage(img3, 0, 0, result.Width, result.Height);
                    }
                }
                pictureBox1.Image = result;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void mTeapot1_Click(object sender, EventArgs e)
        {
            ClassMemory.centerImg = str + "Resources\\CenterTeapot1.png";
        }

        void DrawBitmap(string nameFile)
        {
            Bitmap result = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the images into the target bitmap
                graphics.DrawImage(Image.FromFile(nameFile), 0, 0, result.Width, result.Height);
            }
            pictureBox1.Image = result;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Teapot2_Click(object sender, EventArgs e)
        {
            ClassMemory.leftImg = str + "Resources\\LeftTeapot1.png";
        }

        private void mTeapot_Click(object sender, EventArgs e)
        {
            ClassMemory.RightImg = str + "Resources\\RightTeapot11.png";
        }

        private void mVaseCenter_Click(object sender, EventArgs e)
        {
            ClassMemory.centerImg = str + "Resources\\CenterVase2.png";
        }

        private void mVaseLeft_Click(object sender, EventArgs e)
        {
            ClassMemory.leftImg = str + "Resources\\LeftVase2.png";
        }

        private void mVaseRight_Click(object sender, EventArgs e)
        {
            ClassMemory.RightImg = str + "Resources\\RightVase2.png";
        }

        private void mCupCenter_Click(object sender, EventArgs e)
        {
            ClassMemory.centerImg = str + "Resources\\CenterCup3.png";
        }

        private void mCupLeft_Click(object sender, EventArgs e)
        {
            ClassMemory.leftImg = str + "Resources\\LeftCup3.png";
        }

        private void mCupRight_Click(object sender, EventArgs e)
        {
            ClassMemory.RightImg = str + "Resources\\RightCup3.png";
        }

        private string GetExeDirectory()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            path = Path.GetDirectoryName(path);
            return path;
        }
    }
}
