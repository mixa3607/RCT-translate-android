using Android.App;
using Android.Widget;
using Android.OS;
using System.Text.RegularExpressions;
using System.IO;
using Android.Graphics;
using System;

namespace rct_helper_android
{
    [Activity(Label = "rct_helper_android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText Input_file;
        Button Input_file_check;
        EditText Output_file;
        Button Output_file_check;
        Button Start;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Input_file = FindViewById<EditText>(Resource.Id.Input_file);
            Input_file_check = FindViewById<Button>(Resource.Id.Input_file_check);
            Output_file = FindViewById<EditText>(Resource.Id.Output_file);
            Output_file_check = FindViewById<Button>(Resource.Id.Output_file_check);
            Start = FindViewById<Button>(Resource.Id.Start);

            string text = null;




            Input_file_check.Click += delegate
            {
                string path = Input_file.Text;
                try
                {
                    text = File.ReadAllText(path);
                    Input_file_check.Text = GetString(Resource.String.button_Input_file_check_ok);
                    Input_file_check.SetTextColor(Color.Green);

                }
                catch
                {
                    Input_file_check.Text = GetString(Resource.String.button_Input_file_check_fail);
                    Input_file_check.SetTextColor(Color.Red); 
                }
            };
            Output_file_check.Click += delegate
             {
                 string path = Output_file.Text;
                 try
                 {
                     File.Create(path).Dispose();
                     Output_file_check.Text = GetString(Resource.String.button_Output_file_check_ok);
                     Output_file_check.SetTextColor(Color.Green);

                 }
                 catch
                 {
                     Output_file_check.Text = GetString(Resource.String.button_Output_file_check_fail);
                     Output_file_check.SetTextColor(Color.Red);
                 }
             };
            Start.Click += delegate
            {
                try
                {
                    char[] orig_letters = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
                    char[] repl_letters = { 'A', 'À', 'B', 'Á', 'Â', 'E', 'ü', 'Ã', 'Ä', 'Å', 'ï', 'K', 'Ç', 'M', 'H', 'O', 'É', 'P', 'C', 'T', 'Ê', 'Ë', 'X', 'Ì', 'Í', 'Î', 'Ï', 'û', 'ú', 'ù', 'Ñ', 'Ò', 'Ó', 'a', 'Ô', 'Õ', 'Ö', 'Ù', 'e', 'ë', 'Ú', 'Û', 'Ü', 'ñ', 'ß', 'à', 'ò', 'á', 'o', 'â', 'p', 'c', 'õ', 'y', 'ä', 'x', 'å', 'æ', 'ç', 'è', 'é', 'ê', 'ó', 'ì', 'í', 'î' };
                    
                    for (int i = 0; i < orig_letters.Length; i++)
                    {
                        text = Regex.Replace(text, Char.ToString(orig_letters[i]), Char.ToString(repl_letters[i]));
                    }
                    File.WriteAllText(Output_file.Text, text);
                    Start.Text = GetString(Resource.String.button_Start_ok);
                    Start.SetTextColor(Color.Green);
                }
                catch
                {
                    Start.Text = GetString(Resource.String.button_Start_fail);
                    Start.SetTextColor(Color.Red);
                }
            };
        }
        
        
    }
}

