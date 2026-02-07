using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musikKyr
{
    public partial class MusiCatalog : Form
    {
        private Action<string> retM;
        private string kir;

        public MusiCatalog(Action<string> ret)
        {
            InitializeComponent();
            retM = ret;
            LoadSong();
            listSong.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            listSong.ItemHeight = 30;
        }

        public MusiCatalog(string kir)
        {
            this.kir = kir;
        }

        private void MusiCatalog_Load(object sender, EventArgs e)
        {

        }
        private void LoadSong()
        {
            string musicSong = Path.Combine(Application.StartupPath, "Music");
            string[] mp3file = Directory.GetFiles(musicSong, "*.mp3");
            string[] wavfile = Directory.GetFiles(musicSong, "*.wav");
            string[] file = mp3file.Concat(wavfile).ToArray();
            foreach (string s in file)
            {
                listSong.Items.Add(Path.GetFileName(s));
            }
        }

        private void listSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSong.SelectedItem == null) return;

            string fileName = listSong.SelectedItem.ToString();
            string chlax = Path.Combine(Application.StartupPath, "Music", fileName);
            if (!File.Exists(chlax))
            {
                MessageBox.Show("файл не знайдено" + chlax);
                return;
            }
            retM(chlax);
            //Form1 p = new Form1();
            //p.Show();
            //this.Hide();
            this.Close();

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

        private void nazad_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
