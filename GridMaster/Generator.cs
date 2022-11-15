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
        public string[]? Digits { get; set; }
        public int NumberOfRows { get; set; } = 9;
        public int NumberOfCols { get; set; } = 22;
        public string BlackIconExt { get; set; } = "jpg";
        public string WhiteIconExt { get; set; } = "txt";
        public string RedIconExt { get; set; } = "pdf";
        public string GreenIconExt { get; set; } = "xlsx";
        public string BlueIconExt { get; set; } = "all";
        public bool Running { get; set; } = false;
        public bool Boom { get; set; } = false;

        // current frame
        public int Frame { get; set; } = 0;

        public string Space(int n)
        {
            var spaces = "";
            for (int i = 0; i < n; i++)
            {
                spaces += " ";
            }
            return spaces;
        }
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


        public Generator()
        {
            Fonts = File.ReadAllText("font.txt").Split(Environment.NewLine);
            Digits = File.ReadAllText("digits.txt").Split(Environment.NewLine);
            Screen = Word(ExtraSpace); // make a BLANK screen at start up

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

                    try
                    {
                        var pixel = Screen[i][j + Frame];
                        preview += (pixel);
                    }
                    catch
                    {

                        // :(  DONT TELL ANY ONE
                    }

                }
                preview += "|" + Environment.NewLine + "|";
            }

            return preview;
        }







        public List<string> Character(char ch)
        {
            ch = Char.Parse(ch.ToString().ToUpper());
            var lines = new List<string>();
            var start = 0;

            if (ch >= '0' && ch <= '9' || ch == ':')
            {
                start = (int)ch - (int)'0';

                start = start * 8;
                if (ch == ':')
                    start = Digits.Length - 8;

                for (var i = start; i < start + 7; i++)
                    lines.Add(Digits[i].Replace(" @", ""));
            }
            else
            {

                start = (int)ch - (int)'A';
                start = start * 8;

                if (start > Fonts.Length || start < 0)
                    start = Fonts.Length - 8;
                for (var i = start; i < start + 7; i++)
                    lines.Add(Fonts[i].Replace(" @", ""));




            }
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
                    //Directory.GetFiles(path).ToList().ForEach(File.Delete);
                    var file = 0;

                    for (int j = 0; j < NumberOfCols; j++)
                    {
                        for (int i = 0; i < NumberOfRows; i++)

                        {
                            try
                            {
                                file = i * NumberOfCols + j + 1;
                                var pixel = Screen[i][j + Frame];
                                var filename = file.ToString();
                                if (file < 10)
                                    filename = "000" + file;
                                else if (file < 100)
                                    filename = "00" + file;
                                else filename = "0" + file;


                                var white = Path.Combine(path, filename) + "." + WhiteIconExt;
                                var black = Path.Combine(path, filename) + "." + BlackIconExt;

                                // rgb
                                var r = Path.Combine(path, filename) + "." + RedIconExt;
                                var g = Path.Combine(path, filename) + "." + GreenIconExt;
                                var b = Path.Combine(path, filename) + "." + BlueIconExt;



                                var exist = "";



                                if (pixel == ' ' || pixel == '@')
                                {
                                    if (File.Exists(black))
                                        File.Move(black, white);
                                    else
                                        File.Copy(".\\1.jpg", white, true);

                                    File.Delete(r);
                                    File.Delete(g);
                                    File.Delete(b);
                                }
                                else if (pixel == 'r' || pixel == 'R')
                                {

                                    File.Copy(".\\1.jpg", r, true);
                                    File.Delete(white);
                                    File.Delete(black);

                                }
                                else if (pixel == 'g' || pixel == 'G')
                                {
                                    File.Copy(".\\1.jpg", g, true);
                                    File.Delete(white);
                                    File.Delete(black);
                                }
                                else if (pixel == 'b' || pixel == 'B')
                                {
                                    File.Copy(".\\1.jpg", b, true);
                                    File.Delete(white);
                                    File.Delete(black);
                                }

                                else
                                {
                                    if (File.Exists(white))
                                        File.Move(white, black);
                                    else
                                        File.Copy(".\\1.jpg", black, true);

                                    File.Delete(r);
                                    File.Delete(g);
                                    File.Delete(b);

                                }



                                Thread.Sleep(2);


                            }
                            catch
                            {
                                // :( DONT TELL ANY ONE

                            }

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
                if (Frame >= Screen[0].Length - 1)
                    Frame = 0;
                return;
            }

            Frame--;
            if (Frame < 0) Frame = Screen.Count;


        }
    }
}
