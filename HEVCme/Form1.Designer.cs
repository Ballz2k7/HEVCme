namespace HEVCme
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findMkv = new System.Windows.Forms.CheckBox();
            this.findMp4 = new System.Windows.Forms.CheckBox();
            this.findAvi = new System.Windows.Forms.CheckBox();
            this.checkedFilesList = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textMaxVidBr = new System.Windows.Forms.TextBox();
            this.textAvVidBr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCustomBr = new System.Windows.Forms.CheckBox();
            this.crfVal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cqVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCRF = new System.Windows.Forms.CheckBox();
            this.chkQp = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encodeCPU = new System.Windows.Forms.CheckBox();
            this.useNvidia = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.chkCopyAud = new System.Windows.Forms.CheckBox();
            this.chkEncodeAud = new System.Windows.Forms.CheckBox();
            this.chkAudCustomBr = new System.Windows.Forms.CheckBox();
            this.textAudioBitrate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(666, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.findMkv);
            this.tabPage1.Controls.Add(this.findMp4);
            this.tabPage1.Controls.Add(this.findAvi);
            this.tabPage1.Controls.Add(this.checkedFilesList);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(658, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Files To Convert Below";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose file types";
            // 
            // findMkv
            // 
            this.findMkv.AutoSize = true;
            this.findMkv.Location = new System.Drawing.Point(182, 60);
            this.findMkv.Margin = new System.Windows.Forms.Padding(1);
            this.findMkv.Name = "findMkv";
            this.findMkv.Size = new System.Drawing.Size(49, 17);
            this.findMkv.TabIndex = 4;
            this.findMkv.Text = "MKV";
            this.findMkv.UseVisualStyleBackColor = true;
            // 
            // findMp4
            // 
            this.findMp4.AutoSize = true;
            this.findMp4.Location = new System.Drawing.Point(102, 60);
            this.findMp4.Margin = new System.Windows.Forms.Padding(1);
            this.findMp4.Name = "findMp4";
            this.findMp4.Size = new System.Drawing.Size(48, 17);
            this.findMp4.TabIndex = 3;
            this.findMp4.Text = "MP4";
            this.findMp4.UseVisualStyleBackColor = true;
            // 
            // findAvi
            // 
            this.findAvi.AutoSize = true;
            this.findAvi.Location = new System.Drawing.Point(17, 60);
            this.findAvi.Margin = new System.Windows.Forms.Padding(1);
            this.findAvi.Name = "findAvi";
            this.findAvi.Size = new System.Drawing.Size(43, 17);
            this.findAvi.TabIndex = 2;
            this.findAvi.Text = "AVI";
            this.findAvi.UseVisualStyleBackColor = true;
            // 
            // checkedFilesList
            // 
            this.checkedFilesList.FormattingEnabled = true;
            this.checkedFilesList.Location = new System.Drawing.Point(2, 134);
            this.checkedFilesList.Margin = new System.Windows.Forms.Padding(1);
            this.checkedFilesList.Name = "checkedFilesList";
            this.checkedFilesList.Size = new System.Drawing.Size(639, 214);
            this.checkedFilesList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(379, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose a folder........";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textAudioBitrate);
            this.tabPage2.Controls.Add(this.chkAudCustomBr);
            this.tabPage2.Controls.Add(this.chkEncodeAud);
            this.tabPage2.Controls.Add(this.chkCopyAud);
            this.tabPage2.Controls.Add(this.textMaxVidBr);
            this.tabPage2.Controls.Add(this.textAvVidBr);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.chkCustomBr);
            this.tabPage2.Controls.Add(this.crfVal);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cqVal);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.chkCRF);
            this.tabPage2.Controls.Add(this.chkQp);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.encodeCPU);
            this.tabPage2.Controls.Add(this.useNvidia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(658, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textMaxVidBr
            // 
            this.textMaxVidBr.Location = new System.Drawing.Point(207, 285);
            this.textMaxVidBr.Name = "textMaxVidBr";
            this.textMaxVidBr.Size = new System.Drawing.Size(100, 20);
            this.textMaxVidBr.TabIndex = 13;
            // 
            // textAvVidBr
            // 
            this.textAvVidBr.Location = new System.Drawing.Point(207, 245);
            this.textAvVidBr.Name = "textAvVidBr";
            this.textAvVidBr.Size = new System.Drawing.Size(100, 20);
            this.textAvVidBr.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Maximum Bitrate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Average Bitrate";
            // 
            // chkCustomBr
            // 
            this.chkCustomBr.AutoSize = true;
            this.chkCustomBr.Location = new System.Drawing.Point(124, 211);
            this.chkCustomBr.Name = "chkCustomBr";
            this.chkCustomBr.Size = new System.Drawing.Size(99, 17);
            this.chkCustomBr.TabIndex = 9;
            this.chkCustomBr.Text = "Custom Bitrates";
            this.chkCustomBr.UseVisualStyleBackColor = true;
            this.chkCustomBr.CheckedChanged += new System.EventHandler(this.chkCustomBr_CheckedChanged);
            // 
            // crfVal
            // 
            this.crfVal.Location = new System.Drawing.Point(307, 137);
            this.crfVal.Name = "crfVal";
            this.crfVal.Size = new System.Drawing.Size(24, 20);
            this.crfVal.TabIndex = 8;
            this.crfVal.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CRF Value (0-51)";
            // 
            // cqVal
            // 
            this.cqVal.Location = new System.Drawing.Point(107, 137);
            this.cqVal.Name = "cqVal";
            this.cqVal.Size = new System.Drawing.Size(24, 20);
            this.cqVal.TabIndex = 6;
            this.cqVal.Text = "23";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CQ Value (0-51)";
            // 
            // chkCRF
            // 
            this.chkCRF.AutoSize = true;
            this.chkCRF.Location = new System.Drawing.Point(218, 111);
            this.chkCRF.Name = "chkCRF";
            this.chkCRF.Size = new System.Drawing.Size(47, 17);
            this.chkCRF.TabIndex = 4;
            this.chkCRF.Text = "CRF";
            this.chkCRF.UseVisualStyleBackColor = true;
            this.chkCRF.CheckedChanged += new System.EventHandler(this.chkCRF_CheckedChanged);
            // 
            // chkQp
            // 
            this.chkQp.AutoSize = true;
            this.chkQp.Location = new System.Drawing.Point(22, 111);
            this.chkQp.Name = "chkQp";
            this.chkQp.Size = new System.Drawing.Size(78, 17);
            this.chkQp.TabIndex = 3;
            this.chkQp.Text = "CONSTQP";
            this.chkQp.UseVisualStyleBackColor = true;
            this.chkQp.CheckedChanged += new System.EventHandler(this.chkQp_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose your encoder settings";
            // 
            // encodeCPU
            // 
            this.encodeCPU.AutoSize = true;
            this.encodeCPU.Location = new System.Drawing.Point(218, 74);
            this.encodeCPU.Name = "encodeCPU";
            this.encodeCPU.Size = new System.Drawing.Size(48, 17);
            this.encodeCPU.TabIndex = 1;
            this.encodeCPU.Text = "CPU";
            this.encodeCPU.UseVisualStyleBackColor = true;
            this.encodeCPU.CheckedChanged += new System.EventHandler(this.encodeCPU_CheckedChanged);
            // 
            // useNvidia
            // 
            this.useNvidia.AutoSize = true;
            this.useNvidia.Location = new System.Drawing.Point(22, 74);
            this.useNvidia.Name = "useNvidia";
            this.useNvidia.Size = new System.Drawing.Size(105, 17);
            this.useNvidia.TabIndex = 0;
            this.useNvidia.Text = "Nvidia Hardware";
            this.useNvidia.UseVisualStyleBackColor = true;
            this.useNvidia.CheckedChanged += new System.EventHandler(this.useNvidia_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage3.Size = new System.Drawing.Size(658, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renaming";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage4.Size = new System.Drawing.Size(658, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Convert";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 171);
            this.button2.TabIndex = 0;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chkCopyAud
            // 
            this.chkCopyAud.AutoSize = true;
            this.chkCopyAud.Location = new System.Drawing.Point(452, 74);
            this.chkCopyAud.Name = "chkCopyAud";
            this.chkCopyAud.Size = new System.Drawing.Size(80, 17);
            this.chkCopyAud.TabIndex = 14;
            this.chkCopyAud.Text = "Copy Audio";
            this.chkCopyAud.UseVisualStyleBackColor = true;
            this.chkCopyAud.CheckedChanged += new System.EventHandler(this.chkCopyAud_CheckedChanged);
            // 
            // chkEncodeAud
            // 
            this.chkEncodeAud.AutoSize = true;
            this.chkEncodeAud.Location = new System.Drawing.Point(452, 111);
            this.chkEncodeAud.Name = "chkEncodeAud";
            this.chkEncodeAud.Size = new System.Drawing.Size(133, 17);
            this.chkEncodeAud.TabIndex = 15;
            this.chkEncodeAud.Text = "Encode Audio To AAC";
            this.chkEncodeAud.UseVisualStyleBackColor = true;
            this.chkEncodeAud.CheckedChanged += new System.EventHandler(this.chkEncodeAud_CheckedChanged);
            // 
            // chkAudCustomBr
            // 
            this.chkAudCustomBr.AutoSize = true;
            this.chkAudCustomBr.Location = new System.Drawing.Point(452, 211);
            this.chkAudCustomBr.Name = "chkAudCustomBr";
            this.chkAudCustomBr.Size = new System.Drawing.Size(94, 17);
            this.chkAudCustomBr.TabIndex = 16;
            this.chkAudCustomBr.Text = "Custom Bitrate";
            this.chkAudCustomBr.UseVisualStyleBackColor = true;
            this.chkAudCustomBr.CheckedChanged += new System.EventHandler(this.chkAudCustomBr_CheckedChanged);
            // 
            // textAudioBitrate
            // 
            this.textAudioBitrate.Location = new System.Drawing.Point(452, 261);
            this.textAudioBitrate.Name = "textAudioBitrate";
            this.textAudioBitrate.Size = new System.Drawing.Size(91, 20);
            this.textAudioBitrate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Audio Bitrate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "kbps";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "kbps";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(549, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "kbps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 397);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "HEVCme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox findMkv;
        private System.Windows.Forms.CheckBox findMp4;
        private System.Windows.Forms.CheckBox findAvi;
        private System.Windows.Forms.CheckedListBox checkedFilesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox useNvidia;
        private System.Windows.Forms.CheckBox encodeCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cqVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCRF;
        private System.Windows.Forms.CheckBox chkQp;
        private System.Windows.Forms.TextBox crfVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMaxVidBr;
        private System.Windows.Forms.TextBox textAvVidBr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkCustomBr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAudioBitrate;
        private System.Windows.Forms.CheckBox chkAudCustomBr;
        private System.Windows.Forms.CheckBox chkEncodeAud;
        private System.Windows.Forms.CheckBox chkCopyAud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

