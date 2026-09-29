using ClosedXML.Excel;
using Microsoft.Win32;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
//using System.Windows.Input;
using System.Windows.Media.Imaging;
using Point = OpenCvSharp.Point;
using Size = OpenCvSharp.Size;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> imagePaths = new List<string>();
        int bp = 0;
        int white_pixel = 0;
        int total_pixel = 0;
        int currentIndex = 0;

        private void Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                imagePaths = Directory.GetFiles(fbd.SelectedPath, "*.bmp").ToList();

                if (imagePaths.Count == 0)
                {
                    MessageBox.Show("No BMP images found");
                    return;
                }

                currentIndex = 0;
                img = Cv2.ImRead(imagePaths[currentIndex]);
                pictureBox2.Image = img.ToBitmap();
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count == 0) return;

            if (currentIndex > 0)
            {
                currentIndex--;
                img = Cv2.ImRead(imagePaths[currentIndex]);
                pictureBox2.Image = img.ToBitmap();

            }
            //cbHSV_CheckedChanged(sender, e);

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count == 0) return;

            if (currentIndex < imagePaths.Count - 1)
            {
                currentIndex++;
                img = Cv2.ImRead(imagePaths[currentIndex]);
                pictureBox2.Image = img.ToBitmap();
            }
            else
            {
                MessageBox.Show("End");
            }
            //cbHSV_CheckedChanged(sender, e);
            Houghcircle(img);
        }

        //Preprocessors



        private void Shape_Click(object sender, EventArgs e)
        {
            if(cbMinEnclosing.Checked)
            {
                MinEnclosingCircle(img);
            }
            if (cbsobel.Checked)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Image);
                Mat img = OpenCvSharp.Extensions.BitmapConverter.ToMat(bmp);
                Mat sobelXY = new Mat();
                Cv2.CvtColor(img, sobelXY, ColorConversionCodes.BGR2GRAY);
                Cv2.Sobel(sobelXY, sobelXY, MatType.CV_64F, 2, 2, 3); // src, dst, ddepth, dx, dy, ksize
                Cv2.ConvertScaleAbs(sobelXY, sobelXY);
                pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(sobelXY);
            }
            if (cbcanny.Checked)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Image);
                Mat img = OpenCvSharp.Extensions.BitmapConverter.ToMat(bmp);
                //Mat img = new Mat();              
                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY);
                Cv2.Canny(img, img, 80, 100);
                pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
            }
            if (cbthreshold.Checked)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Image);
                Mat img1 = OpenCvSharp.Extensions.BitmapConverter.ToMat(bmp);

                Mat img = new Mat();
                Cv2.CvtColor(img1, img, ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(img, img, 200, 255, ThresholdTypes.Binary);
                Cv2.BitwiseNot(img, img);
                //Cv2.ConvertScaleAbs(img, img);
                pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
            }
            if (pixelcount.Checked)
            {
                Px_count(img);
            }
            if (contour.Checked)
            {
                Contours(img);
            }
            if (houghcircle.Checked)
            {
                Houghcircle(img);
            }
            if (templatematch.Checked)
            {
                TemplateMatch(img);
            }
            if (cbConnectedComponents.Checked)
            {
                ConnectedComponents(img);
            }

        }
        Mat img = new Mat();

        private void Image_Browse_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                img = Cv2.ImRead(file);
                pictureBox2.Image = img.ToBitmap();
            }
        }

        private double TemplateMatch(Mat img)
        {
            try
            {
                using (Mat input_img = img.Clone())
                using (Mat temp = Cv2.ImRead(@"ENDC.bmp", ImreadModes.Color))
                using (Mat result = new Mat())
                {
                    if (input_img.Empty())
                        return double.NaN;

                    if (temp.Empty())
                        return double.NaN;

                    Cv2.MatchTemplate(
                        input_img,
                        temp,
                        result,
                        TemplateMatchModes.CCoeffNormed);

                    Cv2.MinMaxLoc(
                        result,
                        out double minval,
                        out double maxval,
                        out OpenCvSharp.Point minloc,
                        out OpenCvSharp.Point maxloc);

                    if (maxval > 0.70)
                    {
                        Rect rect = new Rect(
                            maxloc,
                            temp.Size());

                        Cv2.Rectangle(
                            img,
                            rect,
                            Scalar.Red,
                            12);

                        pictureBox3.Image?.Dispose();
                        pictureBox3.Image = img.ToBitmap();

                        return maxval;
                    }

                    using (Mat temp2 =
                        Cv2.ImRead(@"SSW.bmp", ImreadModes.Color))
                    {
                        if (temp2.Empty())
                            return double.NaN;

                        result.SetTo(Scalar.Black);

                        Cv2.MatchTemplate(
                            input_img,
                            temp2,
                            result,
                            TemplateMatchModes.CCoeffNormed);

                        Cv2.MinMaxLoc(
                            result,
                            out double minval2,
                            out double maxval2,
                            out OpenCvSharp.Point minloc2,
                            out OpenCvSharp.Point maxloc2);

                        if (maxval2 > 0.70)
                        {
                            Rect rect2 = new Rect(
                                maxloc2,
                                temp2.Size());

                            Cv2.Rectangle(
                                img,
                                rect2,
                                Scalar.Red,
                                12);
                        }

                        pictureBox3.Image?.Dispose();
                        pictureBox3.Image = img.ToBitmap();

                        return maxval2;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Template Match Error");

                return double.NaN;
            }
        }
        private void Contours(Mat img)
        {
            try
            {
                Mat input_img = img.Clone();

                if (img.Channels() >= 3)
                {
                    Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY);
                }


                Cv2.GaussianBlur(input_img, input_img, new Size(5, 5), 0);

                //Contour
                OpenCvSharp.Point[][] contour;
                HierarchyIndex[] hey;


                Mat thresh = new Mat();
                Cv2.Threshold(input_img, thresh, 20, 255, ThresholdTypes.Binary);
                //Cv2.BitwiseNot(thresh, thresh);

                Rect rect = new Rect(0, 0, 860, 3840);
                Cv2.Rectangle(thresh, rect, Scalar.Black, -1);

                Rect rect2 = new Rect(3826, 2692, 800, 2600);
                Cv2.Rectangle(thresh, rect2, Scalar.Black, -1);

                Cv2.NamedWindow("image", WindowFlags.FreeRatio);
                Cv2.ImShow("image", thresh);
                Cv2.WaitKey(0);

                Cv2.FindContours(thresh, out contour, out hey, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);

                int minHeight = 500;
                int maxHeight = 800;
                int minWidth = 500;
                int maxWidth = 800;
                int minarea = 500;
                int maxarea = 800;

                if (!string.IsNullOrWhiteSpace(minheight.Text))
                    minHeight = int.Parse(minheight.Text);

                if (!string.IsNullOrWhiteSpace(maxheight.Text))
                    maxHeight = int.Parse(maxheight.Text);

                if (!string.IsNullOrWhiteSpace(minwidth.Text))
                    minWidth = int.Parse(minwidth.Text);

                if (!string.IsNullOrWhiteSpace(maxwidth.Text))
                    maxWidth = int.Parse(maxwidth.Text);

                if (!string.IsNullOrWhiteSpace(tbAreamin.Text))
                    minarea = int.Parse(tbAreamin.Text);

                if (!string.IsNullOrWhiteSpace(tbAreaMax.Text))
                    maxarea = int.Parse(tbAreaMax.Text);

                Cv2.CvtColor(thresh, thresh, ColorConversionCodes.GRAY2BGR);

                for (int i = 0; i < contour.Length; i++)
                {
                    Rect rectmain = Cv2.BoundingRect(contour[i]);
                    // arealist.Add(Cv2.ContourArea(contour[i]));
                    double areaa = Cv2.ContourArea(contour[i]);

                    if (areaa > minarea && areaa < maxarea)
                    {
                        Cv2.DrawContours(thresh, contour, i, Scalar.Red, 10);
                        Cv2.Rectangle(thresh, rectmain, Scalar.Green, 10);
                        area.Text = Cv2.ContourArea(contour[i]).ToString();
                        Height.Text = rectmain.Height.ToString();
                        Width.Text = rectmain.Width.ToString();
                    }
                }
                pictureBox3.Image = BitmapConverter.ToBitmap(thresh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Px_count(Mat img)
        {


            try
            {

                Mat input_img = img.Clone();

                if (input_img.Channels() == 3)
                {
                    Cv2.CvtColor(input_img, input_img, ColorConversionCodes.BGR2GRAY);
                }
                else if (input_img.Channels() == 4)
                {
                    Cv2.CvtColor(input_img, input_img, ColorConversionCodes.BGRA2GRAY);
                }

                //Cv2.Threshold(input_img, input_img, 100, 255, ThresholdTypes.Binary);

                //pictureBox2.Image = input_img.ToBitmap();

                white_pixel = Cv2.CountNonZero(input_img);
                white_count.Text = white_pixel.ToString();

                total_pixel = input_img.Height * input_img.Width;

                bp = total_pixel - white_pixel;
                black_count.Text = bp.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GenerateExcel()
        {
            XLWorkbook wb;
            IXLWorksheet ws;

            string path = @"D:\PixelReport.xlsx";

            if (File.Exists(path))
            {
                wb = new XLWorkbook(path);
                ws = wb.Worksheet("Pixel Count");
            }
            else
            {
                wb = new XLWorkbook();
                ws = wb.Worksheets.Add("Pixel Count");

                ws.Cell(1, 1).Value = "Image Name";
                ws.Cell(1, 2).Value = "White Pixels";
                ws.Cell(1, 3).Value = "Black Pixels";
            }
            //string image_Name = Path.GetFileName(imagePaths[currentIndex]);

            int row = ws.LastRowUsed().RowNumber() + 1;


            ws.Cell(row, 2).Value = white_pixel;
            ws.Cell(row, 3).Value = bp;

            wb.SaveAs(path);
        }


        //Hough Circle Transform
        private void Houghcircle(Mat img)
        {
            try
            {
                Mat input_img = img.Clone();
                if (input_img.Channels() >= 3)
                {
                    Cv2.CvtColor(input_img, input_img, ColorConversionCodes.BGR2GRAY);
                }
                Cv2.GaussianBlur(input_img, input_img, new Size(9, 9), 2);
                int dp = 1;
                int minDist = 100;
                int param1 = 100;
                int param2 = 30;
                int minRadius = 0;
                int maxRadius = 0;

                if (!string.IsNullOrWhiteSpace(tbDP.Text))
                    dp = int.Parse(tbDP.Text);

                if (!string.IsNullOrWhiteSpace(tbMinDist.Text))
                    minDist = int.Parse(tbMinDist.Text);

                if (!string.IsNullOrWhiteSpace(tbMinRadius.Text))
                    minRadius = int.Parse(tbMinRadius.Text);

                if (!string.IsNullOrWhiteSpace(tbMaxRadius.Text))
                    maxRadius = int.Parse(tbMaxRadius.Text);

                if (!string.IsNullOrWhiteSpace(tbParam1.Text))
                    param1 = int.Parse(tbParam1.Text);

                if (!string.IsNullOrWhiteSpace(tbParam2.Text))
                    param2 = int.Parse(tbParam2.Text);

                CircleSegment[] circles = Cv2.HoughCircles(input_img, HoughModes.Gradient, dp, minDist, param1, param2, minRadius, maxRadius);
                foreach (CircleSegment circle in circles)
                {
                    OpenCvSharp.Point center = new OpenCvSharp.Point((int)circle.Center.X, (int)circle.Center.Y);
                    int radius = (int)circle.Radius;
                    Cv2.Circle(img, center, radius, Scalar.Red, 5);
                }
                pictureBox3.Image = BitmapConverter.ToBitmap(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void ConnectedComponents(Mat img)
        {
            try
            {
                Mat input_img = img.Clone();

                // Convert to grayscale
                if (input_img.Channels() >= 3)
                {
                    Cv2.CvtColor(input_img, input_img, ColorConversionCodes.BGR2GRAY);
                }

                // Threshold
                Mat thresh = new Mat();
                Cv2.Threshold(input_img, thresh, 20, 255, ThresholdTypes.Binary);


                //hough circle

                int dp = 1;
                int minDist = 100;
                int param1 = 100; //param1 ↓ → more edges considered | param1 ↑ → fewer / stronger edges considered
                int param2 = 50;
                int minRadius = 250;
                int maxRadius = 300;

                if (!string.IsNullOrWhiteSpace(tbDP.Text))
                    dp = int.Parse(lblDP.Text);


                if (!string.IsNullOrWhiteSpace(tbMinDist.Text))
                    minDist = int.Parse(lblMinDist.Text);

                if (!string.IsNullOrWhiteSpace(tbMaxRadius.Text))
                    minRadius = int.Parse(lblMinRadius.Text);


                if (!string.IsNullOrWhiteSpace(tbMaxRadius.Text))
                    maxRadius = int.Parse(lblMaxRadius.Text);

                if (!string.IsNullOrWhiteSpace(tbParam1.Text))
                    param1 = int.Parse(lblParam1.Text);

                if (!string.IsNullOrWhiteSpace(tbParam2.Text))
                    param2 = int.Parse(lblParam2.Text);

                CircleSegment[] circles = Cv2.HoughCircles(thresh, // Mat image
                    HoughModes.Gradient,// Detection method
                    dp,                  // dp (less value, more zoom in)
                    minDist,                 // minDist - between the circle radius 
                    param1,                 // param1 - the higher threshold for the internal Canny edge detector (Depends on edge strength. High-contrast images → 80–150. Weak edges → 30–80.)
                    param2,                 // param2 - Think of it as the confidence required.(Trial and error. Start around 30 and adjust until you get the circles you want.)
                    minRadius,                 // minRadius
                    maxRadius);                // maxRadius

                foreach (CircleSegment circle in circles)
                {
                    Debug.WriteLine($"Center: {circle.Center}, Radius: {circle.Radius}");
                    //if (circle.Radius >= 30 && circle.Radius<= 90)
                    {

                        OpenCvSharp.Point center = new OpenCvSharp.Point((int)circle.Center.X, (int)circle.Center.Y);
                        int radius = (int)circle.Radius;
                        Cv2.Circle(img, center, radius, Scalar.Green, 1000);
                    }
                }
                pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(thresh);


                // Connected Components
                Mat labels = new Mat();
                Mat stats = new Mat();
                Mat centroids = new Mat();

                int numberOfComponents = Cv2.ConnectedComponentsWithStats(
                    thresh,
                    labels,
                    stats,
                    centroids
                );


                for (int i = 1; i < numberOfComponents; i++)
                {
                    int x = stats.At<int>(i, (int)ConnectedComponentsTypes.Left);
                    int y = stats.At<int>(i, (int)ConnectedComponentsTypes.Top);
                    int width = stats.At<int>(i, (int)ConnectedComponentsTypes.Width);
                    int height = stats.At<int>(i, (int)ConnectedComponentsTypes.Height);
                    int area = stats.At<int>(i, (int)ConnectedComponentsTypes.Area);


                    if (area > 10000)
                    {
                        Rect rect = new Rect(x, y, width, height);

                        Cv2.Rectangle(
                            img,
                            rect,
                            Scalar.Green,
                            5
                        );

                        Console.WriteLine(
                            $"Component {i}: Area={area}, X={x}, Y={y}, W={width}, H={height}"
                        );
                    }
                }

                pictureBox3.Image = BitmapConverter.ToBitmap(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void cbGain_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.ConvertScaleAbs(img, dst, 2, 0);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbsobel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pictureBox2.Image);
                Mat img = OpenCvSharp.Extensions.BitmapConverter.ToMat(bmp);
                Mat sobelXY = new Mat();
                Cv2.CvtColor(img, sobelXY, ColorConversionCodes.BGR2GRAY);
                Cv2.Sobel(sobelXY, sobelXY, MatType.CV_64F, 2, 2, 3); // src, dst, ddepth, dx, dy, ksize
                Cv2.ConvertScaleAbs(sobelXY, sobelXY);
                pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(sobelXY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbcanny_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                //Mat inpimg = img.Clone();
                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY);
                Cv2.Canny(img, img, 80, 100);
                pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbthreshold_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat img1 = img.Clone();


                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY);
                Cv2.Threshold(img, img, 20, 255, ThresholdTypes.Binary);
                //Cv2.BitwiseNot(img, img);
                //Cv2.ConvertScaleAbs(img, img);
                pictureBox3.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(img);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbgrayscale_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat inpimg = img.Clone();
                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY, 0);
                pictureBox3.Image = BitmapConverter.ToBitmap(img);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbHSV_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat inpimg = img.Clone();
                Mat dst = new Mat();
                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2HSV);
                Cv2.InRange(img, new Scalar(int.Parse(tbH.Text),
                                            int.Parse(tbS.Text),
                                            int.Parse(tbV.Text)),
                                            new Scalar(int.Parse(tbH2.Text),
                                            int.Parse(tbS2.Text),
                                            int.Parse(tbV2.Text)), dst);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbLAB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat inpimg = img.Clone();
                Mat lab = new Mat();
                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2Lab);
                Cv2.InRange(img, new Scalar(50, 110, 150), new Scalar(220, 255, 150), lab);
                pictureBox3.Image = BitmapConverter.ToBitmap(lab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Enhances local image contrast while limiting noise amplification.
        private void cbClahe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat inpimg = img.Clone();
                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY);

                var clahe = Cv2.CreateCLAHE(2.0, new OpenCvSharp.Size(8, 8));

                Mat dst = new Mat();
                clahe.Apply(img, dst);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbHistogramEquilization_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat inpimg = img.Clone();
                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY, 0);

                Mat dst = new Mat();
                Cv2.EqualizeHist(img, dst);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Replaces a pixel with the weighted average of neighboring pixels.
        private void cbGaussianBlur_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat inpimg = img.Clone();
                //Cv2.CvtColor(inpimg, inpimg, ColorConversionCodes.BGR2GRAY,0);
                Cv2.GaussianBlur(img, img, new OpenCvSharp.Size(5, 5), 30);
                pictureBox3.Image = BitmapConverter.ToBitmap(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Removes salt-and-pepper noise by replacing each pixel with the median of its neighbors.
        private void cbMedianBlur_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat inpimg = img.Clone();
                Cv2.MedianBlur(img, img, 9);
                pictureBox3.Image = BitmapConverter.ToBitmap(img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Reduces noise while preserving object edges.
        private void cbBilateralFilter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat inpimg = img.Clone();
                Cv2.BilateralFilter(img, img, 9, 75, 75);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Increases edge contrast to make objects appear sharper.


        private void templatematch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbThresholdOtsu_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Mat gray = new Mat();
                Cv2.CvtColor(img, gray, ColorConversionCodes.BGR2GRAY);

                Mat thresh = new Mat();
                Cv2.Threshold(gray, thresh, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);
                pictureBox3.Image = thresh.ToBitmap();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbThresholdAdaptive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.AdaptiveThreshold(img, dst,
                    255, //maxValue,
                    AdaptiveThresholdTypes.GaussianC,
                    ThresholdTypes.Binary,
                    11, //blockSize - It is the size of the neighborhood around each pixel used to calculate the local threshold.
                    2);//C - After calculating the local threshold, OpenCV subtracts C.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Low-contrast images where Otsu doesn't choose a good threshold.
        private void cbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.Threshold(img, dst, 0, 255, ThresholdTypes.BinaryInv | ThresholdTypes.Triangle);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbToZero_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.Threshold(img, dst, 0, 255, ThresholdTypes.Tozero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblParam2_Click(object sender, EventArgs e)
        {

        }

        private void cbTruncate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void cbDilate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(5, 5));
                Cv2.Dilate(img, dst, kernel);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbErode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(5, 5));
                Cv2.Erode(img, dst, kernel);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbOpen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(5, 5));
                Cv2.MorphologyEx(img, dst, MorphTypes.Open, kernel);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbClose_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(5, 5));
                Cv2.MorphologyEx(img, dst, MorphTypes.Close, kernel);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbGradient_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(5, 5));
                Cv2.MorphologyEx(img, dst, MorphTypes.Gradient, kernel);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTopHat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Mat src = img.Clone();
                Mat dst = new Mat();
                Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(5, 5));
                Cv2.MorphologyEx(img, dst, MorphTypes.TopHat, kernel);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbBlackHat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(5, 5));
                Cv2.MorphologyEx(img, dst, MorphTypes.BlackHat, kernel);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbHitorMiss_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(5, 5));
                Cv2.MorphologyEx(img, dst, MorphTypes.HitMiss, kernel);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbLaplace_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.CvtColor(img, img, ColorConversionCodes.BGR2GRAY);
                Cv2.Laplacian(img, dst, MatType.CV_16S, 3);
                Cv2.ConvertScaleAbs(dst, dst);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbScharr_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.CvtColor(   img, img, ColorConversionCodes.BGR2GRAY);
                Cv2.Scharr(img, dst, MatType.CV_16S, 1, 0);
                Cv2.ConvertScaleAbs(dst, dst);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbResize_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.Resize(img, dst, new OpenCvSharp.Size(800, 600));
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbRotate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.Rotate(img, dst, RotateFlags.Rotate90Clockwise);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbFlip_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Cv2.Flip(img, dst, FlipMode.X);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAffineTransform_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Point2f[] srcTri = new Point2f[3];
                Point2f[] dstTri = new Point2f[3];
                srcTri[0] = new Point2f(0, 0);
                srcTri[1] = new Point2f(img.Cols - 1, 0);
                srcTri[2] = new Point2f(0, img.Rows - 1);
                dstTri[0] = new Point2f(img.Cols * 0.0f, img.Rows * 0.33f);
                dstTri[1] = new Point2f(img.Cols * 0.85f, img.Rows * 0.25f);
                dstTri[2] = new Point2f(img.Cols * 0.15f, img.Rows * 0.7f);
                Mat warpMat = Cv2.GetAffineTransform(srcTri, dstTri);
                Cv2.WarpAffine(img, dst, warpMat, new OpenCvSharp.Size(img.Cols, img.Rows));
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbPerspectiveTransform_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Point2f[] srcQuad = new Point2f[4];
                Point2f[] dstQuad = new Point2f[4];
                srcQuad[0] = new Point2f(0, 0);
                srcQuad[1] = new Point2f(img.Cols - 1, 0);
                srcQuad[2] = new Point2f(img.Cols - 1, img.Rows - 1);
                srcQuad[3] = new Point2f(0, img.Rows - 1);
                dstQuad[0] = new Point2f(img.Cols * 0.0f, img.Rows * 0.33f);
                dstQuad[1] = new Point2f(img.Cols * 0.85f, img.Rows * 0.25f);
                dstQuad[2] = new Point2f(img.Cols * 0.85f, img.Rows * 0.75f);
                dstQuad[3] = new Point2f(img.Cols * 0.15f, img.Rows * 0.7f);
                Mat perspectiveMat = Cv2.GetPerspectiveTransform(srcQuad, dstQuad);
                Cv2.WarpPerspective(img, dst, perspectiveMat, new OpenCvSharp.Size(img.Cols, img.Rows));
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbWarp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Mat dst = new Mat();
                Point2f[] srcTri = new Point2f[3];
                Point2f[] dstTri = new Point2f[3];
                srcTri[0] = new Point2f(0, 0);
                srcTri[1] = new Point2f(img.Cols - 1, 0);
                srcTri[2] = new Point2f(0, img.Rows - 1);
                dstTri[0] = new Point2f(img.Cols * 0.0f, img.Rows * 0.33f);
                dstTri[1] = new Point2f(img.Cols * 0.85f, img.Rows * 0.25f);
                dstTri[2] = new Point2f(img.Cols * 0.15f, img.Rows * 0.7f);
                Mat warpMat = Cv2.GetAffineTransform(srcTri, dstTri);
                Cv2.WarpAffine(img, dst, warpMat, new OpenCvSharp.Size(img.Cols, img.Rows));
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCrop_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Mat src = img.Clone();
                Rect roi = new Rect(100, 100, 200, 200);
                Mat dst = new Mat(img, roi);
                pictureBox3.Image = BitmapConverter.ToBitmap(dst);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MinEnclosingCircle(Mat img)
        {
            Mat gray = new Mat();
            Cv2.CvtColor(img, gray, ColorConversionCodes.BGR2GRAY);

            // Threshold black region
            Mat binary = new Mat();
            Cv2.Threshold(gray, binary, 50, 255, ThresholdTypes.BinaryInv);

            // Find contours
            Cv2.FindContours(
                binary,
                out Point[][] contours,
                out HierarchyIndex[] hierarchy,
                RetrievalModes.External,
                ContourApproximationModes.ApproxSimple);

            // Find largest suitable contour
            double maxArea = 0;
            Point[] bestContour = null;

            foreach (Point[] contour in contours)
            {
                double area = Cv2.ContourArea(contour);

                if (area > maxArea)
                {
                    maxArea = area;
                    bestContour = contour;
                }
            }

            if (bestContour != null)
            {
                Point2f center;
                float radius;

                Cv2.MinEnclosingCircle(
                    bestContour,
                    out center,
                    out radius);

                double diameterPixels = radius * 2;

                Console.WriteLine($"Diameter = {diameterPixels:F2} pixels");
            }
        }

        private void cbMinEnclosing_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tpMorphologicalOperation_Click(object sender, EventArgs e)
        {

        }

        private void cbConnectedComponents_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}