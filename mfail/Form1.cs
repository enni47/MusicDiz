using System;
using System.Windows.Forms;
//using System.Speech.Recognition; // Для розпізнавання мови
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json; // Додаємо цей простір імен для легкого парсингу JSON той код з Whisper.net Він потужний, але вимагає, щоб ви завантажили величезну модель AI і правильно налаштували шляхи до неї а для курсової простіше використовувати хмарний API. 

namespace musikKyr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void music_katalog_Click(object sender, EventArgs e)
        {
            MusiCatalog catalog = new MusiCatalog(mCatalog);
            catalog.FormClosed += (s, args) => this.Show();
            catalog.Show();
            this.Hide();
        }
        private void mCatalog(string p)
        {
            musikP = p;
            vxid_music.Text = p;
        }

        private void instruction_Click(object sender, EventArgs e)
        {
             Informaishon i = new Informaishon();
            i.Show();
            this.Hide();
        }

        private void shrift_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                perevirka(this, fd.Font);
            }
        }
        private void perevirka(Control newControl, Font newFont)
        {
            if (newControl is RichTextBox || newControl is ListBox || newControl is TextBox)
            {
                newControl.Font = newFont;
            }

            // Рекурсивно перевіряємо дочірні елементи
            foreach (Control c in newControl.Controls)
            {
                perevirka(c, newFont);
            }
        }
//Konvert kon = new Konvert();//musikP
            //kon.FormClosed += (s, args) => this.Show();
            //kon.Show();
            //this.Hide();
            //string filePath = vxid_music.Text;
            //if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            //{
            //    MessageBox.Show("Будь ласка, виберіть файл для конвертації.");
            //    return;
            //}
            //kon.FormClosed += (s, args) => this.Show();
        private void konvertuvati_Click(object sender, EventArgs e)
        {
            
            Konvert kon = new Konvert(vxid_music.Text);
            
            kon.Show();
            this.Hide();
        }

        private void karaoke_Click(object sender, EventArgs e)
        {
            karaoke zm = new karaoke(vxid_music.Text);  //  покашо отмена
            zm.Show();
            this.Hide();

        }
        public static string musikP = "";
        private void download_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio files|*.mp3;*.wav;*.ogg;*.flac;*.aac;*.m4a|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                musikP = ofd.FileName;
                vxid_music.Text = musikP;
            }
        }
        

        private void vxid_music_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
