using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ZetaLongPaths;

namespace random_image
{
    public partial class Form1 : Form
    {


        List<String> file_list = new List<String>();
        public static String[] random_filelist;
        public static String now_seek_dir;
        public static int now_idx = 0;
        public static String image_mode = "W";
        public static Double zoom_ratio = 1;
        String now_file = "";
        List<CheckBox> Array_Radio_edit = new List<CheckBox>();


        //##################### 메인폼 #####################
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ZlpFileInfo fi = new ZlpFileInfo(Application.StartupPath + "\\setup.ini");
            if (fi.Exists == false)
            {
                make_ini();
            }

            string nowdir_name;

            IniFile ini = new IniFile();
            ini.Load(Application.StartupPath + "\\setup.ini");

            //GetPrivateProfileString("Random Image Config", "dir", "", nowdir_name, 256, Application.StartupPath + "\\setup.ini");
            nowdir_name = ini["Random Image Config"]["dir"].ToString();
            if (nowdir_name != null && nowdir_name != "")
            {
                now_seek_dir = nowdir_name.ToString();
            }
            else
            {
                now_seek_dir = Application.StartupPath;
            }

            label_files.Text = "읽기준비중";
            view_image();
            label_zoom.Text = zoom_ratio.ToString();
            //read_files();

            //파일처리 설정 불러들이기
                        string config_value;
            String f_name, f_value1, f_value2;
            CheckBox box;
            groupBox_check.Controls.Clear();
            Array_Radio_edit.Clear();

            int j = 0, p = 0, q = 0;
            double r;
            for (int i = 1; i <= 20; i++)
            {
                //제목
                f_name = "file_title" + i.ToString();
                //GetPrivateProfileString("Radndom Image Config", f_name, "", config_value, 256, Application.StartupPath + "\\setup.ini");
                config_value = ini["Random Image Config"][f_name].ToString();
                if (config_value == null) config_value = "";
                f_value1 = config_value.ToString();

                //경로
                f_name = "file_path" + i.ToString();
                config_value = ini["Random Image Config"][f_name].ToString();
                if (config_value == null) config_value = "";
                f_value2 = config_value.ToString();

                if (f_value1 != "" && f_value1 != null && f_value2 != "" && f_value2 != null)
                {
                    //편집 그룹박스
                    box = new CheckBox();
                    box.Name = "radio_edit" + j;
                    box.Tag = f_value2;
                    box.Text = f_value1;
                    box.Checked = false;
                    box.AutoSize = false;
                    box.Width = 140;
                    box.Height = 17;
                    r = j / 2;
                    r = Math.Truncate(r); // 몫
                    p = Convert.ToInt32(r);
                    q = j % 2;
                    box.Location = new System.Drawing.Point(10, 34 + j * 18); //vertical
                    box.Click += change_color;
                    groupBox_check.Controls.Add(box);
                    Array_Radio_edit.Add(box);
                    j++;

                }


            }



        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            view_image();
            label_zoom.Text = zoom_ratio.ToString();
        }

        private void make_ini()
        {
            List<string> outputList = new List<string>();
            File.WriteAllLines(Application.StartupPath + "\\setup.ini", outputList, Encoding.UTF8);

        }


        //##################### 메인폼END #####################







        //##################### 메뉴 #####################
        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 pop2 = new Form2();
            pop2.ShowDialog();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //종료확인
            if (MessageBox.Show("종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //##################### 메뉴END #####################







        //##################### 버튼 #####################
        private void btn_fullscreen_Click(object sender, EventArgs e)
        {
            Form3 pop3 = new Form3();
            pop3.ShowDialog();
        }


        private void btn_reload_Click(object sender, EventArgs e)
        {
            label_files.Text = "목록읽는중....";
            read_files();
            view_image();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            next_image();
        }

        private void pic_preview_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Form3 pop3 = new Form3();
                pop3.ShowDialog();
            }
        }



        private void btn_zoom_ini_Click(object sender, EventArgs e)
        {
            zoom_ratio = 1;
            label_zoom.Text = zoom_ratio.ToString();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            del_image(now_file);
        }

        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Array_Radio_edit.Count; i++)
            {
                Array_Radio_edit[i].Checked = checkBox_all.Checked;
            }
            change_color(sender, e);
        }


        //##################### 버튼END #####################










        //##################### 라디오버튼 #####################
        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            now_image_mode();
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            now_image_mode();
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            now_image_mode();
        }
        private void radio4_CheckedChanged(object sender, EventArgs e)
        {
            now_image_mode();
        }

        private void now_image_mode()
        {
            if (radio1.Checked == true) image_mode = "W";
            if (radio2.Checked == true) image_mode = "O";
            if (radio3.Checked == true) image_mode = "R";
            if (radio4.Checked == true) image_mode = "A";

        }
        //##################### 라디오버튼END #####################







        //##################### 일반공용함수 #####################
        public void read_files()
        {
            now_idx = 0;
            file_list.Clear();
            String now_dir;
            for (int i = 0; i < Array_Radio_edit.Count; i++)
            {
                if (Array_Radio_edit[i].Checked == true)
                {
                    now_dir = Array_Radio_edit[i].Tag.ToString();
                    ZlpDirectoryInfo di = new ZlpDirectoryInfo(now_dir);
                    if (di.Exists)
                    {
                        read_dir(now_dir);
                    }
                }
            }
            if (file_list.Count > 0)
            {
                random_filelist = file_list.ToArray();
                //배열섞기
                Random random = new Random();
                random_filelist = random_filelist.OrderBy(x => random.Next()).ToArray();
                now_file = random_filelist[now_idx];
            }
            label_files.Text = file_list.Count.ToString() + " files";

        }

        public void read_dir(String dir_path)
        {
            String FolderName = dir_path;
            //System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(FolderName);
            ZlpDirectoryInfo di = new ZlpDirectoryInfo(FolderName);
            //파일처리
            String f_path = "", f_ext = "", sub_dirname;
            if (di.Exists)
            {
                foreach (ZlpFileInfo File in di.GetFiles())
                {

                    f_path = FolderName + "\\" + File.Name;
//                    FileInfo file = new FileInfo(f_path);
                    ZlpFileInfo file = new ZlpFileInfo(f_path);
                    if (file.Exists)
                    {
                        //f_ext = System.IO.Path.GetExtension(f_path).Replace(".", "").ToLower();
                        f_ext = ZlpPathHelper.GetExtension(f_path).Replace(".", "").ToLower();
                        //Debug.WriteLine("검사중 : " + f_path + " / "+ f_ext);

                        if (f_ext == "bmp" || f_ext == "gif" || f_ext == "jpg" || f_ext == "jpeg" || f_ext == "png")
                        {
                           file_list.Add(f_path);
                        }
                    }

                }
                //디렉토리 처리
                //di = new System.IO.DirectoryInfo(FolderName);
                di = new ZlpDirectoryInfo(FolderName);
                ZlpDirectoryInfo sub_di;
                foreach (ZlpDirectoryInfo Dirs in di.GetDirectories())
                {
                    sub_dirname = FolderName + "\\" + Dirs.Name;
                    sub_di = new ZlpDirectoryInfo(sub_dirname);
                    if (sub_di.Exists)
                    {
                        read_dir(sub_dirname);
                    }

                }


            }

        }



        private void view_image()
        {
            if (file_list != null && random_filelist != null)
            {
                if (random_filelist.Length > 0)
                {
                    now_file = random_filelist[now_idx];
                    //FileInfo file = new FileInfo(now_file)
                    ZlpFileInfo file = new ZlpFileInfo(now_file);
                    if (file.Exists)
                    {
                        //                        Image sourceImage = Image.FromFile(now_file);
                        //                        pic_preview.Image = sourceImage;
                        //System.IO.StreamReader pimg = new System.IO.StreamReader(now_file);
                        //pic_preview.Image = Image.FromStream(pimg.BaseStream);
                        pic_preview.Image = LoadBitmap(now_file);
                        //Delay(500);
                        //pimg.Dispose();

                        int now_num = now_idx + 1;
                        label_files.Text = now_num.ToString() + " / " + file_list.Count.ToString() + " files";
                        label_filename.Text = now_file;
                    }
                    else
                    {
                      // next_image();
                    }
                }
            }
        }



        private void next_image()
        {
            if (file_list != null && random_filelist != null)
            {
                now_idx++;
                if (now_idx >= random_filelist.Length) now_idx = 0;
                view_image();
            }
        }
        private void del_image(String file_name)
        {
            //삭제확인
            if (MessageBox.Show("삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //FileInfo file = new FileInfo(file_name);
                ZlpFileInfo file = new ZlpFileInfo(file_name);
                if (file.Exists)
                {
                    next_image();
                    //System.IO.File.Delete(file_name);
                    ZlpIOHelper.DeleteFile(file_name);
                }
            }
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
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

        void change_color(object sender, EventArgs e)
        {
            //RadioButton box = (RadioButton)sender;
            //   if (box.Checked == true) box.BackColor = Color.Red;
            //            else box.BackColor = box.BackColor = Color.Transparent;
            for (int i = 0; i < Array_Radio_edit.Count; i++)
            {
                if (Array_Radio_edit[i].Checked == true)
                {
                    Array_Radio_edit[i].ForeColor = Color.White;
                    Array_Radio_edit[i].BackColor = Color.SteelBlue;
                }
                else
                {
                    Array_Radio_edit[i].ForeColor = Color.Black;
                    Array_Radio_edit[i].BackColor = Color.Transparent;
                }
            }
        }




        //##################### 일반공용함수END #####################




    }
}
