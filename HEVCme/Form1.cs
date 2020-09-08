using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEVCme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((findAvi.CheckState == CheckState.Unchecked) && (findMkv.CheckState == CheckState.Unchecked) && (findMp4.CheckState == CheckState.Unchecked))
            {
                MessageBox.Show("You haven't selected any file types");
            }
            else
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowNewFolderButton = false;
                DialogResult dialogResult = fbd.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    if (findAvi.CheckState == CheckState.Checked)
                    {
                        string[] aviFiles = Directory.GetFiles(fbd.SelectedPath, "*.avi", SearchOption.TopDirectoryOnly);
                        checkedFilesList.Items.AddRange(aviFiles);
                    }
                    if (findMp4.CheckState == CheckState.Checked)
                    {
                        string[] mp4Files = Directory.GetFiles(fbd.SelectedPath, "*.mp4", SearchOption.TopDirectoryOnly);
                        checkedFilesList.Items.AddRange(mp4Files);
                    }
                    if (findMkv.CheckState == CheckState.Checked)
                    {
                        string[] mkvFiles = Directory.GetFiles(fbd.SelectedPath, "*.mkv", SearchOption.TopDirectoryOnly);
                        checkedFilesList.Items.AddRange(mkvFiles);
                    }
                }
            }
        }

        private void useNvidia_CheckedChanged(object sender, EventArgs e)
        {
            if (useNvidia.CheckState == CheckState.Checked)
            {
                chkQp.Enabled = true;
                encodeCPU.CheckState = CheckState.Unchecked;
                chkCRF.CheckState = CheckState.Unchecked;
                chkCRF.Enabled = false;
            }
            if(useNvidia.CheckState == CheckState.Unchecked)
            {
                chkCRF.Enabled = true;
                encodeCPU.CheckState = CheckState.Checked;
                chkQp.CheckState = CheckState.Unchecked;
                chkQp.Enabled = false;

            }
        }

        private void encodeCPU_CheckedChanged(object sender, EventArgs e)
        {
            if (encodeCPU.CheckState == CheckState.Checked)
            {
                useNvidia.CheckState = CheckState.Unchecked;
                chkQp.CheckState = CheckState.Unchecked;
            }
            if (encodeCPU.CheckState == CheckState.Unchecked)
            {
                useNvidia.CheckState = CheckState.Checked;
                chkCRF.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkCustomBr_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCustomBr.CheckState == CheckState.Checked)
            {
                chkCRF.CheckState = CheckState.Unchecked;
                chkQp.CheckState = CheckState.Unchecked;
            }
        }

        private void chkQp_CheckedChanged(object sender, EventArgs e)
        {
            if(chkQp.CheckState == CheckState.Checked)
            {
                chkCRF.CheckState = CheckState.Unchecked;
                chkCustomBr.CheckState = CheckState.Unchecked;
            }
        }

        private void chkCRF_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCRF.CheckState == CheckState.Checked)
            {
                chkQp.CheckState = CheckState.Unchecked;
                chkCustomBr.CheckState = CheckState.Unchecked;
            }
        }

        private void chkCopyAud_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCopyAud.CheckState == CheckState.Checked)
            {
                chkAudCustomBr.CheckState = CheckState.Unchecked;
                chkEncodeAud.CheckState = CheckState.Unchecked;
                chkEncodeAud.Enabled = false;
                chkAudCustomBr.Enabled = false;
            }
            if (chkCopyAud.CheckState == CheckState.Unchecked)
            {
                chkAudCustomBr.CheckState = CheckState.Unchecked;
                chkEncodeAud.CheckState = CheckState.Unchecked;
                chkEncodeAud.Enabled = true;
                chkAudCustomBr.Enabled = true;
            }
        }

        private void chkEncodeAud_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEncodeAud.CheckState == CheckState.Checked)
            {
                chkCopyAud.CheckState = CheckState.Unchecked;
                chkCopyAud.Enabled = false;
            }
            if (chkEncodeAud.CheckState == CheckState.Unchecked)
            {
                chkCopyAud.CheckState = CheckState.Unchecked;
                chkCopyAud.Enabled = true;
            }
        }

        private void chkAudCustomBr_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAudCustomBr.CheckState == CheckState.Checked)
            {
                chkCopyAud.CheckState = CheckState.Unchecked;
                chkCopyAud.Enabled = false;
                chkEncodeAud.CheckState = CheckState.Checked;
            }
            if (chkAudCustomBr.CheckState == CheckState.Unchecked)
            {
                chkCopyAud.CheckState = CheckState.Unchecked;
                chkCopyAud.Enabled = true;
                chkEncodeAud.CheckState = CheckState.Checked;
                chkEncodeAud.CheckState = CheckState.Unchecked;
            }
        }
    }
}
