namespace random_image
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_fullscreen = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.label_files = new System.Windows.Forms.Label();
            this.pic_preview = new System.Windows.Forms.PictureBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label_zoom = new System.Windows.Forms.Label();
            this.btn_zoom_ini = new System.Windows.Forms.Button();
            this.label_filename = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.groupBox_check = new System.Windows.Forms.GroupBox();
            this.checkBox_all = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.환경설정ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.환경설정ToolStripMenuItem.Text = "환경설정";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(693, 27);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(97, 57);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_fullscreen
            // 
            this.btn_fullscreen.Location = new System.Drawing.Point(693, 153);
            this.btn_fullscreen.Name = "btn_fullscreen";
            this.btn_fullscreen.Size = new System.Drawing.Size(97, 55);
            this.btn_fullscreen.TabIndex = 3;
            this.btn_fullscreen.Text = "전체화면";
            this.btn_fullscreen.UseVisualStyleBackColor = true;
            this.btn_fullscreen.Click += new System.EventHandler(this.btn_fullscreen_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(693, 90);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(97, 57);
            this.btn_reload.TabIndex = 4;
            this.btn_reload.Text = "디렉토리 읽기";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // label_files
            // 
            this.label_files.AutoSize = true;
            this.label_files.Location = new System.Drawing.Point(697, 228);
            this.label_files.Name = "label_files";
            this.label_files.Size = new System.Drawing.Size(17, 12);
            this.label_files.TabIndex = 5;
            this.label_files.Text = "...";
            // 
            // pic_preview
            // 
            this.pic_preview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_preview.Location = new System.Drawing.Point(9, 31);
            this.pic_preview.Name = "pic_preview";
            this.pic_preview.Size = new System.Drawing.Size(655, 386);
            this.pic_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_preview.TabIndex = 6;
            this.pic_preview.TabStop = false;
            this.pic_preview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_preview_MouseClick);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(6, 20);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(71, 16);
            this.radio1.TabIndex = 7;
            this.radio1.TabStop = true;
            this.radio1.Text = "가로맞춤";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(6, 38);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(71, 16);
            this.radio2.TabIndex = 8;
            this.radio2.Text = "원본크기";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio4);
            this.groupBox1.Controls.Add(this.radio3);
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.Controls.Add(this.radio2);
            this.groupBox1.Location = new System.Drawing.Point(693, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 97);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "크기";
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(6, 75);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(47, 16);
            this.radio4.TabIndex = 10;
            this.radio4.Text = "자동";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.radio4_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(6, 56);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(71, 16);
            this.radio3.TabIndex = 9;
            this.radio3.Text = "비율유지";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "확대비율";
            // 
            // label_zoom
            // 
            this.label_zoom.AutoSize = true;
            this.label_zoom.Location = new System.Drawing.Point(695, 390);
            this.label_zoom.Name = "label_zoom";
            this.label_zoom.Size = new System.Drawing.Size(21, 12);
            this.label_zoom.TabIndex = 11;
            this.label_zoom.Text = "1.0";
            // 
            // btn_zoom_ini
            // 
            this.btn_zoom_ini.Location = new System.Drawing.Point(748, 364);
            this.btn_zoom_ini.Name = "btn_zoom_ini";
            this.btn_zoom_ini.Size = new System.Drawing.Size(42, 21);
            this.btn_zoom_ini.TabIndex = 12;
            this.btn_zoom_ini.Text = "reset";
            this.btn_zoom_ini.UseVisualStyleBackColor = true;
            this.btn_zoom_ini.Click += new System.EventHandler(this.btn_zoom_ini_Click);
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.Location = new System.Drawing.Point(14, 429);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(17, 12);
            this.label_filename.TabIndex = 13;
            this.label_filename.Text = "...";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(589, 419);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(73, 25);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "삭제";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // groupBox_check
            // 
            this.groupBox_check.Location = new System.Drawing.Point(794, 27);
            this.groupBox_check.Name = "groupBox_check";
            this.groupBox_check.Size = new System.Drawing.Size(156, 396);
            this.groupBox_check.TabIndex = 15;
            this.groupBox_check.TabStop = false;
            this.groupBox_check.Text = "디렉토리선택";
            // 
            // checkBox_all
            // 
            this.checkBox_all.AutoSize = true;
            this.checkBox_all.Location = new System.Drawing.Point(804, 44);
            this.checkBox_all.Name = "checkBox_all";
            this.checkBox_all.Size = new System.Drawing.Size(72, 16);
            this.checkBox_all.TabIndex = 16;
            this.checkBox_all.Text = "전체선택";
            this.checkBox_all.UseVisualStyleBackColor = true;
            this.checkBox_all.CheckedChanged += new System.EventHandler(this.checkBox_all_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 449);
            this.Controls.Add(this.checkBox_all);
            this.Controls.Add(this.groupBox_check);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label_filename);
            this.Controls.Add(this.btn_zoom_ini);
            this.Controls.Add(this.label_zoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pic_preview);
            this.Controls.Add(this.label_files);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_fullscreen);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Random Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_fullscreen;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Label label_files;
        private System.Windows.Forms.PictureBox pic_preview;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_zoom;
        private System.Windows.Forms.Button btn_zoom_ini;
        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.GroupBox groupBox_check;
        private System.Windows.Forms.CheckBox checkBox_all;
    }
}

