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
        float deg = 10;
        PointF a = new PointF(0, -111); // Нормальный вектор прошлого полжения вентеля
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

        private void label1_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_1;
           // Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_2;
           // Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_3;
           // Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_4;
           // Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_I;
           // Draw_circle(img);
            pictureBox6.Image = img;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.rull_II;
           // Draw_circle(img);
            pictureBox6.Image = img;
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            Image img = Properties.Resources.Green_4;
            Bitmap my = new Bitmap(img);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF mypoint = new PointF(17, 17);
            mymatrix.RotateAt(250, mypoint);
            Graphics g = pictureBox7.CreateGraphics();
            // g.RotateTransform(350.0F);
            g.Transform = mymatrix;
            g.DrawImage(img, 0, 0);
            //g.DrawImage()
            
        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            Image img = Properties.Resources.rull_1;
            Bitmap my = new Bitmap(img);
            //Graphics g = 
           // g.RotateTransform(15.0F, System.Drawing.Drawing2D.MatrixOrder.Append);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.Green_4;
            Bitmap my = new Bitmap(img);
            Graphics g = pictureBox7.CreateGraphics();
            g.RotateTransform(255.0F);
            g.DrawImage(img, 0, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.Green_4;
            Bitmap my = new Bitmap(img);
            Graphics g = pictureBox7.CreateGraphics();
            //g.RotateTransform(350.0F);
            g.DrawImage(img, 0, 0);
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
           // Image img = Properties.Resources.Green_4;
           // Bitmap my_bitmap = new Bitmap(pictureBox6.Image);
            System.Drawing.Drawing2D.Matrix mymatrix = new System.Drawing.Drawing2D.Matrix();
            PointF center_picture = new PointF(111, 114);
            PointF b = new PointF(e.Y - 114, e.X - 111);
            //mymatrix.RotateAt((float)Math.Acos((double)((a.X * b.X + a.Y * b.Y) / 
            //    (Math.Sqrt((double)(a.X * a.X + a.Y * a.Y)) * Math.Sqrt((double)(b.X * b.X + b.Y * b.Y)))))
            //    , center_picture);
            mymatrix.RotateAt(deg, center_picture);
            Graphics g = pictureBox6.CreateGraphics();
            // g.RotateTransform(350.0F);
            g.Transform = mymatrix;
            g.DrawImage(pictureBox6.Image, 0, 0);
            a = b;
            deg += 10;
            //g.DrawImage()
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
        //   Image img = Properties.Resources.Green_4;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Image img = Properties.Resources.Green_4;
        }


        private void label7_Click(object sender, EventArgs e)
        {
            Draw_mini_circle(pictureBox2);
            if (pictureBox2.Visible)
                pictureBox2.Visible = false;
            else
                pictureBox2.Visible = true;
            //   label7.Parent = this.pictureBox8;
            label7.BackColor = pictureBox8.BackColor;
            //label7.Visible = true;
            //label7.Enabled = true;
            //label7.Location = new System.Drawing.Point(1031,198);
            //label7.Size = new System.Drawing.Size(32, 32);
            //label7.BringToFront();
           
        }
     

        private void label8_Click(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox3);
            if (pictureBox3.Visible)
                pictureBox3.Visible = false;
            else
                pictureBox3.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox4);
            if (pictureBox4.Visible)
                pictureBox4.Visible = false;
            else
                pictureBox4.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

            Draw_mini_circle(pictureBox5);
            if (pictureBox5.Visible)
                pictureBox5.Visible = false;
            else
                pictureBox5.Visible = true;
        }


        private void label11_Click(object sender, EventArgs e)
        {
            // Draw_mini_circle(pictureBox5);
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
    }
}
