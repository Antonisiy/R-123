using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private
            Timer timer1 = new Timer();
        public Form1()
        {

            InitializeComponent();
            Image img = Properties.Resources.R_123M;
            this.BackgroundImage = new Bitmap(img);
            
            Image img_2 = Properties.Resources.rull_1;
            Draw_circle(img_2);
        }

        //void timer1_Tick(object sender, EventArgs e)
        //{
        //    angle += 1.6f;
        //    pictureBox6.Invalidate();
        //}

        //void pictureBox6_Paint(object sender, PaintEventArgs e)
        //{
        //    e.Graphics.TranslateTransform(image1.Width / 2, image1.Height / 2);
        //    e.Graphics.RotateTransform(angle);
        //    e.Graphics.DrawImage(image1, -image1.Width / 2, -image1.Height / 2);
        //    e.Graphics.RotateTransform(-angle);
        //    e.Graphics.TranslateTransform(-image1.Width / 2, -image1.Height / 2);
        //}

           private void Draw_circle(Image image)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, image.Width, image.Height);
            Region rgn = new Region(path);
            pictureBox6.Region = rgn;
            pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Draw_mini_circle(PictureBox box)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 33, 33);
            Region rgn = new Region(path);
            box.Region = rgn;
            box.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Draw_mini_circle(pictureBox2);
            if (pictureBox2.Visible)
            pictureBox2.Visible = false;
            else
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Draw_mini_circle(pictureBox3);
            if (pictureBox3.Visible)
                pictureBox3.Visible = false;
            else
                pictureBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Draw_mini_circle(pictureBox4);
            if (pictureBox4.Visible)
                pictureBox4.Visible = false;
            else
                pictureBox4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Draw_mini_circle(pictureBox5);
            if (pictureBox5.Visible)
                pictureBox5.Visible = false;
            else
                pictureBox5.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_1;
            Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_2;
            Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_3;
            Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_4;
            Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_I;
            Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_II;
            Draw_circle(img);
            pictureBox6.Image = img;
        }
    }
}
