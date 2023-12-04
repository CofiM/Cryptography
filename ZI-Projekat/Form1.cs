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

namespace ZI_Projekat
{
    public partial class Form1 : Form
    {
        private FileSystem fs;
        private string file;
        private string directory;
        private DirectoryInfo directoryInfo;

        public Form1()
        {
            InitializeComponent();
            fs = new FileSystem();
        }

        private void btnChooseFilesEncryptRC6_Click(object sender, EventArgs e)
        {
            //if (Directory.Exists(rtbFilesToEncryptRC6.Text))
              //  try
               // {
                    //openFileDialog1.FileName = "";
                    openFileDialog1.Filter = "Text files (*.txt)|*.txt|(*.bmp)|*.bmp";
                    openFileDialog1.ShowDialog();
                    if (String.IsNullOrEmpty(openFileDialog1.FileName))
                        return;
                    rtbFilesToEncryptRC6.Text = openFileDialog1.FileName;
                   this.file = rtbFilesToEncryptRC6.Text;
                    //fs.EncodeAllFilesFromDirectory(tbEncodePath.Text);
                  //  MessageBox.Show("Successful encoding!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  }
                //catch (Exception ex)
            //    {
               //     MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  }

          //  else
            //    MessageBox.Show("Invalid directory name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChooseFolderEncryptRC6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                return;

            //if (folderBrowserDialog.SelectedPath == this.destinationFolderPath)
            //{
            //    MessageBox.Show("Target Folder must be different from Destination Folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //this.targetFolderPath = folderBrowserDialog.SelectedPath;
            //txbxTargetFolder.Text = this.targetFolderPath;
            this.directory = folderBrowserDialog.SelectedPath;
            rtbDestinationFolderEncryptRC6.Text = folderBrowserDialog.SelectedPath;
            fs.SetOutputDirectory(folderBrowserDialog.SelectedPath);
        }

        private void btnEncryptRC6_Click(object sender, EventArgs e)
        {
            //string path = this.directory + "\\" + this.file;
            fs.Rc6 = true;
            fs.SetKey("kacam");
            fs.SetOutputDirectory(this.directory);
            fs.EncodeFileFromPath(this.file);
            fs.Rc6 = false;
        }

        private void btnChooseFilesDecryptRC6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|(*.bmp)|*.bmp";
            openFileDialog1.ShowDialog();
            if (String.IsNullOrEmpty(openFileDialog1.FileName))
                return;
            rtbFilesToDecryptRC6.Text = openFileDialog1.FileName;
            this.file = rtbFilesToDecryptRC6.Text;
        }

        private void btnChooseFolderDecryptRC6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                return;

            //if (folderBrowserDialog.SelectedPath == this.destinationFolderPath)
            //{
            //    MessageBox.Show("Target Folder must be different from Destination Folder!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //this.targetFolderPath = folderBrowserDialog.SelectedPath;
            //txbxTargetFolder.Text = this.targetFolderPath;
            this.directory = folderBrowserDialog.SelectedPath;
            rbtDestinationFolderDecryptRC6.Text = folderBrowserDialog.SelectedPath;
            fs.SetOutputDirectory(folderBrowserDialog.SelectedPath);
        }

        private void btnDecryptRC6_Click(object sender, EventArgs e)
        {
            fs.Rc6 = true;
            fs.SetKey("kacam");
            fs.SetOutputDirectory(this.directory);
            fs.DecodeFile(this.file);
            fs.Rc6 = false;
        }

        private void btnChooseFilesEncryptBifid_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            if (String.IsNullOrEmpty(openFileDialog1.FileName))
                return;
            rtbFilesToEncryptBifid.Text = openFileDialog1.FileName;
            this.file = rtbFilesToEncryptBifid.Text;
        }

        private void btnChooseFolderEncryptBifid_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                return;

            this.directory = folderBrowserDialog.SelectedPath;
            rtbDestinationFolderEncryptBifid.Text = folderBrowserDialog.SelectedPath;
            fs.SetOutputDirectory(folderBrowserDialog.SelectedPath);
        }

        private void btnEncryptBifid_Click(object sender, EventArgs e)
        {
            fs.Bifid = true;
            //fs.SetKey("kacam");
            fs.SetOutputDirectory(this.directory);
            fs.EncodeFileFromPath(this.file);
            fs.Bifid = false;
        }

        private void btnChooseFilesDecryptBifid_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            if (String.IsNullOrEmpty(openFileDialog1.FileName))
                return;
            rtbFilesToDecryptBifid.Text = openFileDialog1.FileName;
            this.file = rtbFilesToDecryptBifid.Text;
        }

        private void btnChooseFolderDecryptBifid_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                return;

           
            this.directory = folderBrowserDialog.SelectedPath;
            rbtDestinationFolderDecryptBifid.Text = folderBrowserDialog.SelectedPath;
            fs.SetOutputDirectory(folderBrowserDialog.SelectedPath);
        }

        private void btnDecryptBifid_Click(object sender, EventArgs e)
        {
            fs.Bifid = true;
           // fs.SetKey("kacam");
            fs.SetOutputDirectory(this.directory);
            fs.DecodeFile(this.file);
            fs.Bifid = false;
        }

        private void btnChooseFilesEncryptKnapsack_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            if (String.IsNullOrEmpty(openFileDialog1.FileName))
                return;
            rtbFilesToEncryptKnapsack.Text = openFileDialog1.FileName;
            this.file = rtbFilesToEncryptKnapsack.Text;
        }

        private void btnChooseFolderEncryptKnapsack_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                return;

            this.directory = folderBrowserDialog.SelectedPath;
            rtbDestinationFolderEncryptKnapsack.Text = folderBrowserDialog.SelectedPath;
            fs.SetOutputDirectory(folderBrowserDialog.SelectedPath);
        }

        private void btnEncryptKnapsack_Click(object sender, EventArgs e)
        {      
            fs.Knapsack = true;
            //fs.SetKey("kacam");
            if (rbtnOn.Checked)
                fs.BlockMode = true;
            else
                fs.BlockMode = false;
            fs.SetOutputDirectory(this.directory);
            fs.EncodeFileFromPath(this.file);
            fs.Knapsack = false;
        }

        private void btnChooseFilesDecryptKnapsack_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            if (String.IsNullOrEmpty(openFileDialog1.FileName))
                return;
            rtbFilesToDecryptKnapsack.Text = openFileDialog1.FileName;
            this.file = rtbFilesToDecryptKnapsack.Text;
        }

        private void btnChooseFolderDecryptKnapsack_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                return;


            this.directory = folderBrowserDialog.SelectedPath;
            rbtDestinationFolderDecryptKnapsack.Text = folderBrowserDialog.SelectedPath;
            fs.SetOutputDirectory(folderBrowserDialog.SelectedPath);
        }

        private void btnDecryptKnapsack_Click(object sender, EventArgs e)
        {
            fs.Knapsack = true;
            // fs.SetKey("kacam");
            if (rbtnOn.Checked)
                fs.BlockMode = true;
            else
                fs.BlockMode = false;
            fs.SetOutputDirectory(this.directory);
            fs.DecodeFile(this.file);
            fs.Knapsack = false;
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            List<string> encryptedFileLines = new List<string>();
            List<FileInfo> fileInfos = this.directoryInfo.GetFiles().ToList();
            List<FileInfo> onlyTxts = fileInfos.Where(fi => fi.Extension == ".txt").ToList();

            fs.SetOutputDirectory(this.directory);
            fs.SetKey("kacam");

            foreach (var file in onlyTxts)
            {

                encryptedFileLines.Add(file.FullName);
            }

            fs.Parallel_Loading(encryptedFileLines, 3);

            fileInfos.Clear();
            onlyTxts.Clear();
        }

        private void btnChooseFilesParallel_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = "";
            folderBrowserDialog.ShowDialog();

            if (String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                return;

            this.directory = folderBrowserDialog.SelectedPath;
            rtbChooseFilesParallel.Text = this.directory;
            this.directoryInfo = new DirectoryInfo(this.directory);

        }
    }
}
