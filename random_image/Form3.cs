using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZetaLongPaths;

namespace random_image
{
    public partial class Form3 : Form
    {
        private Point mousePoint; // 현재 마우스 포인터의 좌표저장 변수 선언
        Image sourceImage;
        int source_width = 0, source_height = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pic_big.Top = 0;
            pic_big.Left = 0;
            view_image();
            this.MouseWheel += new MouseEventHandler(Mouse_wheel);
        }
        private void view_image()
        {
            if (Form1.random_filelist != null)
            {
                if (Form1.random_filelist.Length > 0)
                {
                    String now_file = Form1.random_filelist[Form1.now_idx];
                    FileInfo file = new FileInfo(now_file);
                    if (file.Exists)
                    {
                        pic_big.Visible = false;

                        //System.IO.StreamReader pimg = new System.IO.StreamReader(now_file);
                        //sourceImage = Image.FromStream(pimg.BaseStream);
                        sourceImage = LoadBitmap(now_file);

                        pic_big.Image = sourceImage;
                        source_width = sourceImage.Width;
                        source_height = sourceImage.Height;
                        

                        //sourceImage = Image.FromFile(now_file);
                        //source_width = sourceImage.Width;
                        //source_height = sourceImage.Height;
                        //pic_big.Image = sourceImage;
                        
                        if (Form1.image_mode == "W")
                        {
                            Form1.zoom_ratio = 1;
                            pic_big.Top = 0;
                            pic_big.Left = 0;
                            pic_big.SizeMode = PictureBoxSizeMode.StretchImage;
                             double img_ratio = 0;
                             if (sourceImage.Width > 0) img_ratio = ((double)sourceImage.Height / (double)sourceImage.Width);
                             //Debug.WriteLine(img_ratio.ToString());
                             pic_big.Width = this.Width;
                             pic_big.Height = (int) Math.Floor((double)pic_big.Width * img_ratio);
                            source_width = pic_big.Width;
                            source_height = pic_big.Height;

                        }
                        if (Form1.image_mode == "O")
                        {
                            Form1.zoom_ratio = 1;
                            pic_big.Top = 0;
                            pic_big.Left = 0;
                            pic_big.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic_big.Width = sourceImage.Width;
                            pic_big.Height = sourceImage.Height;

                        }
                        if (Form1.image_mode == "R")
                        {
                            pic_big.SizeMode = PictureBoxSizeMode.StretchImage;
                            double temp_width = sourceImage.Width * Form1.zoom_ratio;
                            double temp_height = sourceImage.Height * Form1.zoom_ratio;
                            pic_big.Width = Convert.ToInt32(temp_width);
                            pic_big.Height = Convert.ToInt32(temp_height);

                        }
                        if (Form1.image_mode == "A")
                        {
                            Form1.zoom_ratio = 1;
                            pic_big.Top = 0;
                            pic_big.Left = 0;
                            pic_big.SizeMode = PictureBoxSizeMode.Zoom;
                            pic_big.Width = this.Width;
                            pic_big.Height = this.Height;
                            source_width = pic_big.Width;
                            source_height = pic_big.Height;
                        }

                        if (pic_big.Width < this.Width)
                        {
                            pic_big.Left = (this.Width - pic_big.Width) / 2;
                        }

                        if (pic_big.Height < this.Height)
                        {
                            pic_big.Top = (this.Height - pic_big.Height) / 2;
                        }
                        
                        pic_big.Visible = true;
                       // pimg.Dispose();
                    }
                }
            }
        }

        private void image_resize()
        {
            if (sourceImage != null)
            {
                double temp_width = source_width * Form1.zoom_ratio;
                double temp_height = source_height * Form1.zoom_ratio;

                pic_big.Width = Convert.ToInt32(temp_width);
                pic_big.Height = Convert.ToInt32(temp_height);

//                pic_big.Image = ResizeImage(sourceImage, Convert.ToInt32(temp_width), Convert.ToInt32(temp_height));

                if (pic_big.Width < this.Width)
                {
                    pic_big.Left = (this.Width - pic_big.Width) / 2;
                }

                if (pic_big.Height < this.Height)
                {
                    pic_big.Top = (this.Height - pic_big.Height) / 2;
                }
                pic_big.Visible = true;
            }
        }



        private void next_image()
        {
            if (Form1.random_filelist != null)
            {
                pic_big.Visible = false;
                Form1.now_idx++;
                if (Form1.now_idx >= Form1.random_filelist.Length) Form1.now_idx = 0;
                pic_big.Top = 0;
                pic_big.Left = 0;
                view_image();
            }
        }

        private void pic_big_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                this.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                next_image();
            }

        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                
                this.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                next_image();
            }
        }

        private void pic_big_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y); //현재 마우스 좌표 저장
        }

        private void pic_big_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pic_big_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left) //마우스 왼쪽 클릭 시에만 실행
            {
                //폼의 위치를 드래그중인 마우스의 좌표로 이동 
                // Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
                int movied_top = pic_big.Top - (mousePoint.Y - e.Y);

                if (movied_top > 0) movied_top = 0;
                else if (pic_big.Height <= this.ClientSize.Height - movied_top)
                {
                    movied_top = this.ClientSize.Height - pic_big.Height;
                }
                if (movied_top > 0) movied_top = 0;
                if(pic_big.Height > this.Height) pic_big.Top = movied_top;


                int movied_left = pic_big.Left - (mousePoint.X - e.X);
                if (movied_left > 0) movied_left = 0;
                else if (pic_big.Width <= this.ClientSize.Width - movied_left)
                {
                    movied_left = this.ClientSize.Width - pic_big.Width;
                }
                if (movied_left > 0) movied_left = 0;
                if (pic_big.Width > this.Width)  pic_big.Left = movied_left;

            }
        }

        private void zoom_in()
        {
            if (sourceImage != null)
            {
                double temp_top = (source_height * (Form1.zoom_ratio + 0.1) - source_height * Form1.zoom_ratio) / 2;
                double temp_left = (source_width * (Form1.zoom_ratio + 0.1) - source_width * Form1.zoom_ratio) / 2;
                Form1.zoom_ratio += 0.1;
                pic_big.Top -= Convert.ToInt32(temp_top);
                pic_big.Left -= Convert.ToInt32(temp_left);
                pic_big.Visible = false;
                image_resize();
                //view_image();
            }
        }




        private void zoom_out()
        {
            if (sourceImage != null)
            {
                double temp_top = (source_height * (Form1.zoom_ratio) - source_height * (Form1.zoom_ratio - 0.1)) / 2;
                double temp_left = (source_width * (Form1.zoom_ratio) - source_width * (Form1.zoom_ratio - 0.1)) / 2;
                Form1.zoom_ratio -= 0.1;
                if (Form1.zoom_ratio < 0.1)
                {
                    Form1.zoom_ratio = 0.1;
                }
                else
                {
                    pic_big.Top += Convert.ToInt32(temp_top);
                    pic_big.Left += Convert.ToInt32(temp_left);
                }
                pic_big.Visible = false;
                image_resize();
                //view_image();
            }
        }


        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void Form3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            switch (e.KeyCode)
            {

                case Keys.Add:
                    zoom_in();
                break;
                case Keys.Subtract:
                    zoom_out();
                break;
                case Keys.Escape:
                    this.Close();
                break;
                default:
                    break;


            }
        }

        private void Mouse_wheel(object sender, MouseEventArgs e)
        {
            
                        int lines = e.Delta * SystemInformation.MouseWheelScrollLines / 120;

                        if (lines > 0)  //위로 스크롤
                        {
                          zoom_in();
                        }
                        else if (lines < 0)   //아래로 스크롤
                        {
                          zoom_out();
                        }
            
        }

        //이미지 파일 메모리에 적재(사용중인 파일 문제 해결),  ZetaLongPaths라이브러리로 긴파일이름 오류해결
        public Bitmap LoadBitmap(string path)
        {
            ZlpFileInfo zfi = new ZlpFileInfo(path);
            if (zfi.Exists)
            {
                // open file in read only mode

                // get a binary reader for the file stream

                var fileHandle = ZlpIOHelper.CreateFileHandle(path, ZetaLongPaths.Native.CreationDisposition.OpenAlways, ZetaLongPaths.Native.FileAccess.GenericRead, ZetaLongPaths.Native.FileShare.Read);
                FileStream stream = new System.IO.FileStream(fileHandle, System.IO.FileAccess.Read);


                using (BinaryReader reader = new BinaryReader(stream))
                {
                    // copy the content of the file into a memory stream
                    var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                    // make a new Bitmap object the owner of the MemoryStream

                    return resize_bitmap(new Bitmap(memoryStream), 2732, 2400);
                }
            }
            else
            {
                //        MessageBox.Show("Error Loading File.", "Error!", MessageBoxButtons.OK);
                return null;
            }
        }


        private static Bitmap resize_bitmap(Bitmap mkimg, int max_width, int max_height)
        {

            //int max_width = 2732, max_height = 2400;
            Bitmap croppedBitmap = mkimg;
            if (mkimg.Width > max_width || mkimg.Height > max_height)
            {

                double ratioX = max_width / (double)mkimg.Width;
                double ratioY = max_height / (double)mkimg.Height;
                double ratio = Math.Min(ratioX, ratioY);


                int newWidth = (int)(mkimg.Width * ratio);
                int newHeight = (int)(mkimg.Height * ratio);

                Size resize = new Size(newWidth, newHeight);
                croppedBitmap = new Bitmap(mkimg, resize);



            }

            return croppedBitmap;
        }




    }
}
