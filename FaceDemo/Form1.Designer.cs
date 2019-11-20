namespace FaceDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxDetection1 = new System.Windows.Forms.TextBox();
            this.textBoxDetection2 = new System.Windows.Forms.TextBox();
            this.textBoxCompare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadPic1 = new System.Windows.Forms.Button();
            this.btnLoadPic2 = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(563, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxDetection1
            // 
            this.textBoxDetection1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDetection1.Location = new System.Drawing.Point(16, 355);
            this.textBoxDetection1.Multiline = true;
            this.textBoxDetection1.Name = "textBoxDetection1";
            this.textBoxDetection1.ReadOnly = true;
            this.textBoxDetection1.Size = new System.Drawing.Size(346, 238);
            this.textBoxDetection1.TabIndex = 2;
            // 
            // textBoxDetection2
            // 
            this.textBoxDetection2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDetection2.Location = new System.Drawing.Point(563, 355);
            this.textBoxDetection2.Multiline = true;
            this.textBoxDetection2.Name = "textBoxDetection2";
            this.textBoxDetection2.ReadOnly = true;
            this.textBoxDetection2.Size = new System.Drawing.Size(346, 238);
            this.textBoxDetection2.TabIndex = 3;
            // 
            // textBoxCompare
            // 
            this.textBoxCompare.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCompare.Location = new System.Drawing.Point(381, 70);
            this.textBoxCompare.Multiline = true;
            this.textBoxCompare.Name = "textBoxCompare";
            this.textBoxCompare.ReadOnly = true;
            this.textBoxCompare.Size = new System.Drawing.Size(159, 86);
            this.textBoxCompare.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "人脸检测结果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(559, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "人脸检测结果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(377, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "对比结果";
            // 
            // btnLoadPic1
            // 
            this.btnLoadPic1.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadPic1.Location = new System.Drawing.Point(283, 293);
            this.btnLoadPic1.Name = "btnLoadPic1";
            this.btnLoadPic1.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPic1.TabIndex = 1;
            this.btnLoadPic1.Text = "载入图像";
            this.btnLoadPic1.UseVisualStyleBackColor = true;
            this.btnLoadPic1.Click += new System.EventHandler(this.btnLoadPic1_Click);
            // 
            // btnLoadPic2
            // 
            this.btnLoadPic2.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadPic2.Location = new System.Drawing.Point(834, 293);
            this.btnLoadPic2.Name = "btnLoadPic2";
            this.btnLoadPic2.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPic2.TabIndex = 9;
            this.btnLoadPic2.Text = "载入图像";
            this.btnLoadPic2.UseVisualStyleBackColor = true;
            this.btnLoadPic2.Click += new System.EventHandler(this.btnLoadPic2_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("楷体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompare.Location = new System.Drawing.Point(381, 12);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 10;
            this.btnCompare.Text = "人脸对比";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 603);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnLoadPic2);
            this.Controls.Add(this.btnLoadPic1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCompare);
            this.Controls.Add(this.textBoxDetection2);
            this.Controls.Add(this.textBoxDetection1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceDemo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxDetection1;
        private System.Windows.Forms.TextBox textBoxDetection2;
        private System.Windows.Forms.TextBox textBoxCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadPic1;
        private System.Windows.Forms.Button btnLoadPic2;
        private System.Windows.Forms.Button btnCompare;
    }
}

