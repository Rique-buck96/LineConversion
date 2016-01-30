using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.String;

namespace TextFormat.Text
{
    public class TextFile
    {
        public int NumLines;
        public string TextString = "";

        public async void ReadTextFile()
        {
            using (var reader = new StreamReader("multiline.txt"))
            {
                var line = await reader.ReadToEndAsync();
                MessageBox.Show(line);
                TextString = line;
            }
        }

        /// <summary>
        ///     Formats multiline string
        /// </summary>
        public void FormatMultiline()
        {
            var replace = TextString;

            if (replace.Contains("surname"))
                replace = replace.Replace("surname:", Empty);
            if (replace.Contains("title"))
                replace = replace.Replace("title:", Empty);
            if (replace.Contains("room"))
                replace = replace.Replace("room:", Empty);
            if (replace.Contains("phone"))
                replace = replace.Replace("phone:", Empty);
            if (replace.Contains("firstName"))
                replace = replace.Replace("firstName:", Empty);
            if (replace.Contains("logon"))
                replace = replace.Replace("logon:", Empty);

            replace = replace.Replace("\t", Empty); 
            replace = replace.Replace("\r", Empty);

            replace = replace.Replace(" ", Empty);
        
            TextString = replace;
        }

        public string RemoveSpace(string input)
        {
            var trimmedLine = input.Trim();
            return trimmedLine;
        }
        
    }
}