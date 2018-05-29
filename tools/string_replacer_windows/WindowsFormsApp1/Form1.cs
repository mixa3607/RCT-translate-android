using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] orig_letters = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            char[] repl_letters = { 'A', 'À', 'B', 'Á', 'Â', 'E', 'ü', 'Ã', 'Ä', 'Å', 'ï', 'K', 'Ç', 'M', 'H', 'O', 'É', 'P', 'C', 'T', 'Ê', 'Ë', 'X', 'Ì', 'Í', 'Î', 'Ï', 'û', 'ú', 'ù', 'Ñ', 'Ò', 'Ó', 'a', 'Ô', 'Õ', 'Ö', 'Ù', 'e', 'ë', 'Ú', 'Û', 'Ü', 'ñ', 'ß', 'à', 'ò', 'á', 'o', 'â', 'p', 'c', 'õ', 'y', 'ä', 'x', 'å', 'æ', 'ç', 'è', 'é', 'ê', 'ó', 'ì', 'í', 'î' };
            string text = textBox1.Text;
            for (int i = 0; i < orig_letters.Length; i++)
            {
                text = Regex.Replace(text, Char.ToString(orig_letters[i]), Char.ToString(repl_letters[i]));
            }
            textBox2.Text = text;
            button1.Text= "Готово!";
        }
    }
}
