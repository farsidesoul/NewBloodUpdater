using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace New_Blood_Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Check to see if a previous file path was entered.
            try
            {
                string saveLocated = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\Updater.txt");
                textBox2.Text = saveLocated;
            }
            catch (Exception ex)
            {
                // Change textBox2 location to default
                textBox2.Text = "C:\\Program Files (x86)\\World of Warcraft";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If textBox2 contains no text, return error
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Please select your base WoW folder.");
            }
            // Checks to make sure wow.exe is present in the folder.
            else if (File.Exists(textBox2.Text + "\\wow.exe"))
            {
                DialogResult deleteCache = MessageBox.Show("This will also delete your WoW Cache folder. \n\tDo you wish to continue?", "Delete Cache?", MessageBoxButtons.YesNo);
                if (deleteCache == DialogResult.Yes)
                {
                    // Deletes the cache folder
                    string cacheToDelete = textBox2.Text + "\\cache\\";
                    label1.Text = "Deleting Cache...";
                    try
                    {
                        Directory.Delete(cacheToDelete, true);
                    }
                    catch (DirectoryNotFoundException ex)
                    {
                        label1.Text = "Cache not found, continuing.";
                    }
                    // Displays to user files are downloading
                    label1.Text = "Downloading...";

                    // File location for download and save path of Patch-4.MPQ
                    WebClient Download_Patch4 = new WebClient();
                    Download_Patch4.DownloadFile(textBox1.Text.Trim().ToString(), textBox2.Text.Trim() + "\\data\\patch-4.MPQ");

                    // File location for download and save path of realmlist.wtf
                    WebClient Download_RealmList = new WebClient();
                    Download_RealmList.DownloadFile(textBox3.Text.Trim().ToString(), textBox2.Text.Trim() + "\\data\\enUS\\realmlist.wtf");

                    // Alerts user downloads complete and changess download button to reflect
                    MessageBox.Show("Downloads completed successfully.");
                    label1.Text = "";
                }
                // if user does not wish to delete their Cache, do nothing.
                else if (deleteCache == DialogResult.No)
                {
                 
                }
            }
            // if unable to find wow.exe in specified path in textBox2, display error to user.
            else
            {
                MessageBox.Show("Unable to find your Wow.exe, please make sure you've selected the correct directory.");
            }
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
            } 
            if (!File.Exists(textBox2.Text + "\\wow.exe")) 
            {
                MessageBox.Show("Unable to detect Wow.exe within this folder.\nPlease select another folder.");
            }      
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Unable to find your Wow.exe, please select folder containing this file.");
            }
            else if (File.Exists(textBox2.Text + "\\wow.exe"))
            {
                Process.Start(textBox2.Text + "\\wow.exe");
            }
            // if unable to find wow.exe in specified path in textBox2, display error to user.
            else
            {
                MessageBox.Show("Unable to find your Wow.exe, please make sure you've selected the correct directory.");
            }
        }
    }
}
