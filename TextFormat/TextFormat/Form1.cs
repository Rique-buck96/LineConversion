using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TextFormat.Properties;
using TextFormat.Text;

namespace TextFormat
{
    public partial class Form1 : Form
    {
        private readonly TextFile _textFile = new TextFile();
        private List<Users> _users;
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
                _textFile.ReadTextFile();
            }
             catch
            {
                MessageBox.Show(Resources.FileOpenFail);
                openFileDialog1.InitialDirectory = @"C:\\";
                openFileDialog1.Filter = Resources.TextFilter;
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
                            _textFile.TextString = line;
                        }
                    }
                }
            }
            btnTransform.Enabled = true;
        }

        /// <summary>
        /// Transforms multiline to single line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTransform_Click(object sender, EventArgs e)
        {
            _textFile.FormatMultiline();
            var matches = Regex.Matches(_textFile.TextString, "^(.+)$", RegexOptions.Multiline);
            var userStrings = new List<string>();

            foreach (Match match in matches)
                userStrings.AddRange(from Capture capture in match.Captures select capture.Value);

            while(userStrings.Count > 0)
            {
                _users = new List<Users> {new Users(
                    userStrings[0], 
                    userStrings[1], 
                    userStrings[2], 
                    userStrings[3],
                    userStrings[4],
                    userStrings[5])};
              
                userStrings.RemoveRange(0, 6);

                foreach (var line in _users.Select(user => user.Surname + "   " +
                                                           user.FirstName  + "   " +
                                                           user.Title  + "   " +
                                                           user.Logon  + "   " +
                                                           user.Room  + "   " +
                                                           user.Phone))
                {
                    lstSingleLine.Items.Add(line);
                }
            }

        }

    }
}
