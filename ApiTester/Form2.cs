using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiTester
{
    public partial class Form2 : Form
    {

        public Form2(string title, List<string> messageParagraphs)
        {
            InitializeComponent();
            this.Text = title;
            SplitAndAddTextToPictureBox(messageParagraphs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SplitAndAddTextToPictureBox(List<string> messageParagraphs)
        {
            // PictureBox needs an image to draw on
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Font = new Font("Microsoft Sans Serif", 10);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                // add a gray background background for drawing
                g.FillRectangle(new SolidBrush(Color.LightGray), 0, 0, pictureBox1.Image.Width, pictureBox1.Image.Height);

                float heightOfALine = g.MeasureString(",", pictureBox1.Font).Height;
                float yPosForText = 0;

                //go throughj each paragraph and split them so they fit into the picture box and then
                //add the text with the different colours
                for (int i = 0; i < messageParagraphs.Count; i++)
                {
                    string tempText = messageParagraphs[i];
                    List<string> linesOfMessage = SplitTextIntoLines(tempText).ToList();
                    yPosForText += AddTextToPictureBox(linesOfMessage, heightOfALine, yPosForText);
                    yPosForText += (heightOfALine);
                }
            }
        }




        private IEnumerable<string> SplitTextIntoLines(string text)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            List<string> linesOfMessage = new List<string>();

            //while there is still text to assign to a line
            while (text.Length > 0)
            {
                float widthOfTempString = 0;
                string tempText = "";
                string lineText = "";
                int indexOfEndOfFirstWordIncludingSpace = 0;

                //go through the text that has yet to be assigned to a line and check if the tempText string length is still shorter 
                //than the max possible on a line
                while (pictureBox1.Width > widthOfTempString && !String.IsNullOrEmpty(text))
                {
                    lineText = tempText;
                    text = text.Remove(0, indexOfEndOfFirstWordIncludingSpace);

                    //Check if all the text has all been used - NOTE: text is only assigned to a line after the check is made 
                    //to see if adding the last word from the previous loop has not exceed the max possible on a line
                    //This check is made to avoid errors in the last run through the loop
                    if (!String.IsNullOrEmpty(text))
                    {
                        int indexOfEndOfFirstWord = text.IndexOf(" ");

                        //if no spaces are found in the text then this is the last word
                        if (indexOfEndOfFirstWord == -1)
                        {
                            indexOfEndOfFirstWordIncludingSpace = text.Length;
                        }
                        else
                        {
                            indexOfEndOfFirstWordIncludingSpace = indexOfEndOfFirstWord + 1;
                        }

                        //add the next word to the temptext string
                        tempText += text.Substring(0, indexOfEndOfFirstWordIncludingSpace);
                        //work out how long the temptext is 
                        widthOfTempString = g.MeasureString(tempText, pictureBox1.Font).Width;
                    }
                }
                //add the current line into the collection 
                linesOfMessage.Add(lineText);
            }
            return linesOfMessage;
        }

        private float AddTextToPictureBox(List<string> linesOfMessage, float heightOfALine, float y)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);

            //go through each line of text that will fit in the picturebox
            for (int i = 0; i < linesOfMessage.Count; i++)
            {
                //break the current line of text based on the colour splits
                string[] chunks = linesOfMessage[i].Split('[');
                //SolidBrush brush = new SolidBrush(Color.Black);

                //collection of text colours that will be used 
                SolidBrush[] brushes = new SolidBrush[]
                {
                    new SolidBrush(Color.Black),
                    new SolidBrush(Color.Blue),
                    new SolidBrush(Color.Red)
                };

                float x = 0;

                //go through each of the colour splits for the current line 
                for (int j = 0; j < chunks.Length; j++)
                {
                    //if the split contains text 
                    if (!String.IsNullOrEmpty(chunks[j]))
                    {
                        // draw text in the assigned colour.  The colour will be assigned based on what each split of text starts with
                        if (chunks[j].Trim().StartsWith("https") || chunks[j].Trim().StartsWith("v1/me"))
                        {
                            g.DrawString(chunks[j], pictureBox1.Font, brushes[1], x, y);
                        }
                        else if (chunks[j].Trim().StartsWith("NOTE"))
                        {
                            g.DrawString(chunks[j], pictureBox1.Font, brushes[2], x, y);
                        }
                        else
                        {
                            g.DrawString(chunks[j], pictureBox1.Font, brushes[0], x, y);
                        }

                        //work out where the far across the picturebox the text appears so that the next bit of text starts to the 
                        //right of it.  Prevents the next bit of text overwriting the first bit
                        x += g.MeasureString(chunks[j], pictureBox1.Font).Width;
                    }
                }
                //calculate how far down the picturebox the next line of text should appear so it does not overright the current text 
                y += heightOfALine;
            }
            return y;
        }
    }
}




              