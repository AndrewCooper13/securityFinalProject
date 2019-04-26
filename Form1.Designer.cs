namespace imageConverter
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonShare4 = new System.Windows.Forms.RadioButton();
            this.radioButtonShare2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonEBC = new System.Windows.Forms.RadioButton();
            this.radioButtonCBC = new System.Windows.Forms.RadioButton();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonGenerateShares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::imageConverter.Properties.Resources.lena;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(290, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(462, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 157);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(634, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 157);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(806, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(166, 157);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(24, 321);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(114, 114);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGenerateShares);
            this.groupBox1.Controls.Add(this.radioButtonShare2);
            this.groupBox1.Controls.Add(this.radioButtonShare4);
            this.groupBox1.Location = new System.Drawing.Point(196, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonShare4
            // 
            this.radioButtonShare4.AutoSize = true;
            this.radioButtonShare4.Location = new System.Drawing.Point(0, 34);
            this.radioButtonShare4.Name = "radioButtonShare4";
            this.radioButtonShare4.Size = new System.Drawing.Size(86, 21);
            this.radioButtonShare4.TabIndex = 13;
            this.radioButtonShare4.TabStop = true;
            this.radioButtonShare4.Text = "4 Shares";
            this.radioButtonShare4.UseVisualStyleBackColor = true;
            // 
            // radioButtonShare2
            // 
            this.radioButtonShare2.AutoSize = true;
            this.radioButtonShare2.Location = new System.Drawing.Point(0, 7);
            this.radioButtonShare2.Name = "radioButtonShare2";
            this.radioButtonShare2.Size = new System.Drawing.Size(86, 21);
            this.radioButtonShare2.TabIndex = 12;
            this.radioButtonShare2.TabStop = true;
            this.radioButtonShare2.Text = "2 Shares";
            this.radioButtonShare2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonEBC);
            this.groupBox2.Controls.Add(this.radioButtonCBC);
            this.groupBox2.Location = new System.Drawing.Point(731, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(69, 73);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonEBC
            // 
            this.radioButtonEBC.AutoSize = true;
            this.radioButtonEBC.Enabled = false;
            this.radioButtonEBC.Location = new System.Drawing.Point(3, 45);
            this.radioButtonEBC.Name = "radioButtonEBC";
            this.radioButtonEBC.Size = new System.Drawing.Size(56, 21);
            this.radioButtonEBC.TabIndex = 1;
            this.radioButtonEBC.Text = "EBC";
            this.radioButtonEBC.UseVisualStyleBackColor = true;
            // 
            // radioButtonCBC
            // 
            this.radioButtonCBC.AutoSize = true;
            this.radioButtonCBC.Checked = true;
            this.radioButtonCBC.Enabled = false;
            this.radioButtonCBC.Location = new System.Drawing.Point(3, 18);
            this.radioButtonCBC.Name = "radioButtonCBC";
            this.radioButtonCBC.Size = new System.Drawing.Size(56, 21);
            this.radioButtonCBC.TabIndex = 0;
            this.radioButtonCBC.TabStop = true;
            this.radioButtonCBC.Text = "CBC";
            this.radioButtonCBC.UseVisualStyleBackColor = true;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(823, 196);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(112, 33);
            this.buttonEncrypt.TabIndex = 10;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonGenerateShares
            // 
            this.buttonGenerateShares.Location = new System.Drawing.Point(0, 78);
            this.buttonGenerateShares.Name = "buttonGenerateShares";
            this.buttonGenerateShares.Size = new System.Drawing.Size(86, 46);
            this.buttonGenerateShares.TabIndex = 11;
            this.buttonGenerateShares.Text = "Generate Shares";
            this.buttonGenerateShares.UseVisualStyleBackColor = true;
            this.buttonGenerateShares.Click += new System.EventHandler(this.buttonGenerateShares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 547);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonEBC;
        private System.Windows.Forms.RadioButton radioButtonCBC;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RadioButton radioButtonShare4;
        private System.Windows.Forms.RadioButton radioButtonShare2;
        private System.Windows.Forms.Button buttonGenerateShares;
    }
}

