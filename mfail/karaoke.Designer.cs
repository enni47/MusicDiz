namespace musikKyr
{
    partial class karaoke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(karaoke));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            shrift = new Button();
            music_katalog = new Button();
            instruction = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            start = new Button();
            trackBar1 = new TrackBar();
            panel2 = new Panel();
            nazad = new Button();
            stop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pouza = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 123);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(1354, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(73, 68);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // shrift
            // 
            shrift.BackColor = Color.Transparent;
            shrift.BackgroundImage = (Image)resources.GetObject("shrift.BackgroundImage");
            shrift.BackgroundImageLayout = ImageLayout.Stretch;
            shrift.FlatStyle = FlatStyle.Popup;
            shrift.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shrift.Location = new Point(721, 33);
            shrift.Name = "shrift";
            shrift.Size = new Size(209, 66);
            shrift.TabIndex = 9;
            shrift.Text = "Шрифт";
            shrift.UseVisualStyleBackColor = false;
            shrift.Click += shrift_Click;
            // 
            // music_katalog
            // 
            music_katalog.BackColor = Color.Transparent;
            music_katalog.BackgroundImage = (Image)resources.GetObject("music_katalog.BackgroundImage");
            music_katalog.BackgroundImageLayout = ImageLayout.Stretch;
            music_katalog.FlatStyle = FlatStyle.Popup;
            music_katalog.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            music_katalog.Location = new Point(438, 33);
            music_katalog.Name = "music_katalog";
            music_katalog.Size = new Size(244, 66);
            music_katalog.TabIndex = 10;
            music_katalog.Text = "Музичний каталог";
            music_katalog.UseVisualStyleBackColor = false;
            // 
            // instruction
            // 
            instruction.BackColor = Color.Transparent;
            instruction.BackgroundImage = (Image)resources.GetObject("instruction.BackgroundImage");
            instruction.BackgroundImageLayout = ImageLayout.Stretch;
            instruction.FlatStyle = FlatStyle.Popup;
            instruction.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instruction.Location = new Point(191, 33);
            instruction.Name = "instruction";
            instruction.Size = new Size(209, 66);
            instruction.TabIndex = 11;
            instruction.Text = "Інструкція";
            instruction.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(instruction);
            panel1.Controls.Add(music_katalog);
            panel1.Controls.Add(shrift);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1457, 153);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(329, 470);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 54);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1087, 470);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 54);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // start
            // 
            start.BackColor = Color.Transparent;
            start.BackgroundImage = (Image)resources.GetObject("start.BackgroundImage");
            start.BackgroundImageLayout = ImageLayout.Stretch;
            start.FlatStyle = FlatStyle.Popup;
            start.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            start.Location = new Point(890, 701);
            start.Name = "start";
            start.Size = new Size(235, 68);
            start.TabIndex = 8;
            start.Text = "Старт";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(342, 265);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(783, 56);
            trackBar1.TabIndex = 10;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // panel2
            // 
            panel2.Location = new Point(416, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 299);
            panel2.TabIndex = 11;
            panel2.Paint += panel2_Paint;
            // 
            // nazad
            // 
            nazad.BackColor = Color.Transparent;
            nazad.BackgroundImage = (Image)resources.GetObject("nazad.BackgroundImage");
            nazad.BackgroundImageLayout = ImageLayout.Stretch;
            nazad.FlatStyle = FlatStyle.Popup;
            nazad.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nazad.Location = new Point(329, 174);
            nazad.Name = "nazad";
            nazad.Size = new Size(235, 68);
            nazad.TabIndex = 12;
            nazad.Text = "Назад";
            nazad.UseVisualStyleBackColor = false;
            nazad.Click += nazad_Click;
            // 
            // stop
            // 
            stop.BackColor = Color.Transparent;
            stop.BackgroundImage = (Image)resources.GetObject("stop.BackgroundImage");
            stop.BackgroundImageLayout = ImageLayout.Stretch;
            stop.FlatStyle = FlatStyle.Popup;
            stop.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stop.Location = new Point(342, 701);
            stop.Name = "stop";
            stop.Size = new Size(235, 68);
            stop.TabIndex = 13;
            stop.Text = "Стоп";
            stop.UseVisualStyleBackColor = false;
            stop.Click += stop_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pouza
            // 
            pouza.BackColor = Color.Transparent;
            pouza.BackgroundImage = (Image)resources.GetObject("pouza.BackgroundImage");
            pouza.BackgroundImageLayout = ImageLayout.Stretch;
            pouza.FlatStyle = FlatStyle.Popup;
            pouza.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pouza.Location = new Point(612, 701);
            pouza.Name = "pouza";
            pouza.Size = new Size(235, 68);
            pouza.TabIndex = 14;
            pouza.Text = "Пауза";
            pouza.UseVisualStyleBackColor = false;
            pouza.Click += pouza_Click;
            // 
            // karaoke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1457, 843);
            Controls.Add(pouza);
            Controls.Add(stop);
            Controls.Add(nazad);
            Controls.Add(panel2);
            Controls.Add(trackBar1);
            Controls.Add(start);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "karaoke";
            Text = "karaoke";
            Load += karaoke_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button shrift;
        private Button music_katalog;
        private Button instruction;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Button start;
        private TrackBar trackBar1;
        private Panel panel2;
        private Button nazad;
        private Button stop;
        private System.Windows.Forms.Timer timer1;
        private Button pouza;
    }
}