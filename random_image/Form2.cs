using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_image
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string config_value;
            String f_name, f_title;
            Control[] ctrls;

            FileInfo fi = new FileInfo(Application.StartupPath + "\\setup.ini");
            if (fi.Exists == false)
            {
                make_ini();
            }


            IniFile ini = new IniFile();
            ini.Load(Application.StartupPath + "\\setup.ini");

            for (int i=1; i<=20; i++)
            {
                //제목
                f_name = "file_title" + i.ToString();
                config_value = ini["Random Image Config"][f_name].ToString();
                if (config_value == null) config_value = "";
                f_title = "text_name" + i.ToString();
                ctrls = this.Controls.Find(f_title, true);
                ctrls[0].Text = config_value.ToString();

                //경로
                f_name = "file_path" + i.ToString();
                config_value = ini["Random Image Config"][f_name].ToString();
                if (config_value == null) config_value = "";
                f_title = "text_dir" + i.ToString();
                ctrls = this.Controls.Find(f_title, true);
                ctrls[0].Text = config_value.ToString();

            }

          
        }


        private void make_ini()
        {
            List<string> outputList = new List<string>();
            File.WriteAllLines(Application.StartupPath + "\\setup.ini", outputList, Encoding.UTF8);

        }


        private void btn_find1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir1.Text;
            dialog.ShowDialog();
            text_dir1.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir2.Text;
            dialog.ShowDialog();
            text_dir2.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir3.Text;
            dialog.ShowDialog();
            text_dir3.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir4.Text;
            dialog.ShowDialog();
            text_dir4.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir5.Text;
            dialog.ShowDialog();
            text_dir5.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir6.Text;
            dialog.ShowDialog();
            text_dir6.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir7.Text;
            dialog.ShowDialog();
            text_dir7.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir8.Text;
            dialog.ShowDialog();
            text_dir8.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find9_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir9.Text;
            dialog.ShowDialog();
            text_dir9.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find10_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir10.Text;
            dialog.ShowDialog();
            text_dir10.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find11_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir11.Text;
            dialog.ShowDialog();
            text_dir11.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find12_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir12.Text;
            dialog.ShowDialog();
            text_dir12.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find13_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir13.Text;
            dialog.ShowDialog();
            text_dir13.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find14_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir14.Text;
            dialog.ShowDialog();
            text_dir14.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find15_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir15.Text;
            dialog.ShowDialog();
            text_dir15.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find16_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir16.Text;
            dialog.ShowDialog();
            text_dir16.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find17_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir17.Text;
            dialog.ShowDialog();
            text_dir17.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find18_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir18.Text;
            dialog.ShowDialog();
            text_dir18.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find19_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir19.Text;
            dialog.ShowDialog();
            text_dir19.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_find20_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Reset();
            dialog.SelectedPath = text_dir20.Text;
            dialog.ShowDialog();
            text_dir20.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            StringBuilder config_value = new StringBuilder();
            String f_name, f_title;
            Control[] ctrls;
            IniFile ini = new IniFile();
            ini.Load(Application.StartupPath + "\\setup.ini");
            for (int i = 1; i <= 20; i++)
            {
                //제목
                f_title = "text_name" + i.ToString();
                ctrls = this.Controls.Find(f_title, true);
                f_name = "file_title" + i.ToString();
                ini["Random Image Config"][f_name] = ctrls[0].Text;

                //경로
                f_title = "text_dir" + i.ToString();
                ctrls = this.Controls.Find(f_title, true);
                f_name = "file_path" + i.ToString();
                ini["Random Image Config"][f_name] = ctrls[0].Text;
            }
            ini.Save(Application.StartupPath + "\\setup.ini");



        }
    }
}
