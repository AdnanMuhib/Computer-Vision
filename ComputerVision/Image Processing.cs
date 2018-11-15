using ComputerVision.ParameterForms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVision
{
    public partial class Form1 : Form
    {
        public Image<Bgr, byte> img;
        public Image<Bgr, float> img_16;
        private VideoCapture _capture = null;
        private Mat _frame;
        public double frameIndex;
        public Form1()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            histogramBox.Visible = false;
            _frame = new Mat();
            frameIndex = 0;
            img = new Image<Bgr, byte>(@"D:\UNIVERSITY DOCUMENTS\FYP\Human Activity Recognition\Test Inputs\a person.png");
            pictureViewBox.Image = img;
            pictureViewBox.FunctionalMode = ImageBox.FunctionalModeOption.PanAndZoom;
            pictureViewBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ProcessVideoFrame(Object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                img = _capture.QueryFrame().ToImage<Bgr, byte>().Resize(260, 200, Emgu.CV.CvEnum.Inter.Cubic);
                frameIndex = frameIndex + 1;
                //DetectFaceHaar(img, frameIndex);
                DetectHumanHaar(img, frameIndex);
            }
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);
                //double framenumber = _capture.GetCaptureProperty(CapProp.PosFrames);
                frameIndex = frameIndex + 1;
                DetectFaceHaar(_frame.ToImage<Bgr, byte>(), frameIndex);//.Resize(260, 200, Emgu.CV.CvEnum.Inter.Cubic));
            }
        }

        private void fromImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (img == null)
                {
                    throw new Exception("Please select and image");
                }

                // see if video is playing or camera is running then close the video/camera 
                // and  release the memory
                //if (_capture != null)
                //{
                //    _capture.Stop();
                //    _capture.Dispose();
                //}
                this.DetectFaceHaar(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fromVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frameIndex = 0;
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (_capture != null && _capture.IsOpened)
                {
                    _capture.Stop();
                    _capture.Dispose();
                }
                _capture = new VideoCapture(f.FileName);
                Application.Idle += ProcessVideoFrame;
            }
        }
        private void fromCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frameIndex = 0;
            try
            {
                if (_capture != null && _capture.CaptureSource == VideoCapture.CaptureModuleType.Highgui)
                {
                    _capture.Stop();
                    _capture.Dispose();
                }
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame;
                _capture.Start();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

        }
        public void DetectFaceHaar(Image<Bgr, byte> imgInput, double framenumber = -1)
        {
            try
            {
                //string facePath = Path.GetFullPath(@"../../../data/haarcascade_frontalface_default.xml");
                string facePath = Path.GetFullPath(@"../../../data/lbpcascade_frontalface.xml");
                string eyePath = Path.GetFullPath(@"../../../data/haarcascade_eye.xml");


                CascadeClassifier classifierFace = new CascadeClassifier(facePath);
                CascadeClassifier classifierEye = new CascadeClassifier(eyePath);

                var imgGray = imgInput.Convert<Gray, byte>().Clone();

                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 4);
                String OutputFileName = @"C:\Users\Antivirus\Desktop\faces\face_at_frame_";
                int counter = 0;
                foreach (var face in faces)
                {
                    imgInput.Draw(face, new Bgr(0, 0, 255), 2);

                    imgGray.ROI = face;
                    Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray, 1.1, 4);
                    foreach (var eye in eyes)
                    {
                        var e = eye;
                        e.X += face.X;
                        e.Y += face.Y;
                        imgInput.Draw(e, new Bgr(0, 255, 0), 2);
                    }

                    if (framenumber != -1)
                    {
                        CvInvoke.Imwrite(OutputFileName + framenumber + ".png", imgGray);
                    }
                    else
                    {
                        CvInvoke.Imwrite(OutputFileName + counter + ".png", imgGray);
                        counter = counter + 1;
                    }

                }
                pictureViewBox.Image = imgInput;
                imgInput.Dispose();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnBlurImage_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                histogramBox.Visible = false;
                Image<Bgr, byte> blurred = img.SmoothBlur(20, 20, true);
                //Image<Bgr, byte> mediansmooth = img.SmoothMedian(15);
                //Image<Bgr, byte> bilat = img.SmoothBilatral(7, 255, 34);
                //Image<Bgr, byte> gauss = img.SmoothGaussian(3, 3, 34.3, 45.3);
                pictureViewBox.Image = blurred;
            }
            else
            {
                MessageBox.Show("No Picture Opened");
            }
        }


        private void btnDrawHistogram_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                histogramBox.GenerateHistograms(img, 256);
                histogramBox.Dock = DockStyle.Fill;
                histogramBox.Enabled = true;
                histogramBox.Visible = true;
                histogramBox.Refresh();
            }
            else
            {
                MessageBox.Show("No Picture Opened");
            }
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            var value = (double)trackBarContrast.Value / 10;
            if (img != null)
            {
                histogramBox.Visible = false;
                Image<Bgr, byte> inputImage = img.Copy();
                inputImage._EqualizeHist();
                inputImage._GammaCorrect(value);
                pictureViewBox.Image = inputImage;
            }
            else
            {
                MessageBox.Show("No Picture Opened");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                histogramBox.Visible = false;
                img = new Image<Bgr, byte>(f.FileName);
                img_16 = new Image<Bgr, float>(f.FileName);
                try
                {
                    //img_16.Log();

                    // img.Log();
                    //   Mat m = img_16.Mat;
                    ///Image<Gray, float> outImg = new Image<Gray, float>(img_16.Width, img_16.Height);
                    //CvInvoke.Log(img_16, outImg);
                    pictureViewBox.Image = img;
                    pictureViewBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

               
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                histogramBox.Visible = false;
                Image<Gray, byte> grayImage = img.Convert<Gray, byte>();
                pictureViewBox.Image = grayImage;
            }
            else
            {
                MessageBox.Show("No Picture Opened");
            }

        }

        private void blackAndWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                histogramBox.Visible = false;
                int threshold_value = 50;
                Image<Gray, Byte> grayimg = img.Convert<Gray, byte>();
                grayimg = grayimg.ThresholdBinary(new Gray(threshold_value), new Gray(255));
                pictureViewBox.Image = grayimg;
            }
            else
            {
                MessageBox.Show("No Picture Opened");
            }
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                histogramBox.Visible = false;
                Image<Bgr, byte> negative = img.Not();
                pictureViewBox.Image = negative;
            }
            else
            {
                MessageBox.Show("No Picture Opened");
            }
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ApplyCannyFilter();
            CannyParametersForm frm = new CannyParametersForm(this);
            frm.Show();
        }

        public void ApplyCannyFilter(double thresh = 20.0, double threshLink = 50.0)
        {
            if (img == null)
            {
                MessageBox.Show("No Picture Opened");
                return;
            }
            Image<Gray, byte> imgCanny = new Image<Gray, byte>(img.Width, img.Height, new Gray(0));
            imgCanny = img.Canny(thresh, threshLink);
            pictureViewBox.Image = imgCanny;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("No Picture Opened");
                return;
            }

            //Image<Gray, byte> imgGray = img.Convert<Gray, byte>();
            //Image<Gray, float> imgSobel = new Image<Gray, float>(img.Width, img.Height, new Gray(0));
            //imgSobel = imgGray.Sobel(1, 1, 3);
            //pictureViewBox.Image = imgSobel;
            Image<Gray, byte> gray = img.Convert<Gray, byte>();
            Image<Gray, float> sobel = gray.Sobel(0, 1, 3).Add(gray.Sobel(1, 0, 3)).AbsDiff(new Gray(0.0));
            pictureViewBox.Image = sobel;

        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("No Picture Opened");
                return;
            }

            Image<Gray, byte> imgGray = img.Convert<Gray, byte>();
            Image<Gray, float> imgLaplacian = new Image<Gray, float>(img.Width, img.Height, new Gray(0));

            imgLaplacian = imgGray.Laplace(7);
            pictureViewBox.Image = imgLaplacian;
        }

        private void humanFromImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (img == null) {
                MessageBox.Show("Open Image !!!!");
                return;
            }
            DetectHumanHaar(img);
        }
        public void DetectHumanHaar(Image<Bgr, byte> imgInput, double framenumber = -1)
        {
            try
            {
                string humanPath = Path.GetFullPath(@"../../../data/lbphuman.xml");
                string facePath = Path.GetFullPath(@"../../../data/haarcascade_frontalface_default.xml");
                string eyePath = Path.GetFullPath(@"../../../data/haarcascade_eye.xml");


                CascadeClassifier classifierHuman = new CascadeClassifier(humanPath);
                CascadeClassifier classifierFace = new CascadeClassifier(facePath);
                CascadeClassifier classifierEye = new CascadeClassifier(eyePath);

                var imgGray = imgInput.Convert<Gray, byte>().Clone();
                double w = img.Width;
                double h = img.Height;
                Rectangle[] Humans = classifierHuman.DetectMultiScale(imgGray, 1.3, 3);
                

                //Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 4);
                String OutputFileName = @"C:\Users\Antivirus\Desktop\faces\human_";

                foreach (var human in Humans) {

                    imgInput.Draw(human, new Bgr(0, 0, 255), 2);
                }
                CvInvoke.Imwrite(OutputFileName+"1.png",imgInput);
                //int counter = 0;
                //foreach (var face in faces)
                //{
                //    imgInput.Draw(face, new Bgr(0, 0, 255), 2);

                //    imgGray.ROI = face;
                //    Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray, 1.1, 4);
                //    foreach (var eye in eyes)
                //    {
                //        var e = eye;
                //        e.X += face.X;
                //        e.Y += face.Y;
                //        imgInput.Draw(e, new Bgr(0, 255, 0), 2);
                //    }

                //    if (framenumber != -1)
                //    {
                //        CvInvoke.Imwrite(OutputFileName + framenumber + ".png", imgGray);
                //    }
                //    else
                //    {
                //        CvInvoke.Imwrite(OutputFileName + counter + ".png", imgGray);
                //        counter = counter + 1;
                //    }

                //}
                pictureViewBox.Image = imgInput;
                //imgInput.Dispose();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
            
            
                   
 