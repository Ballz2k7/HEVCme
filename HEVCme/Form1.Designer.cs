﻿namespace HEVCme
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
            this.useNvidia = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.encodeCPU = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 393);
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
            this.tabPage1.Size = new System.Drawing.Size(792, 367);
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
            this.findMkv.Location = new System.Drawing.Point(270, 60);
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
            this.findMp4.Location = new System.Drawing.Point(139, 60);
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
            this.checkedFilesList.Size = new System.Drawing.Size(786, 214);
            this.checkedFilesList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(379, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose a folder........";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.encodeCPU);
            this.tabPage2.Controls.Add(this.useNvidia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage2.Size = new System.Drawing.Size(792, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // useNvidia
            // 
            this.useNvidia.AutoSize = true;
            this.useNvidia.Checked = true;
            this.useNvidia.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.tabPage3.Size = new System.Drawing.Size(792, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renaming";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage4.Size = new System.Drawing.Size(792, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Convert";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "HEVCme";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

