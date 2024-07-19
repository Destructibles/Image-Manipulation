using ImageMagick;
using System.Drawing.Imaging;

namespace Image_Manipulation
{
    public partial class Form1 : Form
    {
        private string currentImageFilePath = string.Empty; // Whatever image is in the ViewPort is the FilePath stored here

        public Form1()
        {
            InitializeComponent();
        }

        private void FileMenu_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|" +
                "*.bmp;" +
                "*.gif;" +
                "*.jpg;*.jpeg;" +
                "*.png";

            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    ViewPort.Image = new Bitmap(openFile.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Incompatible Extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FileMenu_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter =
                "Bitmap(*.bmp)|*.bmp|" +
                "GIF(*.gif)|*.gif|" +
                "JPEG(*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "PNG(*.png)|*.png";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                ViewPort.Image.Save(saveFile.FileName);
            }
        }

        private void FileMenu_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Decreases the brightness of an image.
        // 
        // This will cause the image to lose it's original color values, so make sure to keep a copy of the original image.
        private void ImageMenu_DecreaseBrightness_Click(object sender, EventArgs e)
        {
            Image image = ViewPort.Image;
            Bitmap bitmapChanged = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {    1,     0,     0, 0, 0},
                    new float[] {    0,     1,     0, 0, 0},
                    new float[] {    0,     0,     1, 0, 0},
                    new float[] {    0,     0,     0, 1, 0},
                    new float[] {-0.1f, -0.1f, -0.1f, 1, 1},
                });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapChanged);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            ViewPort.Image = bitmapChanged;
        }

        // Increases the brightness of an image.
        // 
        // This will cause the image to lose it's original color values, so make sure to keep a copy of the original image.
        private void ImageMenu_IncreaseBrightness_Click(object sender, EventArgs e)
        {
            Image image = ViewPort.Image;
            Bitmap bitmapChanged = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {   1,    0,    0, 0, 0},
                    new float[] {   0,    1,    0, 0, 0},
                    new float[] {   0,    0,    1, 0, 0},
                    new float[] {   0,    0,    0, 1, 0},
                    new float[] {0.1f, 0.1f, 0.1f, 1, 1},
                });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapChanged);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            ViewPort.Image = bitmapChanged;
        }

        private void ImageMenu_Grayscale_Click(object sender, EventArgs e)
        {
            Image image = ViewPort.Image;
            Bitmap bitmapChanged = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] { 0.3f,  0.3f,  0.3f, 0, 0},
                    new float[] {0.59f, 0.59f, 0.59f, 0, 0},
                    new float[] {0.11f, 0.11f, 0.11f, 0, 0},
                    new float[] {    0,     0,     0, 1, 0},
                    new float[] {    0,     0,     0, 0, 1},
                });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapChanged);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            ViewPort.Image = bitmapChanged;
        }

        private void ImageMenu_Negative_Click(object sender, EventArgs e)
        {
            Image image = ViewPort.Image;
            Bitmap bitmapChanged = new Bitmap(image.Width, image.Height);
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                {
                    new float[] {-1, 0, 0,  0, 0}, // Invert all red in the image
                    new float[] {0, -1, 0,  0, 0}, // Invert all green in the image
                    new float[] {0,  0, -1, 0, 0}, // Invert all blue in the image
                    new float[] {0,  0,  0, 1, 0}, // Alpha scaling factor of 1
                    new float[] {1,  1,  1, 0, 1}, // Three translations of 1
                });

            imageAttributes.SetColorMatrix(colorMatrix);
            Graphics graphics = Graphics.FromImage(bitmapChanged);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();

            ViewPort.Image = bitmapChanged;
        }

        private void ImageMenu_Transform_FlipHorizontally_Click(object sender, EventArgs e)
        {
            ViewPort.Image.RotateFlip(RotateFlipType.RotateNoneFlipX); // Flip Horizontally
            ViewPort.Refresh();
        }

        private void ImageMenu_Transform_FlipVertically_Click(object sender, EventArgs e)
        {
            ViewPort.Image.RotateFlip(RotateFlipType.RotateNoneFlipY); // Flip Vertically
            ViewPort.Refresh();
        }

        private void ImageMenu_Transform_RotatePlus90_Click(object sender, EventArgs e)
        {
            ViewPort.Image.RotateFlip(RotateFlipType.Rotate90FlipNone); // Rotate 90° Clockwise
            ViewPort.Refresh();
        }

        private void ImageMenu_Transform_RotateMinus90_Click(object sender, EventArgs e)
        {
            // RotateFlip does not support negative rotations, but rotating 270° clockwise is the same as rotating -90° counterclockwise
            ViewPort.Image.RotateFlip(RotateFlipType.Rotate270FlipNone); // Rotate 270° Clockwise
            ViewPort.Refresh();
        }

        private void AnimationMenu_CombineGIFFrames_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // The user needs to select the last file first and work backwards, that way they get Sprite 0, 1, 2, 3 for instance
            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            using var images = new MagickImageCollection(); // Array to store frames for the gif

            if (AnimationMenu_ModifyGIFFrameDelay_Textbox.Text.All(char.IsLetter)) // Make sure the input in the Frame Delay box isn't a non-number
            {
                AnimationMenu_ModifyGIFFrameDelay_Textbox.Text = "4";
                MessageBox.Show("The value in Modify GIF Frame Delay was not a valid number, defaulting to 4 centiseconds.");
            }

            for (int i = 0; i < openFileDialog.FileNames.Length; i++) // Store the files in the array as frames
            {
                images.Add(openFileDialog.FileNames[i]);
                images[i].AnimationDelay = Convert.ToInt32(AnimationMenu_ModifyGIFFrameDelay_Textbox.Text);
                images[i].GifDisposeMethod = GifDisposeMethod.Previous;
                images[i].Scale(new Percentage(100));
            }

            // Save the newly created gif file
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "GIF(*.gif)|*.gif";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                images.Write(saveFile.FileName);

                MessageBox.Show("The file was created succesfully!");
                MessageBox.Show("The created GIF has a frame delay of " + AnimationMenu_ModifyGIFFrameDelay_Textbox.Text + " centiseconds.");
            }
        }

        private void AnimationMenu_ExportGIFFrames_Click(object sender, EventArgs e)
        {
            FrameDimension frameDimension = new FrameDimension(ViewPort.Image.FrameDimensionsList[0]);

            int frameCount = ViewPort.Image.GetFrameCount(frameDimension);
            Image[] getFrames = new Image[frameCount];

            // Store the frames in an array
            for (int i = 0; i < frameCount; i++)
            {
                ViewPort.Image.SelectActiveFrame(frameDimension, i);
                getFrames[i] = new Bitmap(ViewPort.Image);
            }

            // Export the frames in the array
            SaveFileDialog exportFrames = new SaveFileDialog();
            DialogResult dialogResult = exportFrames.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string filePath = exportFrames.FileName;

                for (int i = 0; i < frameCount; i++)
                {
                    string path = Path.Combine(filePath, string.Format(filePath + " {0}.png", i));
                    getFrames[i].Save(path);
                }

                MessageBox.Show("The program exported " + frameCount + " frames succesfully!");
            }
        }

        private void AnimationMenu_ExportSpriteFromSpritesheet_Click_1(object sender, EventArgs e)
        {
            var spriteSheet = new MagickImage(currentImageFilePath);

            // Verifying that user input is correct for all fields
            if (AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox.Text.All(char.IsLetter)) // Make sure the input isn't a non-number
            {
                AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox.Text = "1";
                MessageBox.Show("Invalid value in Export Sprite from Spritesheet - Rows, defaulting to 1 row.");
            }

            if (AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox.Text.All(char.IsLetter)) // Make sure the input isn't a non-number
            {
                AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox.Text = "1";
                MessageBox.Show("Invalid value in Export Sprite from Spritesheet - Columns, defaulting to 1 column.");
            }

            if (AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox.Text.All(char.IsLetter)) // Make sure the input isn't a non-number
            {
                AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox.Text = "1";
                MessageBox.Show("Invalid value in Export Sprite from Spritesheet - Height, defaulting to a height of 1.");
            }

            if (AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox.Text.All(char.IsLetter)) // Make sure the input isn't a non-number
            {
                AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox.Text = "1";
                MessageBox.Show("Invalid value in Export Sprite from Spritesheet - Width, defaulting to a width of 1.");
            }

            if (AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox.Text.All(char.IsLetter)) // Make sure the input isn't a non-number
            {
                AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox.Text = "1";
                MessageBox.Show("Invalid value in Export Sprite from Spritesheet - Horizontal Spacing, defaulting to a horizontal spacing of 1.");
            }

            if (AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox.Text.All(char.IsLetter)) // Make sure the input isn't a non-number
            {
                AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox.Text = "1";
                MessageBox.Show("Invalid value in Export Sprite from Spritesheet - Vertical Spacing, defaulting to a vertical spacing of 1.");
            }
        }

        private void ColorsMenu_FindAndReplaceColors_Click(object sender, EventArgs e)
        {
            // Load the image into an array
            using var images = new MagickImageCollection();
            images.Add(currentImageFilePath);

            /*
            var targetColor = MagickColor.FromRgb((byte)255, (byte)0, (byte)255); // Desired Color
            images[0].Opaque(MagickColor.FromRgb((byte)255, (byte)255, (byte)255), // Color to Change
                             MagickColor.FromRgb((byte)targetColor.R, (byte)targetColor.G, (byte)targetColor.B)); // Change the Color
            */

            var targetColorOne = MagickColor.FromRgb((byte)247, (byte)15, (byte)15); // Red
            images[0].Opaque(MagickColor.FromRgb((byte)255, (byte)0, (byte)255), // Color to Change
                             MagickColor.FromRgb((byte)targetColorOne.R, (byte)targetColorOne.G, (byte)targetColorOne.B));

            var targetColorTwo = MagickColor.FromRgb((byte)191, (byte)23, (byte)23); // Red
            images[0].Opaque(MagickColor.FromRgb((byte)222, (byte)0, (byte)222), // Color to Change
                             MagickColor.FromRgb((byte)targetColorTwo.R, (byte)targetColorTwo.G, (byte)targetColorTwo.B));

            var targetColorThree = MagickColor.FromRgb((byte)191, (byte)23, (byte)23); // Red
            images[0].Opaque(MagickColor.FromRgb((byte)189, (byte)0, (byte)189), // Color to Change
                             MagickColor.FromRgb((byte)targetColorThree.R, (byte)targetColorThree.G, (byte)targetColorThree.B));

            var targetColorFour = MagickColor.FromRgb((byte)162, (byte)15, (byte)15); // Red
            images[0].Opaque(MagickColor.FromRgb((byte)156, (byte)0, (byte)156), // Color to Change
                             MagickColor.FromRgb((byte)targetColorFour.R, (byte)targetColorFour.G, (byte)targetColorFour.B));

            var targetColorFive = MagickColor.FromRgb((byte)130, (byte)0, (byte)0); // Red
            images[0].Opaque(MagickColor.FromRgb((byte)124, (byte)0, (byte)124), // Color to Change
                             MagickColor.FromRgb((byte)targetColorFive.R, (byte)targetColorFive.G, (byte)targetColorFive.B));

            var targetColorSix = MagickColor.FromRgb((byte)107, (byte)0, (byte)0); // Red
            images[0].Opaque(MagickColor.FromRgb((byte)91, (byte)0, (byte)91), // Color to Change
                             MagickColor.FromRgb((byte)targetColorSix.R, (byte)targetColorSix.G, (byte)targetColorSix.B));

            var targetColorSeven = MagickColor.FromRgb((byte)85, (byte)0, (byte)0); // Red
            images[0].Opaque(MagickColor.FromRgb((byte)58, (byte)0, (byte)58), // Color to Change
                             MagickColor.FromRgb((byte)targetColorSeven.R, (byte)targetColorSeven.G, (byte)targetColorSeven.B));

            var targetColorEight = MagickColor.FromRgb((byte)38, (byte)0, (byte)0); // Red
            images[0].Opaque(MagickColor.FromRgb((byte)25, (byte)0, (byte)25), // Color to Change
                             MagickColor.FromRgb((byte)targetColorEight.R, (byte)targetColorEight.G, (byte)targetColorEight.B));

            // Save the image
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                images.Write(saveFileDialog.FileName);

                MessageBox.Show("The file was saved succesfully!");
            }
        }      
    }
}
