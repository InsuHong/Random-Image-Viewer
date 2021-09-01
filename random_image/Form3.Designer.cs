namespace random_image
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pic_big = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_big
            // 
            this.pic_big.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_big.Location = new System.Drawing.Point(39, 34);
            this.pic_big.Name = "pic_big";
            this.pic_big.Size = new System.Drawing.Size(280, 251);
            this.pic_big.TabIndex = 0;
            this.pic_big.TabStop = false;
            this.pic_big.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_big_MouseClick);
            this.pic_big.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_big_MouseDown);
            this.pic_big.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_big_MouseMove);
            this.pic_big.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_big_MouseUp);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_big);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "View";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseClick);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form3_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_big;
    }
}