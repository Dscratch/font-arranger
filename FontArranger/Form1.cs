using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FontArranger
{
    public partial class Form1 : Form
    {
        Point currentDrawPoint;
        Image resultImage;

        string defaultSpecialChars = "#$%&'()*+,-./";

        List<Character> unPackedImages;
        List<Character> packedImages;

        public Form1()
        {
            InitializeComponent();

            specialCharTextBox.Text = defaultSpecialChars;
        }
        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                inputPathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {

            
            resultImage = null;
            currentDrawPoint = new Point(0, 0);
            unPackedImages = new List<Character>();
            packedImages = new List<Character>();
            /*
            if (capLetters.Checked)
            {
                parseImages("char", true);
            }
            if (lowerLetters.Checked)
            {
                parseImages("char", false);
            }
            if (numbers.Checked)
            {
                parseImages("num", false);
            }
            */

            loadASCIICharacters(getImagePaths(inputPathTextBox.Text));

            if (packCheckBox.Checked)
            {
                packedImages = packImages(unPackedImages);
                resultImage = drawPackedImages(packedImages);
            }

            previewPictureBox.Image = resultImage;

            if(unPackedImages.Count + packedImages.Count > 0)
                saveButton.Enabled = true;
            
        }
        private string[] getImagePaths(string folder)
        {
            return Directory.GetFiles(folder, "*.png");
        }
        private void loadASCIICharacters(string[] paths)
        {
            List<Character> rawChars = new List<Character>();
            foreach (string s in paths)
            {
                Image currentChar = new Bitmap(s);
                if (trimInput.Checked)
                {
                    currentChar = trimChar(currentChar);
                }
                string fileName = Path.GetFileNameWithoutExtension(s);
                int asciiNum = Convert.ToInt32(fileName);
                char asciiChar = Convert.ToChar(asciiNum);
                Character c = new Character((Image)currentChar,asciiChar);
                rawChars.Add(c);
            }

            unPackedImages = rawChars;
        }
        private void parseImages(string type, bool isUpper)
        {
            List<Character> rawLetters = new List<Character>();
            Point maxSize = new Point();
            switch(type)
            {
                case "char":
                    maxSize = loadLetters(isUpper, rawLetters);
                    break;
                case "num" :
                    maxSize = loadNumbers(rawLetters);
                    break;
                case "special":
                    maxSize = loadSpecial(rawLetters);
                    break;
            }
            
 
            if (unPackedImages == null)
                unPackedImages = new List<Character>();

            unPackedImages.AddRange(rawLetters.ToArray());


            if (!packCheckBox.Checked)
            {
                if (resultImage == null)
                {
                    resultImage = new Bitmap(maxSize.X, maxSize.Y);
                }
                else
                {
                    Image temp = new Bitmap(Math.Max(resultImage.Width, maxSize.X), resultImage.Height + maxSize.Y + 1);

                    using (Graphics g = Graphics.FromImage(temp))
                    {
                        g.DrawImageUnscaled(resultImage, new Point(0, 0));
                    }

                    resultImage = temp;
                }

                drawCharsToImage(rawLetters, resultImage);

                currentDrawPoint.X = 0;
                currentDrawPoint.Y += maxSize.Y + 1;
            }
        }
        private Point loadLetters(bool isUpper, List<Character> letters)
        {
            string imageNameSuffix = (isUpper ? "_upper" : "_lower");

            Point maxSize = new Point();

            for (char current = 'a'; current <= 'z'; current++)
            {
                Image currentChar = new Bitmap(inputPathTextBox.Text + "\\" + current.ToString() + imageNameSuffix + ".png");

                if (trimInput.Checked)
                {
                    currentChar = trimChar(currentChar);
                }

                maxSize.X += currentChar.Width + 1;

                maxSize.Y = Math.Max(maxSize.Y, currentChar.Height);

                char actualChar = (isUpper ? char.ToUpper(current) : current);

                letters.Add(new Character(currentChar, actualChar));
            }

            return maxSize;
        }
        private Point loadNumbers(List<Character> numbers)
        {
            Point maxSize = new Point();

            for (int current = 0; current <= 9; current++)
            {
                Image currentChar = new Bitmap(inputPathTextBox.Text + "\\" + current.ToString() + ".png");

                if (trimInput.Checked)
                {
                    currentChar = trimChar(currentChar);
                }

                maxSize.X += currentChar.Width + 1;

                maxSize.Y = Math.Max(maxSize.Y, currentChar.Height);
                
                numbers.Add(new Character(currentChar,current.ToString().ToCharArray()[0]));
            }

            return maxSize;
        }
        private Point loadSpecial(List<Character> special)
        {
            return new Point();
        }
        private Image trimChar(Image trimMe)
        {
            Rectangle trimmedDimentions = new Rectangle();
            bool endLoop = false;
            for (int xMin = 0; !endLoop && xMin < trimMe.Width; xMin++)
            {
                for (int current = 0; current < trimMe.Height; current++)
                {
                    if (((Bitmap)trimMe).GetPixel(xMin, current).A > 0)
                    {
                        trimmedDimentions.X = (xMin == 0 ? xMin : xMin - 1);
                        endLoop = true;
                        break;
                    }
                }
            }
            endLoop = false;
            for (int xMax = trimMe.Width - 1; !endLoop && xMax > 0; xMax--)
            {
                for (int current = 0; current < trimMe.Height; current++)
                {
                    if (((Bitmap)trimMe).GetPixel(xMax, current).A > 0)
                    {
                        trimmedDimentions.Width = (xMax == trimMe.Width - 1 ? xMax : xMax + 1) - trimmedDimentions.X;
                        endLoop = true;
                        break;
                    }
                }
            }

            //==
            endLoop = false;
            for (int yMin = 0; !endLoop && yMin < trimMe.Height; yMin++)
            {
                for (int current = 0; current < trimMe.Width; current++)
                {
                    if (((Bitmap)trimMe).GetPixel(current, yMin).A > 0)
                    {
                        trimmedDimentions.Y = yMin; 
                        endLoop = true;
                        break;
                    }
                }
            }
            endLoop = false;
            for (int yMax = trimMe.Height - 1; !endLoop && yMax > 0; yMax--)
            {
                for (int current = 0; current < trimMe.Width; current++)
                {
                    if (((Bitmap)trimMe).GetPixel(current, yMax).A > 0)
                    {
                        trimmedDimentions.Height = (yMax == trimMe.Height - 1 ? yMax : yMax + 1) - trimmedDimentions.Y;
                        endLoop = true;
                        break;
                    }
                }
            }
            
            //==
            Image trimmed = new Bitmap(trimmedDimentions.Width, trimmedDimentions.Height);

            using(Graphics g = Graphics.FromImage(trimmed))
            {
                //g.DrawImage(trimMe, trimmedDimentions.X, trimmedDimentions.Y, trimmedDimentions.Width, trimmedDimentions.Height);
                g.DrawImage(trimMe, new Rectangle(0, 0, trimmed.Width, trimmed.Height), trimmedDimentions, GraphicsUnit.Pixel);
            }

            return trimmed;
        }
        private void drawCharsToImage(List<Character> chars, Image image)
        {
            using(Graphics g = Graphics.FromImage(image))
            {
                foreach (Character c in chars)
                {
                    g.DrawImage(c.image, currentDrawPoint.X, currentDrawPoint.Y, c.image.Width, c.image.Height);
                    c.position = currentDrawPoint;
                    currentDrawPoint.X += c.image.Width + 1;
                }
            }
        }
        private List<Character> packImages(List<Character> unPacked)
        {
            int totalArea = 0;

            foreach (Character c in unPacked)
            {
                totalArea += c.image.Width * c.image.Height;
            }

            int minSquareSize = (int)Math.Ceiling(Math.Sqrt((double)totalArea));

            int currentMax = Convert.ToInt32(Helper.roundUpToNextPowerOfTwo(Convert.ToUInt32(minSquareSize)));

            bool done = false;

            List<Character> result;

            while (!done)
            {
                result = packImagesToSquare(unPacked, currentMax);

                if (result != null)
                    return result;
                else
                    currentMax *= 2;
            }

            return null;
        }
        private List<Character> packImagesToSquare(List<Character> images, int squareSize)
        {
            Point currentPoint = new Point(0, 0);
            Point nextLine = new Point(0, 0);
            images.Sort(delegate(Character a, Character b) { return a.image.Width.CompareTo(b.image.Width); });
            images.Reverse();

            List<Character> packable = new List<Character>(images);
            List<Character> packed = new List<Character>();

            int highestChar = 0;
            foreach (Character c in packable)
            {
                highestChar = Math.Max(highestChar, c.image.Height);
            }
            //List<Character> currentRow = new List<Character>();
            //int maxRowHeight = 0;

            while (packable.Count > 0)
            {
                bool placed = false;

                while (!placed)
                {
                    foreach (Character c in packable)
                    {
                        if (c.image.Height + currentPoint.Y > squareSize)
                            return null;
                        if (c.image.Width + currentPoint.X <= squareSize)
                        {
                            placed = true;

                            c.position.X = currentPoint.X;
                            c.position.Y = currentPoint.Y + highestChar - c.image.Height;
                            packed.Add(c);
                            //currentRow.Add(c);

                            currentPoint.X += c.image.Width + 1;

                            //maxRowHeight = Math.Max(c.image.Height, maxRowHeight);

                            //nextLine.Y = Math.Max(currentPoint.Y + c.image.Height + 1, nextLine.Y);


                            packable.Remove(c);

                            break;
                        }
                    }
                    if (!placed)
                    {
                        //currentPoint = nextLine;

                        currentPoint.X = 0;
                        currentPoint.Y += highestChar+1;

                        /*foreach (Character c in currentRow)
                        {
                            c.rowMaxHeight = maxRowHeight;
                        }

                        maxRowHeight = 0;
                        currentRow.Clear();*/
                    }
                }
            }
            /*if (currentRow.Count != 0)
            {
                foreach (Character c in currentRow)
                {
                    c.rowMaxHeight = maxRowHeight;
                }
            }*/

            return packed;
        }
        private Image drawPackedImages(List<Character> images)
        {
            Point imageSize = new Point();
            foreach (Character i in images)
            {
                imageSize.X = Math.Max(imageSize.X, i.position.X + i.image.Width);
                imageSize.Y = Math.Max(imageSize.Y, i.position.Y + i.image.Height);
            }

            Image result = new Bitmap(imageSize.X, imageSize.Y);

            using (Graphics g = Graphics.FromImage(result))
            {
                foreach (Character i in images)
                {
                    g.DrawImage(i.image, i.position.X, i.position.Y, i.image.Width, i.image.Height);
                }
            }

            return result;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (resultImage != null)
            {

                saveFileDialog1.InitialDirectory = inputPathTextBox.Text;
                saveFileDialog1.FileName = fontNameTextBox.Text;
                saveFileDialog1.Filter = "PNG Image|*.png|Gif Image|*.gif|All Files|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    resultImage.Save(saveFileDialog1.FileName);

                    if (cocosCheckBox.Checked)
                    {
                        string filePath = Path.GetDirectoryName(saveFileDialog1.FileName) + "\\" + fontNameTextBox.Text  + ".fnt";

                        generateCocosFile((packCheckBox.Checked ? packedImages : unPackedImages), filePath);
                    }
                }
                
            }
        }
        private void generateCocosFile(List<Character> chars, string filePath)
        {
            int maxCharHeight = 0;
            foreach (Character c in chars)
            {
                maxCharHeight = Math.Max(maxCharHeight, c.image.Height);
            }
            chars.Sort(delegate(Character a, Character b) { return a.character.CompareTo(b.character); });

            List<string> contents = new List<string>();

            contents.Add("info face=\"MarkerFelt-Wide\" size=32 bold=0 italic=0 charset=\"\" unicode=0 stretchH=100 smooth=1 aa=1 padding=0,0,0,0 spacing=1,1");
            contents.Add("common lineHeight=" + maxCharHeight + " base=20 scaleW=148 scaleH=19 pages=1 packed=0");
            contents.Add("page id=0 file=\"" + Path.GetFileName(saveFileDialog1.FileName) + "\"");
            contents.Add("chars count=11");
            
            int totalThickness = 0;

            foreach (Character c in chars)
            {
                contents.Add(@"//" + c.character.ToString());
                contents.Add("char id=" + (int)c.character + " x=" + c.position.X + " y=" + c.position.Y + " width=" + c.image.Width + " height=" + c.image.Height + " xoffset=0 yoffset=" + (maxCharHeight - c.image.Height).ToString() + " xadvance=" + c.image.Width + " page=0 chnl=0");
                totalThickness += c.image.Width;
            }

            int averageThickness = totalThickness / chars.Count;

            contents.Insert(4,@"// Space");
            contents.Insert(5, "char id=32   x=0     y=0     width=0     height=0     xoffset=0     yoffset=1    xadvance=" + averageThickness/2 + "     page=0  chnl=0");

            File.WriteAllLines(filePath, contents.ToArray());
        }
        private void specialChars_CheckedChanged(object sender, EventArgs e)
        {
            specialCharTextBox.Enabled = specialChars.Checked;
        }
    }
}


