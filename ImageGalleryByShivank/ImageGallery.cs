using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Tile;
using C1.C1Pdf;
using System.Threading.Tasks;
using System.Threading;

// developed by Shivank Maheshwari
// dated: 24-06-2021


namespace ImageGalleryByShivank
{
    public partial class ImageGallery : Form
    {
        /// <summary>
        /// Represents Theme aware form.
        /// </summary>
        /// <remarks>TODO: if you need other theme, open this form in design-time mode and select different theme in the c1ThemeController component.</remarks>        
        public ImageGallery()
        {
            InitializeComponent();
            // dynamic UI Controls
            #region Dynamic UI Controls

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageGallery));
            C1.Win.C1Tile.PanelElement panelElement2 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement2 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement2 = new C1.Win.C1Tile.TextElement();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._searchBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            this._exportButton = new System.Windows.Forms.PictureBox();
            this._saveImage = new System.Windows.Forms.PictureBox();
            this._imageTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.c1PdfDocument1 = new C1.C1Pdf.C1PdfDocument();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._exportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._saveImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            this.ShowInTaskbar = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1ThemeController1.SetTheme(this.splitContainer1.Panel1, "(default)");
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this._exportButton);
            this.splitContainer1.Panel2.Controls.Add(this._saveImage);
            this.splitContainer1.Panel2.Controls.Add(this._imageTileControl);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1ThemeController1.SetTheme(this.splitContainer1.Panel2, "(default)");
            this.splitContainer1.Size = new System.Drawing.Size(764, 761);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.27495F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.59162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.22513F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.tableLayoutPanel1, "(default)");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(119, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 48);
            this.panel1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
            // 
            // _searchBox
            // 
            this._searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._searchBox.Location = new System.Drawing.Point(16, 9);
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(397, 18);
            this._searchBox.TabIndex = 0;
            this._searchBox.Text = "Enter some text to search images!";
            this.c1ThemeController1.SetTheme(this._searchBox, "(default)");
            this._searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchBoxKeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this._search);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Location = new System.Drawing.Point(557, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 6, 45, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 30);
            this.panel2.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.panel2, "(default)");
            // 
            // _search
            // 
            this._search.Dock = System.Windows.Forms.DockStyle.Left;
            this._search.Image = ((System.Drawing.Image)(resources.GetObject("searchImage")));
            this._search.Location = new System.Drawing.Point(0, 0);
            this._search.Margin = new System.Windows.Forms.Padding(0);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(80, 30);
            this._search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._search.TabIndex = 0;
            this._search.TabStop = false;
            this._search.Click += new System.EventHandler(this.OnSearchClick);
            // 
            // _exportButton
            // 
            this._exportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._exportButton.Image = ((System.Drawing.Image)(resources.GetObject("_exportButton.jpg")));
            this._exportButton.Location = new System.Drawing.Point(620, 50);
            this._exportButton.Name = "_exportButton";
            this._exportButton.Size = new System.Drawing.Size(50, 48);
            this._exportButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._exportButton.TabIndex = 4;
            this._exportButton.TabStop = false;
            this._exportButton.Visible = false;
            this._exportButton.Click += new System.EventHandler(this.OnClickExportButton);
            this._exportButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnExportImagePaint);
            // 
            // _saveImage
            // 
            this._saveImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._saveImage.Image = ((System.Drawing.Image)(resources.GetObject("_saveImage.jpg")));
            this._saveImage.Location = new System.Drawing.Point(700, 50);
            this._saveImage.Name = "_saveImage";
            this._saveImage.Size = new System.Drawing.Size(50, 48);
            this._saveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._saveImage.TabIndex = 3;
            this._saveImage.TabStop = false;
            this._saveImage.Visible = false;
            this._saveImage.Click += new System.EventHandler(this.OnClickSaveImagesButton);
            this._saveImage.Paint += new System.Windows.Forms.PaintEventHandler(this.OnSaveImagePaint);
            // 
            // _imageTileControl
            // 
            this._imageTileControl.AllowChecking = true;
            this._imageTileControl.AllowRearranging = true;
            this._imageTileControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._imageTileControl.CellHeight = 78;
            this._imageTileControl.CellSpacing = 11;
            this._imageTileControl.CellWidth = 78;
            this._imageTileControl.CheckBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this._imageTileControl.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this._imageTileControl.CheckWaitingColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            // 
            // 
            // 
            panelElement2.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement2.Children.Add(imageElement2);
            panelElement2.Children.Add(textElement2);
            panelElement2.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this._imageTileControl.DefaultTemplate.Elements.Add(panelElement2);
            this._imageTileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageTileControl.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this._imageTileControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._imageTileControl.GroupFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this._imageTileControl.GroupForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.HotBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this._imageTileControl.Location = new System.Drawing.Point(0, 0);
            this._imageTileControl.Name = "_imageTileControl";
            this._imageTileControl.Orientation = C1.Win.C1Tile.LayoutOrientation.Vertical;
            this._imageTileControl.SBThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this._imageTileControl.SBThumbInnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this._imageTileControl.Size = new System.Drawing.Size(764, 703);
            this._imageTileControl.SurfacePadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this._imageTileControl.TabIndex = 1;
            this._imageTileControl.TextSize = 15F;
            this.c1ThemeController1.SetTheme(this._imageTileControl, "(default)");
            this._imageTileControl.TileBackColor = System.Drawing.Color.White;
            this._imageTileControl.TileBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this._imageTileControl.TileForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this._imageTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this.OnTileChecked);
            this._imageTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this.OnTileUnchecked);
            this._imageTileControl.Paint += new System.Windows.Forms.PaintEventHandler(this.OnImageTileControlPaint);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightCoral;
            this.tile1.Name = "tile1";
            this.tile1.Text = "Tile 1";
            this.tile1.Visible = false;
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Name = "tile2";
            this.tile2.Text = "Tile 2";
            this.tile2.Visible = false;
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Name = "tile3";
            this.tile3.Text = "Tile 3";
            this.tile3.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(764, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.c1ThemeController1.SetTheme(this.statusStrip1, "(default)");
            this.statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // c1PdfDocument1
            // 
            this.c1PdfDocument1.DocumentInfo.Author = "";
            this.c1PdfDocument1.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.c1PdfDocument1.DocumentInfo.Creator = "";
            this.c1PdfDocument1.DocumentInfo.Keywords = "";
            this.c1PdfDocument1.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.c1PdfDocument1.DocumentInfo.Subject = "";
            this.c1PdfDocument1.DocumentInfo.Title = "";
            this.c1PdfDocument1.MaxHeaderBookmarkLevel = 0;
            this.c1PdfDocument1.PdfVersion = "1.3";
            this.c1PdfDocument1.RefDC = null;
            this.c1PdfDocument1.RotateAngle = 0F;
            this.c1PdfDocument1.UseFastTextOut = true;
            this.c1PdfDocument1.UseFontShaping = true;
            // 
            // ImageGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 761);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("cameraIcon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.MinimizeBox = false;
            this.Name = "ImageGallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery by Shivank";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._exportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._saveImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

            #endregion
            
            // displaying splash screen
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(4000);
                     
            // bringing our home screen to the top and displaying it to the user
            this.BringToFront();
            this.TopMost = true;
            this.Show();
            t.Abort();
        }
        // to start splash screen form
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        // data members
        C1PdfDocument imagePdfDocument = new C1PdfDocument();
        DataFetcher datafetch = new DataFetcher();
        List<ImageItem> imagesList;
        int checkedItems = 0;
        private void Panel1Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = _searchBox.Bounds;
            r.Inflate(3, 3);
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);

        }

        // method to be called when search image button is pressed
        private async void OnSearchClick(object sender, EventArgs e)
        {
            await Search();

        }

        // Helper Function to search and extract images using 
        // DataFetcher object
        private async Task Search()
        {
            statusStrip1.Visible = true;
            imagesList = await datafetch.GetImageData(_searchBox.Text);
           
            AddTiles(imagesList);
            statusStrip1.Visible = false;

            checkedItems = 0;
            _exportButton.Visible = false;
             _saveImage.Visible = false;
        }

        // method to add Images to tile control
        private void AddTiles(List<ImageItem> imageList)
        {
            _imageTileControl.Groups[0].Tiles.Clear();
            foreach (var imageitem in imageList)
            {
                Tile tile = new Tile();
                tile.HorizontalSize = 2;
                tile.VerticalSize = 2;
                _imageTileControl.Groups[0].Tiles.Add(tile);
                Image img = Image.FromStream(new
                MemoryStream(imageitem.Base64));
                Template tl = new Template();
                ImageElement ie = new ImageElement();
                ie.ImageLayout = ForeImageLayout.Stretch;
                tl.Elements.Add(ie);
                tile.Template = tl;
                tile.Image = img;
            }
        }

        // methods to keep a counter of how many tiles are selected
        private void OnTileChecked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            checkedItems++;
            _exportButton.Visible = true;
            _saveImage.Visible = true;
        }
        private void OnTileUnchecked(object sender, C1.Win.C1Tile.TileEventArgs e)  
        {
            if(checkedItems>0)
            checkedItems--;
            _exportButton.Visible = checkedItems > 0;
            _saveImage.Visible = checkedItems > 0;
        }
        // method to draw a seperator
        private void OnImageTileControlPaint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawLine(p, 0, 43, 800, 43);
        }

        // method to handle event when enter key is pressed
        private async void OnSearchBoxKeyDown(object sender, KeyEventArgs e)
        {
            // when pressed key is enter then search
            if (e.KeyCode == Keys.Enter)
            {
                await Search();
            }
        }
        
        // methods for save images functionality
        // method to be called when save images button will be pressed
        private void OnClickSaveImagesButton(object sender, EventArgs e)
        {
            List<Image> images1 = new List<Image>();
            foreach (Tile inner_tile1 in _imageTileControl.Groups[0].Tiles)//for each image save individually
            {
                if (inner_tile1.Checked)
                {
                    images1.Add(inner_tile1.Image);
                }
            }
            SaveFileDialog saveFile = new SaveFileDialog
            {
                DefaultExt = "jpg",
                Filter = "JPG files (*.jpg)|*.jpg*"
            };
            foreach (Image img in images1)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    img.Save(saveFile.FileName);
                }
            }
        }
        // method to draw/paint save image to panel
        private void OnSaveImagePaint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(_saveImage.Location.X,
            _saveImage.Location.Y, _saveImage.Width, _saveImage.Height);
            r.X -= 29;
            r.Y -= 3;
            r.Width--;
            r.Height--;
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0, 43), new
            Point(this.Width, 43));
        }

        // methods for export to pdf functionality
        // method to be called when export to pdf button will be pressed
        private void OnClickExportButton(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            foreach (Tile tile in _imageTileControl.Groups[0].Tiles)
            {
                if (tile.Checked)
                {
                    images.Add(tile.Image);
                }
            }
            ConvertToPdf(images);
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "pdf";
            saveFile.Filter = "PDF files (*.pdf)|*.pdf*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {

                imagePdfDocument.Save(saveFile.FileName);

            }
        }
        // method to convert images to pdf
        private void ConvertToPdf(List<Image> images)
        {
            RectangleF rect = imagePdfDocument.PageRectangle;
            bool firstPage = true;
            foreach (var selectedimg in images)
            {
                if (!firstPage)
                {
                    imagePdfDocument.NewPage();
                }
                firstPage = false;
                rect.Inflate(-72, -72);
                imagePdfDocument.DrawImage(selectedimg, rect);
            }

        }
        // method to draw/paint export image to panel
        private void OnExportImagePaint(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(_exportButton.Location.X,
               _exportButton.Location.Y, _exportButton.Width, _exportButton.Height);
            r.X -= 29;
            r.Y -= 3;
            r.Width--;
            r.Height--;
            Pen p = new Pen(Color.LightGray);
            e.Graphics.DrawRectangle(p, r);
            e.Graphics.DrawLine(p, new Point(0, 43), new
            Point(this.Width, 43));
        }
    }
}
