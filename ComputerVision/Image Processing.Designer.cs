namespace ComputerVision
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fullScreenPanel = new System.Windows.Forms.Panel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.histogramBox = new Emgu.CV.UI.HistogramBox();
            this.pictureViewBox = new Emgu.CV.UI.ImageBox();
            this.ToolbarPanel = new System.Windows.Forms.Panel();
            this.btnDrawHistogram = new System.Windows.Forms.Button();
            this.btnBlurImage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilateralBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothMedianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanFromImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanFromVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanFromCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.OutputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewBox)).BeginInit();
            this.ToolbarPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullScreenPanel
            // 
            this.fullScreenPanel.Controls.Add(this.FooterPanel);
            this.fullScreenPanel.Controls.Add(this.OutputPanel);
            this.fullScreenPanel.Controls.Add(this.ToolbarPanel);
            this.fullScreenPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.fullScreenPanel.Name = "fullScreenPanel";
            this.fullScreenPanel.Size = new System.Drawing.Size(1008, 461);
            this.fullScreenPanel.TabIndex = 0;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Controls.Add(this.label1);
            this.FooterPanel.Controls.Add(this.trackBarContrast);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(0, 399);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(1008, 62);
            this.FooterPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.label1.Location = new System.Drawing.Point(52, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contrast";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(149, 11);
            this.trackBarContrast.Maximum = 20;
            this.trackBarContrast.Minimum = -20;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(127, 45);
            this.trackBarContrast.TabIndex = 8;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.histogramBox);
            this.OutputPanel.Controls.Add(this.pictureViewBox);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(0, 69);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(1008, 392);
            this.OutputPanel.TabIndex = 1;
            // 
            // histogramBox
            // 
            this.histogramBox.Location = new System.Drawing.Point(331, 6);
            this.histogramBox.Name = "histogramBox";
            this.histogramBox.Size = new System.Drawing.Size(494, 318);
            this.histogramBox.TabIndex = 3;
            // 
            // pictureViewBox
            // 
            this.pictureViewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureViewBox.ErrorImage = null;
            this.pictureViewBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.pictureViewBox.InitialImage = null;
            this.pictureViewBox.Location = new System.Drawing.Point(0, 0);
            this.pictureViewBox.Name = "pictureViewBox";
            this.pictureViewBox.Size = new System.Drawing.Size(1008, 392);
            this.pictureViewBox.TabIndex = 2;
            this.pictureViewBox.TabStop = false;
            this.pictureViewBox.WaitOnLoad = true;
            // 
            // ToolbarPanel
            // 
            this.ToolbarPanel.Controls.Add(this.btnDrawHistogram);
            this.ToolbarPanel.Controls.Add(this.btnBlurImage);
            this.ToolbarPanel.Controls.Add(this.menuStrip1);
            this.ToolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolbarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolbarPanel.Name = "ToolbarPanel";
            this.ToolbarPanel.Size = new System.Drawing.Size(1008, 69);
            this.ToolbarPanel.TabIndex = 0;
            // 
            // btnDrawHistogram
            // 
            this.btnDrawHistogram.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.btnDrawHistogram.Location = new System.Drawing.Point(863, 12);
            this.btnDrawHistogram.Name = "btnDrawHistogram";
            this.btnDrawHistogram.Size = new System.Drawing.Size(121, 39);
            this.btnDrawHistogram.TabIndex = 6;
            this.btnDrawHistogram.Text = "Histogram";
            this.btnDrawHistogram.UseVisualStyleBackColor = true;
            this.btnDrawHistogram.Click += new System.EventHandler(this.btnDrawHistogram_Click);
            // 
            // btnBlurImage
            // 
            this.btnBlurImage.Font = new System.Drawing.Font("Montserrat", 14.25F);
            this.btnBlurImage.Location = new System.Drawing.Point(638, 12);
            this.btnBlurImage.Name = "btnBlurImage";
            this.btnBlurImage.Size = new System.Drawing.Size(107, 39);
            this.btnBlurImage.TabIndex = 4;
            this.btnBlurImage.Text = "Blur";
            this.btnBlurImage.UseVisualStyleBackColor = true;
            this.btnBlurImage.Click += new System.EventHandler(this.btnBlurImage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.edgeToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.faceDetectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.blackAndWhiteToolStripMenuItem,
            this.negativeToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // blackAndWhiteToolStripMenuItem
            // 
            this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
            this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.blackAndWhiteToolStripMenuItem.Text = "Black and White";
            this.blackAndWhiteToolStripMenuItem.Click += new System.EventHandler(this.blackAndWhiteToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.negativeToolStripMenuItem.Text = "Negative";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.laplacianToolStripMenuItem});
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.edgeToolStripMenuItem.Text = "Edge";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianToolStripMenuItem,
            this.bilateralBlurToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.smoothMedianToolStripMenuItem});
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.blurToolStripMenuItem.Text = "Median";
            // 
            // gaussianToolStripMenuItem
            // 
            this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
            this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gaussianToolStripMenuItem.Text = "Smooth Blur";
            // 
            // bilateralBlurToolStripMenuItem
            // 
            this.bilateralBlurToolStripMenuItem.Name = "bilateralBlurToolStripMenuItem";
            this.bilateralBlurToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.bilateralBlurToolStripMenuItem.Text = "Smooth Bilateral";
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Smooth Gaussian";
            // 
            // smoothMedianToolStripMenuItem
            // 
            this.smoothMedianToolStripMenuItem.Name = "smoothMedianToolStripMenuItem";
            this.smoothMedianToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.smoothMedianToolStripMenuItem.Text = "Smooth Median";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.allColorsToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            // 
            // allColorsToolStripMenuItem
            // 
            this.allColorsToolStripMenuItem.Name = "allColorsToolStripMenuItem";
            this.allColorsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.allColorsToolStripMenuItem.Text = "All Colors";
            // 
            // faceDetectionToolStripMenuItem
            // 
            this.faceDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromImageToolStripMenuItem,
            this.fromVideoToolStripMenuItem,
            this.fromCameraToolStripMenuItem,
            this.humanFromImageToolStripMenuItem,
            this.humanFromVideoToolStripMenuItem,
            this.humanFromCameraToolStripMenuItem});
            this.faceDetectionToolStripMenuItem.Name = "faceDetectionToolStripMenuItem";
            this.faceDetectionToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.faceDetectionToolStripMenuItem.Text = "Face Detection";
            // 
            // fromImageToolStripMenuItem
            // 
            this.fromImageToolStripMenuItem.Name = "fromImageToolStripMenuItem";
            this.fromImageToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.fromImageToolStripMenuItem.Text = "Face From image";
            this.fromImageToolStripMenuItem.Click += new System.EventHandler(this.fromImageToolStripMenuItem_Click);
            // 
            // fromVideoToolStripMenuItem
            // 
            this.fromVideoToolStripMenuItem.Name = "fromVideoToolStripMenuItem";
            this.fromVideoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.fromVideoToolStripMenuItem.Text = "Face From Video";
            this.fromVideoToolStripMenuItem.Click += new System.EventHandler(this.fromVideoToolStripMenuItem_Click);
            // 
            // fromCameraToolStripMenuItem
            // 
            this.fromCameraToolStripMenuItem.Name = "fromCameraToolStripMenuItem";
            this.fromCameraToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.fromCameraToolStripMenuItem.Text = "Face From Camera";
            this.fromCameraToolStripMenuItem.Click += new System.EventHandler(this.fromCameraToolStripMenuItem_Click);
            // 
            // humanFromImageToolStripMenuItem
            // 
            this.humanFromImageToolStripMenuItem.Name = "humanFromImageToolStripMenuItem";
            this.humanFromImageToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.humanFromImageToolStripMenuItem.Text = "Human From Image";
            this.humanFromImageToolStripMenuItem.Click += new System.EventHandler(this.humanFromImageToolStripMenuItem_Click);
            // 
            // humanFromVideoToolStripMenuItem
            // 
            this.humanFromVideoToolStripMenuItem.Name = "humanFromVideoToolStripMenuItem";
            this.humanFromVideoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.humanFromVideoToolStripMenuItem.Text = "Human From Video";
            // 
            // humanFromCameraToolStripMenuItem
            // 
            this.humanFromCameraToolStripMenuItem.Name = "humanFromCameraToolStripMenuItem";
            this.humanFromCameraToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.humanFromCameraToolStripMenuItem.Text = "Human from Camera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.fullScreenPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.fullScreenPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.OutputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureViewBox)).EndInit();
            this.ToolbarPanel.ResumeLayout(false);
            this.ToolbarPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fullScreenPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Panel ToolbarPanel;
        private Emgu.CV.UI.ImageBox pictureViewBox;
        private System.Windows.Forms.Button btnBlurImage;
        private System.Windows.Forms.Button btnDrawHistogram;
        private Emgu.CV.UI.HistogramBox histogramBox;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilateralBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothMedianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanFromImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanFromVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanFromCameraToolStripMenuItem;
    }
}

