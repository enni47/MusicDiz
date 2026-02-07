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
    public partial class Informaishon : Form
    {
        public Informaishon()
        {
            InitializeComponent();
            TextRichBox();
        }

        private void Informaishon_Load(object sender, EventArgs e)
        {

        }
        private void TextRichBox()
        {
            richTextBox1.ReadOnly = true; //заборонює користувачу вносити будь які зміни в текст
            richTextBox1.Clear();//очищення richTextBox1.тобто коли користувач щось уводить
                                 //він одразу робить очистку

            richTextBox1.Font = new Font("Times New Roman", 13, FontStyle.Regular); //це назва шрифту,
                                                                                    //його розмір, і оголос що він без якиї дифектів
            richTextBox1.WordWrap = true; //автоматичне перенесення рядків
            string text = " • Інструкція :  меню в якому написа про кожну кнопку та її значення. \n\n"
                + "• Музичний каталог: підвантажена бібліотека з піснями на вибір.\n\n"
                + "• Шрифт: кнопка яка показує доступні шрифти Windovs та за допомогою якої можна змінювати шрифт в режимі караоке або конвертування.\n\n"
                + "• Завантажити: кнопка яка з диску підвантажує музичний файл та підключена до текст боксу на якій показує шлях файлу який було підвантажено.\n\n"
                + "• Караоке: це кнопка яка піддключена до текст боксу і як тільки туди користувач підвантажує шлях і сам файл,то при натиску на кнопку караоке вона робить такі дії: при натиску на кнопку старт починається грати пісня яку ви підвантажили а разом з нею виводиться текст який використовується в пісні.текст виводиться в три строчки.та що посередині та головна.також караоке має такі кнопки як стоп та пауза. їхні функції дорівнють їхнім назвавам. також можно перетягувати повзунок на любе місце коли почала грати пісня. \n\n"
                + "• Конвертувати: це кнопка яка дістає текст з пісні та виводить його на екран. сам текст можно скопіювати.\n\n"
                + "• Назад: кнопка яка дозволяє повернутись на те звідти прийшли.\n\n"
                + "• Логотип : при натиску на нього користувача буде переносити на головну сторінку.\n\n"
                + "• Профіль користувача: можно увійти або зарейструватись за логіном з паролем.\n\n";//текст який буде виведено в richTextBox1
            richTextBox1.AppendText(text); //текст з нового рядку
            //richTextBox1.Text = text;
            richTextBox1.SelectAll();//виділяє весь текст в richTextBox1
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;//робить вирівлювання з лівого боку
            richTextBox1.DeselectAll();//знімає виділення тексту

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }


        private void nazad_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
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

        private void music_katalog_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
