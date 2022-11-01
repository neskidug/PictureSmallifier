using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PictureSmallifier
{
    public partial class Form1 : Form
    {
        private OpenFileDialog? ofd;
        private int sizePercentage;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();

            
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //if(txtSizePercentage.Text != "")
            //{
                ofd.Filter = "Image Files (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg";
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image picture = Image.FromFile(ofd.FileName);
                    //sizePercentage = Int32.Parse(txtSizePercentage.Text);

                    pictureBox1.Load(ofd.FileName);
                    
                    //Image img = ScaleByPercent(picture, sizePercentage);
                    //pictureBox1.Image = img;
                }
                else
                {
                    throw new Exception("Result not readable");
                }

            //}
            //else
            //{
            //    MessageBox.Show("You must set a size", "Number required",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /// <summary> 
        /// Saves an image as a jpeg image, with the given quality 
        /// </summary> 
        /// <param name="path"> Path to which the image would be saved. </param> 
        /// <param name="quality"> An integer from 0 to 100, with 100 being the highest quality. </param> 
        public static void SaveJpeg(string path, Image img, int quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");

            // Encoder parameter for image quality 
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, quality);
            // JPEG image codec 
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            img.Save(path, jpegCodec, encoderParams);
        }

        /// <summary> 
        /// Returns the image codec with the given mime type 
        /// </summary> 
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec 
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }

        static Image ScaleByPercent(Image imgPhoto, int Percent)
        {
            float nPercent = ((float)Percent / 100);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;

            int destX = 0;
            int destY = 0;
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(destWidth, destHeight,
                                     PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                                    imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }



        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Image picture = Clipboard.GetImage();
                pictureBox1.Image = picture;
                if ((txtSizePercentage.Text != "") & int.TryParse(txtSizePercentage.Text, out _))
                {
                    sizePercentage = Int32.Parse(txtSizePercentage.Text);
                    Image img = ScaleByPercent(picture, sizePercentage);
                    pictureBox1.Image = img;
                }
            }
            else
            {
                MessageBox.Show("Clipboard is empty. Please Copy Image.");
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\";      
            saveFileDialog1.Title = "Save image File";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = false;
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.Filter = "Image Files (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullpath = Path.GetFullPath(saveFileDialog1.FileName);
                SaveJpeg(fullpath, pictureBox1.Image, Int32.Parse(txtSizePercentage.Text));
            }
                
            
            
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSizePercentage_TextChanged(object sender, EventArgs e)
        {
            Image picture = pictureBox1.Image;
            sizePercentage = Int32.Parse(txtSizePercentage.Text);
            Image img = ScaleByPercent(picture, sizePercentage);
            pictureBox1.Image = img;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) {
                MessageBox.Show("Please select a picture first", "No picture selected", MessageBoxButtons.OK);
            }
            else
            {
                createResizeDialog();
            }
            
        }

        private void createResizeDialog()
        {
            Form2 inputDialog = new Form2();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                var input = inputDialog.getTxtInput();
                txtSizePercentage.Text = input;
                sizePercentage = Int32.Parse(input);
            }

        }
    }
}