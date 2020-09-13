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
using MediaInfoLib;

namespace HEVCme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string workDir = "";
        private void getFileInfo(string myFile)
        {
            //Initilaizing MediaInfo
            MediaInfo MI = new MediaInfo();

            //From: preparing an example file for reading
            FileStream From = new FileStream(myFile, FileMode.Open, FileAccess.Read);

            //From: preparing a memory buffer for reading
            byte[] From_Buffer = new byte[64 * 1024];
            int From_Buffer_Size; //The size of the read file buffer

            //Preparing to fill MediaInfo with a buffer
            MI.Open_Buffer_Init(From.Length, 0);

            //The parsing loop
            do
            {
                //Reading data somewhere, do what you want for this.
                From_Buffer_Size = From.Read(From_Buffer, 0, 64 * 1024);

                //Sending the buffer to MediaInfo
                System.Runtime.InteropServices.GCHandle GC = System.Runtime.InteropServices.GCHandle.Alloc(From_Buffer, System.Runtime.InteropServices.GCHandleType.Pinned);
                IntPtr From_Buffer_IntPtr = GC.AddrOfPinnedObject();
                Status Result = (Status)MI.Open_Buffer_Continue(From_Buffer_IntPtr, (IntPtr)From_Buffer_Size);
                GC.Free();
                if ((Result & Status.Finalized) == Status.Finalized)
                    break;

                //Testing if MediaInfo request to go elsewhere
                if (MI.Open_Buffer_Continue_GoTo_Get() != -1)
                {
                    Int64 Position = From.Seek(MI.Open_Buffer_Continue_GoTo_Get(), SeekOrigin.Begin); //Position the file
                    MI.Open_Buffer_Init(From.Length, Position); //Informing MediaInfo we have seek
                }
            }
            while (From_Buffer_Size > 0);

            //Finalizing
            MI.Open_Buffer_Finalize(); //This is the end of the stream, MediaInfo must finnish some work

            //Get() example
            string itemWidth = MI.Get(StreamKind.Video, 0, "Width");
            string itemHeight = MI.Get(StreamKind.Video, 0, "Height");
            string itemFormat = MI.Get(StreamKind.Video, 0, "Format");
            string itemAudFormat = MI.Get(StreamKind.Audio, 0, "Format");
            string itemAudChans = MI.Get(StreamKind.Audio, 0, "Channels");
            string myOutpt = itemWidth + "\r\n" + itemHeight + "\r\n" + itemFormat + "\r\n" + itemAudFormat + "\r\n" + itemAudChans + "\r\n"; ;
            richTextBox1.Text = myOutpt;
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
                    workDir += fbd.SelectedPath.ToString();
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
                    string renameThis = selectedFiles[j].ToString().Split('\\').Last();
                    MessageBox.Show(renameThis + " - " + workDir);
                    MessageBox.Show("-n -i \"" + selectedFiles[j] + "\" " + ffargs + "\"" + selectedFiles[j] + "_converted.mkv\"");
                }
            }
        }

        private void butSelectAll_Click(object sender, EventArgs e)
        {
            for(int a=0; a < checkedFilesList.Items.Count; a++)
            {
                checkedFilesList.SetItemChecked(a, true);
            }
        }

        private void butSelectNone_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < checkedFilesList.Items.Count; a++)
            {
                checkedFilesList.SetItemChecked(a, false);
            }
        }

        private void butMedInf_Click(object sender, EventArgs e)
        {
            getFileInfo("test.mp4");
        }
    }
}
