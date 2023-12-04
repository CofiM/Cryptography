
namespace ZI_Projekat
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnParallel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.rtbChooseFilesParallel = new System.Windows.Forms.RichTextBox();
            this.btnChooseFilesParallel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbFilesToDecryptRC6 = new System.Windows.Forms.RichTextBox();
            this.rbtDestinationFolderDecryptRC6 = new System.Windows.Forms.RichTextBox();
            this.btnDecryptRC6 = new System.Windows.Forms.Button();
            this.btnChooseFolderDecryptRC6 = new System.Windows.Forms.Button();
            this.btnChooseFilesDecryptRC6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbFilesToEncryptRC6 = new System.Windows.Forms.RichTextBox();
            this.rtbDestinationFolderEncryptRC6 = new System.Windows.Forms.RichTextBox();
            this.btnEncryptRC6 = new System.Windows.Forms.Button();
            this.btnChooseFolderEncryptRC6 = new System.Windows.Forms.Button();
            this.btnChooseFilesEncryptRC6 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbFilesToDecryptBifid = new System.Windows.Forms.RichTextBox();
            this.rbtDestinationFolderDecryptBifid = new System.Windows.Forms.RichTextBox();
            this.btnDecryptBifid = new System.Windows.Forms.Button();
            this.btnChooseFolderDecryptBifid = new System.Windows.Forms.Button();
            this.btnChooseFilesDecryptBifid = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbFilesToEncryptBifid = new System.Windows.Forms.RichTextBox();
            this.rtbDestinationFolderEncryptBifid = new System.Windows.Forms.RichTextBox();
            this.btnEncryptBifid = new System.Windows.Forms.Button();
            this.btnChooseFolderEncryptBifid = new System.Windows.Forms.Button();
            this.btnChooseFilesEncryptBifid = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbtnOff = new System.Windows.Forms.RadioButton();
            this.rbtnOn = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbFilesToDecryptKnapsack = new System.Windows.Forms.RichTextBox();
            this.rbtDestinationFolderDecryptKnapsack = new System.Windows.Forms.RichTextBox();
            this.btnDecryptKnapsack = new System.Windows.Forms.Button();
            this.btnChooseFolderDecryptKnapsack = new System.Windows.Forms.Button();
            this.btnChooseFilesDecryptKnapsack = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rtbFilesToEncryptKnapsack = new System.Windows.Forms.RichTextBox();
            this.rtbDestinationFolderEncryptKnapsack = new System.Windows.Forms.RichTextBox();
            this.btnEncryptKnapsack = new System.Windows.Forms.Button();
            this.btnChooseFolderEncryptKnapsack = new System.Windows.Forms.Button();
            this.btnChooseFilesEncryptKnapsack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(786, 640);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RC6";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnParallel);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.rtbChooseFilesParallel);
            this.groupBox8.Controls.Add(this.btnChooseFilesParallel);
            this.groupBox8.Location = new System.Drawing.Point(15, 15);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(695, 186);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Parallel";
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(313, 143);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(75, 23);
            this.btnParallel.TabIndex = 10;
            this.btnParallel.Text = "Parallel";
            this.btnParallel.UseVisualStyleBackColor = true;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Choose files";
            // 
            // rtbChooseFilesParallel
            // 
            this.rtbChooseFilesParallel.Location = new System.Drawing.Point(5, 49);
            this.rtbChooseFilesParallel.Name = "rtbChooseFilesParallel";
            this.rtbChooseFilesParallel.Size = new System.Drawing.Size(307, 58);
            this.rtbChooseFilesParallel.TabIndex = 14;
            this.rtbChooseFilesParallel.Text = "";
            // 
            // btnChooseFilesParallel
            // 
            this.btnChooseFilesParallel.Location = new System.Drawing.Point(83, 116);
            this.btnChooseFilesParallel.Name = "btnChooseFilesParallel";
            this.btnChooseFilesParallel.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFilesParallel.TabIndex = 10;
            this.btnChooseFilesParallel.Text = "Choose files";
            this.btnChooseFilesParallel.UseVisualStyleBackColor = true;
            this.btnChooseFilesParallel.Click += new System.EventHandler(this.btnChooseFilesParallel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rtbFilesToDecryptRC6);
            this.groupBox2.Controls.Add(this.rbtDestinationFolderDecryptRC6);
            this.groupBox2.Controls.Add(this.btnDecryptRC6);
            this.groupBox2.Controls.Add(this.btnChooseFolderDecryptRC6);
            this.groupBox2.Controls.Add(this.btnChooseFilesDecryptRC6);
            this.groupBox2.Location = new System.Drawing.Point(10, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Destination folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Choose files to decrypt";
            // 
            // rtbFilesToDecryptRC6
            // 
            this.rtbFilesToDecryptRC6.Location = new System.Drawing.Point(5, 49);
            this.rtbFilesToDecryptRC6.Name = "rtbFilesToDecryptRC6";
            this.rtbFilesToDecryptRC6.Size = new System.Drawing.Size(307, 58);
            this.rtbFilesToDecryptRC6.TabIndex = 14;
            this.rtbFilesToDecryptRC6.Text = "";
            // 
            // rbtDestinationFolderDecryptRC6
            // 
            this.rbtDestinationFolderDecryptRC6.Location = new System.Drawing.Point(397, 49);
            this.rbtDestinationFolderDecryptRC6.Name = "rbtDestinationFolderDecryptRC6";
            this.rbtDestinationFolderDecryptRC6.Size = new System.Drawing.Size(292, 61);
            this.rbtDestinationFolderDecryptRC6.TabIndex = 13;
            this.rbtDestinationFolderDecryptRC6.Text = "";
            // 
            // btnDecryptRC6
            // 
            this.btnDecryptRC6.Location = new System.Drawing.Point(314, 149);
            this.btnDecryptRC6.Name = "btnDecryptRC6";
            this.btnDecryptRC6.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptRC6.TabIndex = 12;
            this.btnDecryptRC6.Text = "Decrypt";
            this.btnDecryptRC6.UseVisualStyleBackColor = true;
            this.btnDecryptRC6.Click += new System.EventHandler(this.btnDecryptRC6_Click);
            // 
            // btnChooseFolderDecryptRC6
            // 
            this.btnChooseFolderDecryptRC6.Location = new System.Drawing.Point(504, 116);
            this.btnChooseFolderDecryptRC6.Name = "btnChooseFolderDecryptRC6";
            this.btnChooseFolderDecryptRC6.Size = new System.Drawing.Size(118, 23);
            this.btnChooseFolderDecryptRC6.TabIndex = 11;
            this.btnChooseFolderDecryptRC6.Text = "Choose folder";
            this.btnChooseFolderDecryptRC6.UseVisualStyleBackColor = true;
            this.btnChooseFolderDecryptRC6.Click += new System.EventHandler(this.btnChooseFolderDecryptRC6_Click);
            // 
            // btnChooseFilesDecryptRC6
            // 
            this.btnChooseFilesDecryptRC6.Location = new System.Drawing.Point(83, 116);
            this.btnChooseFilesDecryptRC6.Name = "btnChooseFilesDecryptRC6";
            this.btnChooseFilesDecryptRC6.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFilesDecryptRC6.TabIndex = 10;
            this.btnChooseFilesDecryptRC6.Text = "Choose files";
            this.btnChooseFilesDecryptRC6.UseVisualStyleBackColor = true;
            this.btnChooseFilesDecryptRC6.Click += new System.EventHandler(this.btnChooseFilesDecryptRC6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbFilesToEncryptRC6);
            this.groupBox1.Controls.Add(this.rtbDestinationFolderEncryptRC6);
            this.groupBox1.Controls.Add(this.btnEncryptRC6);
            this.groupBox1.Controls.Add(this.btnChooseFolderEncryptRC6);
            this.groupBox1.Controls.Add(this.btnChooseFilesEncryptRC6);
            this.groupBox1.Location = new System.Drawing.Point(10, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destination folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose files to encrypt";
            // 
            // rtbFilesToEncryptRC6
            // 
            this.rtbFilesToEncryptRC6.Location = new System.Drawing.Point(6, 52);
            this.rtbFilesToEncryptRC6.Name = "rtbFilesToEncryptRC6";
            this.rtbFilesToEncryptRC6.Size = new System.Drawing.Size(307, 58);
            this.rtbFilesToEncryptRC6.TabIndex = 7;
            this.rtbFilesToEncryptRC6.Text = "";
            // 
            // rtbDestinationFolderEncryptRC6
            // 
            this.rtbDestinationFolderEncryptRC6.Location = new System.Drawing.Point(398, 52);
            this.rtbDestinationFolderEncryptRC6.Name = "rtbDestinationFolderEncryptRC6";
            this.rtbDestinationFolderEncryptRC6.Size = new System.Drawing.Size(292, 61);
            this.rtbDestinationFolderEncryptRC6.TabIndex = 6;
            this.rtbDestinationFolderEncryptRC6.Text = "";
            // 
            // btnEncryptRC6
            // 
            this.btnEncryptRC6.Location = new System.Drawing.Point(314, 159);
            this.btnEncryptRC6.Name = "btnEncryptRC6";
            this.btnEncryptRC6.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptRC6.TabIndex = 4;
            this.btnEncryptRC6.Text = "Encrypt";
            this.btnEncryptRC6.UseVisualStyleBackColor = true;
            this.btnEncryptRC6.Click += new System.EventHandler(this.btnEncryptRC6_Click);
            // 
            // btnChooseFolderEncryptRC6
            // 
            this.btnChooseFolderEncryptRC6.Location = new System.Drawing.Point(505, 119);
            this.btnChooseFolderEncryptRC6.Name = "btnChooseFolderEncryptRC6";
            this.btnChooseFolderEncryptRC6.Size = new System.Drawing.Size(117, 23);
            this.btnChooseFolderEncryptRC6.TabIndex = 3;
            this.btnChooseFolderEncryptRC6.Text = "Choose folder";
            this.btnChooseFolderEncryptRC6.UseVisualStyleBackColor = true;
            this.btnChooseFolderEncryptRC6.Click += new System.EventHandler(this.btnChooseFolderEncryptRC6_Click);
            // 
            // btnChooseFilesEncryptRC6
            // 
            this.btnChooseFilesEncryptRC6.Location = new System.Drawing.Point(84, 119);
            this.btnChooseFilesEncryptRC6.Name = "btnChooseFilesEncryptRC6";
            this.btnChooseFilesEncryptRC6.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFilesEncryptRC6.TabIndex = 2;
            this.btnChooseFilesEncryptRC6.Text = "Choose files";
            this.btnChooseFilesEncryptRC6.UseVisualStyleBackColor = true;
            this.btnChooseFilesEncryptRC6.Click += new System.EventHandler(this.btnChooseFilesEncryptRC6_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bifid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rtbFilesToDecryptBifid);
            this.groupBox3.Controls.Add(this.rbtDestinationFolderDecryptBifid);
            this.groupBox3.Controls.Add(this.btnDecryptBifid);
            this.groupBox3.Controls.Add(this.btnChooseFolderDecryptBifid);
            this.groupBox3.Controls.Add(this.btnChooseFilesDecryptBifid);
            this.groupBox3.Location = new System.Drawing.Point(25, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 202);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Decrypt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Destination folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Choose files to decrypt";
            // 
            // rtbFilesToDecryptBifid
            // 
            this.rtbFilesToDecryptBifid.Location = new System.Drawing.Point(5, 49);
            this.rtbFilesToDecryptBifid.Name = "rtbFilesToDecryptBifid";
            this.rtbFilesToDecryptBifid.Size = new System.Drawing.Size(307, 58);
            this.rtbFilesToDecryptBifid.TabIndex = 14;
            this.rtbFilesToDecryptBifid.Text = "";
            // 
            // rbtDestinationFolderDecryptBifid
            // 
            this.rbtDestinationFolderDecryptBifid.Location = new System.Drawing.Point(397, 49);
            this.rbtDestinationFolderDecryptBifid.Name = "rbtDestinationFolderDecryptBifid";
            this.rbtDestinationFolderDecryptBifid.Size = new System.Drawing.Size(292, 61);
            this.rbtDestinationFolderDecryptBifid.TabIndex = 13;
            this.rbtDestinationFolderDecryptBifid.Text = "";
            // 
            // btnDecryptBifid
            // 
            this.btnDecryptBifid.Location = new System.Drawing.Point(280, 157);
            this.btnDecryptBifid.Name = "btnDecryptBifid";
            this.btnDecryptBifid.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptBifid.TabIndex = 12;
            this.btnDecryptBifid.Text = "Decrypt";
            this.btnDecryptBifid.UseVisualStyleBackColor = true;
            this.btnDecryptBifid.Click += new System.EventHandler(this.btnDecryptBifid_Click);
            // 
            // btnChooseFolderDecryptBifid
            // 
            this.btnChooseFolderDecryptBifid.Location = new System.Drawing.Point(504, 116);
            this.btnChooseFolderDecryptBifid.Name = "btnChooseFolderDecryptBifid";
            this.btnChooseFolderDecryptBifid.Size = new System.Drawing.Size(118, 23);
            this.btnChooseFolderDecryptBifid.TabIndex = 11;
            this.btnChooseFolderDecryptBifid.Text = "Choose folder";
            this.btnChooseFolderDecryptBifid.UseVisualStyleBackColor = true;
            this.btnChooseFolderDecryptBifid.Click += new System.EventHandler(this.btnChooseFolderDecryptBifid_Click);
            // 
            // btnChooseFilesDecryptBifid
            // 
            this.btnChooseFilesDecryptBifid.Location = new System.Drawing.Point(83, 116);
            this.btnChooseFilesDecryptBifid.Name = "btnChooseFilesDecryptBifid";
            this.btnChooseFilesDecryptBifid.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFilesDecryptBifid.TabIndex = 10;
            this.btnChooseFilesDecryptBifid.Text = "Choose files";
            this.btnChooseFilesDecryptBifid.UseVisualStyleBackColor = true;
            this.btnChooseFilesDecryptBifid.Click += new System.EventHandler(this.btnChooseFilesDecryptBifid_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.rtbFilesToEncryptBifid);
            this.groupBox4.Controls.Add(this.rtbDestinationFolderEncryptBifid);
            this.groupBox4.Controls.Add(this.btnEncryptBifid);
            this.groupBox4.Controls.Add(this.btnChooseFolderEncryptBifid);
            this.groupBox4.Controls.Add(this.btnChooseFilesEncryptBifid);
            this.groupBox4.Location = new System.Drawing.Point(25, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(707, 224);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encrypt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Destination folder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Choose files to encrypt";
            // 
            // rtbFilesToEncryptBifid
            // 
            this.rtbFilesToEncryptBifid.Location = new System.Drawing.Point(6, 52);
            this.rtbFilesToEncryptBifid.Name = "rtbFilesToEncryptBifid";
            this.rtbFilesToEncryptBifid.Size = new System.Drawing.Size(307, 58);
            this.rtbFilesToEncryptBifid.TabIndex = 7;
            this.rtbFilesToEncryptBifid.Text = "";
            // 
            // rtbDestinationFolderEncryptBifid
            // 
            this.rtbDestinationFolderEncryptBifid.Location = new System.Drawing.Point(398, 52);
            this.rtbDestinationFolderEncryptBifid.Name = "rtbDestinationFolderEncryptBifid";
            this.rtbDestinationFolderEncryptBifid.Size = new System.Drawing.Size(292, 61);
            this.rtbDestinationFolderEncryptBifid.TabIndex = 6;
            this.rtbDestinationFolderEncryptBifid.Text = "";
            // 
            // btnEncryptBifid
            // 
            this.btnEncryptBifid.Location = new System.Drawing.Point(281, 160);
            this.btnEncryptBifid.Name = "btnEncryptBifid";
            this.btnEncryptBifid.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptBifid.TabIndex = 4;
            this.btnEncryptBifid.Text = "Encrypt";
            this.btnEncryptBifid.UseVisualStyleBackColor = true;
            this.btnEncryptBifid.Click += new System.EventHandler(this.btnEncryptBifid_Click);
            // 
            // btnChooseFolderEncryptBifid
            // 
            this.btnChooseFolderEncryptBifid.Location = new System.Drawing.Point(505, 119);
            this.btnChooseFolderEncryptBifid.Name = "btnChooseFolderEncryptBifid";
            this.btnChooseFolderEncryptBifid.Size = new System.Drawing.Size(117, 23);
            this.btnChooseFolderEncryptBifid.TabIndex = 3;
            this.btnChooseFolderEncryptBifid.Text = "Choose folder";
            this.btnChooseFolderEncryptBifid.UseVisualStyleBackColor = true;
            this.btnChooseFolderEncryptBifid.Click += new System.EventHandler(this.btnChooseFolderEncryptBifid_Click);
            // 
            // btnChooseFilesEncryptBifid
            // 
            this.btnChooseFilesEncryptBifid.Location = new System.Drawing.Point(84, 119);
            this.btnChooseFilesEncryptBifid.Name = "btnChooseFilesEncryptBifid";
            this.btnChooseFilesEncryptBifid.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFilesEncryptBifid.TabIndex = 2;
            this.btnChooseFilesEncryptBifid.Text = "Choose files";
            this.btnChooseFilesEncryptBifid.UseVisualStyleBackColor = true;
            this.btnChooseFilesEncryptBifid.Click += new System.EventHandler(this.btnChooseFilesEncryptBifid_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(778, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Knapsack";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbtnOff);
            this.groupBox7.Controls.Add(this.rbtnOn);
            this.groupBox7.Location = new System.Drawing.Point(261, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(170, 53);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Coding mode active";
            // 
            // rbtnOff
            // 
            this.rbtnOff.AutoSize = true;
            this.rbtnOff.Location = new System.Drawing.Point(102, 28);
            this.rbtnOff.Name = "rbtnOff";
            this.rbtnOff.Size = new System.Drawing.Size(39, 17);
            this.rbtnOff.TabIndex = 1;
            this.rbtnOff.Text = "Off";
            this.rbtnOff.UseVisualStyleBackColor = true;
            // 
            // rbtnOn
            // 
            this.rbtnOn.AutoSize = true;
            this.rbtnOn.Checked = true;
            this.rbtnOn.Location = new System.Drawing.Point(17, 28);
            this.rbtnOn.Name = "rbtnOn";
            this.rbtnOn.Size = new System.Drawing.Size(39, 17);
            this.rbtnOn.TabIndex = 0;
            this.rbtnOn.TabStop = true;
            this.rbtnOn.Text = "On";
            this.rbtnOn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.rtbFilesToDecryptKnapsack);
            this.groupBox5.Controls.Add(this.rbtDestinationFolderDecryptKnapsack);
            this.groupBox5.Controls.Add(this.btnDecryptKnapsack);
            this.groupBox5.Controls.Add(this.btnChooseFolderDecryptKnapsack);
            this.groupBox5.Controls.Add(this.btnChooseFilesDecryptKnapsack);
            this.groupBox5.Location = new System.Drawing.Point(32, 272);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(706, 192);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Decrypt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Destination folder";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Choose files to decrypt";
            // 
            // rtbFilesToDecryptKnapsack
            // 
            this.rtbFilesToDecryptKnapsack.Location = new System.Drawing.Point(5, 49);
            this.rtbFilesToDecryptKnapsack.Name = "rtbFilesToDecryptKnapsack";
            this.rtbFilesToDecryptKnapsack.Size = new System.Drawing.Size(307, 58);
            this.rtbFilesToDecryptKnapsack.TabIndex = 14;
            this.rtbFilesToDecryptKnapsack.Text = "";
            // 
            // rbtDestinationFolderDecryptKnapsack
            // 
            this.rbtDestinationFolderDecryptKnapsack.Location = new System.Drawing.Point(397, 49);
            this.rbtDestinationFolderDecryptKnapsack.Name = "rbtDestinationFolderDecryptKnapsack";
            this.rbtDestinationFolderDecryptKnapsack.Size = new System.Drawing.Size(292, 61);
            this.rbtDestinationFolderDecryptKnapsack.TabIndex = 13;
            this.rbtDestinationFolderDecryptKnapsack.Text = "";
            // 
            // btnDecryptKnapsack
            // 
            this.btnDecryptKnapsack.Location = new System.Drawing.Point(280, 157);
            this.btnDecryptKnapsack.Name = "btnDecryptKnapsack";
            this.btnDecryptKnapsack.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptKnapsack.TabIndex = 12;
            this.btnDecryptKnapsack.Text = "Decrypt";
            this.btnDecryptKnapsack.UseVisualStyleBackColor = true;
            this.btnDecryptKnapsack.Click += new System.EventHandler(this.btnDecryptKnapsack_Click);
            // 
            // btnChooseFolderDecryptKnapsack
            // 
            this.btnChooseFolderDecryptKnapsack.Location = new System.Drawing.Point(504, 116);
            this.btnChooseFolderDecryptKnapsack.Name = "btnChooseFolderDecryptKnapsack";
            this.btnChooseFolderDecryptKnapsack.Size = new System.Drawing.Size(118, 23);
            this.btnChooseFolderDecryptKnapsack.TabIndex = 11;
            this.btnChooseFolderDecryptKnapsack.Text = "Choose folder";
            this.btnChooseFolderDecryptKnapsack.UseVisualStyleBackColor = true;
            this.btnChooseFolderDecryptKnapsack.Click += new System.EventHandler(this.btnChooseFolderDecryptKnapsack_Click);
            // 
            // btnChooseFilesDecryptKnapsack
            // 
            this.btnChooseFilesDecryptKnapsack.Location = new System.Drawing.Point(83, 116);
            this.btnChooseFilesDecryptKnapsack.Name = "btnChooseFilesDecryptKnapsack";
            this.btnChooseFilesDecryptKnapsack.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFilesDecryptKnapsack.TabIndex = 10;
            this.btnChooseFilesDecryptKnapsack.Text = "Choose files";
            this.btnChooseFilesDecryptKnapsack.UseVisualStyleBackColor = true;
            this.btnChooseFilesDecryptKnapsack.Click += new System.EventHandler(this.btnChooseFilesDecryptKnapsack_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.rtbFilesToEncryptKnapsack);
            this.groupBox6.Controls.Add(this.rtbDestinationFolderEncryptKnapsack);
            this.groupBox6.Controls.Add(this.btnEncryptKnapsack);
            this.groupBox6.Controls.Add(this.btnChooseFolderEncryptKnapsack);
            this.groupBox6.Controls.Add(this.btnChooseFilesEncryptKnapsack);
            this.groupBox6.Location = new System.Drawing.Point(32, 71);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(707, 195);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Encrypt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Destination folder";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Choose files to encrypt";
            // 
            // rtbFilesToEncryptKnapsack
            // 
            this.rtbFilesToEncryptKnapsack.Location = new System.Drawing.Point(6, 52);
            this.rtbFilesToEncryptKnapsack.Name = "rtbFilesToEncryptKnapsack";
            this.rtbFilesToEncryptKnapsack.Size = new System.Drawing.Size(307, 58);
            this.rtbFilesToEncryptKnapsack.TabIndex = 7;
            this.rtbFilesToEncryptKnapsack.Text = "";
            // 
            // rtbDestinationFolderEncryptKnapsack
            // 
            this.rtbDestinationFolderEncryptKnapsack.Location = new System.Drawing.Point(398, 52);
            this.rtbDestinationFolderEncryptKnapsack.Name = "rtbDestinationFolderEncryptKnapsack";
            this.rtbDestinationFolderEncryptKnapsack.Size = new System.Drawing.Size(292, 61);
            this.rtbDestinationFolderEncryptKnapsack.TabIndex = 6;
            this.rtbDestinationFolderEncryptKnapsack.Text = "";
            // 
            // btnEncryptKnapsack
            // 
            this.btnEncryptKnapsack.Location = new System.Drawing.Point(281, 160);
            this.btnEncryptKnapsack.Name = "btnEncryptKnapsack";
            this.btnEncryptKnapsack.Size = new System.Drawing.Size(75, 23);
            this.btnEncryptKnapsack.TabIndex = 4;
            this.btnEncryptKnapsack.Text = "Encrypt";
            this.btnEncryptKnapsack.UseVisualStyleBackColor = true;
            this.btnEncryptKnapsack.Click += new System.EventHandler(this.btnEncryptKnapsack_Click);
            // 
            // btnChooseFolderEncryptKnapsack
            // 
            this.btnChooseFolderEncryptKnapsack.Location = new System.Drawing.Point(505, 119);
            this.btnChooseFolderEncryptKnapsack.Name = "btnChooseFolderEncryptKnapsack";
            this.btnChooseFolderEncryptKnapsack.Size = new System.Drawing.Size(117, 23);
            this.btnChooseFolderEncryptKnapsack.TabIndex = 3;
            this.btnChooseFolderEncryptKnapsack.Text = "Choose folder";
            this.btnChooseFolderEncryptKnapsack.UseVisualStyleBackColor = true;
            this.btnChooseFolderEncryptKnapsack.Click += new System.EventHandler(this.btnChooseFolderEncryptKnapsack_Click);
            // 
            // btnChooseFilesEncryptKnapsack
            // 
            this.btnChooseFilesEncryptKnapsack.Location = new System.Drawing.Point(84, 119);
            this.btnChooseFilesEncryptKnapsack.Name = "btnChooseFilesEncryptKnapsack";
            this.btnChooseFilesEncryptKnapsack.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFilesEncryptKnapsack.TabIndex = 2;
            this.btnChooseFilesEncryptKnapsack.Text = "Choose files";
            this.btnChooseFilesEncryptKnapsack.UseVisualStyleBackColor = true;
            this.btnChooseFilesEncryptKnapsack.Click += new System.EventHandler(this.btnChooseFilesEncryptKnapsack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 660);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbFilesToEncryptRC6;
        private System.Windows.Forms.RichTextBox rtbDestinationFolderEncryptRC6;
        private System.Windows.Forms.Button btnEncryptRC6;
        private System.Windows.Forms.Button btnChooseFolderEncryptRC6;
        private System.Windows.Forms.Button btnChooseFilesEncryptRC6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbFilesToDecryptRC6;
        private System.Windows.Forms.RichTextBox rbtDestinationFolderDecryptRC6;
        private System.Windows.Forms.Button btnDecryptRC6;
        private System.Windows.Forms.Button btnChooseFolderDecryptRC6;
        private System.Windows.Forms.Button btnChooseFilesDecryptRC6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbFilesToDecryptBifid;
        private System.Windows.Forms.RichTextBox rbtDestinationFolderDecryptBifid;
        private System.Windows.Forms.Button btnDecryptBifid;
        private System.Windows.Forms.Button btnChooseFolderDecryptBifid;
        private System.Windows.Forms.Button btnChooseFilesDecryptBifid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbFilesToEncryptBifid;
        private System.Windows.Forms.RichTextBox rtbDestinationFolderEncryptBifid;
        private System.Windows.Forms.Button btnEncryptBifid;
        private System.Windows.Forms.Button btnChooseFolderEncryptBifid;
        private System.Windows.Forms.Button btnChooseFilesEncryptBifid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbFilesToDecryptKnapsack;
        private System.Windows.Forms.RichTextBox rbtDestinationFolderDecryptKnapsack;
        private System.Windows.Forms.Button btnDecryptKnapsack;
        private System.Windows.Forms.Button btnChooseFolderDecryptKnapsack;
        private System.Windows.Forms.Button btnChooseFilesDecryptKnapsack;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rtbFilesToEncryptKnapsack;
        private System.Windows.Forms.RichTextBox rtbDestinationFolderEncryptKnapsack;
        private System.Windows.Forms.Button btnEncryptKnapsack;
        private System.Windows.Forms.Button btnChooseFolderEncryptKnapsack;
        private System.Windows.Forms.Button btnChooseFilesEncryptKnapsack;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbtnOff;
        private System.Windows.Forms.RadioButton rbtnOn;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtbChooseFilesParallel;
        private System.Windows.Forms.Button btnChooseFilesParallel;
    }
}

