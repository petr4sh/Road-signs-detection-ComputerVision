using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace LR4_Video
{
    public partial class Form1 : Form
    {
        IplImage frame = null; // Буфер для хранения изображения
        IplImage HSV = null;
        IplImage binarized = null;
        IplImage CannyImage = null;
        IplImage Filtered = null;
        IplImage Smoothed = null;
        IplImage Contour = null;
        IplImage ROI = null;
        IplImage template = null;
        int counter = 0;
        int count = 0;
        int temp_number = 0;
        private IplImage templateImage;
        private IplImage maskImage;
        IplImage frame_copy = null;
        CvCapture capture = null; // Устройство захвата изображений
        CvWindow windowCapture = new CvWindow("Video_Capture"); // Создаем окно
        bool video = false;

        public Form1()
        {
            InitializeComponent();
            checkedFilterBox.SelectedItem = "Normal";
            hmin.Text = "100";
            hmax.Text = "150";
            smin.Text = "128";
            smax.Text = "255";
            vmin.Text = "128";
            vmax.Text = "255";
            textBoxMinContourSize.Text = "1200";
            textBoxMaxContourSize.Text = "12000";
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files|*.mp4;*.avi|All Files|*.*";
            bool stop = false;
            bool play = true;
            bool check = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                capture = CvCapture.FromFile(openFileDialog.FileName);
            }
            else
            {
                capture = CvCapture.FromCamera(0); // Открытие камеры по умолчанию
            }

            fpsBox.Text = Cv.GetCaptureProperty(capture, CaptureProperty.Fps).ToString();

            if (capture != null)
            {
                windowCapture.OnMouseCallback += new CvMouseCallback(OnMouseCallback);
                video = true;
                while (play)
                {
                    if (stop == false)
                    {
                        frame = capture.QueryFrame(); // Получение кадра
                        ApplySelectedFilter();
                        if (frame == null)
                        {
                            play = false; // Прекратить, если кадр не получен
                        }
                        if (filterBox.Checked)
                        {
                            FilteringImage(int.Parse(hmin.Text), int.Parse(hmax.Text), int.Parse(smin.Text), int.Parse(smax.Text), int.Parse(vmin.Text), int.Parse(vmax.Text));
                        }

                        windowCapture.ShowImage(frame); // Показ изображения с измененным размером

                        int key = CvWindow.WaitKey(33); // Ожидание нажатия клавиши
                        if (key == 27) // Esc
                        {
                            windowCapture.Close();
                            play = false;
                        }
                        else if (key == 13) // Enter
                        {
                            stop = true; //STOP
                            check = true;
                        }
                    }
                    else
                    {
                        if (autoBox.Checked && check)
                        {
                            mfPercentBox.Text = "";
                            stopPercentBox.Text = "";
                            leftPercentBox.Text = "";
                            moveForwardBox.Image = null;
                            stopSignBox.Image = null;
                            leftSighBox.Image = null;
                            temp_number = 0;

                            frame_copy = frame.Clone();
                            frame = capture.QueryFrame();
                            FilteringImage(100, 150, 128, 255, 0, 255);
                            ObjectDetection(Cv.LoadImage("C:\\Users\\fedot\\source\\repos\\tvision\\templates\\mf_mask.bmp"));
                            temp_number++;
                            frame = capture.QueryFrame();
                            IplImage filterRed = new IplImage(frame.Size, BitDepth.U8, 1);
                            IplImage filterRed1 = FilteringImage(0, 20, 75, 255, 180, 255);
                            frame = capture.QueryFrame();
                            IplImage filterRed2 = FilteringImage(150, 200, 128, 255, 0, 255);
                            frame = capture.QueryFrame();
                            IplImage filterRed3 = FilteringImage(0, 50, 220, 255, 50, 255);
                            Cv.Or(filterRed1, filterRed2, filterRed);
                            Cv.Or(filterRed3, filterRed, filterRed);
                            frame = filterRed.Clone();
                            ObjectDetection(Cv.LoadImage("C:\\Users\\fedot\\source\\repos\\tvision\\templates\\stop_mask.bmp"));
                            temp_number++;
                            frame = capture.QueryFrame();
                            FilteringImage(50, 150, 128, 255, 0, 255);
                            ObjectDetection(Cv.LoadImage("C:\\Users\\fedot\\source\\repos\\tvision\\templates\\left_mask.bmp"));
                            frame = frame_copy.Clone();
                            windowCapture.ShowImage(frame);
                            check = false;
                        }

                        int key = CvWindow.WaitKey(33);
                        if (key == 13) // Enter
                        {
                            stop = false; //PLAY
                        }
                        if (key == 27) // Esc
                        {
                            windowCapture.Close(); //NEED TO FIX
                            play = false;
                            video = false;
                        }
                    }
                }
            }
        }

        private void openImageBtn_Click(object sender, EventArgs e)
        {
            windowCapture.OnMouseCallback += new CvMouseCallback(OnMouseCallback);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                frame = Cv.LoadImage(openFileDialog.FileName);
                if (frame != null)
                {
                    temp_number = 0;
                    //ShowResizedImage(frame); // Показ изображения с измененным размером
                    if (filterBox.Checked)
                    {
                        FilteringImage(int.Parse(hmin.Text), int.Parse(hmax.Text), int.Parse(smin.Text), int.Parse(smax.Text), int.Parse(vmin.Text), int.Parse(vmax.Text));
                    }
                    else if (autoBox.Checked)
                    {
                        temp_number = 0;
                        mfPercentBox.Text = "";
                        stopPercentBox.Text = "";
                        leftPercentBox.Text = "";
                        moveForwardBox.Image = null;
                        stopSignBox.Image = null;
                        leftSighBox.Image = null;
                        frame_copy = frame.Clone();
                        frame = Cv.LoadImage(openFileDialog.FileName);
                        FilteringImage(100, 150, 128, 255, 0, 255);
                        ObjectDetection(Cv.LoadImage("C:\\Users\\fedot\\source\\repos\\tvision\\templates\\mf_mask.bmp"));
                        temp_number++;
                        frame = Cv.LoadImage(openFileDialog.FileName);
                        IplImage filterRed = new IplImage(frame.Size, BitDepth.U8, 1);
                        IplImage filterRed1 = FilteringImage(0, 20, 75, 255, 180, 255);
                        frame = Cv.LoadImage(openFileDialog.FileName);
                        IplImage filterRed2 = FilteringImage(150, 200, 128, 255, 0, 255);
                        frame = Cv.LoadImage(openFileDialog.FileName);
                        IplImage filterRed3 = FilteringImage(0, 50, 220, 255, 50, 255);
                        Cv.Or(filterRed1, filterRed2, filterRed);
                        Cv.Or(filterRed3, filterRed, filterRed);
                        frame = filterRed.Clone();
                        ObjectDetection(Cv.LoadImage("C:\\Users\\fedot\\source\\repos\\tvision\\templates\\stop_mask.bmp"));
                        temp_number++;
                        frame = Cv.LoadImage(openFileDialog.FileName);
                        FilteringImage(50, 150, 128, 255, 0, 150);
                        ObjectDetection(Cv.LoadImage("C:\\Users\\fedot\\source\\repos\\tvision\\templates\\left_mask.bmp"));
                        frame = frame_copy.Clone();
                    }
                        
                    windowCapture.ShowImage(frame);
                    ApplySelectedFilter();
                }
                else
                {
                    MessageBox.Show("[!] Error: can't open image file.");
                }
            }
        }

        private void ApplySelectedFilter()
        {
            if (frame == null)
            {
                MessageBox.Show("[!] Error: no frame to process.");
                return;
            }

            string selectedFilter = checkedFilterBox.SelectedItem.ToString();
            HSV = new IplImage(frame.Size, BitDepth.U8, 3);
            switch (selectedFilter)
            {
                case "CvtColor":
                    Cv.CvtColor(frame, HSV, ColorConversion.BgrToHsv);
                    frame = HSV;
                    windowCapture.ShowImage(HSV);
                    break;

                case "InRangeS":
                    binarized = new IplImage(frame.Size, BitDepth.U8, 1);
                    Cv.CvtColor(frame, HSV, ColorConversion.BgrToHsv);
                    Cv.InRangeS(HSV, new CvScalar(int.Parse(hmin.Text), int.Parse(smin.Text), int.Parse(vmin.Text)),
                        new CvScalar(int.Parse(hmax.Text), int.Parse(smax.Text), int.Parse(vmax.Text)), binarized);
                    frame = binarized;
                    windowCapture.ShowImage(binarized);
                    break;

                case "Canny":
                    CannyImage = new IplImage(frame.Size, BitDepth.U8, 1);
                    Cv.CvtColor(frame, CannyImage, ColorConversion.BgrToGray);
                    Cv.Canny(CannyImage, CannyImage, 50, 200);
                    frame = CannyImage;
                    windowCapture.ShowImage(CannyImage);
                    break;

                case "Filter2D":
                    Filtered = new IplImage(frame.Size, BitDepth.U8, 3);
                    float[] kernelData = { 0, -1, 0, -1, 5, -1, 0, -1, 0 }; // Пример ядра (усиление резкости)
                    CvMat kernel = new CvMat(3, 3, MatrixType.F32C1, kernelData);
                    Cv.Filter2D(frame, Filtered, kernel);
                    frame = Filtered;
                    windowCapture.ShowImage(Filtered);
                    break;

                case "Smooth":
                    Smoothed = new IplImage(frame.Size, BitDepth.U8, 3);
                    Cv.Smooth(frame, Smoothed, SmoothType.Gaussian, 9);
                    frame = Smoothed;
                    windowCapture.ShowImage(Smoothed);
                    break;

                case "Normal":
                    windowCapture.ShowImage(frame);
                    break;

                default:
                    MessageBox.Show("[!] Unknown filter selected.");
                    break;
            }
        }

        // Обработчик событий мыши для вывода параметров пикселя под курсором
        private void OnMouseCallback(MouseEvent @event, int x, int y, MouseEvent flags)
        {
            if (@event == MouseEvent.LButtonDown)
            {
                if (frame == null)
                    return;

                IplImage for_hsv = frame.Clone();
                IntPtr ptr = for_hsv.ImageData;
                int offset = (for_hsv.WidthStep * y) + (x * 3);
                byte b = Marshal.ReadByte(ptr, offset + 0); // B
                byte g = Marshal.ReadByte(ptr, offset + 1); // G
                byte r = Marshal.ReadByte(ptr, offset + 2); // R

                // Вывод значений пикселя на изображение
                string text = $"R={r}, G={g}, B={b}";
                for_hsv.PutText(text, new CvPoint(x, y), new CvFont(FontFace.HersheySimplex, 0.4, 0.4, 0, 1, LineType.AntiAlias), CvColor.Red);

                // Обновление окна
                windowCapture.ShowImage(for_hsv);
            }
        }

        // Фильтрация изображения по цветовому ключу
        private IplImage FilteringImage(int lowH, int highH, int lowS, int highS, int lowV, int highV)
        {
            HSV = new IplImage(frame.Size, BitDepth.U8, 3);
            Cv.CvtColor(frame, HSV, ColorConversion.BgrToHsv);

            binarized = new IplImage(frame.Size, BitDepth.U8, 1);
            Cv.InRangeS(HSV, new CvScalar(lowH, lowS, lowV), new CvScalar(highH, highS, highV), binarized);

            frame = binarized.Clone();
            return binarized;

            //windowCapture.ShowImage(maskedImage);
            //Итоговое изображение - frame
        }

        //Выделение объектов по границам

        List<double> percantages = new List<double>();
        private void ObjectDetection(IplImage mask = null)
        {
            percantages.Clear();
            percantages.Add(80);
            if (frame == null)
            {
                MessageBox.Show("[!] Error: no frame to process.");
                return;
            }

            //Smoothed = new IplImage(frame.Size, BitDepth.U8, 1);
            //Cv.Smooth(frame, Smoothed, SmoothType.Gaussian, 9);

            IplImage detected_obj_im = frame.Clone();

            //IplImage grayImage = new IplImage(detected_obj_im.Size, BitDepth.U8, 1);
            //Cv.CvtColor(detected_obj_im, grayImage, ColorConversion.BgrToGray);

            IplImage cannyImage = new IplImage(detected_obj_im.Size, BitDepth.U8, 1);
            Cv.Canny(detected_obj_im, cannyImage, 50, 200);

            CvSeq<CvPoint> contours;
            CvMemStorage storage = new CvMemStorage();
            Cv.FindContours(cannyImage, storage, out contours);

            int minContourSize = int.Parse(textBoxMinContourSize.Text);
            int maxContourSize = int.Parse(textBoxMaxContourSize.Text);

            IplImage resize = null;
            int count = 0;

            for (CvSeq<CvPoint> current = contours; current != null; current = current.HNext)
            {
                CvRect rect = Cv.BoundingRect(current);
                int contourSize = rect.Width * rect.Height;

                if (contourSize < minContourSize || contourSize > maxContourSize)
                    continue;

                //Cv.DrawContours(detected_obj_im, current, CvColor.Green, CvColor.Red, 1, 1, LineType.Link8);
                IplImage detected_copy = detected_obj_im.Clone();
                detected_obj_im.Rectangle(rect, CvColor.Blue, 2);

                bool ask = true;
                if (mask != null)
                {
                    IplImage frameWT = CompareWithTemplate(rect, detected_copy, mask);
                    if (frameWT != null)
                    {
                        ask = false;
                        detected_obj_im = frameWT.Clone();
                    }
                }
                if (ask)
                {
                    string rectParams = $"W={rect.Width}, H={rect.Height}";
                    detected_obj_im.PutText(rectParams, new CvPoint(rect.X, rect.Y - 10), new CvFont(FontFace.HersheySimplex, 0.4, 0.4, 0, 1, LineType.AntiAlias), CvColor.White);
                }

                if (askTempBtn.Checked)
                {
                    // работаем с фрагментами изображений
                    IplImage ROI = detected_obj_im.Clone();
                    Cv.SetImageROI(ROI, rect);
                    resize = Cv.CreateImage(Cv.Size(60, 60), ROI.Depth, ROI.NChannels);
                    Cv.Resize(ROI, resize, Interpolation.Linear);
                    Cv.ResetImageROI(ROI);

                    // Преобразование в HSV
                    IplImage resize_hsv = new IplImage(resize.GetSize(), BitDepth.U8, 3);
                    Cv.CvtColor(resize, resize_hsv, ColorConversion.BgrToHsv);

                    // Бинаризация
                    IplImage resize_binary = new IplImage(resize.GetSize(), BitDepth.U8, 1);
                    Cv.InRangeS(resize_hsv, new CvScalar(int.Parse(hmin.Text), int.Parse(smin.Text), int.Parse(vmin.Text)), new CvScalar(int.Parse(hmax.Text), int.Parse(smin.Text), int.Parse(vmin.Text)), resize_binary);


                    resize.SaveImage($"C:\\Users\\fedot\\source\\repos\\tvision\\templates\\template{counter}.bmp");
                    resize_binary.SaveImage($"C:\\Users\\fedot\\source\\repos\\tvision\\templates\\mask{counter}.bmp");

                    counter++;
                }
            }
            windowCapture.ShowImage(detected_obj_im);
        }

        //Функция сравнения фрагмента изображения с шаблоном
        private IplImage CompareWithTemplate(CvRect rect, IplImage frameWithTemplate, IplImage maskImage)
        {
            if (maskImage == null)
            {
                MessageBox.Show("[!] Error: Template or mask not loaded.");
                return null;
            }
            count++;

            // Установка ROI и копирование фрагмента изображения
            frameWithTemplate.SetROI(rect);
            IplImage fragment = frameWithTemplate.Clone();
            frameWithTemplate.ResetROI();

            // Преобразование maskImage в grayscale и изменение размера до размера шаблона, если требуется
            IplImage resizedMaskImage = new IplImage(maskImage.Size, BitDepth.U8, 1);
            Cv.CvtColor(maskImage, resizedMaskImage, ColorConversion.BgrToGray);

            // Изменение размера фрагмента до размера шаблона
            IplImage resizedFragment = new IplImage(maskImage.Size, maskImage.Depth, resizedMaskImage.NChannels);
            Cv.Resize(fragment, resizedFragment, Interpolation.Linear);

            // Попиксельное сравнение с шаблоном с учетом маски
            IplImage result = new IplImage(maskImage.Size, BitDepth.U8, 1);
            Cv.Xor(resizedFragment, resizedMaskImage, result);
            Cv.Not(result, result);

            // Вычисление количества белых пикселей
            int nonZeroCount = Cv.CountNonZero(result);
            int totalPixels = maskImage.Width * maskImage.Height;
            double matchPercentage = (double)nonZeroCount / totalPixels * 100;

            // Вывод результата
            if (!autoBox.Checked)
            {
                frameWithTemplate.PutText($"Match: {matchPercentage:F2}%", new CvPoint(rect.X, rect.Y - 10), new CvFont(FontFace.HersheySimplex, 0.4, 0.4, 0, 1, LineType.AntiAlias), CvColor.White);
                frameWithTemplate.Rectangle(rect, CvColor.Blue, 2);
            }

            if (autoBox.Checked)
            {
                if (matchPercentage > percantages.Max())
                {
                    frame_copy.PutText($"Match: {matchPercentage:F2}%", new CvPoint(rect.X, rect.Y - 10), new CvFont(FontFace.HersheySimplex, 0.4, 0.4, 0, 1, LineType.AntiAlias), CvColor.Red);
                    frame_copy.Rectangle(rect, CvColor.Blue, 2);
                    percantages.Add(matchPercentage);
                    if (temp_number == 0 && (matchPercentage > 58 || video))
                    {
                        mfPercentBox.Text = matchPercentage.ToString();
                        moveForwardBox.Image = resizedFragment.ToBitmap();
                    }
                    else if (temp_number == 1 && (matchPercentage > 52 || video))
                    {
                        stopPercentBox.Text = matchPercentage.ToString();
                        stopSignBox.Image = resizedFragment.ToBitmap();
                    }
                    else if (temp_number == 2 && (matchPercentage > 59 || video))
                    {
                        leftPercentBox.Text = matchPercentage.ToString();
                        leftSighBox.Image = resizedFragment.ToBitmap();
                    }
                }
            }

            return frameWithTemplate;
        }


        private void autoBox_CheckedChanged(object sender, EventArgs e)
        {
            if (autoBox.Checked)
            {
                askTempBtn.Enabled = false;
                tempBtn.Enabled = false;
            }
            else if (!autoBox.Checked)
            {
                askTempBtn.Enabled = true;
                tempBtn.Enabled = true;
            }
        }

        private void tempBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                template = Cv.LoadImage(openFileDialog.FileName);
                if (frame != null)
                {
                    ObjectDetection(template);
                }
            }
        }

        private void detectObjBtn_Click(object sender, EventArgs e)
        {
            ObjectDetection();
        }

        private void filterBox_CheckedChanged(object sender, EventArgs e)
        {
            if (filterBox.Checked) { tempBtn.Enabled = true; }
            else { tempBtn.Enabled = false; }
        }
    }
}
