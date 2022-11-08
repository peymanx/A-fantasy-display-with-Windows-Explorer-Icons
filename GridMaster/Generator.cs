using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridMaster
{
    public enum Directions { RIGHT2LEFT, LEFT2RIGHT };
    public class Generator
    {

        public string[]? Fonts { get; set; }
        public int NumberOfRows { get; set; } = 9;
        public int NumberOfCols { get; set; } = 22;
        public string BlackIconExt { get; set; } = "jpg";
        public string WhiteIconExt { get; set; } = "txt";
        public bool Running { get; set; } = false;
        public bool Boom { get; set; } = false;

        public int Frame { get; set; } = 0;

        public List<string> Screen { get; set; }
        public string ExtraSpace
        {
            get
            {
                var extra_space = "";
                for (int i = 0; i < NumberOfRows; i++)
                {
                    extra_space += " ";
                }
                return extra_space;
            }
        }

        internal string Preview(string word = "")
        {
            var result = "";
            if (word != "")
                UpdateScreen(word);

            for (int i = 0; i < NumberOfRows; i++)
            {
                result += Screen[i].Replace("@", "") + Environment.NewLine;
            }

            return result;
        }


        internal string PreviewFrame()
        {
            if (Screen == null || Screen.Count < 1)
                return "$";

            var preview = "|";
            for (int i = 0; i < NumberOfRows; i++)
            {

                for (int j = 0; j < NumberOfCols; j++)
                {
                    var pixel = Screen[i][j + Frame];
                    preview += (pixel);

                }
                preview += "|" + Environment.NewLine + "|";
            }

            return preview;
        }





        public Generator()
        {
            Fonts = File.ReadAllText("font.txt").Split(Environment.NewLine);

        }

        public List<string> Character(char ch)
        {
            ch = Char.Parse(ch.ToString().ToUpper());
            var lines = new List<string>();

            var start = (int)ch - (int)'A';
            start = start * 8;

            if (start > Fonts.Length || start < 0)
                start = Fonts.Length - 8;
            for (var i = start; i < start + 7; i++)
                lines.Add(Fonts[i].Replace(" @", ""));

            if (lines.Count < NumberOfRows)
            {
                for (int i = 0; i <= (NumberOfRows - lines.Count) / 2; i++)
                {
                    lines.Insert(0, lines[0]);
                    lines.Add(lines[0]);
                }
                lines.Add(lines[0]);
            }

            return lines;
        }



        public List<string> Word(string word)
        {
            word += ExtraSpace;
            var characters = new List<List<string>>();
            foreach (var ch in word)
            {
                var character = Character(ch);
                characters.Add(character);
            }

            var result = new List<string>();
            for (int i = 0; i < characters[0].Count; i++)
            {
                var line = "";


                foreach (var character in characters)
                {
                    line += character[i];
                }
                result.Add(line);
            }
            return result;
        }

        public void UpdateScreen(string word)
        {
            Screen = Word(word);
        }


        public void Icons(string path)
        {
            if (Screen == null || Screen.Count < 1)
                return;

            new Thread(() =>
                {
                  //  if (Running)
                    //    return;

                    Running = true;
                    Directory.GetFiles(path).ToList().ForEach(File.Delete);
                    var file = 0;

                    for (int i = 0; i < NumberOfRows; i++)
                    {

                        for (int j = 0; j < NumberOfCols; j++)
                        {
                            var pixel = Screen[i][j + Frame];
                            var filename = file.ToString();
                            if (file < 10)
                                filename = "000" + file;
                            else if (file < 100)
                                filename = "00" + file;
                            else filename = "0" + file;




                            if (pixel == ' ' || pixel == '@')

                                File.Copy(".\\0.txt", Path.Combine(path, filename) + "." + WhiteIconExt, true);
                            else
                                File.Copy(".\\1.jpg", Path.Combine(path, filename) + "." + BlackIconExt, true);

                            Thread.Sleep(2);
                            file++;


                        }

                    }
                    Running = false;
                }).Start();
        }

        public void Next(Directions direction = Directions.LEFT2RIGHT)
        {
            if (Screen == null || Screen.Count < 1)
                return;


            if (direction == Directions.LEFT2RIGHT)
            {

                Frame++;
                return;
            }

            Frame--;
            if (Frame < 0) Frame = Screen.Count;


        }
    }
}
