namespace hash_code_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSha256 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSha1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSha384 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSha512 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRIPMID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File:";
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(44, 21);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(358, 20);
            this.txtFile.TabIndex = 11;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(412, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.Text = "ADD";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnHash
            // 
            this.btnHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHash.Location = new System.Drawing.Point(448, 21);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(75, 23);
            this.btnHash.TabIndex = 13;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "MD5:";
            // 
            // txtMd5
            // 
            this.txtMd5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMd5.Location = new System.Drawing.Point(87, 80);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.ReadOnly = true;
            this.txtMd5.Size = new System.Drawing.Size(439, 20);
            this.txtMd5.TabIndex = 17;
            this.txtMd5.TextChanged += new System.EventHandler(this.txtMd5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SHA256:";
            // 
            // txtSha256
            // 
            this.txtSha256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSha256.Location = new System.Drawing.Point(87, 106);
            this.txtSha256.Name = "txtSha256";
            this.txtSha256.ReadOnly = true;
            this.txtSha256.Size = new System.Drawing.Size(439, 20);
            this.txtSha256.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "SHA1:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSha1
            // 
            this.txtSha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSha1.Location = new System.Drawing.Point(87, 133);
            this.txtSha1.Name = "txtSha1";
            this.txtSha1.ReadOnly = true;
            this.txtSha1.Size = new System.Drawing.Size(439, 20);
            this.txtSha1.TabIndex = 22;
            this.txtSha1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "SHA 384:";
            // 
            // txtSha384
            // 
            this.txtSha384.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSha384.Location = new System.Drawing.Point(87, 159);
            this.txtSha384.Name = "txtSha384";
            this.txtSha384.ReadOnly = true;
            this.txtSha384.Size = new System.Drawing.Size(439, 20);
            this.txtSha384.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "SHA 512:";
            // 
            // txtSha512
            // 
            this.txtSha512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSha512.Location = new System.Drawing.Point(87, 185);
            this.txtSha512.Name = "txtSha512";
            this.txtSha512.ReadOnly = true;
            this.txtSha512.Size = new System.Drawing.Size(439, 20);
            this.txtSha512.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "RIPMID 160:";
            // 
            // txtRIPMID
            // 
            this.txtRIPMID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRIPMID.Location = new System.Drawing.Point(87, 215);
            this.txtRIPMID.Name = "txtRIPMID";
            this.txtRIPMID.ReadOnly = true;
            this.txtRIPMID.Size = new System.Drawing.Size(439, 20);
            this.txtRIPMID.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 257);
            this.Controls.Add(this.txtRIPMID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSha512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSha384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSha1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSha256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMd5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMd5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSha256;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSha1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSha384;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSha512;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRIPMID;
    }
}

