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
	public partial class Р123 : Form
	{
		private
			Timer timer1 = new Timer();
		[Obsolete("Лучше не компилировать этот говонокод!", true)]
		public Р123()
		{
			InitializeComponent();
		}

		const int frequency_1 = 220, frequency_2 = 500;
		int main_rull_deg = -60, volume_rull_deg = 0,
			  corrector_rull_deg = 0, antenna_rull_deg = 0,
			  voltage_control_rull_deg = 0, shum_rull_deg = 0, frenquence_rull_deg = 785;

		int flag_auto;

		MouseEventArgs Volume_arg = null,
			frequence_arg = null,
			shum_arg = null,
			antenna_arg = null,
			fiks_antenna = null;

		List<PictureBox> right_picture = new List<PictureBox>();


		int[] arr = new int[44]; // Массив флагов
		int[] configuration_steps = new int[5];

		bool flag = false, flag_2 = false, flag_perek_1 = true, flag_perek_2 = true, flag_perek_3 = true, flag_perek_4 = true, draw_flag = true,
			fix = true;
		int value_fr = 0;
		PointF a = new PointF(0, -111);
		//Рисуем круг
		private void Draw_circle(Image image, PictureBox box)
		{
			System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
			path.AddEllipse(0, 0, image.Width - 1, image.Height - 1);
			Region rgn = new Region(path);
			box.Region = rgn;
			box.BackColor = System.Drawing.SystemColors.ActiveCaption;
		}

		private void set_arr_null(int begin, int end)
		{
			for (int i = begin; i <= end; i++)
			{
				arr[i] = 0;
			}
		}

		//
		private void Form1_Load(object sender, EventArgs e)
		{
			//Image img = Properties.Resources.R_123M;
			//this.BackgroundImage = new Bitmap(img);
			//Open_Panel.Visible = true;
			//Image img_2 = Properties.Resources.rull_I;
			//Draw_circle(img_2, Main_rull);

			//Draw_circle(Volume_rull.Image, Volume_rull);

			//Draw_circle(Corrector.Image, Corrector);

			//Draw_circle(frenquence_table.Image, frenquence_table);

			//Draw_circle(picture_antenna.Image, picture_antenna);

			//Draw_circle(voltage_control_rull.Image, voltage_control_rull);

			//Draw_circle(Picture_shum.Image, Picture_shum);

			//Draw_circle(Picture_frequence.Image, Picture_frequence);


			//frenquence_label.Text = "357";
			//frenquence_label_2.Text = "515";

			//Draw_circle(picture_lamp_fr.Image, picture_lamp_fr);

			////Draw_circle(picture_fiks_anten.Image, picture_fiks_anten);

			//for (int i = 0; i < 44; i++)
			//	arr[i] = 0;
			//arr[0] = 1;
			//for (int i = 0; i < 5; i++)
			//	configuration_steps[i] = 0;
			//timer7.Start();

			//right_picture.Add(Right_Perek_1);
			//right_picture.Add(Right_Perek_2);
			//right_picture.Add(Right_Perek_3);
			//right_picture.Add(Right_Perek_4);
		}

		//Рисуем маленький круг
		private void Draw_mini_circle(PictureBox box)
		{
			System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
			path.AddEllipse(0, 0, 33, 33);
			Region rgn = new Region(path);
			box.Region = rgn;
			box.BackColor = System.Drawing.SystemColors.ActiveCaption;
		}

		//-------------------------------
		private void button_pic_MouseClick(object sender, MouseEventArgs e)
		{
			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}

		//Яркость лампы
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

		//Крутилка шумов
		private void Picture_shum_MouseDown(object sender, MouseEventArgs e)
		{
			shum_arg = e;
			timer4.Enabled = true;
		}

		private void Picture_shum_MouseUp(object sender, MouseEventArgs e)
		{
			timer4.Enabled = false;
		}




		//Правый угол переключатели
		private void Right_Perek_1_MouseClick(object sender, MouseEventArgs e)
		{
			//if (flag_perek_1)
			//{
			//	Image img = Properties.Resources.perek_I;
			//	Right_Perek_1.Image = img;
			//	flag_perek_1 = false;
			//}
			//else
			//{
			//	Image img = Properties.Resources.perek_II;
			//	Right_Perek_1.Image = img;
			//	flag_perek_1 = true;
			//}
			if (pictureBox2.Visible == false)
			{
				pictureBox2.Visible = true;
				Image img = Properties.Resources.perek_I;
				Right_Perek_1.Image = img;
			}
			else
			{
				pictureBox2.Visible = false;
				Image img = Properties.Resources.perek_II;
				Right_Perek_1.Image = img;
			}

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}

		private void Right_Perek_2_MouseClick(object sender, MouseEventArgs e)
		{
			//if (flag_perek_2)
			//{
			//	Image img = Properties.Resources.perek_I;
			//	Right_Perek_2.Image = img;
			//	flag_perek_2 = false;
			//}
			//else
			//{
			//	Image img = Properties.Resources.perek_II;
			//	Right_Perek_2.Image = img;
			//	flag_perek_2 = true;
			//}

			if (pictureBox3.Visible == false)
			{
				pictureBox3.Visible = true;
				Image img = Properties.Resources.perek_I;
				Right_Perek_2.Image = img;
			}
			else
			{
				pictureBox3.Visible = false;
				Image img = Properties.Resources.perek_II;
				Right_Perek_2.Image = img;
			}

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}

		private void Right_Perek_3_MouseClick(object sender, MouseEventArgs e)
		{
			//if (flag_perek_3)
			//{
			//	Image img = Properties.Resources.perek_I;
			//	Right_Perek_3.Image = img;
			//	flag_perek_3 = false;
			//}
			//else
			//{
			//	Image img = Properties.Resources.perek_II;
			//	Right_Perek_3.Image = img;
			//	flag_perek_3 = true;
			//}

			if (pictureBox4.Visible == false)
			{
				pictureBox4.Visible = true;
				Image img = Properties.Resources.perek_I;
				Right_Perek_3.Image = img;
			}
			else
			{
				pictureBox4.Visible = false;
				Image img = Properties.Resources.perek_II;
				Right_Perek_3.Image = img;
			}

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}

		private void Right_Perek_4_MouseClick(object sender, MouseEventArgs e)
		{
			//if (flag_perek_4)
			//{
			//	Image img = Properties.Resources.perek_I;
			//	Right_Perek_4.Image = img;
			//	flag_perek_4 = false;
			//}
			//else
			//{
			//	Image img = Properties.Resources.perek_II;
			//	Right_Perek_4.Image = img;
			//	flag_perek_4 = true;
			//}

			if (pictureBox5.Visible == false)
			{
				pictureBox5.Visible = true;
				Image img = Properties.Resources.perek_I;
				Right_Perek_4.Image = img;
			}
			else
			{
				pictureBox5.Visible = false;
				Image img = Properties.Resources.perek_II;
				Right_Perek_4.Image = img;
			}

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}


		float LAMP = 1f;
		const int best_antenna = 280;
		//Таймеры
		private void timer5_Tick(object sender, EventArgs e) // Лампочка
		{
			Draw_circle(picture_antenna.Image, picture_antenna);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(picture_antenna.Image.Width / 2, picture_antenna.Image.Height / 2);

			if ((flag_auto == 1) || ((antenna_arg.Button == MouseButtons.Left) && (flag_auto == 0)))
			{
				if (antenna_rull_deg < 1440)
				{
					antenna_rull_deg += 10;
				}

				if ((best_antenna > antenna_rull_deg) && (antenna_rull_deg > 0))
				{
					Brightness_Picture(picture_lamp_fr, 1.05f);
				}
				else if ((best_antenna + 100 < antenna_rull_deg) && (antenna_rull_deg < 560))
				{
					Brightness_Picture(picture_lamp_fr, 0.95f);
				}

				if (antenna_rull_deg > best_antenna - 70 && antenna_rull_deg < best_antenna + 50)
				{
					label_poddiapazon.Text = Convert.ToString(Convert.ToInt32(label_poddiapazon.Text) + 5);
				}

				if (antenna_rull_deg > best_antenna + 100 && antenna_rull_deg < best_antenna + 210)
				{
					label_poddiapazon.Text = Convert.ToString(Convert.ToInt32(label_poddiapazon.Text) - 5);
				}
			}
			else
			{
				if (antenna_rull_deg > -720)
				{
					antenna_rull_deg -= 10;
				}
				if ((best_antenna > antenna_rull_deg) && (antenna_rull_deg > 60))
				{
					Brightness_Picture(picture_lamp_fr, 0.95f);
				}
				else if ((best_antenna + 100 < antenna_rull_deg) && (antenna_rull_deg < 560))
				{
					Brightness_Picture(picture_lamp_fr, 1.05f);
				}

				if (antenna_rull_deg > best_antenna - 70 && antenna_rull_deg < best_antenna + 40)
				{
					label_poddiapazon.Text = Convert.ToString(Convert.ToInt32(label_poddiapazon.Text) - 5);
				}

				if (antenna_rull_deg > best_antenna + 90 && antenna_rull_deg < best_antenna + 210)
				{
					label_poddiapazon.Text = Convert.ToString(Convert.ToInt32(label_poddiapazon.Text) + 5);
				}
			}

			if (antenna_rull_deg == best_antenna - 70)
			{
				label_poddiapazon.Text = "20";
			}

			mymatrix.RotateAt(antenna_rull_deg, center_picture);
			Graphics g = picture_antenna.CreateGraphics();
			picture_lamp_fr.Visible = true;
			g.Transform = mymatrix;
			g.DrawImage(picture_antenna.Image, 0, 0);

			if (antenna_rull_deg == 560 || antenna_rull_deg == 0)
			{
				picture_lamp_fr.Image = Properties.Resources.power;

			}


			//Brightness_Picture(picture_lamp_fr, LAMP);

			flag_auto = 0;
		}

		private void timer4_Tick(object sender, EventArgs e)
		{
			Draw_circle(Picture_shum.Image, Picture_shum);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(Picture_shum.Image.Width / 2, Picture_shum.Image.Height / 2);

			if (shum_arg.Button == MouseButtons.Left) //определиние какая клавиша мыши была нажата
			{
				if (shum_rull_deg < 360)
				{
					shum_rull_deg += 15;
				}
			}
			else
			{
				if (shum_rull_deg > -60)
				{
					shum_rull_deg -= 15;
				}
			}


			mymatrix.RotateAt(shum_rull_deg, center_picture);
			Graphics g = Picture_shum.CreateGraphics();
			g.Transform = mymatrix;
			g.DrawImage(Picture_shum.Image, 0, 0);

			if (shum_rull_deg == -60 && arr[1] == 1)
			{
				arr[2] = 1;
			}
			else
			{
				arr[2] = 0;
				configuration_steps[0] = 0;
			}
		}

		private void timer3_Tick(object sender, EventArgs e)
		{

			Draw_circle(Picture_frequence.Image, Picture_frequence);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(Picture_frequence.Image.Width / 2, Picture_frequence.Image.Height / 2);


			if ((flag_auto == 1) || ((frequence_arg.Button == MouseButtons.Left) && (flag_auto == 0))) //определиние какая клавиша мыши была нажата
			{
				if (frenquence_rull_deg > 0)
				{
					frenquence_rull_deg -= 5;
				}
			}
			else
			{
				if (frenquence_rull_deg < 785)
				{
					frenquence_rull_deg += 5;
				}

			}

			mymatrix.RotateAt(frenquence_rull_deg * (-1), center_picture);
			Graphics g = Picture_frequence.CreateGraphics();
			g.Transform = mymatrix;
			g.DrawImage(Picture_frequence.Image, 0, 0);

			value_fr = (frenquence_rull_deg / 5) + 200;
			frenquence_label.Text = value_fr.ToString();
			value_fr = (frenquence_rull_deg / 5) + 358;
			frenquence_label_2.Text = value_fr.ToString();


			Picture_frequence_table((frenquence_rull_deg / 2) * (-1));
			flag_auto = 0;
			draw_flag = false;

		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			Draw_circle(Volume_rull.Image, Volume_rull);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(Volume_rull.Image.Width / 2, Volume_rull.Image.Height / 2);

			if (Volume_arg.Button == MouseButtons.Left) //определиние какая клавиша мыши была нажата
			{
				if (volume_rull_deg < 360)
				{
					volume_rull_deg += 15;
				}
			}
			else
			{
				if (volume_rull_deg > 0)
				{
					volume_rull_deg -= 15;
				}
			}

			if (volume_rull_deg == 360)
			{
				arr[6] = 1;
			}
			else
			{
				arr[6] = 0;
				configuration_steps[0] = 0;
			}
			mymatrix.RotateAt(volume_rull_deg, center_picture);
			Graphics g = Volume_rull.CreateGraphics();

			g.Transform = mymatrix;
			g.DrawImage(Volume_rull.Image, 0, 0);
		}




		//Шкала вкл/выкл
		private void pictrure_shcala_MouseClick(object sender, MouseEventArgs e)
		{
			if (flag)
			{
				Image img = Properties.Resources.vkl_2;
				pictrure_shcala.Image = img;
				flag = false;

				arr[4] = 0;
				configuration_steps[0] = 0;
			}
			else
			{
				Image img = Properties.Resources.vkl_1;
				pictrure_shcala.Image = img;
				flag = true;

				arr[4] = 1;
			}

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}
		//Питание вкл/выкл
		private void picture_power_MouseClick(object sender, MouseEventArgs e)
		{
			if (!flag_2)
			{
				Image img = Properties.Resources.vkl_1;
				picture_power.Image = img;
				flag_2 = true;

				arr[5] = 1;
			}
			else
			{
				Image img = Properties.Resources.vkl_2;
				picture_power.Image = img;
				flag_2 = false;

				arr[5] = 0;
				configuration_steps[0] = 0;
			}
			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}





		//Крутилка частот

		private void Rotate(object sender, EventArgs e)
		{

			Draw_circle(Picture_frequence.Image, Picture_frequence);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(Picture_frequence.Image.Width / 2, Picture_frequence.Image.Height / 2);

			mymatrix.RotateAt(-785, center_picture);
			Graphics g = Picture_frequence.CreateGraphics();
			g.Transform = mymatrix;
			g.DrawImage(Picture_frequence.Image, 0, 0);


			Draw_circle(frenquence_table.Image, frenquence_table);
			System.Drawing.Drawing2D.Matrix mymatrix_2 = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture_2 = new PointF(frenquence_table.Image.Width / 2, frenquence_table.Image.Height / 2);

			mymatrix.RotateAt(-392.5f, center_picture);
			Graphics g_2 = frenquence_table.CreateGraphics();
			g_2.Transform = mymatrix_2;
			g_2.DrawImage(frenquence_table.Image, 0, 0);
		}

		private void Picture_frequence_Paint(object sender, PaintEventArgs e)
		{
			Rotate(sender, e);
		}

		private void Р123_Shown(object sender, EventArgs e)
		{
			Image img = Properties.Resources.R_123M;
			this.BackgroundImage = new Bitmap(img);
			Open_Panel.Visible = true;
			Image img_2 = Properties.Resources.rull_I;
			Draw_circle(img_2, Main_rull);

			Draw_circle(Volume_rull.Image, Volume_rull);

			Draw_circle(Corrector.Image, Corrector);

			Draw_circle(frenquence_table.Image, frenquence_table);

			Draw_circle(picture_antenna.Image, picture_antenna);

			Draw_circle(voltage_control_rull.Image, voltage_control_rull);

			Draw_circle(Picture_shum.Image, Picture_shum);

			Draw_circle(Picture_frequence.Image, Picture_frequence);


			frenquence_label.Text = "357";
			frenquence_label_2.Text = "515";

			Draw_circle(picture_lamp_fr.Image, picture_lamp_fr);

			//Draw_circle(picture_fiks_anten.Image, picture_fiks_anten);

			for (int i = 0; i < 44; i++)
				arr[i] = 0;
			arr[0] = 1;
			for (int i = 0; i < 5; i++)
				configuration_steps[i] = 0;
			timer7.Start();

			right_picture.Add(Right_Perek_1);
			right_picture.Add(Right_Perek_2);
			right_picture.Add(Right_Perek_3);
			right_picture.Add(Right_Perek_4);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (open_frenquence_table.Visible == false)
			{
				if (fix == true)
				{
					fix = false;
					button1.Text = "ЗАФИКСИРОВАТЬ";
				}
				else
				{
					fix = true;
					button1.Text = "РАЗФИКСИРОВАТЬ";
				}
			}
		}

		private void timer7_Tick(object sender, EventArgs e) // Проверка выполнения задачи(отображается в справке)
		{

			if (configuration_steps[0] == 0) // Блок подготовки к работе
			{
				for (int i = 0; i < 7; i++)
				{
					if (arr[i] == 0)
					{
						for (int j = 7; j < 44; j++)
						{
							arr[j] = 0;
						}
						return;
					}
				}
				configuration_steps[0] = 1;
			}
			switch (main_rull_deg) // Блок проверки настроенных частот
			{
				case 0:
					{
						arr[7] = 1; // установили нужную частоту

						if (fix == false) // Расфиксировали болтик
						{
							arr[8] = 1;
							set_arr_null(9, 15);
						}
						else
						{
							if ((frenquence_label.Text == frequency_1.ToString() || frenquence_label.Text == frequency_2.ToString()) && (fix == true)
								&& arr[8] == 1)
							{
								arr[9] = 1;
							}
							else
							{
								set_arr_null(8, 15);
								break;
							}
						}

						if (pictureBox2.Visible == true && frenquence_label.Text == frequency_1.ToString() && arr[9] == 1)
						{
							arr[10] = 1;
							arr[11] = 1;
						}
						else
						{
							if (pictureBox2.Visible == false && frenquence_label.Text == frequency_2.ToString())
							{
								arr[10] = 1;
								arr[11] = 1;
							}
							else
							{
								set_arr_null(10, 15);
								break;
							}
						}

						if (antenna_rull_deg <= 380 && antenna_rull_deg >= 320)
						{
							arr[12] = 1;
							arr[13] = 1;
							arr[14] = 1;
							arr[15] = 1;
						}
						else
						{
							set_arr_null(12, 15);
							break;
						}



						return;
					}

				default:
					return;
			}

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			//if (draw_flag)
			//	Rotate(sender, e);
		}

		private void Picture_frequence_table(float frenquence_table_deg)
		{
			Draw_circle(frenquence_table.Image, frenquence_table);
			Point rotated = new Point();
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(frenquence_table.Image.Width / 2, frenquence_table.Image.Height / 2);

			mymatrix.RotateAt(frenquence_table_deg, center_picture);
			Graphics g = frenquence_table.CreateGraphics();


			//TODO доделать ебучий поворот болтов!!!
			//исспользовать матрицу поворота(?)

			//center_picture.X = frenquence_table.Location.X + 129;
			//center_picture.Y = frenquence_table.Location.Y + 123;

			//rotated.X = Convert.ToInt32(center_picture.X + (label1.Location.X - center_picture.X) * (float)Math.Cos(0.1)
			//	+ (label1.Location.Y - center_picture.Y) * (float)Math.Sin(0.1));
			//rotated.Y = Convert.ToInt32(center_picture.Y - (label1.Location.X - center_picture.X) * (float)Math.Sin(0.1)
			//	+ (label1.Location.Y - center_picture.Y) * (float)Math.Cos(0.1));
			//label1.Location = rotated;

			g.Transform = mymatrix;
			g.DrawImage(frenquence_table.Image, 0, 0);

		}

		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 f = new Form2(arr);
			f.Show();
		}

		private void Picture_frequence_MouseDown(object sender, MouseEventArgs e)
		{
			frequence_arg = e;
			if (fix == false)
			{
				timer3.Enabled = true;
			}
		}

		private void Picture_frequence_MouseUp(object sender, MouseEventArgs e)
		{
			timer3.Enabled = false;
		}

		//Закрывашка крутилки частот
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



		//Переключатель Симплекс-Прием-
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
			if (corrector_rull_deg == 25)
			{
				arr[1] = 1;
			}
			else
			{
				arr[1] = 0;
				configuration_steps[0] = 0;
			}
		}



		//Крутилка громкости
		private void Volume_rull_MouseDown(object sender, MouseEventArgs e)
		{
			Volume_arg = e;
			timer2.Enabled = true;
		}

		private void Volume_rull_MouseUp(object sender, MouseEventArgs e)
		{
			timer2.Enabled = false;
		}



		//Контроль напряжения
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
			if (voltage_control_rull_deg == 30)
			{
				arr[3] = 1;
			}
			else
			{
				arr[3] = 0;
				configuration_steps[0] = 0;
			}
		}



		//Крутилка фиксированных частот и плавных поддиапазовнов
		private void Auto_(object sender, MouseEventArgs e, int value, int value_2)
		{

			while (((frenquence_rull_deg / 5) + 200) != value)
			{
				if (((frenquence_rull_deg / 5) + 200) >= value)
				{
					flag_auto = 1;
				}
				else
				{
					flag_auto = 2;
				}

				timer3_Tick(sender, e);
				System.Threading.Thread.Sleep(30);
			}


			while (antenna_rull_deg != value_2)
			{
				if (antenna_rull_deg <= value_2)
				{
					flag_auto = 1;
				}
				else
				{
					flag_auto = 2;
				}

				timer5_Tick(sender, e);
				System.Threading.Thread.Sleep(30);
			}
		}
		private void Main_rull_MouseClick(object sender, MouseEventArgs e)
		{
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(111, 114);
			if (fix == true)
			{
				if (e.Button == MouseButtons.Left)
					main_rull_deg += 60;
				else
					main_rull_deg -= 60;

				if (main_rull_deg == 360 || main_rull_deg == -360)
					main_rull_deg = 0;

				mymatrix.RotateAt(main_rull_deg + 60, center_picture);
				Graphics g = Main_rull.CreateGraphics();
				g.Transform = mymatrix;
				g.DrawImage(Main_rull.Image, 0, 0);

				new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
				switch (main_rull_deg / 60)
				{
					case 0:
						{
							//pictureBox2.Visible = true;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							Auto_(sender, e, 232, 1000);

							break;
						}
					case 1:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = true;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							break;
						}
					case 2:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = true;
							//pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							break;
						}
					case 3:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = true;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							break;
						}
					case 4:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = false;
							picture_Lamp_I.Visible = false;
							picture_Lamp_II.Visible = true;
							break;
						}
					case 5:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = true;
							break;
						}
					case 6:
						{
							//pictureBox2.Visible = true;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							break;
						}
					case -1:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = true;
							break;
						}
					case -2:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = false;
							picture_Lamp_I.Visible = false;
							picture_Lamp_II.Visible = true;
							break;
						}
					case -3:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = true;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							break;
						}
					case -4:
						{
							//pictureBox2.Visible = false;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = true;
							//pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							break;
						}
					case -5:
						{
							//	pictureBox2.Visible = false;
							//	pictureBox3.Visible = true;
							//	pictureBox4.Visible = false;
							//	pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							break;
						}
					case -6:
						{
							//pictureBox2.Visible = true;
							//pictureBox3.Visible = false;
							//pictureBox4.Visible = false;
							//pictureBox5.Visible = false;
							picture_Lamp_II.Visible = false;
							picture_Lamp_I.Visible = false;
							break;
						}
					default:
						break;
				}
				//if (configuration_steps[0] == 1)
				//{
				//	switch (main_rull_deg)
				//	{
				//		case 0:
				//			{

				//				break;
				//			}
				//		default:
				//			break;
				//	}
				//}
			}
			else // TODO добавить звук если пользователь пытается переключить не зафиксировав частоту
			{

			}
		}



		//Крутилка антенны

		private void picture_antenna_MouseDown(object sender, MouseEventArgs e)
		{
			antenna_arg = e;
			timer5.Enabled = true;
		}

		private void picture_antenna_MouseUp(object sender, MouseEventArgs e)
		{
			timer5.Enabled = false;
		}

		private void picture_fiks_anten_MouseDown(object sender, MouseEventArgs e)
		{
			fiks_antenna = e;
			timer6.Enabled = true;
		}

		private void picture_fiks_anten_MouseUp(object sender, MouseEventArgs e)
		{
			timer6.Enabled = false;
		}



	}
}
