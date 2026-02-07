using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using TagLib;





namespace musikKyr
{

    public partial class karaoke : Form
    {
        private WaveOutEvent wive;
        private AudioFileReader audiofile;
        private System.Windows.Forms.Timer timers;
        private List<string> poradocs = new List<string>();
        private int chotchics = 0;
        private string audios;
        private WaveOutEvent wives;
        private AudioFileReader audiofiles;
        private Label labTop;
        private Label labSer;
        private Label labBottom;


        private System.Windows.Forms.Timer timer;

        private List<string> poradoc = new List<string> {
            "Темно в кімнаті",
            "Гасне світло у сусідському вікні",
            "Хочеться кричати",
            " ",
            "Давно терпець урвався вже мені",
            "",
            "Чужий серед своїх",
            "",
            "А люди йдуть, сліди лишаючи в душі",
            "",
            "Лабіринтом ходжу",
            "",
            "Як би до тебе трохи ближче підійти","",
            "Я відчуваю, та ти не бачиш","",
            "Я довіряю, ти не цінуєш","",
            "Волію знати, та ти не скажеш","",
            "Хочеться вірити  ти обдуриш","",
            "Я утомився, втомили люди","",
            "Ідуть повз тебе немов ти привид","",
            "Я вигоратиму наче свічка ","",
            "Твоє світило в пітьмі суцільній","",
            "Снігом покриє","",
            "Усі проступки, що даремно ти вчинив","",
            "Та рано чи пізно","",
            "Мине цей біль, цей біль","",
            "Я відчуваю, та ти не бачиш","",
            "Я довіряю, ти не цінуєш","",
            "Волію знати, та ти не скажеш","",
            "Хочеться вірити  ти обдуриш","",
            "Я утомився, втомили люди","",
            "Ідуть повз тебе немов ти привид","",
            "Я вигоратиму наче свічка ","",
            "Твоє світило в пітьмі суцільній","",
            "Між людьми як між вовками","",
            "Ми їх зростили своїми ж руками","",
            "Краще нікого ніж ворога мати","",
            "Найбижча людина готова продати"

        };
        private int chotchic = 0;

        
        private string audio; //покашо отмена

        private List<string> GetPoradoc(string fileChotchic)
        {
            try
            {
                var file = TagLib.File.Create(fileChotchic);
                string porad = file.Tag.Lyrics;
                if (string.IsNullOrEmpty(porad))
                {
                    return new List<string> { "текст пісні не знайдено" };

                }
                return porad.Split(new[] { 'r', 'n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            catch (Exception ex)
            {
                return new List<string> { $"Помилка при зчитуванні тексту: {ex.Message}" };
            }
        }
        public karaoke(string audio_per)  // покашо отмена
        {
            InitializeComponent();
            audio = audio_per; //покашо отмена
            trackBar1.Minimum = 0;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.MouseUp += TrackBar1_MouseUp; ;
        }

        private void TrackBar1_MouseUp(object? sender, MouseEventArgs e)
        {
            if (audiofile != null)
            {
                TimeSpan newTime = TimeSpan.FromSeconds(trackBar1.Value);
                audiofile.CurrentTime = newTime;
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void start_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(audio))
            {
                wive = new WaveOutEvent();
                audiofile = new AudioFileReader(audio);

                chotchic = 0;
               
                // 🔹 Запускаємо музику
                wive.Init(audiofile);
                wive.Play();

                trackBar1.Maximum = (int)audiofile.TotalTime.TotalSeconds;
                RobotaText();
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 5000; // перевіряємо кожну секунду
                timer.Tick += timer1_Tick;
                timer.Start();
            }
            else
            {
                MessageBox.Show("шлях до файлу не знайдений. для початку підвантаж файл");
            }
        }


        //private async void start_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(audio))
        //    {
        //        wive = new WaveOutEvent();
        //        audiofile = new AudioFileReader(audio);

        //        // 🔹 Викликаємо конвертацію одразу при старті
        //        panel2.Text = " Обробка. З'єднання з OpenAI...";
        //        try
        //        {
        //            string resultText = await ConvertAudioToText(audio);

        //            // Розбиваємо результат на рядки і зберігаємо у poradoc
        //            poradoc = resultText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        //            chotchic = 0;

        //            // Відображаємо перші три рядки у методі RobotaText()
        //            RobotaText();
        //        }
        //        catch (Exception ex)
        //        {
        //            panel2.Text = $" КРИТИЧНА ПОМИЛКА: {ex.Message}";
        //            MessageBox.Show($"Критична помилка: {ex.Message}");
        //        }

        //        // 🔹 Запускаємо музику
        //        wive.Init(audiofile);
        //        wive.Play();

        //        trackBar1.Maximum = (int)audiofile.TotalTime.TotalSeconds;
        //        timer = new System.Windows.Forms.Timer();
        //        timer.Interval = 3000;
        //        timer.Tick += timer1_Tick;
        //        timer.Start();
        //    }
        //    else
        //    {
        //        MessageBox.Show("шлях до файлу не знайдений. для початку підвантаж файл");
        //    }
        //}


        private void RobotaText()
        {
            panel2.Controls.Clear();
            labTop = new Label();
            labSer = new Label();
            labBottom = new Label();
            labTop.Text = chotchic >= 1 ? poradoc[chotchic - 1] : "";
            //labSer.Text = poradoc[chotchic];
            labSer.Text = chotchic < poradoc.Count ? poradoc[chotchic] : "";
            labBottom.Text = (chotchic + 1 < poradoc.Count) ? poradoc[chotchic + 1] : "";

            labTop.Font = new Font("Segoe UI", 13, FontStyle.Bold); //стиль текста
            labSer.Font = new Font("Segoe UI", 17, FontStyle.Bold);
            labBottom.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            labTop.ForeColor = Color.Black; //кольор тексту
            labSer.ForeColor = Color.Black;
            labBottom.ForeColor = Color.Black;

            labTop.AutoSize = true; //авто відступи між рядками
            labSer.AutoSize = true;
            labBottom.AutoSize = true;

            labTop.Location = new Point(60, 55);
            labSer.Location = new Point(55, 113);
            labBottom.Location = new Point(60, 189);

            panel2.Controls.Add(labTop); //додаємо на панель
            panel2.Controls.Add(labSer);
            panel2.Controls.Add(labBottom);

            // Початкове заповнення
            if (poradoc.Count > 0) labSer.Text = poradoc[chotchic++];
            if (poradoc.Count > 1) labBottom.Text = poradoc[chotchic++];
            //// Верхній отримує текст середнього
            //labTop.Text = labSer.Text;

            //// Середній отримує текст нижнього
            //labSer.Text = labBottom.Text;

            //// Нижній отримує новий рядок зі списку
            //if (chotchic < poradoc.Count)
            //{
            //    labBottom.Text = poradoc[chotchic++];
            //}
            //else
            //{
            //    labBottom.Text = "";
            //}


        }

        private void UpdateLyrics()
        {
            // Верхній отримує текст середнього
            labTop.Text = labSer.Text;

            // Середній отримує текст нижнього
            labSer.Text = labBottom.Text;

            // Нижній отримує новий рядок зі списку
            if (chotchic < poradoc.Count)
            {
                labBottom.Text = poradoc[chotchic++];
            }
            else
            {
                labBottom.Text = "";
            }
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            Form1 ver = new Form1();
            ver.Show();
            this.Hide();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
            wive.Stop();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (audiofile != null)
        //    {
        //        int seconds = (int)audiofile.CurrentTime.TotalSeconds;

        //        if (seconds >= trackBar1.Minimum && seconds <= trackBar1.Maximum)
        //        {
        //            trackBar1.Value = seconds;
        //        }
        //        //  Починаємо показ тексту тільки після 20 секунд
        //        if (seconds >= 20)
        //        {
        //            // Кожні 5 секунд переходимо до наступного рядка
        //            if ((seconds - 20) % 5 == 0 && chotchic < poradoc.Count)
        //            {
        //                RobotaText();
        //                chotchic++;
        //            }
        //        }
        //        //if (chotchic < poradoc.Count - 1)
        //        //{
        //        //    chotchic++;
        //        //    RobotaText();
        //        //}

        //        if (wive.PlaybackState == PlaybackState.Stopped)
        //        {
        //            timer.Stop();
        //        }
        //    }

        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audiofile != null)
            {
                int seconds = (int)audiofile.CurrentTime.TotalSeconds;
                

                if (seconds >= trackBar1.Minimum && seconds <= trackBar1.Maximum)
                {
                    trackBar1.Value = seconds;
                }

                // 🔹 Починаємо показ тексту тільки після 20 секунд
                if (seconds >= 20)
                {
                    // Кожні 5 секунд після 20-ї показуємо новий рядок
                    if ((seconds - 20) % 5 == 0 && chotchic < poradoc.Count)
                    {
                        UpdateLyrics();
                        //RobotaText();
                        chotchic++;
                    }
                }

                if (wive.PlaybackState == PlaybackState.Stopped)
                {
                    timer.Stop();
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool p = false;
        private void pouza_Click(object sender, EventArgs e)
        {
            if (wive == null) return;
            if (!p)
            {
                wive.Pause();
                p = true;
                pouza.Text = "Продовжити";
            }
            else
            {
                wive.Play();
                p = false;
                pouza.Text = "Пауза";
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (timer != null)
            {
                timer.Stop();
                timer.Tick -= timer1_Tick;
                timer.Dispose();
                timer = null;
            }

            if (wive != null)
            {
                wive.Stop();
                wive.Dispose();
                wive = null;
            }

            if (audiofile != null)
            {
                audiofile.Dispose();
                audiofile = null;
            }
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
            if (newControl is RichTextBox || newControl is ListBox || newControl is System.Windows.Forms.TextBox)
            {
                newControl.Font = newFont;
            }

            // Рекурсивно перевіряємо дочірні елементи
            foreach (Control c in newControl.Controls)
            {
                perevirka(c, newFont);
            }
        }
        // private void UpdateLyrics()
        //{
        //    // Верхній отримує текст середнього
        //    labTop.Text = labSer.Text;

        //    // Середній отримує текст нижнього
        //    labSer.Text = labBottom.Text;

        //    // Нижній отримує новий рядок зі списку
        //    if (chotchic < poradoc.Count)
        //    {
        //        labBottom.Text = poradoc[chotchic++];
        //    }
        //    else
        //    {
        //        labBottom.Text = "";
        //    }
        //}
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {

        }

        private void karaoke_Load(object sender, EventArgs e)
        {

        }
        //private async void btnStartConvert_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(Form1.musikP))
        //    {
        //        MessageBox.Show("Немає вибраного аудіофайлу!");
        //        return;
        //    }

        //    panel2.Text = " Обробка. З'єднання з OpenAI...";

        //    try
        //    {
        //        // Викликаємо асинхронний метод конвертації
        //        string resultText = await ConvertAudioToText(Form1.musikP);

        //        // Виводимо результат у richTextBox1
        //        panel2.Text = resultText;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Ловимо критичні помилки
        //        panel2.Text = $" КРИТИЧНА ПОМИЛКА: Не вдалося встановити з'єднання з API. {ex.Message}";
        //        MessageBox.Show($"Критична помилка з'єднання: {ex.Message}");
        //    }
        //}

        //// 🔹 Асинхронний метод для конвертації аудіо у текст
        //private async Task<string> ConvertAudioToText(string audioPath)
        //{
        //    string apiKey = "";
        //    string url = "https://api.openai.com/v1/audio/transcriptions";

        //    if (string.IsNullOrWhiteSpace(apiKey) || apiKey.Length < 10)
        //    {
        //        return "Помилка: Вставте ваш API ключ OpenAI.";
        //    }

        //    if (!System.IO.File.Exists(audioPath))
        //    {
        //        return "Помилка: Аудіофайл не знайдено за шляхом: " + audioPath;
        //    }

        //    try
        //    {
        //        var fileBytes = System.IO.File.ReadAllBytes(audioPath);
        //        return $" Файл успішно прочитано. Розмір: {fileBytes.Length} байт. API-запит ВІДКЛЮЧЕНО.";
        //    }
        //    catch (Exception ex)
        //    {
        //        return $" КРИТИЧНА ПОМИЛКА ЧИТАННЯ ФАЙЛУ: {ex.Message}";
        //    }
        //}
    }
}
