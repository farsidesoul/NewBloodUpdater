using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace New_Blood_Updater
{
    public partial class Form1 : Form
    {
        string wowExeLocation = "";
        string patchLocation = "";
        string realmListLocation = "";

        public Form1()
        {
            

            InitializeComponent();
            try
            {
                string saveLocated = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Updater.txt");
                textBox2.Text = saveLocated;
            }
            catch (Exception ex)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Please select your base WoW folder.");
            }
            else
            {
                WebClient Download_Patch4 = new WebClient();
                Download_Patch4.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                Download_Patch4.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Download_Patch4.DownloadFile(new Uri(textBox1.Text.Trim().ToString()), textBox2.Text.Trim() + "\\data\\patch-4.MPQ");

                //while (Download_Patch4.IsBusy)
                //{

                //}
                //Download_Patch4.Dispose();

                WebClient Download_RealmList = new WebClient();
                Download_RealmList.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                Download_RealmList.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Download_RealmList.DownloadFileAsync(new Uri(textBox3.Text.Trim().ToString()), textBox2.Text.Trim() + "\\data\\enUS\\realmlist.wtf");
                
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Downloading Successful", "Download_Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Save = new FolderBrowserDialog();
            Save.RootFolder = Environment.SpecialFolder.Desktop;
            if (Save.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = Save.SelectedPath;
                string saveLocation = textBox2.Text;
                System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Updater.txt", saveLocation);
                wowExeLocation = textBox2.Text + "\\wow.exe";
                patchLocation = textBox2.Text + "\\data\\";
                realmListLocation = textBox2.Text + "\\data\\enUS\\";
            } else {
                MessageBox.Show("Please select your base WoW folder (the one with Wow.exe in it)");
            }

            string Text = textBox1.Text.ToString();
            string[] arry = Text.Split('/');
            for (int i = 0; i < Int32.Parse(arry.Length.ToString()); i++)
            {
                if (i == Int32.Parse(arry.Length.ToString()) - 1)
                {
                    textBox2.Text += "\\" + arry[i].ToString();
                }
            }            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
