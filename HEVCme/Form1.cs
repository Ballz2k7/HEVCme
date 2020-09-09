using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private void convertIt(string ffmpegsetup)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "ffmpeg.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = ffmpegsetup;
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.WaitForExit();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            string ffargs = "";
            if ((useNvidia.CheckState == CheckState.Unchecked) && (encodeCPU.CheckState == CheckState.Unchecked))
            {
                MessageBox.Show("You haven't selected either Nvidia or CPU!");
                return;
            }
            if ((chkCRF.CheckState == CheckState.Unchecked) && (chkQp.CheckState == CheckState.Unchecked) && (chkCustomBr.CheckState == CheckState.Unchecked))
            {
                MessageBox.Show("You havent selected an encoding methos (CONSTQP, CRF, Custom Bitrate)");
                return;
            }
            if((chkCustomBr.CheckState == CheckState.Checked) && ((textAvVidBr.Text == "") || (textMaxVidBr.Text == "")))
            {
                MessageBox.Show("You have selected a custom bitrate but your bitrate box is empty!");
                return;
            }
            if ((useNvidia.CheckState == CheckState.Checked) && (chkQp.CheckState == CheckState.Checked))
            {
                ffargs += "-c:v hevc_nvenc -rc constqp -cq " + cqVal.Text + " -rc-lookahead 32 -g 600 ";
            }
            if ((encodeCPU.CheckState == CheckState.Checked) && (chkCRF.CheckState == CheckState.Checked))
            {
                ffargs += "-c:v libx265 -crf " + crfVal.Text + " -x265-params rc-lookahead=32:intra-refresh=1:ctu=32:ref=1:bframes=0:keyint=150:min-keyint=150:aq-mode=2:aq-strength=1.0:no-aq-motion=1:qg-size=16:no-cutree=1 ";
            }
            if ((useNvidia.CheckState == CheckState.Checked) && (chkCustomBr.CheckState == CheckState.Checked))
            {
                ffargs += "-c:v hevc_nvenc -rc vbr_hq -b:v " + textAvVidBr.Text + "k -maxrate:v " + textMaxVidBr.Text + "k -rc-lookahead 32 -g 600 ";
            }
            if ((encodeCPU.CheckState == CheckState.Checked) && (chkCustomBr.CheckState == CheckState.Checked))
            {
                ffargs += "-c:v libx265 -b:v " + textAvVidBr.Text + "k -maxrate:v " + textMaxVidBr.Text + "k -x265-params rc-lookahead=32:intra-refresh=1:ctu=32:ref=1:bframes=0:keyint=150:min-keyint=150:aq-mode=2:aq-strength=1.0:no-aq-motion=1:qg-size=16:no-cutree=1 ";
            }
            if (chkCopyAud.CheckState == CheckState.Checked)
            {
                ffargs += "-c:a copy ";
            }
            if ((chkAudCustomBr.CheckState == CheckState.Checked) && (textAudioBitrate.Text == "") && (chkEncodeAud.CheckState == CheckState.Checked))
            {
                MessageBox.Show("You haven't enterted an audio bitrate");
                return;
            }
            if ((chkAudCustomBr.CheckState == CheckState.Checked) && (chkEncodeAud.CheckState == CheckState.Checked))
            {
            ffargs += "-c:a aac -b:a " + textAudioBitrate.Text + "k ";
            }
            if ((chkAudCustomBr.CheckState == CheckState.Unchecked) && (chkEncodeAud.CheckState == CheckState.Checked))
            {
                ffargs += "-c:a aac ";
            }
            if (chkCopySubs.CheckState == CheckState.Checked)
            {
                ffargs += "-c:s copy ";
            }
            ArrayList selectedFiles = new ArrayList();

            for(int i=0; i < checkedFilesList.Items.Count; i++)
                if (checkedFilesList.GetItemChecked(i))
                {
                    selectedFiles.Add(checkedFilesList.Items[i].ToString());
                }
            if (selectedFiles.Count < 1)
            {
                MessageBox.Show("You haven't selected any files!!!");
                return;
            } else
            {
                for (int j=0; j < selectedFiles.Count; j++)
                {
                    convertIt("-n -i \"" + selectedFiles[j] + "\" " + ffargs + "\"" + selectedFiles[j] + "_converted.mkv\"");
                }
            }
        }
    }
}
