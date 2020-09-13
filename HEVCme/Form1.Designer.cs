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
            this.butSelectNone = new System.Windows.Forms.Button();
            this.butSelectAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findMkv = new System.Windows.Forms.CheckBox();
            this.findMp4 = new System.Windows.Forms.CheckBox();
            this.findAvi = new System.Windows.Forms.CheckBox();
            this.checkedFilesList = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkCopySubs = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textAudioBitrate = new System.Windows.Forms.TextBox();
            this.chkAudCustomBr = new System.Windows.Forms.CheckBox();
            this.chkEncodeAud = new System.Windows.Forms.CheckBox();
            this.chkCopyAud = new System.Windows.Forms.CheckBox();
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
            this.butConvert = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butMedInf = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1776, 937);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.butSelectNone);
            this.tabPage1.Controls.Add(this.butSelectAll);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.findMkv);
            this.tabPage1.Controls.Add(this.findMp4);
            this.tabPage1.Controls.Add(this.findAvi);
            this.tabPage1.Controls.Add(this.checkedFilesList);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1756, 879);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // butSelectNone
            // 
            this.butSelectNone.Location = new System.Drawing.Point(1011, 789);
            this.butSelectNone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.butSelectNone.Name = "butSelectNone";
            this.butSelectNone.Size = new System.Drawing.Size(336, 55);
            this.butSelectNone.TabIndex = 8;
            this.butSelectNone.Text = "Select None";
            this.butSelectNone.UseVisualStyleBackColor = true;
            this.butSelectNone.Click += new System.EventHandler(this.butSelectNone_Click);
            // 
            // butSelectAll
            // 
            this.butSelectAll.Location = new System.Drawing.Point(1379, 789);
            this.butSelectAll.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.butSelectAll.Name = "butSelectAll";
            this.butSelectAll.Size = new System.Drawing.Size(331, 55);
            this.butSelectAll.TabIndex = 7;
            this.butSelectAll.Text = "Select All";
            this.butSelectAll.UseVisualStyleBackColor = true;
            this.butSelectAll.Click += new System.EventHandler(this.butSelectAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Files To Convert Below";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose file types";
            // 
            // findMkv
            // 
            this.findMkv.AutoSize = true;
            this.findMkv.Location = new System.Drawing.Point(485, 143);
            this.findMkv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findMkv.Name = "findMkv";
            this.findMkv.Size = new System.Drawing.Size(114, 36);
            this.findMkv.TabIndex = 4;
            this.findMkv.Text = "MKV";
            this.findMkv.UseVisualStyleBackColor = true;
            // 
            // findMp4
            // 
            this.findMp4.AutoSize = true;
            this.findMp4.Location = new System.Drawing.Point(272, 143);
            this.findMp4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findMp4.Name = "findMp4";
            this.findMp4.Size = new System.Drawing.Size(111, 36);
            this.findMp4.TabIndex = 3;
            this.findMp4.Text = "MP4";
            this.findMp4.UseVisualStyleBackColor = true;
            // 
            // findAvi
            // 
            this.findAvi.AutoSize = true;
            this.findAvi.Location = new System.Drawing.Point(45, 143);
            this.findAvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findAvi.Name = "findAvi";
            this.findAvi.Size = new System.Drawing.Size(98, 36);
            this.findAvi.TabIndex = 2;
            this.findAvi.Text = "AVI";
            this.findAvi.UseVisualStyleBackColor = true;
            // 
            // checkedFilesList
            // 
            this.checkedFilesList.FormattingEnabled = true;
            this.checkedFilesList.Location = new System.Drawing.Point(5, 320);
            this.checkedFilesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedFilesList.Name = "checkedFilesList";
            this.checkedFilesList.Size = new System.Drawing.Size(1697, 433);
            this.checkedFilesList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1011, 93);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(699, 131);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose a folder........";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkCopySubs);
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
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1756, 879);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkCopySubs
            // 
            this.chkCopySubs.AutoSize = true;
            this.chkCopySubs.Location = new System.Drawing.Point(1205, 701);
            this.chkCopySubs.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkCopySubs.Name = "chkCopySubs";
            this.chkCopySubs.Size = new System.Drawing.Size(277, 36);
            this.chkCopySubs.TabIndex = 22;
            this.chkCopySubs.Text = "Copy All Subtitles";
            this.chkCopySubs.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1464, 553);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "kbps";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(835, 610);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "kbps";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(835, 515);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "kbps";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1197, 508);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Audio Bitrate";
            // 
            // textAudioBitrate
            // 
            this.textAudioBitrate.Location = new System.Drawing.Point(1205, 546);
            this.textAudioBitrate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textAudioBitrate.Name = "textAudioBitrate";
            this.textAudioBitrate.Size = new System.Drawing.Size(236, 38);
            this.textAudioBitrate.TabIndex = 17;
            // 
            // chkAudCustomBr
            // 
            this.chkAudCustomBr.AutoSize = true;
            this.chkAudCustomBr.Location = new System.Drawing.Point(1205, 427);
            this.chkAudCustomBr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkAudCustomBr.Name = "chkAudCustomBr";
            this.chkAudCustomBr.Size = new System.Drawing.Size(240, 36);
            this.chkAudCustomBr.TabIndex = 16;
            this.chkAudCustomBr.Text = "Custom Bitrate";
            this.chkAudCustomBr.UseVisualStyleBackColor = true;
            this.chkAudCustomBr.CheckedChanged += new System.EventHandler(this.chkAudCustomBr_CheckedChanged);
            // 
            // chkEncodeAud
            // 
            this.chkEncodeAud.AutoSize = true;
            this.chkEncodeAud.Location = new System.Drawing.Point(1205, 265);
            this.chkEncodeAud.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkEncodeAud.Name = "chkEncodeAud";
            this.chkEncodeAud.Size = new System.Drawing.Size(336, 36);
            this.chkEncodeAud.TabIndex = 15;
            this.chkEncodeAud.Text = "Encode Audio To AAC";
            this.chkEncodeAud.UseVisualStyleBackColor = true;
            this.chkEncodeAud.CheckedChanged += new System.EventHandler(this.chkEncodeAud_CheckedChanged);
            // 
            // chkCopyAud
            // 
            this.chkCopyAud.AutoSize = true;
            this.chkCopyAud.Location = new System.Drawing.Point(1205, 176);
            this.chkCopyAud.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkCopyAud.Name = "chkCopyAud";
            this.chkCopyAud.Size = new System.Drawing.Size(200, 36);
            this.chkCopyAud.TabIndex = 14;
            this.chkCopyAud.Text = "Copy Audio";
            this.chkCopyAud.UseVisualStyleBackColor = true;
            this.chkCopyAud.CheckedChanged += new System.EventHandler(this.chkCopyAud_CheckedChanged);
            // 
            // textMaxVidBr
            // 
            this.textMaxVidBr.Location = new System.Drawing.Point(552, 603);
            this.textMaxVidBr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textMaxVidBr.Name = "textMaxVidBr";
            this.textMaxVidBr.Size = new System.Drawing.Size(260, 38);
            this.textMaxVidBr.TabIndex = 13;
            // 
            // textAvVidBr
            // 
            this.textAvVidBr.Location = new System.Drawing.Point(552, 508);
            this.textAvVidBr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textAvVidBr.Name = "textAvVidBr";
            this.textAvVidBr.Size = new System.Drawing.Size(260, 38);
            this.textAvVidBr.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 610);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Maximum Bitrate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 515);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Average Bitrate";
            // 
            // chkCustomBr
            // 
            this.chkCustomBr.AutoSize = true;
            this.chkCustomBr.Location = new System.Drawing.Point(331, 427);
            this.chkCustomBr.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkCustomBr.Name = "chkCustomBr";
            this.chkCustomBr.Size = new System.Drawing.Size(254, 36);
            this.chkCustomBr.TabIndex = 9;
            this.chkCustomBr.Text = "Custom Bitrates";
            this.chkCustomBr.UseVisualStyleBackColor = true;
            this.chkCustomBr.CheckedChanged += new System.EventHandler(this.chkCustomBr_CheckedChanged);
            // 
            // crfVal
            // 
            this.crfVal.Location = new System.Drawing.Point(819, 327);
            this.crfVal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.crfVal.Name = "crfVal";
            this.crfVal.Size = new System.Drawing.Size(57, 38);
            this.crfVal.TabIndex = 8;
            this.crfVal.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "CRF Value (0-51)";
            // 
            // cqVal
            // 
            this.cqVal.Location = new System.Drawing.Point(285, 327);
            this.cqVal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cqVal.Name = "cqVal";
            this.cqVal.Size = new System.Drawing.Size(57, 38);
            this.cqVal.TabIndex = 6;
            this.cqVal.Text = "23";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "CQ Value (0-51)";
            // 
            // chkCRF
            // 
            this.chkCRF.AutoSize = true;
            this.chkCRF.Location = new System.Drawing.Point(581, 265);
            this.chkCRF.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkCRF.Name = "chkCRF";
            this.chkCRF.Size = new System.Drawing.Size(110, 36);
            this.chkCRF.TabIndex = 4;
            this.chkCRF.Text = "CRF";
            this.chkCRF.UseVisualStyleBackColor = true;
            this.chkCRF.CheckedChanged += new System.EventHandler(this.chkCRF_CheckedChanged);
            // 
            // chkQp
            // 
            this.chkQp.AutoSize = true;
            this.chkQp.Location = new System.Drawing.Point(59, 265);
            this.chkQp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.chkQp.Name = "chkQp";
            this.chkQp.Size = new System.Drawing.Size(192, 36);
            this.chkQp.TabIndex = 3;
            this.chkQp.Text = "CONSTQP";
            this.chkQp.UseVisualStyleBackColor = true;
            this.chkQp.CheckedChanged += new System.EventHandler(this.chkQp_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(580, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose your encoder settings";
            // 
            // encodeCPU
            // 
            this.encodeCPU.AutoSize = true;
            this.encodeCPU.Location = new System.Drawing.Point(581, 176);
            this.encodeCPU.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.encodeCPU.Name = "encodeCPU";
            this.encodeCPU.Size = new System.Drawing.Size(112, 36);
            this.encodeCPU.TabIndex = 1;
            this.encodeCPU.Text = "CPU";
            this.encodeCPU.UseVisualStyleBackColor = true;
            this.encodeCPU.CheckedChanged += new System.EventHandler(this.encodeCPU_CheckedChanged);
            // 
            // useNvidia
            // 
            this.useNvidia.AutoSize = true;
            this.useNvidia.Location = new System.Drawing.Point(59, 176);
            this.useNvidia.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.useNvidia.Name = "useNvidia";
            this.useNvidia.Size = new System.Drawing.Size(262, 36);
            this.useNvidia.TabIndex = 0;
            this.useNvidia.Text = "Nvidia Hardware";
            this.useNvidia.UseVisualStyleBackColor = true;
            this.useNvidia.CheckedChanged += new System.EventHandler(this.useNvidia_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.butMedInf);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1756, 879);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renaming";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.butConvert);
            this.tabPage4.Location = new System.Drawing.Point(10, 48);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1756, 879);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Convert";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // butConvert
            // 
            this.butConvert.Location = new System.Drawing.Point(1088, 141);
            this.butConvert.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(563, 408);
            this.butConvert.TabIndex = 0;
            this.butConvert.Text = "Convert";
            this.butConvert.UseVisualStyleBackColor = true;
            this.butConvert.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(41, 102);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1618, 337);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // butMedInf
            // 
            this.butMedInf.Location = new System.Drawing.Point(1132, 571);
            this.butMedInf.Name = "butMedInf";
            this.butMedInf.Size = new System.Drawing.Size(433, 113);
            this.butMedInf.TabIndex = 1;
            this.butMedInf.Text = "Get Info";
            this.butMedInf.UseVisualStyleBackColor = true;
            this.butMedInf.Click += new System.EventHandler(this.butMedInf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 947);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "HEVCme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.Button butConvert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAudioBitrate;
        private System.Windows.Forms.CheckBox chkAudCustomBr;
        private System.Windows.Forms.CheckBox chkEncodeAud;
        private System.Windows.Forms.CheckBox chkCopyAud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkCopySubs;
        private System.Windows.Forms.Button butSelectNone;
        private System.Windows.Forms.Button butSelectAll;
        private System.Windows.Forms.Button butMedInf;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

