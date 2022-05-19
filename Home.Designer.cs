
namespace E300
{
    partial class Home
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbGrondbediening = new System.Windows.Forms.Label();
            this.tbPlatformbediening = new System.Windows.Forms.TextBox();
            this.tbGrondbediening = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGround = new System.Windows.Forms.Button();
            this.btnPlatform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::E300.Properties.Resources.E450AJP_Gallery_Silo;
            this.pictureBox2.Location = new System.Drawing.Point(108, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(921, 645);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbGrondbediening
            // 
            this.lbGrondbediening.AutoSize = true;
            this.lbGrondbediening.Location = new System.Drawing.Point(66, 761);
            this.lbGrondbediening.Name = "lbGrondbediening";
            this.lbGrondbediening.Size = new System.Drawing.Size(104, 16);
            this.lbGrondbediening.TabIndex = 5;
            this.lbGrondbediening.Text = "Grondbediening";
            // 
            // tbPlatformbediening
            // 
            this.tbPlatformbediening.Location = new System.Drawing.Point(229, 784);
            this.tbPlatformbediening.Name = "tbPlatformbediening";
            this.tbPlatformbediening.Size = new System.Drawing.Size(800, 22);
            this.tbPlatformbediening.TabIndex = 4;
            this.tbPlatformbediening.TextChanged += new System.EventHandler(this.tbPlatformbediening_TextChanged);
            // 
            // tbGrondbediening
            // 
            this.tbGrondbediening.Location = new System.Drawing.Point(229, 756);
            this.tbGrondbediening.Name = "tbGrondbediening";
            this.tbGrondbediening.Size = new System.Drawing.Size(800, 22);
            this.tbGrondbediening.TabIndex = 3;
            this.tbGrondbediening.TextChanged += new System.EventHandler(this.tbGrondbediening_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 784);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Platformbediening";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGround
            // 
            this.btnGround.Location = new System.Drawing.Point(1044, 758);
            this.btnGround.Name = "btnGround";
            this.btnGround.Size = new System.Drawing.Size(23, 23);
            this.btnGround.TabIndex = 7;
            this.btnGround.Text = "...";
            this.btnGround.UseVisualStyleBackColor = true;
            this.btnGround.Click += new System.EventHandler(this.btnGround_Click);
            // 
            // btnPlatform
            // 
            this.btnPlatform.Location = new System.Drawing.Point(1044, 783);
            this.btnPlatform.Name = "btnPlatform";
            this.btnPlatform.Size = new System.Drawing.Size(23, 23);
            this.btnPlatform.TabIndex = 8;
            this.btnPlatform.Text = "...";
            this.btnPlatform.UseVisualStyleBackColor = true;
            this.btnPlatform.Click += new System.EventHandler(this.btnPlatform_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 1000);
            this.Controls.Add(this.btnPlatform);
            this.Controls.Add(this.btnGround);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGrondbediening);
            this.Controls.Add(this.tbPlatformbediening);
            this.Controls.Add(this.tbGrondbediening);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbGrondbediening;
        private System.Windows.Forms.TextBox tbPlatformbediening;
        private System.Windows.Forms.TextBox tbGrondbediening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected internal System.Windows.Forms.Button btnGround;
        protected internal System.Windows.Forms.Button btnPlatform;
    }
}