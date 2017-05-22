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
		[Obsolete("Лучше не компилировать этот говонокод!", false)]
		public Р123()
		{
			InitializeComponent();
		}

		int[] frequency_1 = { 220, 260, 280, 300 };
		int[] frequency_2 = { 500, 480, 460, 440 };
		int main_rull_deg = 300, volume_rull_deg = 0,
			  corrector_rull_deg = 0, antenna_rull_deg = 0,
			  voltage_control_rull_deg = 0, shum_rull_deg = 0, frenquence_rull_deg = 785;


		int flag_auto;

		MouseEventArgs Volume_arg = null,
			frequence_arg = null,
			shum_arg = null,
			antenna_arg = null,
			fiks_antenna = null;
		bool[] right_perek = { false, false, false, false };

		List<PictureBox> right_picture = new List<PictureBox>();


		int[] arr = new int[44]; // Массив флагов
		int[] configuration_steps = new int[5];

		int[] best_antenna = { 420, 900 }; // Значения предельного отклонения стрелки 
		int[] best_luminosity = { -280, 500, 1100 }; // Максимальное свечение лампы


		bool flag = false, flag_2 = false, draw_flag = true, fix = true, flag_antenn_fiks = true;
		int value_fr = 0;
		bool tangenta_flag = false;
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
			label_poddiapazon.Text = "20";
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

			if (right_perek[0] == false)
			{
				if (Math.Abs(main_rull_deg / 60) % 6 == 0)
				{
					picture_Lamp_I.Visible = false;
					picture_Lamp_II.Visible = true;
				}
				Image img = Properties.Resources.perek_I;
				Right_Perek_1.Image = img;
				right_perek[0] = true;
			}
			else
			{
				if (Math.Abs(main_rull_deg / 60) % 6 == 0)
				{
					picture_Lamp_I.Visible = true;
					picture_Lamp_II.Visible = false;
				}
				Image img = Properties.Resources.perek_II;
				Right_Perek_1.Image = img;
				right_perek[0] = false;
			}


			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}

		private void Right_Perek_2_MouseClick(object sender, MouseEventArgs e)
		{
			if (right_perek[1] == false)
			{
				if (Math.Abs(main_rull_deg / 60) % 6 == 1)
				{
					picture_Lamp_I.Visible = false;
					picture_Lamp_II.Visible = true;
				}
				Image img = Properties.Resources.perek_I;
				Right_Perek_2.Image = img;
				right_perek[1] = true;
			}
			else
			{
				if (Math.Abs(main_rull_deg / 60) % 6 == 1)
				{
					picture_Lamp_I.Visible = true;
					picture_Lamp_II.Visible = false;
				}
				Image img = Properties.Resources.perek_II;
				Right_Perek_2.Image = img;
				right_perek[1] = false;
			}

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}

		private void Right_Perek_3_MouseClick(object sender, MouseEventArgs e)
		{
			if (right_perek[2] == false)
			{
				if (Math.Abs(main_rull_deg / 60) % 6 == 2)
				{
					picture_Lamp_I.Visible = false;
					picture_Lamp_II.Visible = true;
				}
				Image img = Properties.Resources.perek_I;
				Right_Perek_3.Image = img;
				right_perek[2] = true;
			}
			else
			{
				if (Math.Abs(main_rull_deg / 60) % 6 == 2)
				{
					picture_Lamp_I.Visible = true;
					picture_Lamp_II.Visible = false;
				}
				Image img = Properties.Resources.perek_II;
				Right_Perek_3.Image = img;
				right_perek[2] = false;
			}

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}

		private void Right_Perek_4_MouseClick(object sender, MouseEventArgs e)
		{
			if (right_perek[3] == false)
			{
				if (Math.Abs(main_rull_deg / 60) % 6 == 3)
				{
					picture_Lamp_I.Visible = false;
					picture_Lamp_II.Visible = true;
				}
				Image img = Properties.Resources.perek_I;
				Right_Perek_4.Image = img;
				right_perek[3] = true;
			}
			else
			{
				if (Math.Abs(main_rull_deg / 60) % 6 == 3)
				{
					picture_Lamp_I.Visible = true;
					picture_Lamp_II.Visible = false;
				}
				Image img = Properties.Resources.perek_II;
				Right_Perek_4.Image = img;
				right_perek[3] = false;
			}

			new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
		}
		//Таймеры
		private void timer5_Tick(object sender, EventArgs e) // Лампочка
		{
			Draw_circle(picture_antenna.Image, picture_antenna);
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(picture_antenna.Image.Width / 2, picture_antenna.Image.Height / 2);
			if (flag_antenn_fiks)
			{
				if ((flag_auto == 1) || ((antenna_arg.Button == MouseButtons.Left) && (flag_auto == 0)))
				{
					if (antenna_rull_deg < 1440)
					{
						antenna_rull_deg += 10;
					}
				}
				else
				{
					if (antenna_rull_deg > -720)
					{
						antenna_rull_deg -= 10;
					}
				}
				//лампочка начинает загораться начиная от best - 220 до best 
				// И начинает затухать от best + 100 до best + 320

				foreach (int best in best_luminosity) // яркость лампочки
				{
					if ((best - 220 < antenna_rull_deg && best > antenna_rull_deg && antenna_arg.Button == MouseButtons.Left)
						|| (best + 100 < antenna_rull_deg && best + 320 > antenna_rull_deg && antenna_arg.Button == MouseButtons.Right))
					{
						Brightness_Picture(picture_lamp_fr, 1.015f); // Увелечение яркости
					}

					if ((best - 220 < antenna_rull_deg && best > antenna_rull_deg && antenna_arg.Button == MouseButtons.Right)
						|| (best + 100 < antenna_rull_deg && best + 320 > antenna_rull_deg && antenna_arg.Button == MouseButtons.Left))
					{
						Brightness_Picture(picture_lamp_fr, 0.985f); // Уменьшение яркости
					}

					if (antenna_rull_deg == best - 250 || antenna_rull_deg == best + 350) // Сбросили текстуру лампочки к исходному варианту
					{
						picture_lamp_fr.Image = Properties.Resources.power;
					}
				}

				// стрелка дергается от [x-70, x+100] и [x + 140, x + 310]

				foreach (int best in best_antenna) // вроверка вхождения значения поворота крутилки в границы необходимые для отклонения стрелки
				{
					if ((antenna_rull_deg > best - 70 && antenna_rull_deg <= best + 100 && antenna_arg.Button == MouseButtons.Left)
						|| (antenna_rull_deg >= best + 140 && antenna_rull_deg < best + 310 && antenna_arg.Button == MouseButtons.Right))
					{
						label_poddiapazon.Text = Convert.ToString(Convert.ToInt32(label_poddiapazon.Text) + 5);

						System.Drawing.Drawing2D.Matrix matrix = new System.Drawing.Drawing2D.Matrix();
						PointF center = new PointF(arrow_image.Image.Width / 2, frenquence_table.Image.Height);

						matrix.RotateAt((Convert.ToInt32(label_poddiapazon.Text) - 60) / 5, center);
						Graphics gr = arrow_image.CreateGraphics();
						gr.Transform = matrix;
						gr.DrawImage(arrow_image.Image, 0, 0);
					}

					if ((antenna_rull_deg > best + 140 && antenna_rull_deg <= best + 310 && antenna_arg.Button == MouseButtons.Left)
						|| (antenna_rull_deg >= best - 70 && antenna_rull_deg < best + 100 && antenna_arg.Button == MouseButtons.Right))
					{
						label_poddiapazon.Text = Convert.ToString(Convert.ToInt32(label_poddiapazon.Text) - 5);

						System.Drawing.Drawing2D.Matrix matrix = new System.Drawing.Drawing2D.Matrix();
						PointF center = new PointF(arrow_image.Image.Width / 2, frenquence_table.Image.Height);

						matrix.RotateAt((Convert.ToInt32(label_poddiapazon.Text) - 60) / 5, center);
						Graphics gr = arrow_image.CreateGraphics();
						gr.Transform = matrix;
						gr.DrawImage(arrow_image.Image, 0, 0);
					}

				}

				mymatrix.RotateAt(antenna_rull_deg, center_picture);
				Graphics g = picture_antenna.CreateGraphics();
				picture_lamp_fr.Visible = true;
				g.Transform = mymatrix;
				g.DrawImage(picture_antenna.Image, 0, 0);

				mymatrix = new System.Drawing.Drawing2D.Matrix();
				center_picture = new PointF(Fiks_antenn.Image.Width / 2, Fiks_antenn.Image.Height / 2);
				mymatrix.RotateAt(antenna_rull_deg, center_picture);
				g = Fiks_antenn.CreateGraphics();
				g.Transform = mymatrix;
				g.DrawImage(Fiks_antenn.Image, 0, 0);
				//Brightness_Picture(picture_lamp_fr, LAMP);

				flag_auto = 0;
			}

		}
		//Шум
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
		//Частота
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
		//Громкость
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

		private void Fiks_antenn_MouseClick(object sender, MouseEventArgs e)
		{
			int turn = 0;
			if (flag_antenn_fiks)
			{
				turn = 90;
				flag_antenn_fiks = false;
			}
			else
			{
				turn = 0;
				flag_antenn_fiks = true;
			}
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(Fiks_antenn.Image.Width / 2, Fiks_antenn.Image.Height / 2);
			mymatrix.RotateAt(antenna_rull_deg + turn, center_picture);
			Graphics g = Fiks_antenn.CreateGraphics();
			g.Transform = mymatrix;
			g.DrawImage(Fiks_antenn.Image, 0, 0);
		}

		private void Р123_Shown(object sender, EventArgs e)
		{

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

			Draw_circle(Fiks_antenn.Image, Fiks_antenn);

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

			//label_poddiapazon.Text = "20";
			////System.Drawing.Drawing2D.Matrix matrix = new System.Drawing.Drawing2D.Matrix();
			////PointF center = new PointF(arrow_image.Image.Width / 2, frenquence_table.Image.Height);

			////matrix.RotateAt((Convert.ToInt32(label_poddiapazon.Text) - 60) / 5, center);
			////Graphics gr = arrow_image.CreateGraphics();
			////gr.Transform = matrix;
			////gr.DrawImage(arrow_image.Image, 0, 0);
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

		private void Main_rull_Click(object sender, EventArgs e)
		{

		}

		private void tangenta_prd_picture_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void tangenta_picture_MouseClick_1(object sender, MouseEventArgs e)
		{
			if (!tangenta_flag)
			{
				tangenta_picture.Image = Properties.Resources.tangenta_prd;
				tangenta_flag = true;
				new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
			}
			else
			{
				tangenta_picture.Image = Properties.Resources.tangenta_prm;
				tangenta_flag = false;
				new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
			}
		}

		private void timer7_Tick(object sender, EventArgs e) // Проверка выполнения задачи(отображается в справке)
		{
			CheckBox[] check = { checkBox2, checkBox3, checkBox4, checkBox5 }; // Массив чекбоксов отвечающих за настройку застот
			if (configuration_steps[0] == 0) // Блок подготовки к работе
			{
				for (int k = 0; k < 7; k++)
				{
					if (arr[k] == 0)
					{
						for (int j = 7; j < 44; j++)
						{
							arr[j] = 0;
						}
						checkBox1.Checked = false;
						return;
					}
				}
				configuration_steps[0] = 1;
				checkBox1.Checked = true;
			}

			//if (configuration_steps[0] == 1)
			//{
			//    checkBox1.Checked = true;
			//}

			// Блок проверки настроенных частот
			int i = Math.Abs(main_rull_deg / 60) % 6;
			if (i > 3)
				return;

			arr[7 + 9 * i] = 1; // установили нужную частоту

			if (fix == false) // Расфиксировали болтик
			{
				arr[8 + 9 * i] = 1;
				set_arr_null(9 + 9 * i, 15 + 9 * i);
			}
			else
			{
				//если болтик расфиксирован, проверяем установку нужной частоты 
				if ((frenquence_label.Text == frequency_1[i].ToString() || frenquence_label_2.Text == frequency_2[i].ToString())
					&& (fix == true) && arr[8 + 9 * i] == 1) //Если болтик зафиксирован и установлена нужная чатота, то ставим ГОТОВО
				{
					arr[9 + 9 * i] = 1;
				}
				else
				{ // Иначе зануляем
					set_arr_null(8 + 9 * i, 15 + 9 * i);
					return;
				}
			}
			// Устанавливаем рабочий поддиапазон
			///TODO переделать, сейчас поддиапазоны устанавливаются неправильно
			if (pictureBox2.Visible == true && frenquence_label.Text == frequency_1[i].ToString() && arr[9 + 9 * i] == 1)
			{
				arr[10 + 9 * i] = 1;
			}
			else
			{
				if (pictureBox2.Visible == false && frenquence_label_2.Text == frequency_2[i].ToString())
				{
					arr[10 + 9 * i] = 1;
				}
				else
				{
					set_arr_null(10 + 9 * i, 15 + 9 * i);
					return;
				}
			}
			// Включили радиостанцию на передачу через тангенту
			if (tangenta_flag && check[i - 1].Checked == false)
			{
				arr[11 + 9 * i] = 1;
			}
			else
			{
				set_arr_null(11 + 9 * i, 15 + 9 * i);
				return;
			}
			//Настройка антенны 
			if (flag_antenn_fiks == true)
			{

				if (antenna_rull_deg <= 560 && antenna_rull_deg >= 520)
				{
					arr[12 + 9 * i] = 1;
				}
				else
				{
					set_arr_null(12 + 9 * i, 15 + 9 * i);
					return;
				}
			}

			if ((flag_antenn_fiks == false) && (arr[12 + 9 * i] == 1))
			{
				arr[13 + 9 * i] = 1;
				arr[14 + 9 * i] = 1;
			}
			else
			{
				set_arr_null(13 + 9 * i, 15 + 9 * i);
				return;
			}

			// отпустили тангенту
			if (tangenta_flag == false)
			{
				arr[15 + 9 * i] = 1;
			}


			// Устанавливаем чекбоксы
			for (int k = 1; i <= 4; i++)
			{
				if (arr[15 + 9 * k] == 1)
				{
					check[k - 1].Checked = true;
				}
				else
				{
					check[k - 1].Checked = false;
				}
			}


		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			//label_poddiapazon.Text = "20";
			System.Drawing.Drawing2D.Matrix matrix = new System.Drawing.Drawing2D.Matrix();
			PointF center = new PointF(arrow_image.Image.Width / 2, frenquence_table.Image.Height);

			matrix.RotateAt((Convert.ToInt32(label_poddiapazon.Text) - 60) / 5, center);
			Graphics gr = arrow_image.CreateGraphics();
			gr.Transform = matrix;
			gr.DrawImage(arrow_image.Image, 0, 0);
		}

		private void Picture_frequence_table(float frenquence_table_deg)
		{
			Draw_circle(frenquence_table.Image, frenquence_table);
			Point rotated = new Point();
			System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
			PointF center_picture = new PointF(frenquence_table.Image.Width / 2, frenquence_table.Image.Height / 2);

			mymatrix.RotateAt(frenquence_table_deg, center_picture);
			Graphics g = frenquence_table.CreateGraphics();


			///TODO доделать ебучий поворот болтов!!!
			///Код готов, надо исправить картинку, в ней неправильный центр
			// выставить центр
			center_picture.X = frenquence_table.Location.X + 122;
			center_picture.Y = frenquence_table.Location.Y + 122;

			rotated.X = Convert.ToInt32(center_picture.X + (label1.Location.X - center_picture.X) * (float)Math.Cos(-2.2 / (180 / 3.14))
				+ (label1.Location.Y - center_picture.Y) * (float)Math.Sin(-2.2 / (180 / 3.14)));
			rotated.Y = Convert.ToInt32(center_picture.Y - (label1.Location.X - center_picture.X) * (float)Math.Sin(-2.2 / (180 / 3.14))
				+ (label1.Location.Y - center_picture.Y) * (float)Math.Cos(-2.2 / (180 / 3.14)));
			label1.Location = rotated;

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
		// Переключатель частот(главная крутилка)
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
				if (main_rull_deg == -60)
					main_rull_deg = 300;

				mymatrix.RotateAt(main_rull_deg + 60, center_picture);
				Graphics g = Main_rull.CreateGraphics();
				g.Transform = mymatrix;
				g.DrawImage(Main_rull.Image, 0, 0);

				new System.Media.SoundPlayer(Properties.Resources.Click_Sound).Play();
				switch (Math.Abs(main_rull_deg / 60) % 6)
				{
					case 0: //1 частота
						{
							//Auto_(sender, e, 232, 1000);
							// Включили лампочку нужной частоты(и выключили лампочки соседних частот)
							pictureBox2.Visible = true;
							pictureBox3.Visible = false;

							// Включили лампочку нужного поддиапаона(в зависимости от положения переключателя)
							if (right_perek[0] == false)
							{
								picture_Lamp_I.Visible = true;
								picture_Lamp_II.Visible = false;
							}
							else
							{
								picture_Lamp_I.Visible = false;
								picture_Lamp_II.Visible = true;
							}
								break;
						}
					case 1: // 2 частота
						{
							pictureBox2.Visible = false;
							pictureBox3.Visible = true;
							pictureBox4.Visible = false;

							if (right_perek[1] == false)
							{
								picture_Lamp_I.Visible = true;
								picture_Lamp_II.Visible = false;
							}
							else
							{
								picture_Lamp_I.Visible = false;
								picture_Lamp_II.Visible = true;
							}
							break;
						}
					case 2: // 3 частота
						{
							pictureBox3.Visible = false;
							pictureBox4.Visible = true;
							pictureBox5.Visible = false;

							if (right_perek[2] == false)
							{
								picture_Lamp_I.Visible = true;
								picture_Lamp_II.Visible = false;
							}
							else
							{
								picture_Lamp_I.Visible = false;
								picture_Lamp_II.Visible = true;
							}
							break;
						}
					case 3: // 4 частота
						{
							pictureBox4.Visible = false;
							pictureBox5.Visible = true;

							if (right_perek[3] == false)
							{
								picture_Lamp_I.Visible = true;
								picture_Lamp_II.Visible = false;
							}
							else
							{
								picture_Lamp_I.Visible = false;
								picture_Lamp_II.Visible = true;
							}
							break;
						}
					case 4: // 2 поддиапазон
						{
							pictureBox5.Visible = false;

							picture_Lamp_I.Visible = false;
							picture_Lamp_II.Visible = true;
							break;
						}
					case 5: // 1 поддиапазон
						{
							pictureBox2.Visible = false;

							picture_Lamp_I.Visible = true;
							picture_Lamp_II.Visible = false;
							break;
						}
					default:
						break;
				}
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

		//private void picture_fiks_anten_MouseDown(object sender, MouseEventArgs e)
		//{
		//	fiks_antenna = e;
		//	timer6.Enabled = true;
		//}

		//private void picture_fiks_anten_MouseUp(object sender, MouseEventArgs e)
		//{
		//	timer6.Enabled = false;
		//}



	}
}
