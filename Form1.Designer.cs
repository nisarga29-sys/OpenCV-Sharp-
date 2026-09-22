namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Shape = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shapee = new System.Windows.Forms.Label();
            this.Image_Browse = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.Widthcount = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.areacount = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.Heightcount = new System.Windows.Forms.Label();
            this.black_count = new System.Windows.Forms.Label();
            this.white_count = new System.Windows.Forms.Label();
            this.black_pixel = new System.Windows.Forms.Label();
            this.white = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.minheight = new System.Windows.Forms.TextBox();
            this.lblheight = new System.Windows.Forms.Label();
            this.maxwidth = new System.Windows.Forms.TextBox();
            this.minwidth = new System.Windows.Forms.TextBox();
            this.maxheight = new System.Windows.Forms.TextBox();
            this.lblwidth = new System.Windows.Forms.Label();
            this.pixelcount = new System.Windows.Forms.CheckBox();
            this.contour = new System.Windows.Forms.CheckBox();
            this.houghcircle = new System.Windows.Forms.CheckBox();
            this.templatematch = new System.Windows.Forms.CheckBox();
            this.gbContour = new System.Windows.Forms.GroupBox();
            this.tbAreamin = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.tbAreaMax = new System.Windows.Forms.TextBox();
            this.cbErode = new System.Windows.Forms.CheckBox();
            this.cbOpen = new System.Windows.Forms.CheckBox();
            this.cbClose = new System.Windows.Forms.CheckBox();
            this.cbGain = new System.Windows.Forms.CheckBox();
            this.cbLaplace = new System.Windows.Forms.CheckBox();
            this.cbthreshold = new System.Windows.Forms.CheckBox();
            this.cbDilate = new System.Windows.Forms.CheckBox();
            this.cbsobel = new System.Windows.Forms.CheckBox();
            this.cbcanny = new System.Windows.Forms.CheckBox();
            this.tpPerspectiveTransform = new System.Windows.Forms.TabPage();
            this.cbResize = new System.Windows.Forms.CheckBox();
            this.cbRotate = new System.Windows.Forms.CheckBox();
            this.cbFlip = new System.Windows.Forms.CheckBox();
            this.cbAffineTransform = new System.Windows.Forms.CheckBox();
            this.cbPerspectiveTransform = new System.Windows.Forms.CheckBox();
            this.cbWarp = new System.Windows.Forms.CheckBox();
            this.cbCrop = new System.Windows.Forms.CheckBox();
            this.tpEdgeDetection = new System.Windows.Forms.TabPage();
            this.cbScharr = new System.Windows.Forms.CheckBox();
            this.tpMorphologicalOperation = new System.Windows.Forms.TabPage();
            this.cbTopHat = new System.Windows.Forms.CheckBox();
            this.cbBlackHat = new System.Windows.Forms.CheckBox();
            this.cbHitorMiss = new System.Windows.Forms.CheckBox();
            this.cbGradient = new System.Windows.Forms.CheckBox();
            this.tpThreshold = new System.Windows.Forms.TabPage();
            this.cbThresholdOtsu = new System.Windows.Forms.CheckBox();
            this.cbThresholdAdaptive = new System.Windows.Forms.CheckBox();
            this.cbTriangle = new System.Windows.Forms.CheckBox();
            this.cbToZero = new System.Windows.Forms.CheckBox();
            this.cbTruncate = new System.Windows.Forms.CheckBox();
            this.tpFiltering = new System.Windows.Forms.TabPage();
            this.cbMedianBlur = new System.Windows.Forms.CheckBox();
            this.cbBilateralFilter = new System.Windows.Forms.CheckBox();
            this.cbGaussianBlur = new System.Windows.Forms.CheckBox();
            this.tpColorConversion = new System.Windows.Forms.TabPage();
            this.tbH2 = new System.Windows.Forms.TextBox();
            this.tbS2 = new System.Windows.Forms.TextBox();
            this.tbV2 = new System.Windows.Forms.TextBox();
            this.tbS = new System.Windows.Forms.TextBox();
            this.tbV = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.cbHistogramEquilization = new System.Windows.Forms.CheckBox();
            this.cbClahe = new System.Windows.Forms.CheckBox();
            this.cbLAB = new System.Windows.Forms.CheckBox();
            this.cbHSV = new System.Windows.Forms.CheckBox();
            this.cbgrayscale = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gbHoughCircle = new System.Windows.Forms.GroupBox();
            this.tbMinRadius = new System.Windows.Forms.TextBox();
            this.tbMaxRadius = new System.Windows.Forms.TextBox();
            this.lblMaxRadius = new System.Windows.Forms.Label();
            this.lblMinDist = new System.Windows.Forms.Label();
            this.lblMinRadius = new System.Windows.Forms.Label();
            this.lblParam1 = new System.Windows.Forms.Label();
            this.lblParam2 = new System.Windows.Forms.Label();
            this.tbDP = new System.Windows.Forms.TextBox();
            this.lblDP = new System.Windows.Forms.Label();
            this.tbParam1 = new System.Windows.Forms.TextBox();
            this.tbParam2 = new System.Windows.Forms.TextBox();
            this.tbMinDist = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpPixelCount = new System.Windows.Forms.TabPage();
            this.tpCountous = new System.Windows.Forms.TabPage();
            this.tpHoughCircle = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbConnectedComponents = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbMinEnclosing = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Result.SuspendLayout();
            this.gbContour.SuspendLayout();
            this.tpPerspectiveTransform.SuspendLayout();
            this.tpEdgeDetection.SuspendLayout();
            this.tpMorphologicalOperation.SuspendLayout();
            this.tpThreshold.SuspendLayout();
            this.tpFiltering.SuspendLayout();
            this.tpColorConversion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.gbHoughCircle.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpPixelCount.SuspendLayout();
            this.tpCountous.SuspendLayout();
            this.tpHoughCircle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1886, 115);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Right;
            this.logo.Location = new System.Drawing.Point(1771, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(115, 115);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(371, 34);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(699, 55);
            this.Header.TabIndex = 0;
            this.Header.Text = "VISION SYSTEM SOLUTIONS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(23, 155);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 418);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Browse.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Location = new System.Drawing.Point(112, 611);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(193, 47);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Folder Browse";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Previous
            // 
            this.Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.Location = new System.Drawing.Point(34, 612);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(58, 47);
            this.Previous.TabIndex = 3;
            this.Previous.Text = "<<";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(322, 612);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(62, 47);
            this.Next.TabIndex = 4;
            this.Next.Text = ">>";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Shape
            // 
            this.Shape.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Shape.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shape.Location = new System.Drawing.Point(460, 615);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(193, 47);
            this.Shape.TabIndex = 5;
            this.Shape.Text = "Test";
            this.Shape.UseVisualStyleBackColor = false;
            this.Shape.Click += new System.EventHandler(this.Shape_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(508, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(447, 418);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // shapee
            // 
            this.shapee.AutoSize = true;
            this.shapee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapee.Location = new System.Drawing.Point(203, 220);
            this.shapee.Name = "shapee";
            this.shapee.Size = new System.Drawing.Size(81, 19);
            this.shapee.TabIndex = 7;
            this.shapee.Text = "_________";
            // 
            // Image_Browse
            // 
            this.Image_Browse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Image_Browse.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image_Browse.Location = new System.Drawing.Point(762, 615);
            this.Image_Browse.Name = "Image_Browse";
            this.Image_Browse.Size = new System.Drawing.Size(193, 44);
            this.Image_Browse.TabIndex = 8;
            this.Image_Browse.Text = "Image Browse";
            this.Image_Browse.UseVisualStyleBackColor = false;
            this.Image_Browse.Click += new System.EventHandler(this.Image_Browse_Click);
            // 
            // Result
            // 
            this.Result.Controls.Add(this.label3);
            this.Result.Controls.Add(this.Width);
            this.Result.Controls.Add(this.Widthcount);
            this.Result.Controls.Add(this.shapee);
            this.Result.Controls.Add(this.area);
            this.Result.Controls.Add(this.areacount);
            this.Result.Controls.Add(this.Height);
            this.Result.Controls.Add(this.Heightcount);
            this.Result.Controls.Add(this.black_count);
            this.Result.Controls.Add(this.white_count);
            this.Result.Controls.Add(this.black_pixel);
            this.Result.Controls.Add(this.white);
            this.Result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(50, 38);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(573, 298);
            this.Result.TabIndex = 9;
            this.Result.TabStop = false;
            this.Result.Text = "Pixel Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Shape";
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(202, 183);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 22);
            this.Width.TabIndex = 9;
            this.Width.Text = "_________";
            this.Width.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Widthcount
            // 
            this.Widthcount.AutoSize = true;
            this.Widthcount.Location = new System.Drawing.Point(104, 183);
            this.Widthcount.Name = "Widthcount";
            this.Widthcount.Size = new System.Drawing.Size(60, 22);
            this.Widthcount.TabIndex = 8;
            this.Widthcount.Text = "Width";
            this.Widthcount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Location = new System.Drawing.Point(203, 118);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(100, 22);
            this.area.TabIndex = 7;
            this.area.Text = "_________";
            this.area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // areacount
            // 
            this.areacount.AutoSize = true;
            this.areacount.Location = new System.Drawing.Point(104, 118);
            this.areacount.Name = "areacount";
            this.areacount.Size = new System.Drawing.Size(50, 22);
            this.areacount.TabIndex = 6;
            this.areacount.Text = "Area";
            this.areacount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(203, 149);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 22);
            this.Height.TabIndex = 5;
            this.Height.Text = "_________";
            this.Height.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Heightcount
            // 
            this.Heightcount.AutoSize = true;
            this.Heightcount.Location = new System.Drawing.Point(103, 149);
            this.Heightcount.Name = "Heightcount";
            this.Heightcount.Size = new System.Drawing.Size(64, 22);
            this.Heightcount.TabIndex = 4;
            this.Heightcount.Text = "Height";
            this.Heightcount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // black_count
            // 
            this.black_count.AutoSize = true;
            this.black_count.Location = new System.Drawing.Point(202, 78);
            this.black_count.Name = "black_count";
            this.black_count.Size = new System.Drawing.Size(100, 22);
            this.black_count.TabIndex = 3;
            this.black_count.Text = "_________";
            // 
            // white_count
            // 
            this.white_count.AutoSize = true;
            this.white_count.Location = new System.Drawing.Point(202, 33);
            this.white_count.Name = "white_count";
            this.white_count.Size = new System.Drawing.Size(100, 22);
            this.white_count.TabIndex = 2;
            this.white_count.Text = "_________";
            // 
            // black_pixel
            // 
            this.black_pixel.AutoSize = true;
            this.black_pixel.Location = new System.Drawing.Point(26, 78);
            this.black_pixel.Name = "black_pixel";
            this.black_pixel.Size = new System.Drawing.Size(158, 22);
            this.black_pixel.TabIndex = 1;
            this.black_pixel.Text = "Black Pixel Count";
            // 
            // white
            // 
            this.white.AutoSize = true;
            this.white.Location = new System.Drawing.Point(26, 33);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(159, 22);
            this.white.TabIndex = 0;
            this.white.Text = "White Pixel Count";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1773, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // minheight
            // 
            this.minheight.Location = new System.Drawing.Point(28, 61);
            this.minheight.Name = "minheight";
            this.minheight.Size = new System.Drawing.Size(100, 29);
            this.minheight.TabIndex = 14;
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.Location = new System.Drawing.Point(126, 23);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(54, 19);
            this.lblheight.TabIndex = 15;
            this.lblheight.Text = "Height";
            // 
            // maxwidth
            // 
            this.maxwidth.Location = new System.Drawing.Point(170, 161);
            this.maxwidth.Name = "maxwidth";
            this.maxwidth.Size = new System.Drawing.Size(100, 29);
            this.maxwidth.TabIndex = 16;
            // 
            // minwidth
            // 
            this.minwidth.Location = new System.Drawing.Point(28, 161);
            this.minwidth.Name = "minwidth";
            this.minwidth.Size = new System.Drawing.Size(100, 29);
            this.minwidth.TabIndex = 17;
            // 
            // maxheight
            // 
            this.maxheight.Location = new System.Drawing.Point(169, 61);
            this.maxheight.Name = "maxheight";
            this.maxheight.Size = new System.Drawing.Size(100, 29);
            this.maxheight.TabIndex = 18;
            // 
            // lblwidth
            // 
            this.lblwidth.AutoSize = true;
            this.lblwidth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwidth.Location = new System.Drawing.Point(126, 114);
            this.lblwidth.Name = "lblwidth";
            this.lblwidth.Size = new System.Drawing.Size(49, 19);
            this.lblwidth.TabIndex = 19;
            this.lblwidth.Text = "Width";
            // 
            // pixelcount
            // 
            this.pixelcount.AutoSize = true;
            this.pixelcount.Location = new System.Drawing.Point(707, 712);
            this.pixelcount.Name = "pixelcount";
            this.pixelcount.Size = new System.Drawing.Size(79, 17);
            this.pixelcount.TabIndex = 20;
            this.pixelcount.Text = "Pixel Count";
            this.pixelcount.UseVisualStyleBackColor = true;
            // 
            // contour
            // 
            this.contour.AutoSize = true;
            this.contour.Location = new System.Drawing.Point(707, 762);
            this.contour.Name = "contour";
            this.contour.Size = new System.Drawing.Size(74, 17);
            this.contour.TabIndex = 21;
            this.contour.Text = "Countours";
            this.contour.UseVisualStyleBackColor = true;
            // 
            // houghcircle
            // 
            this.houghcircle.AutoSize = true;
            this.houghcircle.Location = new System.Drawing.Point(460, 758);
            this.houghcircle.Name = "houghcircle";
            this.houghcircle.Size = new System.Drawing.Size(87, 17);
            this.houghcircle.TabIndex = 22;
            this.houghcircle.Text = "Hough Circle";
            this.houghcircle.UseVisualStyleBackColor = true;
            // 
            // templatematch
            // 
            this.templatematch.AutoSize = true;
            this.templatematch.Location = new System.Drawing.Point(707, 805);
            this.templatematch.Name = "templatematch";
            this.templatematch.Size = new System.Drawing.Size(103, 17);
            this.templatematch.TabIndex = 23;
            this.templatematch.Text = "Template Match";
            this.templatematch.UseVisualStyleBackColor = true;
            this.templatematch.CheckedChanged += new System.EventHandler(this.templatematch_CheckedChanged);
            // 
            // gbContour
            // 
            this.gbContour.Controls.Add(this.tbAreamin);
            this.gbContour.Controls.Add(this.lblArea);
            this.gbContour.Controls.Add(this.tbAreaMax);
            this.gbContour.Controls.Add(this.lblwidth);
            this.gbContour.Controls.Add(this.minheight);
            this.gbContour.Controls.Add(this.lblheight);
            this.gbContour.Controls.Add(this.maxwidth);
            this.gbContour.Controls.Add(this.minwidth);
            this.gbContour.Controls.Add(this.maxheight);
            this.gbContour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContour.Location = new System.Drawing.Point(39, 16);
            this.gbContour.Name = "gbContour";
            this.gbContour.Size = new System.Drawing.Size(635, 311);
            this.gbContour.TabIndex = 26;
            this.gbContour.TabStop = false;
            this.gbContour.Text = "Contour ";
            // 
            // tbAreamin
            // 
            this.tbAreamin.Location = new System.Drawing.Point(34, 250);
            this.tbAreamin.Name = "tbAreamin";
            this.tbAreamin.Size = new System.Drawing.Size(100, 29);
            this.tbAreamin.TabIndex = 20;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(132, 212);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 19);
            this.lblArea.TabIndex = 21;
            this.lblArea.Text = "Area";
            // 
            // tbAreaMax
            // 
            this.tbAreaMax.Location = new System.Drawing.Point(175, 250);
            this.tbAreaMax.Name = "tbAreaMax";
            this.tbAreaMax.Size = new System.Drawing.Size(100, 29);
            this.tbAreaMax.TabIndex = 22;
            // 
            // cbErode
            // 
            this.cbErode.AutoSize = true;
            this.cbErode.Location = new System.Drawing.Point(39, 319);
            this.cbErode.Name = "cbErode";
            this.cbErode.Size = new System.Drawing.Size(74, 25);
            this.cbErode.TabIndex = 43;
            this.cbErode.Text = "Erode";
            this.cbErode.UseVisualStyleBackColor = true;
            this.cbErode.CheckedChanged += new System.EventHandler(this.cbErode_CheckedChanged);
            // 
            // cbOpen
            // 
            this.cbOpen.AutoSize = true;
            this.cbOpen.Location = new System.Drawing.Point(220, 39);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(70, 25);
            this.cbOpen.TabIndex = 42;
            this.cbOpen.Text = "Open";
            this.cbOpen.UseVisualStyleBackColor = true;
            this.cbOpen.CheckedChanged += new System.EventHandler(this.cbOpen_CheckedChanged);
            // 
            // cbClose
            // 
            this.cbClose.AutoSize = true;
            this.cbClose.Location = new System.Drawing.Point(218, 95);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(72, 25);
            this.cbClose.TabIndex = 41;
            this.cbClose.Text = "Close";
            this.cbClose.UseVisualStyleBackColor = true;
            this.cbClose.CheckedChanged += new System.EventHandler(this.cbClose_CheckedChanged);
            // 
            // cbGain
            // 
            this.cbGain.AutoSize = true;
            this.cbGain.Location = new System.Drawing.Point(47, 35);
            this.cbGain.Name = "cbGain";
            this.cbGain.Size = new System.Drawing.Size(64, 25);
            this.cbGain.TabIndex = 40;
            this.cbGain.Text = "Gain";
            this.cbGain.UseVisualStyleBackColor = true;
            this.cbGain.CheckedChanged += new System.EventHandler(this.cbGain_CheckedChanged);
            // 
            // cbLaplace
            // 
            this.cbLaplace.AutoSize = true;
            this.cbLaplace.Location = new System.Drawing.Point(32, 187);
            this.cbLaplace.Name = "cbLaplace";
            this.cbLaplace.Size = new System.Drawing.Size(100, 25);
            this.cbLaplace.TabIndex = 38;
            this.cbLaplace.Text = "Laplacian";
            this.cbLaplace.UseVisualStyleBackColor = true;
            this.cbLaplace.CheckedChanged += new System.EventHandler(this.cbLaplace_CheckedChanged);
            // 
            // cbthreshold
            // 
            this.cbthreshold.AutoSize = true;
            this.cbthreshold.Location = new System.Drawing.Point(26, 36);
            this.cbthreshold.Name = "cbthreshold";
            this.cbthreshold.Size = new System.Drawing.Size(105, 25);
            this.cbthreshold.TabIndex = 34;
            this.cbthreshold.Text = "Threshold";
            this.cbthreshold.UseVisualStyleBackColor = true;
            this.cbthreshold.CheckedChanged += new System.EventHandler(this.cbthreshold_CheckedChanged);
            // 
            // cbDilate
            // 
            this.cbDilate.AutoSize = true;
            this.cbDilate.Location = new System.Drawing.Point(39, 263);
            this.cbDilate.Name = "cbDilate";
            this.cbDilate.Size = new System.Drawing.Size(71, 25);
            this.cbDilate.TabIndex = 37;
            this.cbDilate.Text = "Dilate";
            this.cbDilate.UseVisualStyleBackColor = true;
            this.cbDilate.CheckedChanged += new System.EventHandler(this.cbDilate_CheckedChanged);
            // 
            // cbsobel
            // 
            this.cbsobel.AutoSize = true;
            this.cbsobel.Location = new System.Drawing.Point(32, 53);
            this.cbsobel.Name = "cbsobel";
            this.cbsobel.Size = new System.Drawing.Size(72, 25);
            this.cbsobel.TabIndex = 35;
            this.cbsobel.Text = "Sobel";
            this.cbsobel.UseVisualStyleBackColor = true;
            this.cbsobel.CheckedChanged += new System.EventHandler(this.cbsobel_CheckedChanged);
            // 
            // cbcanny
            // 
            this.cbcanny.AutoSize = true;
            this.cbcanny.Location = new System.Drawing.Point(29, 120);
            this.cbcanny.Name = "cbcanny";
            this.cbcanny.Size = new System.Drawing.Size(77, 25);
            this.cbcanny.TabIndex = 36;
            this.cbcanny.Text = "Canny";
            this.cbcanny.UseVisualStyleBackColor = true;
            this.cbcanny.CheckedChanged += new System.EventHandler(this.cbcanny_CheckedChanged);
            // 
            // tpPerspectiveTransform
            // 
            this.tpPerspectiveTransform.BackColor = System.Drawing.Color.DarkGray;
            this.tpPerspectiveTransform.Controls.Add(this.cbResize);
            this.tpPerspectiveTransform.Controls.Add(this.cbRotate);
            this.tpPerspectiveTransform.Controls.Add(this.cbFlip);
            this.tpPerspectiveTransform.Controls.Add(this.cbAffineTransform);
            this.tpPerspectiveTransform.Controls.Add(this.cbPerspectiveTransform);
            this.tpPerspectiveTransform.Controls.Add(this.cbWarp);
            this.tpPerspectiveTransform.Controls.Add(this.cbCrop);
            this.tpPerspectiveTransform.Location = new System.Drawing.Point(4, 30);
            this.tpPerspectiveTransform.Name = "tpPerspectiveTransform";
            this.tpPerspectiveTransform.Padding = new System.Windows.Forms.Padding(3);
            this.tpPerspectiveTransform.Size = new System.Drawing.Size(728, 387);
            this.tpPerspectiveTransform.TabIndex = 5;
            this.tpPerspectiveTransform.Text = "Perspective Transform";
            // 
            // cbResize
            // 
            this.cbResize.AutoSize = true;
            this.cbResize.Location = new System.Drawing.Point(42, 44);
            this.cbResize.Name = "cbResize";
            this.cbResize.Size = new System.Drawing.Size(78, 25);
            this.cbResize.TabIndex = 27;
            this.cbResize.Text = "Resize";
            this.cbResize.UseVisualStyleBackColor = true;
            this.cbResize.CheckedChanged += new System.EventHandler(this.cbResize_CheckedChanged);
            // 
            // cbRotate
            // 
            this.cbRotate.AutoSize = true;
            this.cbRotate.Location = new System.Drawing.Point(42, 92);
            this.cbRotate.Name = "cbRotate";
            this.cbRotate.Size = new System.Drawing.Size(78, 25);
            this.cbRotate.TabIndex = 26;
            this.cbRotate.Text = "Rotate";
            this.cbRotate.UseVisualStyleBackColor = true;
            this.cbRotate.CheckedChanged += new System.EventHandler(this.cbRotate_CheckedChanged);
            // 
            // cbFlip
            // 
            this.cbFlip.AutoSize = true;
            this.cbFlip.Location = new System.Drawing.Point(42, 188);
            this.cbFlip.Name = "cbFlip";
            this.cbFlip.Size = new System.Drawing.Size(58, 25);
            this.cbFlip.TabIndex = 25;
            this.cbFlip.Text = "Flip";
            this.cbFlip.UseVisualStyleBackColor = true;
            this.cbFlip.CheckedChanged += new System.EventHandler(this.cbFlip_CheckedChanged);
            // 
            // cbAffineTransform
            // 
            this.cbAffineTransform.AutoSize = true;
            this.cbAffineTransform.Location = new System.Drawing.Point(42, 332);
            this.cbAffineTransform.Name = "cbAffineTransform";
            this.cbAffineTransform.Size = new System.Drawing.Size(158, 25);
            this.cbAffineTransform.TabIndex = 24;
            this.cbAffineTransform.Text = "Affine Transform";
            this.cbAffineTransform.UseVisualStyleBackColor = true;
            this.cbAffineTransform.CheckedChanged += new System.EventHandler(this.cbAffineTransform_CheckedChanged);
            // 
            // cbPerspectiveTransform
            // 
            this.cbPerspectiveTransform.AutoSize = true;
            this.cbPerspectiveTransform.Location = new System.Drawing.Point(42, 284);
            this.cbPerspectiveTransform.Name = "cbPerspectiveTransform";
            this.cbPerspectiveTransform.Size = new System.Drawing.Size(198, 25);
            this.cbPerspectiveTransform.TabIndex = 23;
            this.cbPerspectiveTransform.Text = "Perspective Transform";
            this.cbPerspectiveTransform.UseVisualStyleBackColor = true;
            this.cbPerspectiveTransform.CheckedChanged += new System.EventHandler(this.cbPerspectiveTransform_CheckedChanged);
            // 
            // cbWarp
            // 
            this.cbWarp.AutoSize = true;
            this.cbWarp.Location = new System.Drawing.Point(42, 140);
            this.cbWarp.Name = "cbWarp";
            this.cbWarp.Size = new System.Drawing.Size(69, 25);
            this.cbWarp.TabIndex = 22;
            this.cbWarp.Text = "Warp";
            this.cbWarp.UseVisualStyleBackColor = true;
            this.cbWarp.CheckedChanged += new System.EventHandler(this.cbWarp_CheckedChanged);
            // 
            // cbCrop
            // 
            this.cbCrop.AutoSize = true;
            this.cbCrop.Location = new System.Drawing.Point(42, 236);
            this.cbCrop.Name = "cbCrop";
            this.cbCrop.Size = new System.Drawing.Size(68, 25);
            this.cbCrop.TabIndex = 21;
            this.cbCrop.Text = "Crop";
            this.cbCrop.UseVisualStyleBackColor = true;
            this.cbCrop.CheckedChanged += new System.EventHandler(this.cbCrop_CheckedChanged);
            // 
            // tpEdgeDetection
            // 
            this.tpEdgeDetection.BackColor = System.Drawing.Color.DarkGray;
            this.tpEdgeDetection.Controls.Add(this.cbScharr);
            this.tpEdgeDetection.Controls.Add(this.cbsobel);
            this.tpEdgeDetection.Controls.Add(this.cbcanny);
            this.tpEdgeDetection.Controls.Add(this.cbLaplace);
            this.tpEdgeDetection.Location = new System.Drawing.Point(4, 30);
            this.tpEdgeDetection.Name = "tpEdgeDetection";
            this.tpEdgeDetection.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdgeDetection.Size = new System.Drawing.Size(728, 387);
            this.tpEdgeDetection.TabIndex = 4;
            this.tpEdgeDetection.Text = "Edge Detection";
            // 
            // cbScharr
            // 
            this.cbScharr.AutoSize = true;
            this.cbScharr.Location = new System.Drawing.Point(32, 254);
            this.cbScharr.Name = "cbScharr";
            this.cbScharr.Size = new System.Drawing.Size(78, 25);
            this.cbScharr.TabIndex = 39;
            this.cbScharr.Text = "Scharr";
            this.cbScharr.UseVisualStyleBackColor = true;
            this.cbScharr.CheckedChanged += new System.EventHandler(this.cbScharr_CheckedChanged);
            // 
            // tpMorphologicalOperation
            // 
            this.tpMorphologicalOperation.BackColor = System.Drawing.Color.DarkGray;
            this.tpMorphologicalOperation.Controls.Add(this.cbTopHat);
            this.tpMorphologicalOperation.Controls.Add(this.cbBlackHat);
            this.tpMorphologicalOperation.Controls.Add(this.cbHitorMiss);
            this.tpMorphologicalOperation.Controls.Add(this.cbGradient);
            this.tpMorphologicalOperation.Controls.Add(this.cbDilate);
            this.tpMorphologicalOperation.Controls.Add(this.cbErode);
            this.tpMorphologicalOperation.Controls.Add(this.cbClose);
            this.tpMorphologicalOperation.Controls.Add(this.cbOpen);
            this.tpMorphologicalOperation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMorphologicalOperation.ForeColor = System.Drawing.Color.Black;
            this.tpMorphologicalOperation.Location = new System.Drawing.Point(4, 30);
            this.tpMorphologicalOperation.Name = "tpMorphologicalOperation";
            this.tpMorphologicalOperation.Padding = new System.Windows.Forms.Padding(3);
            this.tpMorphologicalOperation.Size = new System.Drawing.Size(728, 387);
            this.tpMorphologicalOperation.TabIndex = 3;
            this.tpMorphologicalOperation.Text = "Morphological Operations";
            this.tpMorphologicalOperation.Click += new System.EventHandler(this.tpMorphologicalOperation_Click);
            // 
            // cbTopHat
            // 
            this.cbTopHat.AutoSize = true;
            this.cbTopHat.Location = new System.Drawing.Point(39, 95);
            this.cbTopHat.Name = "cbTopHat";
            this.cbTopHat.Size = new System.Drawing.Size(91, 25);
            this.cbTopHat.TabIndex = 47;
            this.cbTopHat.Text = "Top Hat";
            this.cbTopHat.UseVisualStyleBackColor = true;
            this.cbTopHat.CheckedChanged += new System.EventHandler(this.cbTopHat_CheckedChanged);
            // 
            // cbBlackHat
            // 
            this.cbBlackHat.AutoSize = true;
            this.cbBlackHat.Location = new System.Drawing.Point(39, 151);
            this.cbBlackHat.Name = "cbBlackHat";
            this.cbBlackHat.Size = new System.Drawing.Size(102, 25);
            this.cbBlackHat.TabIndex = 46;
            this.cbBlackHat.Text = "Black Hat";
            this.cbBlackHat.UseVisualStyleBackColor = true;
            this.cbBlackHat.CheckedChanged += new System.EventHandler(this.cbBlackHat_CheckedChanged);
            // 
            // cbHitorMiss
            // 
            this.cbHitorMiss.AutoSize = true;
            this.cbHitorMiss.Location = new System.Drawing.Point(39, 207);
            this.cbHitorMiss.Name = "cbHitorMiss";
            this.cbHitorMiss.Size = new System.Drawing.Size(115, 25);
            this.cbHitorMiss.TabIndex = 45;
            this.cbHitorMiss.Text = "Hit-or-Miss";
            this.cbHitorMiss.UseVisualStyleBackColor = true;
            this.cbHitorMiss.CheckedChanged += new System.EventHandler(this.cbHitorMiss_CheckedChanged);
            // 
            // cbGradient
            // 
            this.cbGradient.AutoSize = true;
            this.cbGradient.Location = new System.Drawing.Point(39, 39);
            this.cbGradient.Name = "cbGradient";
            this.cbGradient.Size = new System.Drawing.Size(93, 25);
            this.cbGradient.TabIndex = 44;
            this.cbGradient.Text = "Gradient";
            this.cbGradient.UseVisualStyleBackColor = true;
            this.cbGradient.CheckedChanged += new System.EventHandler(this.cbGradient_CheckedChanged);
            // 
            // tpThreshold
            // 
            this.tpThreshold.BackColor = System.Drawing.Color.DarkGray;
            this.tpThreshold.Controls.Add(this.cbThresholdOtsu);
            this.tpThreshold.Controls.Add(this.cbThresholdAdaptive);
            this.tpThreshold.Controls.Add(this.cbTriangle);
            this.tpThreshold.Controls.Add(this.cbToZero);
            this.tpThreshold.Controls.Add(this.cbTruncate);
            this.tpThreshold.Controls.Add(this.cbthreshold);
            this.tpThreshold.Location = new System.Drawing.Point(4, 30);
            this.tpThreshold.Name = "tpThreshold";
            this.tpThreshold.Padding = new System.Windows.Forms.Padding(3);
            this.tpThreshold.Size = new System.Drawing.Size(728, 387);
            this.tpThreshold.TabIndex = 2;
            this.tpThreshold.Text = "Threshold";
            // 
            // cbThresholdOtsu
            // 
            this.cbThresholdOtsu.AutoSize = true;
            this.cbThresholdOtsu.Location = new System.Drawing.Point(26, 81);
            this.cbThresholdOtsu.Name = "cbThresholdOtsu";
            this.cbThresholdOtsu.Size = new System.Drawing.Size(146, 25);
            this.cbThresholdOtsu.TabIndex = 39;
            this.cbThresholdOtsu.Text = "Threshold Otsu";
            this.cbThresholdOtsu.UseVisualStyleBackColor = true;
            this.cbThresholdOtsu.CheckedChanged += new System.EventHandler(this.cbThresholdOtsu_CheckedChanged);
            // 
            // cbThresholdAdaptive
            // 
            this.cbThresholdAdaptive.AutoSize = true;
            this.cbThresholdAdaptive.Location = new System.Drawing.Point(26, 128);
            this.cbThresholdAdaptive.Name = "cbThresholdAdaptive";
            this.cbThresholdAdaptive.Size = new System.Drawing.Size(176, 25);
            this.cbThresholdAdaptive.TabIndex = 38;
            this.cbThresholdAdaptive.Text = "Threshold Adaptive";
            this.cbThresholdAdaptive.UseVisualStyleBackColor = true;
            this.cbThresholdAdaptive.CheckedChanged += new System.EventHandler(this.cbThresholdAdaptive_CheckedChanged);
            // 
            // cbTriangle
            // 
            this.cbTriangle.AutoSize = true;
            this.cbTriangle.Location = new System.Drawing.Point(26, 184);
            this.cbTriangle.Name = "cbTriangle";
            this.cbTriangle.Size = new System.Drawing.Size(169, 25);
            this.cbTriangle.TabIndex = 37;
            this.cbTriangle.Text = "Triangle Threshold";
            this.cbTriangle.UseVisualStyleBackColor = true;
            this.cbTriangle.CheckedChanged += new System.EventHandler(this.cbTriangle_CheckedChanged);
            // 
            // cbToZero
            // 
            this.cbToZero.AutoSize = true;
            this.cbToZero.Location = new System.Drawing.Point(26, 234);
            this.cbToZero.Name = "cbToZero";
            this.cbToZero.Size = new System.Drawing.Size(85, 25);
            this.cbToZero.TabIndex = 36;
            this.cbToZero.Text = "ToZero";
            this.cbToZero.UseVisualStyleBackColor = true;
            this.cbToZero.CheckedChanged += new System.EventHandler(this.cbToZero_CheckedChanged);
            // 
            // cbTruncate
            // 
            this.cbTruncate.AutoSize = true;
            this.cbTruncate.Location = new System.Drawing.Point(26, 291);
            this.cbTruncate.Name = "cbTruncate";
            this.cbTruncate.Size = new System.Drawing.Size(94, 25);
            this.cbTruncate.TabIndex = 35;
            this.cbTruncate.Text = "Truncate";
            this.cbTruncate.UseVisualStyleBackColor = true;
            this.cbTruncate.CheckedChanged += new System.EventHandler(this.cbTruncate_CheckedChanged);
            // 
            // tpFiltering
            // 
            this.tpFiltering.BackColor = System.Drawing.Color.DarkGray;
            this.tpFiltering.Controls.Add(this.cbMedianBlur);
            this.tpFiltering.Controls.Add(this.cbBilateralFilter);
            this.tpFiltering.Controls.Add(this.cbGaussianBlur);
            this.tpFiltering.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpFiltering.Location = new System.Drawing.Point(4, 30);
            this.tpFiltering.Name = "tpFiltering";
            this.tpFiltering.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiltering.Size = new System.Drawing.Size(728, 387);
            this.tpFiltering.TabIndex = 1;
            this.tpFiltering.Text = "Filtering";
            // 
            // cbMedianBlur
            // 
            this.cbMedianBlur.AutoSize = true;
            this.cbMedianBlur.Location = new System.Drawing.Point(47, 113);
            this.cbMedianBlur.Name = "cbMedianBlur";
            this.cbMedianBlur.Size = new System.Drawing.Size(120, 25);
            this.cbMedianBlur.TabIndex = 4;
            this.cbMedianBlur.Text = "Median Blur";
            this.cbMedianBlur.UseVisualStyleBackColor = true;
            this.cbMedianBlur.CheckedChanged += new System.EventHandler(this.cbMedianBlur_CheckedChanged);
            // 
            // cbBilateralFilter
            // 
            this.cbBilateralFilter.AutoSize = true;
            this.cbBilateralFilter.Location = new System.Drawing.Point(47, 176);
            this.cbBilateralFilter.Name = "cbBilateralFilter";
            this.cbBilateralFilter.Size = new System.Drawing.Size(131, 25);
            this.cbBilateralFilter.TabIndex = 3;
            this.cbBilateralFilter.Text = "Bilateral Filter";
            this.cbBilateralFilter.UseVisualStyleBackColor = true;
            this.cbBilateralFilter.CheckedChanged += new System.EventHandler(this.cbBilateralFilter_CheckedChanged);
            // 
            // cbGaussianBlur
            // 
            this.cbGaussianBlur.AutoSize = true;
            this.cbGaussianBlur.Location = new System.Drawing.Point(47, 53);
            this.cbGaussianBlur.Name = "cbGaussianBlur";
            this.cbGaussianBlur.Size = new System.Drawing.Size(133, 25);
            this.cbGaussianBlur.TabIndex = 0;
            this.cbGaussianBlur.Text = "Gaussian Blur";
            this.cbGaussianBlur.UseVisualStyleBackColor = true;
            this.cbGaussianBlur.CheckedChanged += new System.EventHandler(this.cbGaussianBlur_CheckedChanged);
            // 
            // tpColorConversion
            // 
            this.tpColorConversion.BackColor = System.Drawing.Color.DarkGray;
            this.tpColorConversion.Controls.Add(this.tbH2);
            this.tpColorConversion.Controls.Add(this.tbS2);
            this.tpColorConversion.Controls.Add(this.tbV2);
            this.tpColorConversion.Controls.Add(this.tbS);
            this.tpColorConversion.Controls.Add(this.tbV);
            this.tpColorConversion.Controls.Add(this.tbH);
            this.tpColorConversion.Controls.Add(this.lblLower);
            this.tpColorConversion.Controls.Add(this.lblUpper);
            this.tpColorConversion.Controls.Add(this.cbHistogramEquilization);
            this.tpColorConversion.Controls.Add(this.cbClahe);
            this.tpColorConversion.Controls.Add(this.cbLAB);
            this.tpColorConversion.Controls.Add(this.cbHSV);
            this.tpColorConversion.Controls.Add(this.cbgrayscale);
            this.tpColorConversion.Controls.Add(this.cbGain);
            this.tpColorConversion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpColorConversion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpColorConversion.Location = new System.Drawing.Point(4, 30);
            this.tpColorConversion.Name = "tpColorConversion";
            this.tpColorConversion.Padding = new System.Windows.Forms.Padding(3);
            this.tpColorConversion.Size = new System.Drawing.Size(728, 387);
            this.tpColorConversion.TabIndex = 0;
            this.tpColorConversion.Text = "Color and Intensity";
            // 
            // tbH2
            // 
            this.tbH2.Location = new System.Drawing.Point(497, 96);
            this.tbH2.Name = "tbH2";
            this.tbH2.Size = new System.Drawing.Size(29, 29);
            this.tbH2.TabIndex = 54;
            // 
            // tbS2
            // 
            this.tbS2.Location = new System.Drawing.Point(565, 99);
            this.tbS2.Name = "tbS2";
            this.tbS2.Size = new System.Drawing.Size(29, 29);
            this.tbS2.TabIndex = 53;
            // 
            // tbV2
            // 
            this.tbV2.Location = new System.Drawing.Point(629, 99);
            this.tbV2.Name = "tbV2";
            this.tbV2.Size = new System.Drawing.Size(29, 29);
            this.tbV2.TabIndex = 52;
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(284, 96);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(29, 29);
            this.tbS.TabIndex = 51;
            // 
            // tbV
            // 
            this.tbV.Location = new System.Drawing.Point(351, 96);
            this.tbV.Name = "tbV";
            this.tbV.Size = new System.Drawing.Size(29, 29);
            this.tbV.TabIndex = 50;
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(216, 96);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(29, 29);
            this.tbH.TabIndex = 49;
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Location = new System.Drawing.Point(145, 96);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(58, 21);
            this.lblLower.TabIndex = 48;
            this.lblLower.Text = "Lower";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Location = new System.Drawing.Point(426, 99);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(57, 21);
            this.lblUpper.TabIndex = 47;
            this.lblUpper.Text = "Upper";
            // 
            // cbHistogramEquilization
            // 
            this.cbHistogramEquilization.AutoSize = true;
            this.cbHistogramEquilization.Location = new System.Drawing.Point(47, 348);
            this.cbHistogramEquilization.Name = "cbHistogramEquilization";
            this.cbHistogramEquilization.Size = new System.Drawing.Size(197, 25);
            this.cbHistogramEquilization.TabIndex = 46;
            this.cbHistogramEquilization.Text = "Histogram Equilization";
            this.cbHistogramEquilization.UseVisualStyleBackColor = true;
            this.cbHistogramEquilization.CheckedChanged += new System.EventHandler(this.cbHistogramEquilization_CheckedChanged);
            // 
            // cbClahe
            // 
            this.cbClahe.AutoSize = true;
            this.cbClahe.Location = new System.Drawing.Point(49, 276);
            this.cbClahe.Name = "cbClahe";
            this.cbClahe.Size = new System.Drawing.Size(90, 25);
            this.cbClahe.TabIndex = 44;
            this.cbClahe.Text = "CLAHE";
            this.cbClahe.UseVisualStyleBackColor = true;
            this.cbClahe.CheckedChanged += new System.EventHandler(this.cbClahe_CheckedChanged);
            // 
            // cbLAB
            // 
            this.cbLAB.AutoSize = true;
            this.cbLAB.Location = new System.Drawing.Point(49, 211);
            this.cbLAB.Name = "cbLAB";
            this.cbLAB.Size = new System.Drawing.Size(65, 25);
            this.cbLAB.TabIndex = 43;
            this.cbLAB.Text = "LAB";
            this.cbLAB.UseVisualStyleBackColor = true;
            this.cbLAB.CheckedChanged += new System.EventHandler(this.cbLAB_CheckedChanged);
            // 
            // cbHSV
            // 
            this.cbHSV.AutoSize = true;
            this.cbHSV.Location = new System.Drawing.Point(47, 92);
            this.cbHSV.Name = "cbHSV";
            this.cbHSV.Size = new System.Drawing.Size(66, 25);
            this.cbHSV.TabIndex = 42;
            this.cbHSV.Text = "HSV";
            this.cbHSV.UseVisualStyleBackColor = true;
            this.cbHSV.CheckedChanged += new System.EventHandler(this.cbHSV_CheckedChanged);
            // 
            // cbgrayscale
            // 
            this.cbgrayscale.AutoSize = true;
            this.cbgrayscale.Location = new System.Drawing.Point(47, 151);
            this.cbgrayscale.Name = "cbgrayscale";
            this.cbgrayscale.Size = new System.Drawing.Size(103, 25);
            this.cbgrayscale.TabIndex = 41;
            this.cbgrayscale.Text = "Grayscale";
            this.cbgrayscale.UseVisualStyleBackColor = true;
            this.cbgrayscale.CheckedChanged += new System.EventHandler(this.cbgrayscale_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpColorConversion);
            this.tabControl1.Controls.Add(this.tpFiltering);
            this.tabControl1.Controls.Add(this.tpThreshold);
            this.tabControl1.Controls.Add(this.tpMorphologicalOperation);
            this.tabControl1.Controls.Add(this.tpEdgeDetection);
            this.tabControl1.Controls.Add(this.tpPerspectiveTransform);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1001, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 421);
            this.tabControl1.TabIndex = 44;
            // 
            // gbHoughCircle
            // 
            this.gbHoughCircle.Controls.Add(this.tbMinRadius);
            this.gbHoughCircle.Controls.Add(this.tbMaxRadius);
            this.gbHoughCircle.Controls.Add(this.lblMaxRadius);
            this.gbHoughCircle.Controls.Add(this.lblMinDist);
            this.gbHoughCircle.Controls.Add(this.lblMinRadius);
            this.gbHoughCircle.Controls.Add(this.lblParam1);
            this.gbHoughCircle.Controls.Add(this.lblParam2);
            this.gbHoughCircle.Controls.Add(this.tbDP);
            this.gbHoughCircle.Controls.Add(this.lblDP);
            this.gbHoughCircle.Controls.Add(this.tbParam1);
            this.gbHoughCircle.Controls.Add(this.tbParam2);
            this.gbHoughCircle.Controls.Add(this.tbMinDist);
            this.gbHoughCircle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHoughCircle.Location = new System.Drawing.Point(68, 49);
            this.gbHoughCircle.Name = "gbHoughCircle";
            this.gbHoughCircle.Size = new System.Drawing.Size(601, 300);
            this.gbHoughCircle.TabIndex = 47;
            this.gbHoughCircle.TabStop = false;
            this.gbHoughCircle.Text = "Hough Circle";
            // 
            // tbMinRadius
            // 
            this.tbMinRadius.Location = new System.Drawing.Point(166, 201);
            this.tbMinRadius.Name = "tbMinRadius";
            this.tbMinRadius.Size = new System.Drawing.Size(100, 29);
            this.tbMinRadius.TabIndex = 25;
            // 
            // tbMaxRadius
            // 
            this.tbMaxRadius.Location = new System.Drawing.Point(166, 248);
            this.tbMaxRadius.Name = "tbMaxRadius";
            this.tbMaxRadius.Size = new System.Drawing.Size(100, 29);
            this.tbMaxRadius.TabIndex = 24;
            // 
            // lblMaxRadius
            // 
            this.lblMaxRadius.AutoSize = true;
            this.lblMaxRadius.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxRadius.Location = new System.Drawing.Point(23, 253);
            this.lblMaxRadius.Name = "lblMaxRadius";
            this.lblMaxRadius.Size = new System.Drawing.Size(92, 19);
            this.lblMaxRadius.TabIndex = 23;
            this.lblMaxRadius.Text = "Max Radius";
            // 
            // lblMinDist
            // 
            this.lblMinDist.AutoSize = true;
            this.lblMinDist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinDist.Location = new System.Drawing.Point(24, 165);
            this.lblMinDist.Name = "lblMinDist";
            this.lblMinDist.Size = new System.Drawing.Size(69, 19);
            this.lblMinDist.TabIndex = 22;
            this.lblMinDist.Text = "Min Dist";
            // 
            // lblMinRadius
            // 
            this.lblMinRadius.AutoSize = true;
            this.lblMinRadius.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinRadius.Location = new System.Drawing.Point(23, 211);
            this.lblMinRadius.Name = "lblMinRadius";
            this.lblMinRadius.Size = new System.Drawing.Size(88, 19);
            this.lblMinRadius.TabIndex = 21;
            this.lblMinRadius.Text = "Min Radius";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParam1.Location = new System.Drawing.Point(23, 77);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(91, 19);
            this.lblParam1.TabIndex = 20;
            this.lblParam1.Text = "Parameter 1";
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParam2.Location = new System.Drawing.Point(23, 117);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(91, 19);
            this.lblParam2.TabIndex = 19;
            this.lblParam2.Text = "Parameter 2";
            this.lblParam2.Click += new System.EventHandler(this.lblParam2_Click);
            // 
            // tbDP
            // 
            this.tbDP.Location = new System.Drawing.Point(166, 34);
            this.tbDP.Name = "tbDP";
            this.tbDP.Size = new System.Drawing.Size(100, 29);
            this.tbDP.TabIndex = 14;
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDP.Location = new System.Drawing.Point(24, 44);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(29, 19);
            this.lblDP.TabIndex = 15;
            this.lblDP.Text = "dp ";
            // 
            // tbParam1
            // 
            this.tbParam1.Location = new System.Drawing.Point(166, 72);
            this.tbParam1.Name = "tbParam1";
            this.tbParam1.Size = new System.Drawing.Size(100, 29);
            this.tbParam1.TabIndex = 16;
            // 
            // tbParam2
            // 
            this.tbParam2.Location = new System.Drawing.Point(166, 112);
            this.tbParam2.Name = "tbParam2";
            this.tbParam2.Size = new System.Drawing.Size(100, 29);
            this.tbParam2.TabIndex = 17;
            // 
            // tbMinDist
            // 
            this.tbMinDist.Location = new System.Drawing.Point(166, 160);
            this.tbMinDist.Name = "tbMinDist";
            this.tbMinDist.Size = new System.Drawing.Size(100, 29);
            this.tbMinDist.TabIndex = 18;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpPixelCount);
            this.tabControl2.Controls.Add(this.tpCountous);
            this.tabControl2.Controls.Add(this.tpHoughCircle);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(1005, 630);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(732, 394);
            this.tabControl2.TabIndex = 48;
            // 
            // tpPixelCount
            // 
            this.tpPixelCount.Controls.Add(this.Result);
            this.tpPixelCount.Location = new System.Drawing.Point(4, 22);
            this.tpPixelCount.Name = "tpPixelCount";
            this.tpPixelCount.Padding = new System.Windows.Forms.Padding(3);
            this.tpPixelCount.Size = new System.Drawing.Size(724, 368);
            this.tpPixelCount.TabIndex = 0;
            this.tpPixelCount.Text = "Pixel Count";
            this.tpPixelCount.UseVisualStyleBackColor = true;
            // 
            // tpCountous
            // 
            this.tpCountous.Controls.Add(this.gbContour);
            this.tpCountous.Location = new System.Drawing.Point(4, 22);
            this.tpCountous.Name = "tpCountous";
            this.tpCountous.Padding = new System.Windows.Forms.Padding(3);
            this.tpCountous.Size = new System.Drawing.Size(724, 368);
            this.tpCountous.TabIndex = 1;
            this.tpCountous.Text = "Contours";
            this.tpCountous.UseVisualStyleBackColor = true;
            // 
            // tpHoughCircle
            // 
            this.tpHoughCircle.Controls.Add(this.gbHoughCircle);
            this.tpHoughCircle.Location = new System.Drawing.Point(4, 22);
            this.tpHoughCircle.Name = "tpHoughCircle";
            this.tpHoughCircle.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoughCircle.Size = new System.Drawing.Size(724, 368);
            this.tpHoughCircle.TabIndex = 2;
            this.tpHoughCircle.Text = "Hough Circle";
            this.tpHoughCircle.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbConnectedComponents);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 368);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbConnectedComponents
            // 
            this.cbConnectedComponents.AutoSize = true;
            this.cbConnectedComponents.Location = new System.Drawing.Point(67, 134);
            this.cbConnectedComponents.Name = "cbConnectedComponents";
            this.cbConnectedComponents.Size = new System.Drawing.Size(140, 17);
            this.cbConnectedComponents.TabIndex = 51;
            this.cbConnectedComponents.Text = "Connected Components";
            this.cbConnectedComponents.UseVisualStyleBackColor = true;
            this.cbConnectedComponents.CheckedChanged += new System.EventHandler(this.cbConnectedComponents_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbMinEnclosing);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 368);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbMinEnclosing
            // 
            this.cbMinEnclosing.AutoSize = true;
            this.cbMinEnclosing.Location = new System.Drawing.Point(188, 174);
            this.cbMinEnclosing.Name = "cbMinEnclosing";
            this.cbMinEnclosing.Size = new System.Drawing.Size(121, 17);
            this.cbMinEnclosing.TabIndex = 54;
            this.cbMinEnclosing.Text = "Min Enclosing Circle";
            this.cbMinEnclosing.UseVisualStyleBackColor = true;
            this.cbMinEnclosing.CheckedChanged += new System.EventHandler(this.cbMinEnclosing_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1773, 1036);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.templatematch);
            this.Controls.Add(this.houghcircle);
            this.Controls.Add(this.contour);
            this.Controls.Add(this.pixelcount);
            this.Controls.Add(this.Image_Browse);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Shape);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.gbContour.ResumeLayout(false);
            this.gbContour.PerformLayout();
            this.tpPerspectiveTransform.ResumeLayout(false);
            this.tpPerspectiveTransform.PerformLayout();
            this.tpEdgeDetection.ResumeLayout(false);
            this.tpEdgeDetection.PerformLayout();
            this.tpMorphologicalOperation.ResumeLayout(false);
            this.tpMorphologicalOperation.PerformLayout();
            this.tpThreshold.ResumeLayout(false);
            this.tpThreshold.PerformLayout();
            this.tpFiltering.ResumeLayout(false);
            this.tpFiltering.PerformLayout();
            this.tpColorConversion.ResumeLayout(false);
            this.tpColorConversion.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.gbHoughCircle.ResumeLayout(false);
            this.gbHoughCircle.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tpPixelCount.ResumeLayout(false);
            this.tpCountous.ResumeLayout(false);
            this.tpHoughCircle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Shape;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label shapee;
        private System.Windows.Forms.Button Image_Browse;
        private System.Windows.Forms.GroupBox Result;
        private System.Windows.Forms.Label black_count;
        private System.Windows.Forms.Label white_count;
        private System.Windows.Forms.Label black_pixel;
        private System.Windows.Forms.Label white;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Heightcount;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label Widthcount;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label areacount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minheight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.TextBox maxwidth;
        private System.Windows.Forms.TextBox minwidth;
        private System.Windows.Forms.TextBox maxheight;
        private System.Windows.Forms.Label lblwidth;
        private System.Windows.Forms.CheckBox pixelcount;
        private System.Windows.Forms.CheckBox contour;
        private System.Windows.Forms.CheckBox houghcircle;
        private System.Windows.Forms.CheckBox templatematch;
        private System.Windows.Forms.GroupBox gbContour;
        private System.Windows.Forms.CheckBox cbErode;
        private System.Windows.Forms.CheckBox cbOpen;
        private System.Windows.Forms.CheckBox cbClose;
        private System.Windows.Forms.CheckBox cbGain;
        private System.Windows.Forms.CheckBox cbLaplace;
        private System.Windows.Forms.CheckBox cbthreshold;
        private System.Windows.Forms.CheckBox cbDilate;
        private System.Windows.Forms.CheckBox cbsobel;
        private System.Windows.Forms.CheckBox cbcanny;
        private System.Windows.Forms.TabPage tpPerspectiveTransform;
        private System.Windows.Forms.TabPage tpEdgeDetection;
        private System.Windows.Forms.TabPage tpMorphologicalOperation;
        private System.Windows.Forms.TabPage tpThreshold;
        private System.Windows.Forms.TabPage tpFiltering;
        private System.Windows.Forms.TabPage tpColorConversion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox cbgrayscale;
        private System.Windows.Forms.CheckBox cbClahe;
        private System.Windows.Forms.CheckBox cbLAB;
        private System.Windows.Forms.CheckBox cbHSV;
        private System.Windows.Forms.CheckBox cbMedianBlur;
        private System.Windows.Forms.CheckBox cbBilateralFilter;
        private System.Windows.Forms.CheckBox cbGaussianBlur;
        private System.Windows.Forms.CheckBox cbHistogramEquilization;
        private System.Windows.Forms.CheckBox cbThresholdOtsu;
        private System.Windows.Forms.CheckBox cbThresholdAdaptive;
        private System.Windows.Forms.CheckBox cbTriangle;
        private System.Windows.Forms.CheckBox cbToZero;
        private System.Windows.Forms.CheckBox cbTruncate;
        private System.Windows.Forms.CheckBox cbGradient;
        private System.Windows.Forms.CheckBox cbTopHat;
        private System.Windows.Forms.CheckBox cbBlackHat;
        private System.Windows.Forms.CheckBox cbHitorMiss;
        private System.Windows.Forms.CheckBox cbScharr;
        private System.Windows.Forms.CheckBox cbResize;
        private System.Windows.Forms.CheckBox cbRotate;
        private System.Windows.Forms.CheckBox cbFlip;
        private System.Windows.Forms.CheckBox cbAffineTransform;
        private System.Windows.Forms.CheckBox cbPerspectiveTransform;
        private System.Windows.Forms.CheckBox cbWarp;
        private System.Windows.Forms.CheckBox cbCrop;
        private System.Windows.Forms.GroupBox gbHoughCircle;
        private System.Windows.Forms.Label lblParam2;
        private System.Windows.Forms.TextBox tbDP;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.TextBox tbParam1;
        private System.Windows.Forms.TextBox tbParam2;
        private System.Windows.Forms.TextBox tbMinDist;
        private System.Windows.Forms.Label lblParam1;
        private System.Windows.Forms.Label lblMinDist;
        private System.Windows.Forms.Label lblMinRadius;
        private System.Windows.Forms.Label lblMaxRadius;
        private System.Windows.Forms.TextBox tbMinRadius;
        private System.Windows.Forms.TextBox tbMaxRadius;
        private System.Windows.Forms.TextBox tbH2;
        private System.Windows.Forms.TextBox tbS2;
        private System.Windows.Forms.TextBox tbV2;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.TextBox tbV;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpPixelCount;
        private System.Windows.Forms.TabPage tpCountous;
        private System.Windows.Forms.TabPage tpHoughCircle;
        private System.Windows.Forms.TextBox tbAreamin;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox tbAreaMax;
        private System.Windows.Forms.CheckBox cbConnectedComponents;
        private System.Windows.Forms.CheckBox cbMinEnclosing;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

