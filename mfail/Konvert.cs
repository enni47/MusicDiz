//using OpenAI;
//using OpenAI.Audio;
//using OpenAI.Chat;
//using System;
//using System.Diagnostics;
//using System.Drawing;
//using System.IO;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using OpenAI;
//using OpenAI.Audio;
//using System;
//using System.IO;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Whisper.net;
using System;
using System.IO;
using System.Net.Http.Headers;
//using System.Speech.Recognition;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;



namespace musikKyr
{
    public partial class Konvert : Form
    {
      



        private string filePath;

        public Konvert(string filePath)
        {
            InitializeComponent();     
            this.filePath = filePath;
            
        }

        private void Konvert_Load(object sender, EventArgs e)
        {
            
           
            TextR();
        }
        private void TextR()
        { 
            richTextBox1.ReadOnly = true;
            richTextBox1.Clear();
            richTextBox1.Font = new Font("Times New Roman",13, FontStyle.Bold);
            String text = "Темно в кімнаті\r\nГасне світло у сусідському вікні\r\nХочеться кричати\r\nДавно терпець урвався вже мені\r\nЧужий серед своїх\r\nА люди йдуть, сліди лишаючи в душі\r\nЛабіринтом ходжу\r\nЯк би до тебе трохи ближче підійти\r\nЯ відчуваю, та ти не бачиш\r\nЯ довіряю, ти не цінуєш\r\nВолію знати, та ти не скажеш\r\nХочеться вірити - ти обдуриш\r\nЯ утомився, втомили люди\r\nІдуть повз тебе немов ти привид\r\nЯ вигоратиму наче свічка –\r\nТвоє світило в пітьмі суцільній\r\nСнігом покриє\r\nУсі проступки, що даремно ти вчинив\r\nТа рано чи пізно\r\nМине цей біль, цей біль\r\nЯ відчуваю, та ти не бачиш\r\nЯ довіряю, ти не цінуєш\r\nВолію знати, та ти не скажеш\r\nХочеться вірити - ти обдуриш\r\nЯ утомився, втомили люди\r\nІдуть повз тебе немов ти привид\r\nЯ вигоратиму наче свічка –\r\nТвоє світило в пітьмі суцільній\r\nМіж людьми як між вовками\r\nМи їх зростили своїми ж руками\r\nКраще нікого ніж ворога мати\r\nНайбижча людина готова продати";     
            richTextBox1.WordWrap = true;
            richTextBox1.AppendText (text);
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.DeselectAll();

        }



        private async void btnStartConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Form1.musikP))
            {
                MessageBox.Show("Немає вибраного аудіофайлу!");
                return;
            }

            richTextBox1.Text = " Обробка. З'єднання з OpenAI...";

            try
            {
                // Ось тут ми чекаємо на результат від асинхронної функції
                string resultText = await ConvertAudioToText(Form1.musikP);

                // Якщо помилки немає, виводимо текст (або повідомлення про помилку API)
                richTextBox1.Text = resultText;
            }
            catch (Exception ex)
            {
                // ЦЕЙ БЛОК ЛОВИТЬ КРИТИЧНІ ПОМИЛКИ МЕРЕЖІ (HttpRequestException)
                
                richTextBox1.Text = $" КРИТИЧНА ПОМИЛКА: Не вдалося встановити з'єднання з API. {ex.Message}";
                MessageBox.Show($"Критична помилка з'єднання: {ex.Message}");
            }
        }


        private async Task<string> ConvertAudioToText(string audioPath)
        {
            // ... ваш код для apiKey та url
            // ... ваша перевірка if (string.IsNullOrWhiteSpace(apiKey))

            string apiKey = "";
            string url = "https://api.openai.com/v1/audio/transcriptions";

            if (string.IsNullOrWhiteSpace(apiKey) || apiKey.Length < 10)
            {
                return "Помилка: Вставте ваш API ключ OpenAI."; // Повернути просто текст
            }

            if (!File.Exists(audioPath))
            {
                return "Помилка: Аудіофайл не знайдено за шляхом: " + audioPath;
            }

            // ВІДКЛЮЧАЄМО МЕРЕЖУ. Просто перевіряємо, чи можна прочитати файл.
            try
            {
                // Спробуйте прочитати файл. Якщо він завеликий, тут буде помилка.
                var fileBytes = File.ReadAllBytes(audioPath);

                // Якщо файл прочитався успішно, виводимо його розмір,
                // інакше виникає OutOfMemoryException.
                return $" Файл успішно прочитано. Розмір: {fileBytes.Length} байт. API-запит ВІДКЮЧЕНО.";
            }
            catch (Exception ex)
            {
                // Якщо тут виникла помилка, це точно проблема з доступом або розміром файлу.
                return $" КРИТИЧНА ПОМИЛКА ЧИТАННЯ ФАЙЛУ: {ex.Message}";
            }



        } 
        



        
       

        private void nazad_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            MessageBox.Show("Текст скопійовано!");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}



 //ConvertAudioToText(filePath);
            //DDDAsync();



            //string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

            //if (string.IsNullOrEmpty(apiKey))
            //{
            //    MessageBox.Show("❌ Встанови змінну середовища OPENAI_API_KEY!");
            //    return;
            //}

            //client = new OpenAIClient(apiKey);




            //loadedPath = musicPath;
            //LoadLyricsFromAudio(musicPath);
        
        
        
        
        //private void ConvertAudioToText(string filePath)
        //{
        //    try
        //    {
        //        // Створення об'єкта для розпізнавання мови
        //        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();

        //        // Потрібно налаштувати файл аудіо
        //        recognizer.SetInputToWaveFile(filePath);

        //        // Виконання розпізнавання
        //        RecognitionResult result = recognizer.Recognize();

        //        // Виведення результату в RichTextBox
        //        richTextBox1.Text = result.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Сталася помилка при конвертації: " + ex.Message);
        //    }
        //}
        // Додаємо цей простір імен для легкого парсингу JSON той код з Whisper.net Він потужний, але вимагає, щоб ви завантажили величезну модель AI і правильно налаштували шляхи до неї а для курсової простіше використовувати хмарний API. 

        // ...

        //private async Task<string> ConvertAudioToText(string audioPath)
        //{

        //    string apiKey = "";
        //    string url = "https://api.openai.com/v1/audio/transcriptions";

        //    if (string.IsNullOrWhiteSpace(apiKey) || apiKey.Length < 10)
        //    {
        //       return "Помилка: Вставте ваш API ключ OpenAI."; // Повернути просто текст
        //    }

        //    if (!File.Exists(audioPath))
        //    {
        //        return "Помилка: Аудіофайл не знайдено за шляхом: " + audioPath;
        //    }

        //    try
        //    {
        //        using (var http = new HttpClient())
        //        {
        //            // Налаштування заголовка авторизації
        //            http.DefaultRequestHeaders.Authorization =
        //                 new AuthenticationHeaderValue("Bearer", apiKey); 

        //    using (var content = new MultipartFormDataContent())
        //            {
        //                // Підготовка аудіофайлу до відправки
        //                var fileBytes = File.ReadAllBytes(audioPath);
        //        var byteContent = new ByteArrayContent(fileBytes); 

        //        // уВаЖНо перевір, чи MediaType "audio/mpeg" підходить для файлу (я прилад MP3).Якщо  WAV, може знадобитися "audio/wav".
        //         byteContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg"); 

        //        // Додавання файлу та моделі до контенту запиту
        //         content.Add(byteContent, "file", Path.GetFileName(audioPath)); 
        //         content.Add(new StringContent("whisper-1"), "model"); 

        //        // Надсилання запиту
        //         var response = await http.PostAsync(url, content); 
        //        var resultJson = await response.Content.ReadAsStringAsync(); 

        //        // КРОК 2: Обробка відповіді та парсинг JSON
        //        if (response.IsSuccessStatusCode)
        //                {
        //                    // Успішний запит, парсимо JSON, щоб витягнути лише текст
        //                    using (JsonDocument document = JsonDocument.Parse(resultJson))
        //                    {
        //                        var root = document.RootElement;
        //                        // Whisper повертає розпізнаний текст у полі "text"
        //                        if (root.TryGetProperty("text", out JsonElement textElement))
        //                        {
        //                            return textElement.GetString();
        //                        }
        //                        return "Отримано несподівану відповідь від API. Не знайдено поле 'text'.";
        //                    }
        //                }
        //                else
        //                {
        //                    // Помилка API (наприклад, 401 Unauthorized або 429 Quota Exceeded)
        //                    return $"Помилка HTTP {response.StatusCode}. Відповідь: {resultJson}";
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return $" Невідома помилка при відправці запиту: {ex.Message}";
        //    }
        //}









        //private async void btnStartConvert_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(Form1.musikP))
        //    {
        //        MessageBox.Show("Немає вибраного аудіофайлу!");
        //        return;
        //    }

        //    string text = await ConvertAudioToText(Form1.musikP);
        //    richTextBox1.Text = text;
        //}

        //private async Task<string> ConvertAudioToText(string audioPath)
        //{
        //    string apiKey = "YOUR_OPENAI_API_KEY"; // 🔥 ВСТАВИТИ СВІЙ КЛЮЧ
        //    string url = "https://api.openai.com/v1/audio/transcriptions";

        //    using (var http = new HttpClient())
        //    {
        //        http.DefaultRequestHeaders.Authorization =
        //            new AuthenticationHeaderValue("Bearer", apiKey);

        //        var content = new MultipartFormDataContent();

        //        var fileBytes = File.ReadAllBytes(audioPath);
        //        var byteContent = new ByteArrayContent(fileBytes);
        //        byteContent.Headers.ContentType = MediaTypeHeaderValue.Parse("audio/mpeg");

        //        content.Add(byteContent, "file", Path.GetFileName(audioPath));
        //        content.Add(new StringContent("whisper-1"), "model");

        //        var response = await http.PostAsync(url, content);
        //        var result = await response.Content.ReadAsStringAsync();

        //        return result;
        //    }
        //}








//private async Task DDDAsync()
        //{
        //    try
        //    {
        //        // Отримуємо шлях до аудіофайлу з текстового поля
        //        string audioPath = richTextBox1.Text.Trim();

        //        if (string.IsNullOrWhiteSpace(audioPath) || !File.Exists(audioPath))
        //        {
        //            MessageBox.Show("Файл не знайдено. Перевірте шлях.");
        //            return;
        //        }

        //        // Ініціалізація WhisperFactory з правильним шляхом до моделі
        //        var whisperFactory = WhisperFactory.FromPath("Models/ggml-base.bin");

        //        // Створення процесора через фабрику
        //        var whisperProcessor = whisperFactory.CreateProcessor();

        //        // Відкриваємо аудіофайл
        //        using (FileStream fs = File.OpenRead(audioPath))
        //        {
        //            // Виконуємо транскрипцію асинхронно
        //            var result = await Task.Run(() => whisperProcessor.Process(fs));

        //            // Виводимо результат у RichTextBox
        //            richTextBox1.Text = result.Text;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Помилка при конвертації: " + ex.Message);
        //    }
        //}

        //private async Task DDDAsync()
        //{
        //    try
        //    {
        //        // Шлях до аудіо, який ти передаєш з форми 1
        //        string audioFilePath = (string)lblAudioPath; // або твій спосіб передачі

        //        if (!File.Exists(audioFilePath))
        //        {
        //            MessageBox.Show("Файл не знайдено!");
        //            return;
        //        }

        //        richTextBox1.Text = "Обробка аудіо... Зачекайте...";

        //        // 1. Створюємо Whisper клієнт
        //        AudioClient client = new AudioClient("whisper-1", apiKey);

        //        // 2. Опції (може повертати слова, сегменти, часи)
        //        AudioTranscriptionOptions options = new()
        //        {
        //            ResponseFormat = AudioTranscriptionFormat.Text
        //        };

        //        // 3. Отримуємо транскрипцію
        //        AudioTranscription transcription =
        //            await client.TranscribeAudioAsync(audioFilePath, options);

        //        // 4. Виводимо текст у richTextBox
        //        richTextBox1.Text = transcription.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Помилка: " + ex.Message);
        //    }
        //}

        //private async void btnStartConvert_Click(object sender, EventArgs e)
        //{
        //    if (!File.Exists(audioPath))
        //    {
        //        MessageBox.Show("Файл не знайдено!");
        //        return;
        //    }

        //    richTextBox1.Text = "⏳ Конвертація... Зачекайте...";

        //    string text = await ConvertAudioWhisper(audioPath);

        //    richTextBox1.Text = text;
        //}

        //private async Task<string> ConvertAudioWhisper(string audioPath)
        //{
        //    throw new NotImplementedException();
        //}

        //private async Task<string> ConvertWithGetAudioClient(string file)
        //{
        //    string apiKey = Environment.GetEnvironmentVariable("");
        //    var client = new OpenAIClient(apiKey);

        //    // створюємо AudioClient для whisper-1
        //    var audioClient = client.GetAudioClient("whisper-1");

        //    using var fs = File.OpenRead(file);
        //    // метод назви у різних версіях може бути TranscribeAudio або CreateTranscriptionAsync
        //    var transcription = await audioClient.TranscribeAudioAsync(file, new AudioTranscriptionOptions
        //    {
        //        // опції за бажанням
        //    });

        //    return transcription.Text;
        //}




        //private async Task<string> ConvertAudioWhisper(string file)
        //{
        //    try
        //    {
        //        // Читай ключ із змінної середовища (налаштуй перед запуском)
        //        // setx OPENAI_API_KEY your_key_here
        //        string apiKey = Environment.GetEnvironmentVariable("");
        //        if (string.IsNullOrEmpty(apiKey))
        //            return "❌ Помилка: API ключ відсутній. Додайте OPENAI_API_KEY у змінні середовища.";

        //        var client = new OpenAIClient(apiKey);

        //        using var fs = File.OpenRead(file);
        //        var response = await client.Audio.Transcriptions.CreateTranscriptionAsync(
        //            file: fs,
        //            fileName: Path.GetFileName(file),
        //            model: "whisper-1" // стабільна модель для аудіотранскрипції
        //        );

        //        return string.IsNullOrWhiteSpace(response.Text)
        //            ? "⚠️ Порожній результат. Спробуйте інший файл або конвертуйте у WAV 16 kHz mono."
        //            : response.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        return "❌ Помилка: " + ex.Message;
        //    }
        //}



        // 🔹 Основна функція: розпізнавання тексту з аудіофайлу
        //private async void LoadLyricsFromAudio(string audioPath)
        //{
        //    richTextBox1.Text = "🎧 Обробка аудіо…";

        //    string wavPath = Path.ChangeExtension(audioPath, ".wav");

        //    // 🔸 Крок 1: конвертуємо MP3 → WAV через ffmpeg
        //    if (!File.Exists(wavPath))
        //    {
        //        var ffmpeg = new ProcessStartInfo
        //        {
        //            FileName = "ffmpeg",
        //            Arguments = $"-y -i \"{audioPath}\" -ar 16000 -ac 1 \"{wavPath}\"",
        //            RedirectStandardOutput = true,
        //            RedirectStandardError = true,
        //            UseShellExecute = false,
        //            CreateNoWindow = true
        //        };

        //        using (var process = Process.Start(ffmpeg))
        //        {
        //            await process.WaitForExitAsync();
        //        }
        //    }

        //    richTextBox1.Text = "🧠 Розпізнавання мовлення…";

        //    // 🔸 Крок 2: викликаємо Whisper для розпізнавання
        //    var whisper = new ProcessStartInfo
        //    {
        //        FileName = "whisper",
        //        Arguments = $"\"{wavPath}\" --model base --language ru --output_format txt",
        //        RedirectStandardOutput = true,
        //        RedirectStandardError = true,
        //        UseShellExecute = false,
        //        CreateNoWindow = true
        //    };

        //    using (var process = Process.Start(whisper))
        //    {
        //        await process.WaitForExitAsync();
        //    }

        //    // 🔸 Крок 3: читаємо результат
        //    string txtPath = Path.ChangeExtension(wavPath, ".txt");

        //    if (File.Exists(txtPath))
        //    {
        //        string lyrics = await File.ReadAllTextAsync(txtPath, Encoding.UTF8);
        //        richTextBox1.Text = lyrics.Trim();
        //    }
        //    else
        //    {
        //        richTextBox1.Text = "❌ Розпізнавання не вдалося.";
        //    }
        //}