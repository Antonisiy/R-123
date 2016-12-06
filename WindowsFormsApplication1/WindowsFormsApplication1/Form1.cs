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

		float main_rull_deg = 0, volume_rull_deg = 0,
			  corrector_rull_deg = 0, antenna_rull_deg = 0;

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
            path.AddEllipse(0, 0, image.Width - 1, image.Height - 1);
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
			Draw_circle(frenquence_table.Image, frenquence_table);
			Draw_circle(picture_antenna.Image, picture_antenna);
			Draw_circle(voltage_control_rull.Image, voltage_control_rull);
		}

        private void Draw_mini_circle(PictureBox box)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 33, 33);
            Region rgn = new Region(path);
            box.Region = rgn;
            box.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        //Right angle
        private void Right_Perek_1_CLick(object sender, EventArgs e)
        {
            picture_Lamp_I.Visible = true;
            picture_Lamp_II.Visible = false;
            Draw_mini_circle(pictureBox2);
            if (pictureBox2.Visible)
                pictureBox2.Visible = false;
            else
                pictureBox2.Visible = true;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();

        }

        private void Right_Perek_2_CLick(object sender, EventArgs e)
        {
            picture_Lamp_I.Visible = true;
            picture_Lamp_II.Visible = false;
            Draw_mini_circle(pictureBox3);
            if (pictureBox3.Visible)
                pictureBox3.Visible = false;
            else
                pictureBox3.Visible = true;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void Right_Perek_3_CLick(object sender, EventArgs e)
        {
            picture_Lamp_I.Visible = false;
            picture_Lamp_II.Visible = true;
            Draw_mini_circle(pictureBox4);
            if (pictureBox4.Visible)
                pictureBox4.Visible = false;
            else
                pictureBox4.Visible = true;
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void Right_Perek_4_CLick(object sender, EventArgs e)
        {
            picture_Lamp_I.Visible = false;
            picture_Lamp_II.Visible = true;
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

            if (Open_cap.Visible)
            {
                Open_cap.Visible = false;
            }
            else
            {
                Open_cap.Visible = true;
            }
        }


        //-------------------------------
        //Frenquence_table
        private void open_frenquence_table_Click(object sender, EventArgs e)
        {
            if (frenquence_table.Visible)
            {
                frenquence_table.Visible = false;
            }
            else
            {
                frenquence_table.Visible = true;
            }

        }
        //-------------------------------
        //Volume_Rull

        private void Volume_rull_MouseDown(object sender, MouseEventArgs e)
        {
            Draw_circle(Volume_rull.Image, Volume_rull);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(Volume_rull.Image.Width / 2, Volume_rull.Image.Height / 2);

            if (e.Button == MouseButtons.Left)
            {
                mymatrix.RotateAt(volume_rull_deg, center_picture);
                Graphics g = Volume_rull.CreateGraphics();

                g.Transform = mymatrix;
                g.DrawImage(Volume_rull.Image, 0, 0);
                volume_rull_deg += 10;
            }
        }



		private void voltage_control_rull_MouseClick(object sender, MouseEventArgs e)
		{
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(voltage_control_rull.Image.Width / 2, voltage_control_rull.Image.Height / 2);

			if (e.Button == MouseButtons.Left)
				voltage_control_rull_deg += 30;
			else
				voltage_control_rull_deg -= 30;

			if (voltage_control_rull_deg == 360 || voltage_control_rull_deg == -360)
				voltage_control_rull_deg = 0;

			mymatrix.RotateAt(voltage_control_rull_deg, center_picture);
			Graphics g = voltage_control_rull.CreateGraphics();
			g.Transform = mymatrix;
			g.DrawImage(voltage_control_rull.Image, 0, 0);

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}

		private void Main_rull_MouseClick(object sender, MouseEventArgs e)
		{
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(111, 114);

            if (e.Button == MouseButtons.Left)
                main_rull_deg += 60;
            else
                main_rull_deg -= 60;

            if (main_rull_deg == 360 || main_rull_deg == -360)
                main_rull_deg = 0;

            mymatrix.RotateAt(main_rull_deg, center_picture);
            Graphics g = Main_rull.CreateGraphics();
            g.Transform = mymatrix;
            g.DrawImage(Main_rull.Image, 0, 0);

            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
            if (main_rull_deg / 60 == 4 || main_rull_deg / 60 == -2)
            {
                picture_Lamp_II.Visible = true;
                picture_Lamp_I.Visible = false;
            }
            else
                if (main_rull_deg / 60 == 5 || main_rull_deg / 60 == -1)
            {
                picture_Lamp_II.Visible = false;
                picture_Lamp_I.Visible = true;
            }
            else
            {
                picture_Lamp_II.Visible = false;
                picture_Lamp_I.Visible = false;
            }
        }

        //antenna
        private void picture_antenna_Click(object sender, EventArgs e)
        {
            Draw_circle(picture_antenna.Image, picture_antenna);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(picture_antenna.Image.Width / 2, picture_antenna.Image.Height / 2);

            //PointF b = new PointF(e.Y - 114, e.X - 111);
            //mymatrix.RotateAt((float)Math.Acos((double)((a.X * b.X + a.Y * b.Y) / 
            //    (Math.Sqrt((double)(a.X * a.X + a.Y * a.Y)) * Math.Sqrt((double)(b.X * b.X + b.Y * b.Y)))))
            //    , center_picture);

            mymatrix.RotateAt(antenna_rull_deg, center_picture);
            Graphics g = picture_antenna.CreateGraphics();

            g.Transform = mymatrix;
            g.DrawImage(picture_antenna.Image, 0, 0);
            antenna_rull_deg += 10;
        }
 
    }
}
