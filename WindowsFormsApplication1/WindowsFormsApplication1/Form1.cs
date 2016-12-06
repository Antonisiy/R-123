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
        }

        float deg = 60;

        PointF a = new PointF(0, -111); 

        // Нормальный вектор прошлого полжения вентеля
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

        private void Draw_circle(Image image, PictureBox box)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, image.Width, image.Height);
            Region rgn = new Region(path);
            box.Region = rgn;
            box.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image img = Properties.Resources.R_123M;
            this.BackgroundImage = new Bitmap(img);
            Image img_2 = Properties.Resources.rull_1;
            Draw_circle(img_2, pictureBox6);
        }

        private void Draw_mini_circle(PictureBox box)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 33, 33);
            Region rgn = new Region(path);
            box.Region = rgn;
            box.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_1;
            new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
            // Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_2;
            new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
            // Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_3;
			new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
			// Draw_circle(img);
			pictureBox6.Image = img;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_4;
			new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
			// Draw_circle(img);
			pictureBox6.Image = img;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_I;
			new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
			// Draw_circle(img);
			pictureBox6.Image = img;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_II;
			new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
			// Draw_circle(img);
			pictureBox6.Image = img;
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(111, 114);

			//PointF b = new PointF(e.Y - 114, e.X - 111);
			//mymatrix.RotateAt((float)Math.Acos((double)((a.X * b.X + a.Y * b.Y) / 
			//    (Math.Sqrt((double)(a.X * a.X + a.Y * a.Y)) * Math.Sqrt((double)(b.X * b.X + b.Y * b.Y)))))
			//    , center_picture);

			mymatrix.RotateAt(deg, center_picture);
			Graphics g = pictureBox6.CreateGraphics();

			// g.RotateTransform(350.0F);

			g.Transform = mymatrix;
			g.DrawImage(pictureBox6.Image, 0, 0);
			deg += 60;

			//g.DrawImage()
			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}


        private void label7_Click(object sender, EventArgs e)
        {
            Draw_mini_circle(pictureBox2);
            if (pictureBox2.Visible)
                pictureBox2.Visible = false;
            else
                pictureBox2.Visible = true;
			new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();

		}
     

        private void label8_Click(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox3);
            if (pictureBox3.Visible)
                pictureBox3.Visible = false;
            else
                pictureBox3.Visible = true;
			new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
		}

        private void label9_Click(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox4);
            if (pictureBox4.Visible)
                pictureBox4.Visible = false;
            else
                pictureBox4.Visible = true;
			new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
		}

        private void label10_Click(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox5);
            if (pictureBox5.Visible)
                pictureBox5.Visible = false;
            else
                pictureBox5.Visible = true;
			new System.Media.SoundPlayer(
             "/Resources/Click_Sound.wav").Play();
		}


        private void label11_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Visible)
            {
                pictureBox8.Visible = false;
                label7.Visible = false; 
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }
            else
            {
                pictureBox8.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }
        }

		private void pictureBox9_Click(object sender, EventArgs e)
		{
            Draw_circle(pictureBox9.Image, pictureBox9);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(67, 66);

			//PointF b = new PointF(e.Y - 114, e.X - 111);
			//mymatrix.RotateAt((float)Math.Acos((double)((a.X * b.X + a.Y * b.Y) / 
			//    (Math.Sqrt((double)(a.X * a.X + a.Y * a.Y)) * Math.Sqrt((double)(b.X * b.X + b.Y * b.Y)))))
			//    , center_picture);

			mymatrix.RotateAt(deg, center_picture);
			Graphics g = pictureBox9.CreateGraphics();

			// g.RotateTransform(350.0F);

			g.Transform = mymatrix;
			g.DrawImage(pictureBox9.Image, 0, 0);
			deg += 10;

		}
	}
}
