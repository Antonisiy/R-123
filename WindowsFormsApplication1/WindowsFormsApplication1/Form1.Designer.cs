namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.Open_cap = new System.Windows.Forms.Label();
			this.open_frenquence_table = new System.Windows.Forms.Label();
			this.frenquence_label = new System.Windows.Forms.Label();
			this.picture_lamp_fr = new System.Windows.Forms.PictureBox();
			this.Picture_frequence = new System.Windows.Forms.PictureBox();
			this.Picture_shum = new System.Windows.Forms.PictureBox();
			this.picture_antenna = new System.Windows.Forms.PictureBox();
			this.voltage_control_rull = new System.Windows.Forms.PictureBox();
			this.picture_Lamp_II = new System.Windows.Forms.PictureBox();
			this.picture_Lamp_I = new System.Windows.Forms.PictureBox();
			this.frenquence_table = new System.Windows.Forms.PictureBox();
			this.Volume_rull = new System.Windows.Forms.PictureBox();
			this.Corrector = new System.Windows.Forms.PictureBox();
			this.Right_Perek_4 = new System.Windows.Forms.Label();
			this.Right_Perek_3 = new System.Windows.Forms.Label();
			this.Right_Perek_2 = new System.Windows.Forms.Label();
			this.Right_Perek_1 = new System.Windows.Forms.Label();
			this.Open_Panel = new System.Windows.Forms.PictureBox();
			this.Main_rull = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.picture_lamp_fr)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture_frequence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture_shum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_antenna)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.voltage_control_rull)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Lamp_II)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Lamp_I)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.frenquence_table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Volume_rull)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Corrector)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Open_Panel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Main_rull)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Open_cap
			// 
			this.Open_cap.BackColor = System.Drawing.Color.Transparent;
			this.Open_cap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Open_cap.Location = new System.Drawing.Point(1097, 232);
			this.Open_cap.Name = "Open_cap";
			this.Open_cap.Size = new System.Drawing.Size(30, 18);
			this.Open_cap.TabIndex = 24;
			this.Open_cap.Click += new System.EventHandler(this.Open_cap_Click);
			// 
			// open_frenquence_table
			// 
			this.open_frenquence_table.BackColor = System.Drawing.Color.Transparent;
			this.open_frenquence_table.Cursor = System.Windows.Forms.Cursors.Hand;
			this.open_frenquence_table.Location = new System.Drawing.Point(476, 304);
			this.open_frenquence_table.Name = "open_frenquence_table";
			this.open_frenquence_table.Size = new System.Drawing.Size(25, 28);
			this.open_frenquence_table.TabIndex = 32;
			this.open_frenquence_table.Click += new System.EventHandler(this.open_frenquence_table_Click);
			// 
			// frenquence_label
			// 
			this.frenquence_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.frenquence_label.Location = new System.Drawing.Point(508, 93);
			this.frenquence_label.Name = "frenquence_label";
			this.frenquence_label.Size = new System.Drawing.Size(157, 61);
			this.frenquence_label.TabIndex = 39;
			this.frenquence_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picture_lamp_fr
			// 
			this.picture_lamp_fr.Image = global::WindowsFormsApplication1.Properties.Resources.power;
			this.picture_lamp_fr.Location = new System.Drawing.Point(771, 119);
			this.picture_lamp_fr.Name = "picture_lamp_fr";
			this.picture_lamp_fr.Size = new System.Drawing.Size(50, 50);
			this.picture_lamp_fr.TabIndex = 40;
			this.picture_lamp_fr.TabStop = false;
			this.picture_lamp_fr.Visible = false;
			// 
			// Picture_frequence
			// 
			this.Picture_frequence.Image = global::WindowsFormsApplication1.Properties.Resources.frequency_rull;
			this.Picture_frequence.Location = new System.Drawing.Point(297, 283);
			this.Picture_frequence.Name = "Picture_frequence";
			this.Picture_frequence.Size = new System.Drawing.Size(105, 105);
			this.Picture_frequence.TabIndex = 38;
			this.Picture_frequence.TabStop = false;
			this.Picture_frequence.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Picture_frequence_MouseClick);
			// 
			// Picture_shum
			// 
			this.Picture_shum.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Picture_shum.Image = global::WindowsFormsApplication1.Properties.Resources.shum;
			this.Picture_shum.Location = new System.Drawing.Point(204, 117);
			this.Picture_shum.Name = "Picture_shum";
			this.Picture_shum.Size = new System.Drawing.Size(73, 73);
			this.Picture_shum.TabIndex = 37;
			this.Picture_shum.TabStop = false;
			this.Picture_shum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Picture_shum_MouseClick);
			// 
			// picture_antenna
			// 
			this.picture_antenna.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picture_antenna.Image = global::WindowsFormsApplication1.Properties.Resources.antenna;
			this.picture_antenna.Location = new System.Drawing.Point(758, 168);
			this.picture_antenna.Name = "picture_antenna";
			this.picture_antenna.Size = new System.Drawing.Size(194, 194);
			this.picture_antenna.TabIndex = 36;
			this.picture_antenna.TabStop = false;
			this.picture_antenna.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_antenna_MouseClick);
			// 
			// voltage_control_rull
			// 
			this.voltage_control_rull.Cursor = System.Windows.Forms.Cursors.Hand;
			this.voltage_control_rull.Image = global::WindowsFormsApplication1.Properties.Resources.voltage_control_rull;
			this.voltage_control_rull.Location = new System.Drawing.Point(124, 232);
			this.voltage_control_rull.Name = "voltage_control_rull";
			this.voltage_control_rull.Size = new System.Drawing.Size(122, 125);
			this.voltage_control_rull.TabIndex = 35;
			this.voltage_control_rull.TabStop = false;
			this.voltage_control_rull.MouseClick += new System.Windows.Forms.MouseEventHandler(this.voltage_control_rull_MouseClick);
			// 
			// picture_Lamp_II
			// 
			this.picture_Lamp_II.Image = global::WindowsFormsApplication1.Properties.Resources.Green_II;
			this.picture_Lamp_II.Location = new System.Drawing.Point(1138, 391);
			this.picture_Lamp_II.Name = "picture_Lamp_II";
			this.picture_Lamp_II.Size = new System.Drawing.Size(30, 30);
			this.picture_Lamp_II.TabIndex = 34;
			this.picture_Lamp_II.TabStop = false;
			this.picture_Lamp_II.Visible = false;
			// 
			// picture_Lamp_I
			// 
			this.picture_Lamp_I.Image = global::WindowsFormsApplication1.Properties.Resources.Green_I;
			this.picture_Lamp_I.Location = new System.Drawing.Point(1054, 393);
			this.picture_Lamp_I.Name = "picture_Lamp_I";
			this.picture_Lamp_I.Size = new System.Drawing.Size(30, 30);
			this.picture_Lamp_I.TabIndex = 33;
			this.picture_Lamp_I.TabStop = false;
			this.picture_Lamp_I.Visible = false;
			// 
			// frenquence_table
			// 
			this.frenquence_table.Image = global::WindowsFormsApplication1.Properties.Resources.frequency_table;
			this.frenquence_table.Location = new System.Drawing.Point(456, 232);
			this.frenquence_table.Name = "frenquence_table";
			this.frenquence_table.Size = new System.Drawing.Size(254, 254);
			this.frenquence_table.TabIndex = 31;
			this.frenquence_table.TabStop = false;
			this.frenquence_table.Visible = false;
			// 
			// Volume_rull
			// 
			this.Volume_rull.BackColor = System.Drawing.Color.Transparent;
			this.Volume_rull.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Volume_rull.Image = global::WindowsFormsApplication1.Properties.Resources.volume_rull;
			this.Volume_rull.Location = new System.Drawing.Point(1056, 432);
			this.Volume_rull.Name = "Volume_rull";
			this.Volume_rull.Size = new System.Drawing.Size(109, 108);
			this.Volume_rull.TabIndex = 30;
			this.Volume_rull.TabStop = false;
			this.Volume_rull.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Volume_rull_MouseDown);
			this.Volume_rull.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Volume_rull_MouseUp);
			// 
			// Corrector
			// 
			this.Corrector.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Corrector.Image = global::WindowsFormsApplication1.Properties.Resources.rull_2_1;
			this.Corrector.Location = new System.Drawing.Point(303, 104);
			this.Corrector.Name = "Corrector";
			this.Corrector.Size = new System.Drawing.Size(130, 128);
			this.Corrector.TabIndex = 29;
			this.Corrector.TabStop = false;
			this.Corrector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Corrector_MouseClick);
			// 
			// Right_Perek_4
			// 
			this.Right_Perek_4.BackColor = System.Drawing.Color.Transparent;
			this.Right_Perek_4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Right_Perek_4.Image = global::WindowsFormsApplication1.Properties.Resources.selector;
			this.Right_Perek_4.Location = new System.Drawing.Point(1154, 195);
			this.Right_Perek_4.Name = "Right_Perek_4";
			this.Right_Perek_4.Size = new System.Drawing.Size(32, 32);
			this.Right_Perek_4.TabIndex = 28;
			this.Right_Perek_4.Visible = false;
			this.Right_Perek_4.Click += new System.EventHandler(this.Right_Perek_4_CLick);
			// 
			// Right_Perek_3
			// 
			this.Right_Perek_3.BackColor = System.Drawing.Color.Transparent;
			this.Right_Perek_3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Right_Perek_3.Image = global::WindowsFormsApplication1.Properties.Resources.selector;
			this.Right_Perek_3.Location = new System.Drawing.Point(1114, 195);
			this.Right_Perek_3.Name = "Right_Perek_3";
			this.Right_Perek_3.Size = new System.Drawing.Size(32, 32);
			this.Right_Perek_3.TabIndex = 27;
			this.Right_Perek_3.Visible = false;
			this.Right_Perek_3.Click += new System.EventHandler(this.Right_Perek_3_CLick);
			// 
			// Right_Perek_2
			// 
			this.Right_Perek_2.BackColor = System.Drawing.Color.Transparent;
			this.Right_Perek_2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Right_Perek_2.Image = global::WindowsFormsApplication1.Properties.Resources.selector;
			this.Right_Perek_2.Location = new System.Drawing.Point(1074, 195);
			this.Right_Perek_2.Name = "Right_Perek_2";
			this.Right_Perek_2.Size = new System.Drawing.Size(32, 32);
			this.Right_Perek_2.TabIndex = 26;
			this.Right_Perek_2.Visible = false;
			this.Right_Perek_2.Click += new System.EventHandler(this.Right_Perek_2_CLick);
			// 
			// Right_Perek_1
			// 
			this.Right_Perek_1.BackColor = System.Drawing.Color.Transparent;
			this.Right_Perek_1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Right_Perek_1.Image = global::WindowsFormsApplication1.Properties.Resources.selector;
			this.Right_Perek_1.Location = new System.Drawing.Point(1036, 195);
			this.Right_Perek_1.Name = "Right_Perek_1";
			this.Right_Perek_1.Size = new System.Drawing.Size(32, 29);
			this.Right_Perek_1.TabIndex = 16;
			this.Right_Perek_1.Visible = false;
			this.Right_Perek_1.Click += new System.EventHandler(this.Right_Perek_1_CLick);
			// 
			// Open_Panel
			// 
			this.Open_Panel.BackColor = System.Drawing.Color.Transparent;
			this.Open_Panel.Image = global::WindowsFormsApplication1.Properties.Resources.Panel_1;
			this.Open_Panel.Location = new System.Drawing.Point(1008, 159);
			this.Open_Panel.Name = "Open_Panel";
			this.Open_Panel.Size = new System.Drawing.Size(205, 100);
			this.Open_Panel.TabIndex = 25;
			this.Open_Panel.TabStop = false;
			this.Open_Panel.Visible = false;
			// 
			// Main_rull
			// 
			this.Main_rull.BackColor = System.Drawing.Color.Transparent;
			this.Main_rull.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Main_rull.Image = global::WindowsFormsApplication1.Properties.Resources.rull_1;
			this.Main_rull.Location = new System.Drawing.Point(765, 382);
			this.Main_rull.Name = "Main_rull";
			this.Main_rull.Size = new System.Drawing.Size(223, 229);
			this.Main_rull.TabIndex = 9;
			this.Main_rull.TabStop = false;
			this.Main_rull.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_rull_MouseClick);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::WindowsFormsApplication1.Properties.Resources.Green_4;
			this.pictureBox5.Location = new System.Drawing.Point(1152, 104);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(34, 34);
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Visible = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.Green_3;
			this.pictureBox4.Location = new System.Drawing.Point(1112, 104);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(34, 34);
			this.pictureBox4.TabIndex = 7;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.Green_2;
			this.pictureBox3.Location = new System.Drawing.Point(1072, 105);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(34, 34);
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Green_1;
			this.pictureBox2.Location = new System.Drawing.Point(1029, 105);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 34);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.R_123M;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1280, 763);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// timer2
			// 
			this.timer2.Interval = 50;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 750);
			this.Controls.Add(this.picture_lamp_fr);
			this.Controls.Add(this.frenquence_label);
			this.Controls.Add(this.Picture_frequence);
			this.Controls.Add(this.Picture_shum);
			this.Controls.Add(this.picture_antenna);
			this.Controls.Add(this.voltage_control_rull);
			this.Controls.Add(this.picture_Lamp_II);
			this.Controls.Add(this.picture_Lamp_I);
			this.Controls.Add(this.open_frenquence_table);
			this.Controls.Add(this.frenquence_table);
			this.Controls.Add(this.Volume_rull);
			this.Controls.Add(this.Corrector);
			this.Controls.Add(this.Right_Perek_4);
			this.Controls.Add(this.Right_Perek_3);
			this.Controls.Add(this.Right_Perek_2);
			this.Controls.Add(this.Right_Perek_1);
			this.Controls.Add(this.Open_cap);
			this.Controls.Add(this.Open_Panel);
			this.Controls.Add(this.Main_rull);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picture_lamp_fr)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture_frequence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Picture_shum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_antenna)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.voltage_control_rull)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Lamp_II)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture_Lamp_I)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.frenquence_table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Volume_rull)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Corrector)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Open_Panel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Main_rull)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Main_rull;
        private System.Windows.Forms.Label Open_cap;
        private System.Windows.Forms.PictureBox Open_Panel;
        public System.Windows.Forms.Label Right_Perek_1;
		private System.Windows.Forms.PictureBox Corrector;
        public System.Windows.Forms.Label Right_Perek_2;
        public System.Windows.Forms.Label Right_Perek_3;
        public System.Windows.Forms.Label Right_Perek_4;
        private System.Windows.Forms.PictureBox Volume_rull;
        private System.Windows.Forms.PictureBox frenquence_table;
        private System.Windows.Forms.Label open_frenquence_table;
        private System.Windows.Forms.PictureBox picture_Lamp_I;
        private System.Windows.Forms.PictureBox picture_Lamp_II;
		private System.Windows.Forms.PictureBox voltage_control_rull;
		private System.Windows.Forms.PictureBox picture_antenna;
        private System.Windows.Forms.PictureBox Picture_shum;
        private System.Windows.Forms.PictureBox Picture_frequence;
        private System.Windows.Forms.Label frenquence_label;
        private System.Windows.Forms.PictureBox picture_lamp_fr;
		private System.Windows.Forms.Timer timer2;
	}
}

