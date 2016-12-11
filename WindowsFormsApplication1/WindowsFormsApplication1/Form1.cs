using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;



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

        int main_rull_deg = 0, volume_rull_deg = 0,
              corrector_rull_deg = 0, antenna_rull_deg = 0,
              voltage_control_rull_deg = 0, shum_rull_deg = 0, frenquence_rull_deg = 0;

        bool flag = true, flag_2 = true, flag_3 = true;
        PointF a = new PointF(0, -111);

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

            Draw_circle(Volume_rull.Image, Volume_rull);

            Draw_circle(Corrector.Image, Corrector);

            Draw_circle(frenquence_table.Image, frenquence_table);

            Draw_circle(picture_antenna.Image, picture_antenna);

            Draw_circle(voltage_control_rull.Image, voltage_control_rull);

            Draw_circle(Picture_shum.Image, Picture_shum);

            Draw_circle(Picture_frequence.Image, Picture_frequence);
            frenquence_label.Text = frenquence_rull_deg.ToString();

            Draw_circle(picture_lamp_fr.Image, picture_lamp_fr);

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
            if (open_frenquence_table.Visible)
            {
                open_frenquence_table.Visible = false;
            }
            else
            {
                open_frenquence_table.Visible = true;
            }
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }
        //shum;
        private void Picture_shum_MouseClick(object sender, MouseEventArgs e)
        {
            Draw_circle(Picture_shum.Image, Picture_shum);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(Picture_shum.Image.Width / 2, Picture_shum.Image.Height / 2);

            if (e.Button == MouseButtons.Left) //определиние какая клавиша мыши была нажата
            {
                if (shum_rull_deg < 360)
                {
                    shum_rull_deg += 15;
                    new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
                }
            }
            else
            {
                if (shum_rull_deg > 0)
                {
                    shum_rull_deg -= 15;
                    new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
                }
            }

            mymatrix.RotateAt(shum_rull_deg, center_picture);
            Graphics g = Picture_shum.CreateGraphics();
            g.Transform = mymatrix;
            g.DrawImage(Picture_shum.Image, 0, 0);
        }
        //frequence
        private void Brightness_Picture(PictureBox Picture, float brightness)
        {
            
            var image = new Bitmap(Picture.Image);

            ImageAttributes imageAttributes = new ImageAttributes();
            int width = image.Width;
            int height = image.Height;

            float[][] colorMatrixElements = {
                                                new float[] {brightness, 0, 0, 0, 0},
                                                new float[] {0, brightness, 0, 0, 0},
                                                new float[] {0, 0, brightness, 0, 0},
                                                new float[] {0, 0, 0, 1, 0},
                                                new float[] {0, 0, 0, 0, 1}
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);

            imageAttributes.SetColorMatrix(
                colorMatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(image);
            graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width,
                               height,
                               GraphicsUnit.Pixel,
                               imageAttributes);

            Picture.Image = image;
        }

        
        private void Picture_frequence_MouseClick(object sender, MouseEventArgs e)
        {
            Draw_circle(Picture_frequence.Image, Picture_frequence);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(Picture_frequence.Image.Width / 2, Picture_frequence.Image.Height / 2);

            if (e.Button == MouseButtons.Left) //определиние какая клавиша мыши была нажата
            {
                if (frenquence_rull_deg < 720)
                {
                    frenquence_rull_deg += 15;
                    new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
                }
            }
            else
            {
                if (frenquence_rull_deg > 0)
                {
                    frenquence_rull_deg -= 15;
                    new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
                }
            }

            mymatrix.RotateAt(frenquence_rull_deg, center_picture);
            Graphics g = Picture_frequence.CreateGraphics();
            g.Transform = mymatrix;
            g.DrawImage(Picture_frequence.Image, 0, 0);

            frenquence_label.Text = frenquence_rull_deg.ToString();
            picture_lamp_fr.Visible = true;

            PictureBox Picture_temp = picture_lamp_fr;

            switch (frenquence_rull_deg)
            {
                case 15:
                    Brightness_Picture(Picture_temp, (float)0.1);
                    break;
                case 105:
                    Brightness_Picture(Picture_temp, (float)0.25);
                    break;
                case 210:
                    Brightness_Picture(Picture_temp, (float)0.5);
                    break;
                case 315:
                    Brightness_Picture(Picture_temp, (float)0.75);
                    break;
                case 420:
                    Brightness_Picture(Picture_temp, 1);
                    break;
                default:
                    break;
            }
           
            Picture_frequence_table(frenquence_rull_deg/2);

        }

        private void button_pic_MouseClick(object sender, MouseEventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void pictrure_shcala_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                Image img = Properties.Resources.vkl_2;
                pictrure_shcala.Image = img;
                flag = false;
            }
            else
            {
                Image img = Properties.Resources.vkl_1;
                pictrure_shcala.Image = img;
                flag = true;
            }
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void picture_power_MouseClick(object sender, MouseEventArgs e)
        {
            if(flag_2)
            {
                Image img = Properties.Resources.vkl_1;
                picture_power.Image = img;
                flag_2 = false;
            }
            else
            {
                Image img = Properties.Resources.vkl_2;
                picture_power.Image = img;
                flag_2 = true;
            }
           
            new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
        }

        private void Picture_frequence_table(float frenquence_table_deg)
        {
            Draw_circle(frenquence_table.Image, frenquence_table);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(frenquence_table.Image.Width / 2, frenquence_table.Image.Height / 2);

            mymatrix.RotateAt(frenquence_table_deg, center_picture);
            Graphics g = frenquence_table.CreateGraphics();

            g.Transform = mymatrix;
            g.DrawImage(frenquence_table.Image, 0, 0);
 
        }
        //corrector
        private void Corrector_MouseClick(object sender, MouseEventArgs e)
        {
            Draw_circle(Corrector.Image, Corrector);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(67, 66);

            if (e.Button == MouseButtons.Left) //определиние какая клавиша мыши была нажата
            {
                if (corrector_rull_deg < 50)
                {
                    corrector_rull_deg += 25;
                    new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
                }
            }
            else
            {
                if (corrector_rull_deg > 0)
                {
                    corrector_rull_deg -= 25;
                    new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
                }
            }

            mymatrix.RotateAt(corrector_rull_deg, center_picture);
            Graphics g = Corrector.CreateGraphics();
            g.Transform = mymatrix;
            g.DrawImage(Corrector.Image, 0, 0);
        }
        //Volume_Rull
        private void Volume_rull_MouseDown(object sender, MouseEventArgs e)
        {
            Draw_circle(Volume_rull.Image, Volume_rull);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(Volume_rull.Image.Width / 2, Volume_rull.Image.Height / 2);

            if (e.Button == MouseButtons.Left) //определиние какая клавиша мыши была нажата
            {
                if (volume_rull_deg < 360)
                {
                    volume_rull_deg += 15;
                    new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
                }
            }
            else
            {
                if (volume_rull_deg > 0)
                {
                    volume_rull_deg -= 15;
                    new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
                }
            }

            mymatrix.RotateAt(volume_rull_deg, center_picture);
            Graphics g = Volume_rull.CreateGraphics();

            g.Transform = mymatrix;
            g.DrawImage(Volume_rull.Image, 0, 0);

        }
        //voltage_control
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
        //Main_Rull
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
        private void picture_antenna_MouseClick(object sender, MouseEventArgs e)
        {
            Draw_circle(picture_antenna.Image, picture_antenna);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(picture_antenna.Image.Width / 2, picture_antenna.Image.Height / 2);

            mymatrix.RotateAt(antenna_rull_deg, center_picture);
            Graphics g = picture_antenna.CreateGraphics();

            g.Transform = mymatrix;
            g.DrawImage(picture_antenna.Image, 0, 0);
            antenna_rull_deg += 10;
        }


    }
}
