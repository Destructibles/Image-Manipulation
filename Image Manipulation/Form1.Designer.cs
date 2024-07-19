namespace Image_Manipulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            FileMenu_Open = new ToolStripMenuItem();
            FileMenu_Separator1 = new ToolStripSeparator();
            FileMenu_SaveAs = new ToolStripMenuItem();
            FileMenu_Separator2 = new ToolStripSeparator();
            FileMenu_Quit = new ToolStripMenuItem();
            ImageMenu = new ToolStripMenuItem();
            ImageMenu_DecreaseBrightness = new ToolStripMenuItem();
            ImageMenu_IncreaseBrightness = new ToolStripMenuItem();
            ImageMenu_Separator1 = new ToolStripSeparator();
            ImageMenu_Grayscale = new ToolStripMenuItem();
            ImageMenu_Negative = new ToolStripMenuItem();
            ImageMenu_Separator2 = new ToolStripSeparator();
            ImageMenu_Transform = new ToolStripMenuItem();
            ImageMenu_Transform_FlipHorizontally = new ToolStripMenuItem();
            ImageMenu_Transform_FlipVertically = new ToolStripMenuItem();
            ImageMenu_Transform_Separator1 = new ToolStripSeparator();
            ImageMenu_Transform_RotatePlus90 = new ToolStripMenuItem();
            ImageMenu_Transform_RotateMinus90 = new ToolStripMenuItem();
            animationToolStripMenuItem = new ToolStripMenuItem();
            AnimationMenu_CombineGIFFrames = new ToolStripMenuItem();
            AnimationMenu_ExportGIFFrames = new ToolStripMenuItem();
            AnimationMenu_ModifyGIFFrameDelay = new ToolStripMenuItem();
            AnimationMenu_ModifyGIFFrameDelay_Textbox = new ToolStripTextBox();
            AnimationMenu_ExportSpriteFromSpritesheet = new ToolStripMenuItem();
            AnimationMenu_ExportSpriteFromSpritesheet_Rows = new ToolStripMenuItem();
            AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox = new ToolStripTextBox();
            AnimationMenu_ExportSpriteFromSpritesheet_Columns = new ToolStripMenuItem();
            AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox = new ToolStripTextBox();
            AnimationMenu_ExportSpriteFromSpritesheet_Height = new ToolStripMenuItem();
            AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox = new ToolStripTextBox();
            AnimationMenu_ExportSpriteFromSpritesheet_Width = new ToolStripMenuItem();
            AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox = new ToolStripTextBox();
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing = new ToolStripMenuItem();
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox = new ToolStripTextBox();
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing = new ToolStripMenuItem();
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox = new ToolStripTextBox();
            ColorsMenu = new ToolStripMenuItem();
            ColorsMenu_FindAndReplaceColors = new ToolStripMenuItem();
            ViewPort = new PictureBox();
            ViewPortPanel = new Panel();
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewPort).BeginInit();
            ViewPortPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenu, ImageMenu, animationToolStripMenuItem, ColorsMenu });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(864, 24);
            MenuStrip.TabIndex = 10;
            MenuStrip.Text = "MenuStrip";
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { FileMenu_Open, FileMenu_Separator1, FileMenu_SaveAs, FileMenu_Separator2, FileMenu_Quit });
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(37, 20);
            FileMenu.Text = "File";
            // 
            // FileMenu_Open
            // 
            FileMenu_Open.Name = "FileMenu_Open";
            FileMenu_Open.ShortcutKeys = Keys.Control | Keys.O;
            FileMenu_Open.Size = new Size(186, 22);
            FileMenu_Open.Text = "Open";
            FileMenu_Open.Click += FileMenu_Open_Click;
            // 
            // FileMenu_Separator1
            // 
            FileMenu_Separator1.Name = "FileMenu_Separator1";
            FileMenu_Separator1.Size = new Size(183, 6);
            // 
            // FileMenu_SaveAs
            // 
            FileMenu_SaveAs.Name = "FileMenu_SaveAs";
            FileMenu_SaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            FileMenu_SaveAs.Size = new Size(186, 22);
            FileMenu_SaveAs.Text = "Save As";
            FileMenu_SaveAs.Click += FileMenu_SaveAs_Click;
            // 
            // FileMenu_Separator2
            // 
            FileMenu_Separator2.Name = "FileMenu_Separator2";
            FileMenu_Separator2.Size = new Size(183, 6);
            // 
            // FileMenu_Quit
            // 
            FileMenu_Quit.Name = "FileMenu_Quit";
            FileMenu_Quit.ShortcutKeys = Keys.Control | Keys.Q;
            FileMenu_Quit.Size = new Size(186, 22);
            FileMenu_Quit.Text = "Quit";
            FileMenu_Quit.Click += FileMenu_Quit_Click;
            // 
            // ImageMenu
            // 
            ImageMenu.DropDownItems.AddRange(new ToolStripItem[] { ImageMenu_DecreaseBrightness, ImageMenu_IncreaseBrightness, ImageMenu_Separator1, ImageMenu_Grayscale, ImageMenu_Negative, ImageMenu_Separator2, ImageMenu_Transform });
            ImageMenu.Name = "ImageMenu";
            ImageMenu.Size = new Size(52, 20);
            ImageMenu.Text = "Image";
            // 
            // ImageMenu_DecreaseBrightness
            // 
            ImageMenu_DecreaseBrightness.Name = "ImageMenu_DecreaseBrightness";
            ImageMenu_DecreaseBrightness.Size = new Size(179, 22);
            ImageMenu_DecreaseBrightness.Text = "Decrease Brightness";
            ImageMenu_DecreaseBrightness.Click += ImageMenu_DecreaseBrightness_Click;
            // 
            // ImageMenu_IncreaseBrightness
            // 
            ImageMenu_IncreaseBrightness.Name = "ImageMenu_IncreaseBrightness";
            ImageMenu_IncreaseBrightness.Size = new Size(179, 22);
            ImageMenu_IncreaseBrightness.Text = "Increase Brightness";
            ImageMenu_IncreaseBrightness.Click += ImageMenu_IncreaseBrightness_Click;
            // 
            // ImageMenu_Separator1
            // 
            ImageMenu_Separator1.Name = "ImageMenu_Separator1";
            ImageMenu_Separator1.Size = new Size(176, 6);
            // 
            // ImageMenu_Grayscale
            // 
            ImageMenu_Grayscale.Name = "ImageMenu_Grayscale";
            ImageMenu_Grayscale.Size = new Size(179, 22);
            ImageMenu_Grayscale.Text = "Grayscale";
            ImageMenu_Grayscale.Click += ImageMenu_Grayscale_Click;
            // 
            // ImageMenu_Negative
            // 
            ImageMenu_Negative.Name = "ImageMenu_Negative";
            ImageMenu_Negative.Size = new Size(179, 22);
            ImageMenu_Negative.Text = "Negative";
            ImageMenu_Negative.Click += ImageMenu_Negative_Click;
            // 
            // ImageMenu_Separator2
            // 
            ImageMenu_Separator2.Name = "ImageMenu_Separator2";
            ImageMenu_Separator2.Size = new Size(176, 6);
            // 
            // ImageMenu_Transform
            // 
            ImageMenu_Transform.DropDownItems.AddRange(new ToolStripItem[] { ImageMenu_Transform_FlipHorizontally, ImageMenu_Transform_FlipVertically, ImageMenu_Transform_Separator1, ImageMenu_Transform_RotatePlus90, ImageMenu_Transform_RotateMinus90 });
            ImageMenu_Transform.Name = "ImageMenu_Transform";
            ImageMenu_Transform.Size = new Size(179, 22);
            ImageMenu_Transform.Text = "Transform";
            // 
            // ImageMenu_Transform_FlipHorizontally
            // 
            ImageMenu_Transform_FlipHorizontally.Name = "ImageMenu_Transform_FlipHorizontally";
            ImageMenu_Transform_FlipHorizontally.Size = new Size(160, 22);
            ImageMenu_Transform_FlipHorizontally.Text = "Flip Horizontally";
            ImageMenu_Transform_FlipHorizontally.Click += ImageMenu_Transform_FlipHorizontally_Click;
            // 
            // ImageMenu_Transform_FlipVertically
            // 
            ImageMenu_Transform_FlipVertically.Name = "ImageMenu_Transform_FlipVertically";
            ImageMenu_Transform_FlipVertically.Size = new Size(160, 22);
            ImageMenu_Transform_FlipVertically.Text = "Flip Vertically";
            ImageMenu_Transform_FlipVertically.Click += ImageMenu_Transform_FlipVertically_Click;
            // 
            // ImageMenu_Transform_Separator1
            // 
            ImageMenu_Transform_Separator1.Name = "ImageMenu_Transform_Separator1";
            ImageMenu_Transform_Separator1.Size = new Size(157, 6);
            // 
            // ImageMenu_Transform_RotatePlus90
            // 
            ImageMenu_Transform_RotatePlus90.Name = "ImageMenu_Transform_RotatePlus90";
            ImageMenu_Transform_RotatePlus90.Size = new Size(160, 22);
            ImageMenu_Transform_RotatePlus90.Text = "Rotate +90°";
            ImageMenu_Transform_RotatePlus90.Click += ImageMenu_Transform_RotatePlus90_Click;
            // 
            // ImageMenu_Transform_RotateMinus90
            // 
            ImageMenu_Transform_RotateMinus90.Name = "ImageMenu_Transform_RotateMinus90";
            ImageMenu_Transform_RotateMinus90.Size = new Size(160, 22);
            ImageMenu_Transform_RotateMinus90.Text = "Rotate -90°";
            ImageMenu_Transform_RotateMinus90.Click += ImageMenu_Transform_RotateMinus90_Click;
            // 
            // animationToolStripMenuItem
            // 
            animationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_CombineGIFFrames, AnimationMenu_ExportGIFFrames, AnimationMenu_ModifyGIFFrameDelay, AnimationMenu_ExportSpriteFromSpritesheet });
            animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            animationToolStripMenuItem.Size = new Size(75, 20);
            animationToolStripMenuItem.Text = "Animation";
            // 
            // AnimationMenu_CombineGIFFrames
            // 
            AnimationMenu_CombineGIFFrames.Name = "AnimationMenu_CombineGIFFrames";
            AnimationMenu_CombineGIFFrames.Size = new Size(231, 22);
            AnimationMenu_CombineGIFFrames.Text = "Combine GIF Frames";
            AnimationMenu_CombineGIFFrames.Click += AnimationMenu_CombineGIFFrames_Click;
            // 
            // AnimationMenu_ExportGIFFrames
            // 
            AnimationMenu_ExportGIFFrames.Name = "AnimationMenu_ExportGIFFrames";
            AnimationMenu_ExportGIFFrames.Size = new Size(231, 22);
            AnimationMenu_ExportGIFFrames.Text = "Export GIF Frames";
            AnimationMenu_ExportGIFFrames.Click += AnimationMenu_ExportGIFFrames_Click;
            // 
            // AnimationMenu_ModifyGIFFrameDelay
            // 
            AnimationMenu_ModifyGIFFrameDelay.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ModifyGIFFrameDelay_Textbox });
            AnimationMenu_ModifyGIFFrameDelay.Name = "AnimationMenu_ModifyGIFFrameDelay";
            AnimationMenu_ModifyGIFFrameDelay.Size = new Size(231, 22);
            AnimationMenu_ModifyGIFFrameDelay.Text = "Modify GIF Frame Delay";
            // 
            // AnimationMenu_ModifyGIFFrameDelay_Textbox
            // 
            AnimationMenu_ModifyGIFFrameDelay_Textbox.Name = "AnimationMenu_ModifyGIFFrameDelay_Textbox";
            AnimationMenu_ModifyGIFFrameDelay_Textbox.Size = new Size(100, 23);
            AnimationMenu_ModifyGIFFrameDelay_Textbox.Text = "4";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet
            // 
            AnimationMenu_ExportSpriteFromSpritesheet.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ExportSpriteFromSpritesheet_Rows, AnimationMenu_ExportSpriteFromSpritesheet_Columns, AnimationMenu_ExportSpriteFromSpritesheet_Height, AnimationMenu_ExportSpriteFromSpritesheet_Width, AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing, AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing });
            AnimationMenu_ExportSpriteFromSpritesheet.Name = "AnimationMenu_ExportSpriteFromSpritesheet";
            AnimationMenu_ExportSpriteFromSpritesheet.Size = new Size(231, 22);
            AnimationMenu_ExportSpriteFromSpritesheet.Text = "Export Sprite from Spritesheet";
            AnimationMenu_ExportSpriteFromSpritesheet.Click += AnimationMenu_ExportSpriteFromSpritesheet_Click_1;
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_Rows
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_Rows.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox });
            AnimationMenu_ExportSpriteFromSpritesheet_Rows.Name = "AnimationMenu_ExportSpriteFromSpritesheet_Rows";
            AnimationMenu_ExportSpriteFromSpritesheet_Rows.Size = new Size(180, 22);
            AnimationMenu_ExportSpriteFromSpritesheet_Rows.Text = "Rows:";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox.Name = "AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox";
            AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox.Size = new Size(100, 23);
            AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox.Text = "1";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_Columns
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_Columns.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox });
            AnimationMenu_ExportSpriteFromSpritesheet_Columns.Name = "AnimationMenu_ExportSpriteFromSpritesheet_Columns";
            AnimationMenu_ExportSpriteFromSpritesheet_Columns.Size = new Size(180, 22);
            AnimationMenu_ExportSpriteFromSpritesheet_Columns.Text = "Columns:";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox.Name = "AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox";
            AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox.Size = new Size(100, 23);
            AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox.Text = "1";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_Height
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_Height.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox });
            AnimationMenu_ExportSpriteFromSpritesheet_Height.Name = "AnimationMenu_ExportSpriteFromSpritesheet_Height";
            AnimationMenu_ExportSpriteFromSpritesheet_Height.Size = new Size(180, 22);
            AnimationMenu_ExportSpriteFromSpritesheet_Height.Text = "Height:";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox.Name = "AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox";
            AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox.Size = new Size(100, 23);
            AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox.Text = "1";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_Width
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_Width.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox });
            AnimationMenu_ExportSpriteFromSpritesheet_Width.Name = "AnimationMenu_ExportSpriteFromSpritesheet_Width";
            AnimationMenu_ExportSpriteFromSpritesheet_Width.Size = new Size(180, 22);
            AnimationMenu_ExportSpriteFromSpritesheet_Width.Text = "Width:";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox.Name = "AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox";
            AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox.Size = new Size(100, 23);
            AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox.Text = "1";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox });
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing.Name = "AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing";
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing.Size = new Size(180, 22);
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing.Text = "Horizontal Spacing:";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox.Name = "AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox";
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox.Size = new Size(100, 23);
            AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox.Text = "1";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing.DropDownItems.AddRange(new ToolStripItem[] { AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox });
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing.Name = "AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing";
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing.Size = new Size(180, 22);
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing.Text = "Vertical Spacing:";
            // 
            // AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox
            // 
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox.Name = "AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox";
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox.Size = new Size(100, 23);
            AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox.Text = "1";
            // 
            // ColorsMenu
            // 
            ColorsMenu.DropDownItems.AddRange(new ToolStripItem[] { ColorsMenu_FindAndReplaceColors });
            ColorsMenu.Name = "ColorsMenu";
            ColorsMenu.Size = new Size(53, 20);
            ColorsMenu.Text = "Colors";
            // 
            // ColorsMenu_FindAndReplaceColors
            // 
            ColorsMenu_FindAndReplaceColors.Name = "ColorsMenu_FindAndReplaceColors";
            ColorsMenu_FindAndReplaceColors.Size = new Size(201, 22);
            ColorsMenu_FindAndReplaceColors.Text = "Find and Replace Colors";
            ColorsMenu_FindAndReplaceColors.Click += ColorsMenu_FindAndReplaceColors_Click;
            // 
            // ViewPort
            // 
            ViewPort.BackColor = Color.FromArgb(224, 224, 224);
            ViewPort.BackgroundImageLayout = ImageLayout.Center;
            ViewPort.BorderStyle = BorderStyle.FixedSingle;
            ViewPort.Location = new Point(3, 3);
            ViewPort.Name = "ViewPort";
            ViewPort.Size = new Size(840, 642);
            ViewPort.SizeMode = PictureBoxSizeMode.Zoom;
            ViewPort.TabIndex = 1;
            ViewPort.TabStop = false;
            // 
            // ViewPortPanel
            // 
            ViewPortPanel.AutoScroll = true;
            ViewPortPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ViewPortPanel.Controls.Add(ViewPort);
            ViewPortPanel.Location = new Point(12, 27);
            ViewPortPanel.Name = "ViewPortPanel";
            ViewPortPanel.Size = new Size(840, 642);
            ViewPortPanel.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 681);
            Controls.Add(ViewPortPanel);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Manipulation";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewPort).EndInit();
            ViewPortPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem FileMenu_Open;
        private ToolStripSeparator FileMenu_Separator1;
        private ToolStripMenuItem FileMenu_SaveAs;
        private ToolStripSeparator FileMenu_Separator2;
        private ToolStripMenuItem FileMenu_Quit;
        private ToolStripMenuItem ImageMenu;
        private ToolStripMenuItem ImageMenu_DecreaseBrightness;
        private ToolStripMenuItem ImageMenu_IncreaseBrightness;
        private ToolStripSeparator ImageMenu_Separator1;
        private ToolStripMenuItem ImageMenu_Grayscale;
        private ToolStripMenuItem ImageMenu_Negative;
        private ToolStripSeparator ImageMenu_Separator2;
        private ToolStripMenuItem ImageMenu_Transform;
        private ToolStripMenuItem animationToolStripMenuItem;
        private ToolStripMenuItem AnimationMenu_CombineGIFFrames;
        private ToolStripMenuItem AnimationMenu_ExportGIFFrames;
        private ToolStripMenuItem ColorsMenu;
        private ToolStripMenuItem AnimationMenu_ModifyGIFFrameDelay;
        private ToolStripTextBox AnimationMenu_ModifyGIFFrameDelay_Textbox;
        private ToolStripMenuItem AnimationMenu_ExportSpriteFromSpritesheet;
        private ToolStripMenuItem AnimationMenu_ExportSpriteFromSpritesheet_Rows;
        private ToolStripMenuItem AnimationMenu_ExportSpriteFromSpritesheet_Columns;
        private ToolStripMenuItem AnimationMenu_ExportSpriteFromSpritesheet_Height;
        private ToolStripMenuItem AnimationMenu_ExportSpriteFromSpritesheet_Width;
        private ToolStripTextBox AnimationMenu_ExportSpriteFromSpritesheet_RowsTextbox;
        private ToolStripTextBox AnimationMenu_ExportSpriteFromSpritesheet_ColumnsTextbox;
        private ToolStripTextBox AnimationMenu_ExportSpriteFromSpritesheet_HeightTextbox;
        private ToolStripTextBox AnimationMenu_ExportSpriteFromSpritesheet_WidthTextbox;
        private ToolStripMenuItem AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacing;
        private ToolStripTextBox AnimationMenu_ExportSpriteFromSpritesheet_HorizontalSpacingTextbox;
        private ToolStripMenuItem AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacing;
        private ToolStripTextBox AnimationMenu_ExportSpriteFromSpritesheet_VerticalSpacingTextbox;
        private ToolStripMenuItem ColorsMenu_FindAndReplaceColors;
        private PictureBox ViewPort;
        private ToolStripMenuItem ImageMenu_Transform_FlipHorizontally;
        private ToolStripMenuItem ImageMenu_Transform_FlipVertically;
        private ToolStripSeparator ImageMenu_Transform_Separator1;
        private ToolStripMenuItem ImageMenu_Transform_RotatePlus90;
        private ToolStripMenuItem ImageMenu_Transform_RotateMinus90;
        private Panel ViewPortPanel;
    }
}
