using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // initilize image as global variable
        Image img = Image.FromFile("C:\\Users\\u333206\\Desktop\\lena.bmp");
       


      
        public static Bitmap[] Create4Shares()
        {
            Image img = Image.FromFile("C:\\Users\\u333206\\Desktop\\lena.bmp");
            // create bitmap object from image for the set/getpixel functions
            Bitmap image = new Bitmap(img);

            // create the byte array from the image
            byte[] byteArray = new byte[262144];
            var count = 0;
            for (var i = 0; i < image.Height; i++)
            {
                for (var j = 0; j < image.Width; j++)
                {
                    byteArray[count] = image.GetPixel(i, j).R;
                    count++;
                }
            }

            // create the bit array from the byte array
            var userABits = new System.Collections.BitArray(byteArray);
            var userBBits = new System.Collections.BitArray(byteArray);
            var userCBits = new System.Collections.BitArray(byteArray);
            var userDBits = new System.Collections.BitArray(byteArray);

            // convert the bit arrays to randomize shares
            count = 0;
            Random rnd = new Random();
            for (int i = 0; i < userABits.Length; i++)
            {
                if (count == 0 || count == 1)
                {
                    if (rnd.Next(1, 100) > 50)
                    {
                        userBBits[i] = true;
                        userCBits[i] = true;
                        userDBits[i] = true;
                    }
                    else
                    {
                        userBBits[i] = false;
                        userCBits[i] = false;
                        userDBits[i] = false;
                    }
                }
                else if (count == 2 || count == 3)
                {
                    if (rnd.Next(1, 100) > 50)
                    {
                        userABits[i] = true;
                        userCBits[i] = true;
                        userDBits[i] = true;
                    }
                    else
                    {
                        userABits[i] = false;
                        userCBits[i] = false;
                        userDBits[i] = false;
                    }
                }
                else if (count == 4 || count == 5)
                {
                    if (rnd.Next(1, 100) > 50)
                    {
                        userABits[i] = true;
                        userBBits[i] = true;
                        userDBits[i] = true;
                    }
                    else
                    {
                        userABits[i] = false;
                        userBBits[i] = false;
                        userDBits[i] = false;
                    }
                }
                else
                {
                    if (rnd.Next(1, 100) > 50)
                    {
                        userABits[i] = true;
                        userBBits[i] = true;
                        userCBits[i] = true;
                    }
                    else
                    {
                        userABits[i] = false;
                        userBBits[i] = false;
                        userCBits[i] = false;
                    }
                }

                count++;
                if (count == 8)
                {
                    count = 0;
                }
            }


            // try to put back together the image
            var newBits = new System.Collections.BitArray(byteArray);
            count = 0;
            for (var i = 0; i < newBits.Length; i++)
            {
                if (count == 0 || count == 1)
                {
                    newBits[i] = userABits[i];
                }
                else if (count == 2 || count == 3)
                {
                    newBits[i] = userBBits[i];
                }
                else if (count == 4 || count == 5)
                {
                    newBits[i] = userCBits[i];
                }
                else if (count == 6 || count == 7)
                {
                    newBits[i] = userDBits[i];
                }
                count++;
                if (count == 8)
                {
                    count = 0;
                }
            }

            // convert the user shares back to byte arrays
            byte[] userABytes = BitArrayToByteArray(userABits);
            byte[] userBBytes = BitArrayToByteArray(userBBits);
            byte[] userCBytes = BitArrayToByteArray(userCBits);
            byte[] userDBytes = BitArrayToByteArray(userDBits);
            byte[] originalBack = BitArrayToByteArray(newBits);

            //
            Bitmap userAImage = new Bitmap(img);
            Bitmap userBImage = new Bitmap(img);
            Bitmap userCImage = new Bitmap(img);
            Bitmap userDImage = new Bitmap(img);
            Bitmap originalBacks = new Bitmap(img);

            count = 0;
            for (var i = 0; i < img.Width; i++)
            {
                for (var k = 0; k < img.Height; k++)
                {
                    userAImage.SetPixel(i, k, Color.FromArgb(userABytes[count], userABytes[count], userABytes[count]));
                    userBImage.SetPixel(i, k, Color.FromArgb(userBBytes[count], userBBytes[count], userBBytes[count]));
                    userCImage.SetPixel(i, k, Color.FromArgb(userCBytes[count], userCBytes[count], userCBytes[count]));
                    userDImage.SetPixel(i, k, Color.FromArgb(userDBytes[count], userDBytes[count], userDBytes[count]));
                    originalBacks.SetPixel(i, k, Color.FromArgb(originalBack[count], originalBack[count], originalBack[count]));
                    //Console.WriteLine(userDImage.GetPixel(i, k));
                    count++;
                }
            }

            Bitmap[] imageArray = new Bitmap[5];
            imageArray[0] = userAImage;
            imageArray[1] = userBImage;
            imageArray[2] = userCImage;
            imageArray[3] = userDImage;
            imageArray[4] = originalBacks;
            return imageArray;

            
        }

        public static Bitmap[] Create2Shares()
        {
            Image img = Image.FromFile("C:\\Users\\u333206\\Desktop\\lena.bmp");
            // create bitmap object from image for the set/getpixel functions
            Bitmap image = new Bitmap(img);

            // create the byte array from the image
            byte[] byteArray = new byte[262144];
            var count = 0;
            for (var i = 0; i < image.Height; i++)
            {
                for (var j = 0; j < image.Width; j++)
                {
                    byteArray[count] = image.GetPixel(i, j).R;
                    count++;
                }
            }

            // create the bit array from the byte array
            var userABits = new System.Collections.BitArray(byteArray);
            var userBBits = new System.Collections.BitArray(byteArray);


            // convert the bit arrays to randomize shares
            count = 0;
            Random rnd = new Random();
            for (int i = 0; i < userABits.Length; i++)
            {
                if (count == 0 || count == 1 || count == 2 || count == 3)
                {
                    if (rnd.Next(1, 11) > 5)
                    {
                        userBBits[i] = true;
                    }
                    else
                    {
                        userBBits[i] = false;
                    }
                }
                else
                {
                    if (rnd.Next(1, 11) > 5)
                    {
                        userABits[i] = true;
                    }
                    else
                    {
                        userABits[i] = false;
                    }
                }

                count++;
                if (count == 8)
                {
                    count = 0;
                }
            }


            // try to put back together the image
            var newBits = new System.Collections.BitArray(byteArray);
            count = 0;
            for (var i = 0; i < newBits.Length; i++)
            {
                if (count == 0 || count == 1 || count == 3 || count == 4)
                {
                    newBits[i] = userABits[i];
                }
                else
                {
                    newBits[i] = userBBits[i];
                }

                count++;
                if (count == 8)
                {
                    count = 0;
                }
            }

            // convert the user shares back to byte arrays
            byte[] userABytes = BitArrayToByteArray(userABits);
            byte[] userBBytes = BitArrayToByteArray(userBBits);
            byte[] originalBack = BitArrayToByteArray(newBits);

            //
            Bitmap userAImage = new Bitmap(img);
            Bitmap userBImage = new Bitmap(img);
            Bitmap originalBacks = new Bitmap(img);

            count = 0;
            for (var i = 0; i < img.Width; i++)
            {
                for (var k = 0; k < img.Height; k++)
                {
                    userAImage.SetPixel(i, k, Color.FromArgb(userABytes[count], userABytes[count], userABytes[count]));
                    userBImage.SetPixel(i, k, Color.FromArgb(userBBytes[count], userBBytes[count], userBBytes[count]));
                    originalBacks.SetPixel(i, k, Color.FromArgb(originalBack[count], originalBack[count], originalBack[count]));
                    count++;
                }
            }

            Bitmap[] ImageArray = new Bitmap[3];
            ImageArray[0] = userAImage;
            ImageArray[1] = userBImage;

            return ImageArray;
        }
        public static byte[] BitArrayToByteArray(System.Collections.BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }

        private void buttonGenerateShares_Click(object sender, EventArgs e)
        {
            if(radioButtonShare2.Checked == true)
            {
                Bitmap[] Shares = Create2Shares();

                pictureBox2.Image = Shares[0];
                pictureBox3.Image = Shares[1];

                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            if (radioButtonShare4.Checked == true)
            {
                Bitmap[] Shares = Create4Shares();

                pictureBox2.Image = Shares[0];
                pictureBox3.Image = Shares[1];
                pictureBox4.Image = Shares[2];
                pictureBox5.Image = Shares[3];
                pictureBox6.Image = Shares[4];
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
            }

            radioButtonCBC.Enabled = true;
            radioButtonEBC.Enabled = true;
            buttonEncrypt.Enabled = true;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            // encryption code goes here
        }
    }
}
