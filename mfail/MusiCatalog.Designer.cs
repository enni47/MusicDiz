namespace musikKyr
{
    partial class MusiCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusiCatalog));
            panel1 = new Panel();
            instruction = new Button();
            music_katalog = new Button();
            shrift = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            nazad = new Button();
            listSong = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 4;
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
            // nazad
            // 
            nazad.BackColor = Color.Transparent;
            nazad.BackgroundImage = (Image)resources.GetObject("nazad.BackgroundImage");
            nazad.BackgroundImageLayout = ImageLayout.Stretch;
            nazad.FlatStyle = FlatStyle.Popup;
            nazad.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nazad.Location = new Point(259, 176);
            nazad.Name = "nazad";
            nazad.Size = new Size(235, 68);
            nazad.TabIndex = 14;
            nazad.Text = "Назад";
            nazad.UseVisualStyleBackColor = false;
            nazad.Click += nazad_Click;
            // 
            // listSong
            // 
            listSong.BackColor = Color.MediumPurple;
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(259, 330);
            listSong.Name = "listSong";
            listSong.Size = new Size(939, 484);
            listSong.TabIndex = 15;
            listSong.SelectedIndexChanged += listSong_SelectedIndexChanged;
            // 
            // MusiCatalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1457, 843);
            Controls.Add(listSong);
            Controls.Add(nazad);
            Controls.Add(panel1);
            Name = "MusiCatalog";
            Text = "MusiCatalog";
            Load += MusiCatalog_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button instruction;
        private Button music_katalog;
        private Button shrift;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button nazad;
        private ListBox listSong;
    }
}