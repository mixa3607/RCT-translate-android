using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace rct_text_replace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            input_file.Text = Properties.Settings.Default.inp_file;
            output_file.Text = Properties.Settings.Default.outp_file;
        }

        private void Set_output_file_Click(object sender, EventArgs e)
        {
            output_file.Text = Open_file_dialog("входной файл", output_file.Text);
            Properties.Settings.Default.outp_file = output_file.Text;
        }

        private void Set_input_file_Click(object sender, EventArgs e)
        {
            input_file.Text = Open_file_dialog("входной файл", input_file.Text);
            Properties.Settings.Default.inp_file = input_file.Text;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            char[] orig_letters = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            char[] repl_letters = { 'A', 'À', 'B', 'Á', 'Â', 'E', 'ü', 'Ã', 'Ä', 'Å', 'ï', 'K', 'Ç', 'M', 'H', 'O', 'É', 'P', 'C', 'T', 'Ê', 'Ë', 'X', 'Ì', 'Í', 'Î', 'Ï', 'û', 'ú', 'ù', 'Ñ', 'Ò', 'Ó', 'a', 'Ô', 'Õ', 'Ö', 'Ù', 'e', 'ë', 'Ú', 'Û', 'Ü', 'ñ', 'ß', 'à', 'ò', 'á', 'o', 'â', 'p', 'c', 'õ', 'y', 'ä', 'x', 'å', 'æ', 'ç', 'è', 'é', 'ê', 'ó', 'ì', 'í', 'î' };
            string text = File.ReadAllText(input_file.Text);
            for ( int i = 0; i < orig_letters.Length; i++ )
            {
                text = Regex.Replace(text, Char.ToString(orig_letters[i]), Char.ToString(repl_letters[i]));
            }
            File.WriteAllText(output_file.Text, text);
            start.Text = "Готово!";
            start.BackColor = Color.FromName("green");
            //Console.WriteLine(text);
            Properties.Settings.Default.Save();
        }
        public String Open_file_dialog(string head_text, string start_dir)
        {
            OpenFileDialog file_dialog = new OpenFileDialog
            {
                Title = head_text,
                InitialDirectory = start_dir,
                Multiselect = false
            };
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                return file_dialog.FileName;
            }

            return "Ошибка выбора файла!";
        }
    }


}
