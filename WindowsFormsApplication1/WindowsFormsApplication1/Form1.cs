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

		float main_rull_deg = 60, volume_rull_deg = 0,
			  corrector_rull_deg = 25;

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
            path.AddEllipse(0, 0, image.Width-1, image.Height-1);
            Region rgn = new Region(path);
            box.Region = rgn;
            box.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image img = Properties.Resources.R_123M;
            this.BackgroundImage = new Bitmap(img);
            Image img_2 = Properties.Resources.rull_1;
            Draw_circle(img_2, Main_rull);
			Image img_3 = Properties.Resources.volume_rull;
			Draw_circle(img_3, Volume_rull);
			//Volume_rull_Click(sender, e);
			Draw_circle(Corrector.Image, Corrector);
		}

        private void Draw_mini_circle(PictureBox box)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 33, 33);
            Region rgn = new Region(path);
            box.Region = rgn;
            box.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }




        //-------------------------------
        //Main_rull
        private void Main_rull_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(111, 114);

            //PointF b = new PointF(e.Y - 114, e.X - 111);
            //mymatrix.RotateAt((float)Math.Acos((double)((a.X * b.X + a.Y * b.Y) / 
            //    (Math.Sqrt((double)(a.X * a.X + a.Y * a.Y)) * Math.Sqrt((double)(b.X * b.X + b.Y * b.Y)))))
            //    , center_picture);

            mymatrix.RotateAt(main_rull_deg, center_picture);
            Graphics g = Main_rull.CreateGraphics();

            // g.RotateTransform(350.0F);

            g.Transform = mymatrix;
            g.DrawImage(Main_rull.Image, 0, 0);
            main_rull_deg += 60;

            //g.DrawImage()
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_1;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
            // Draw_circle(img);
            Main_rull.Image = img;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_2;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
            // Draw_circle(img);
            Main_rull.Image = img;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_3;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
            // Draw_circle(img);
            Main_rull.Image = img;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_4;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
            // Draw_circle(img);
            Main_rull.Image = img;
        }

        private void label_II_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_I;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
            // Draw_circle(img);
            Main_rull.Image = img;
        }

        private void label_I_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_II;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
            // Draw_circle(img);
            Main_rull.Image = img;
        }


      
        //Right angle
        private void Right_Perek_1_CLick(object sender, EventArgs e)
        {
            Draw_mini_circle(pictureBox2);
            if (pictureBox2.Visible)
                pictureBox2.Visible = false;
            else
                pictureBox2.Visible = true;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();

        }
     
        private void Right_Perek_2_CLick(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox3);
            if (pictureBox3.Visible)
                pictureBox3.Visible = false;
            else
                pictureBox3.Visible = true;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void Right_Perek_3_CLick(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox4);
            if (pictureBox4.Visible)
                pictureBox4.Visible = false;
            else
                pictureBox4.Visible = true;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void Right_Perek_4_CLick(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox5);
            if (pictureBox5.Visible)
                pictureBox5.Visible = false;
            else
                pictureBox5.Visible = true;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void Open_cap_Click(object sender, EventArgs e)
        {
            if (Open_Panel.Visible)
            {
                Open_Panel.Visible = false;
                Right_Perek_1.Visible = false; 
                Right_Perek_2.Visible = false;
                Right_Perek_3.Visible = false;
                Right_Perek_4.Visible = false;
            }
            else
            {
                Open_Panel.Visible = true;
                Right_Perek_1.Visible = true;
                Right_Perek_2.Visible = true;
                Right_Perek_3.Visible = true;
                Right_Perek_4.Visible = true;
            }
        }


		//спросить совета!
		private void Volume_rull_MouseDown(object sender, MouseEventArgs e)
		{
			Draw_circle(Volume_rull.Image, Volume_rull);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(Volume_rull.Image.Width / 2, Volume_rull.Image.Height / 2);

			//PointF b = new PointF(e.Y - 114, e.X - 111);
			//mymatrix.RotateAt((float)Math.Acos((double)((a.X * b.X + a.Y * b.Y) / 
			//    (Math.Sqrt((double)(a.X * a.X + a.Y * a.Y)) * Math.Sqrt((double)(b.X * b.X + b.Y * b.Y)))))
			//    , center_picture);
			
			
			if(e.Button == MouseButtons.Left)
			{
				mymatrix.RotateAt(volume_rull_deg, center_picture);
				Graphics g = Volume_rull.CreateGraphics();

				// g.RotateTransform(350.0F);

				g.Transform = mymatrix;
				g.DrawImage(Volume_rull.Image, 0, 0);
				volume_rull_deg += 10;
				Volume_rull_MouseDown(sender, e);
			}
		}

		//-------------------------------
		//Volume_Rull
		private void Volume_rull_Click(object sender, EventArgs e)
		{
		//	Draw_circle(Volume_rull.Image, Volume_rull);
		//	System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
		//	PointF center_picture = new PointF(Volume_rull.Image.Width / 2, Volume_rull.Image.Height / 2);

		//	//PointF b = new PointF(e.Y - 114, e.X - 111);
		//	//mymatrix.RotateAt((float)Math.Acos((double)((a.X * b.X + a.Y * b.Y) / 
		//	//    (Math.Sqrt((double)(a.X * a.X + a.Y * a.Y)) * Math.Sqrt((double)(b.X * b.X + b.Y * b.Y)))))
		//	//    , center_picture);

		//	mymatrix.RotateAt(volume_rull_deg, center_picture);
		//	Graphics g = Volume_rull.CreateGraphics();

		//	// g.RotateTransform(350.0F);

		//	g.Transform = mymatrix;
		//	g.DrawImage(Volume_rull.Image, 0, 0);
		//	volume_rull_deg += 10;
		}

//-------------------------------
private void Corrector_Click(object sender, EventArgs e)
		{
			Draw_circle(Corrector.Image, Corrector);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(67, 66);

			//PointF b = new PointF(e.Y - 114, e.X - 111);
			//mymatrix.RotateAt((float)Math.Acos((double)((a.X * b.X + a.Y * b.Y) / 
			//    (Math.Sqrt((double)(a.X * a.X + a.Y * a.Y)) * Math.Sqrt((double)(b.X * b.X + b.Y * b.Y)))))
			//    , center_picture);

			mymatrix.RotateAt(corrector_rull_deg, center_picture);
			Graphics g = Corrector.CreateGraphics();

			// g.RotateTransform(350.0F);

			g.Transform = mymatrix;
			g.DrawImage(Corrector.Image, 0, 0);
			corrector_rull_deg += 25;
			if (corrector_rull_deg > 50)
				corrector_rull_deg = 0;
			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();

		}
	}
}
