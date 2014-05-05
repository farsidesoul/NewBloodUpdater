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
                MessageBox.Show("Please select a destination to save the file");
            }
            else
            {
                WebClient Download_Client = new WebClient();
                Download_Client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                Download_Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Download_Client.DownloadFileAsync(new Uri(textBox1.Text.Trim().ToString()), textBox2.Text.Trim());
                Download_Client.DownloadFileAsync(new Uri(textBox3.Text.Trim().ToString()), textBox2.Text.Trim());
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

            string saveLocation = textBox2.Text;
            System.IO.File.WriteAllText(@"C:\Users\Public\Documents\Updater.txt", saveLocation);
        }
    }
}
