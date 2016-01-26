using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextFormat
{
    public partial class Form1 : Form
    {
       public string TextString;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reads the string values from the multiline text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (var reader = new StreamReader("multiline.txt"))
                {
                    var line = await reader.ReadToEndAsync();
                    MessageBox.Show(line);
                    TextString = line;
                }
            }
           catch
           {
               MessageBox.Show("Read failed.\nPlease choose the appropriate file");
               openFileDialog1.InitialDirectory = @"C:\\";
               openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
               openFileDialog1.FilterIndex = 2;
               openFileDialog1.RestoreDirectory = true;

               if (openFileDialog1.ShowDialog() == DialogResult.OK) //Displays the file dialogue, if the file cannot be found
               {
                   Stream stream;
                   if ((stream = openFileDialog1.OpenFile()) != null)
                   {
                       using (var reader = new StreamReader(stream))
                       {
                            var line = await reader.ReadToEndAsync();
                            MessageBox.Show(line);
                            TextString = line;
                        }
                   }
               }
           }
        }

        /// <summary>
        /// Transforms the multiline text to single line
        /// </summary>
        private void ConvertToSingle()
        {
            var replace = TextString;

            //note: optimise decision statement
                if (replace.Contains("surname"))
                {
                replace = replace.Replace("surname:", string.Empty);
                    
                }
                if (replace.Contains("title"))
                {
                    replace = replace.Replace("title:", string.Empty);
                }
                if (replace.Contains("room"))
                {
                    replace = replace.Replace("room:", string.Empty);
                }
                if (replace.Contains("phone"))
                {
                    replace = replace.Replace("phone:", string.Empty);
                }
                if (replace.Contains("firstName"))
                {
                    replace = replace.Replace("firstName:", string.Empty);
                }
                if (replace.Contains("logon"))
                {
                    replace = replace.Replace("logon:", string.Empty);
                }

            replace = replace.Replace("\t", string.Empty);   //removes tabbed characters

            var matches = Regex.Matches(replace, "^(.+)$", RegexOptions.Multiline);
            

            foreach (Match match in matches)
            {
               
                foreach (Capture capture in match.Captures)
                {
                    lstSingleLine.Items.Add(capture.Value);
                } 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertToSingle();
        }
    }
}
