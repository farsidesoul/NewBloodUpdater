using System;
using System.Net;
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
                string saveLocated = File.ReadAllText(@"C:\Users\Public\Documents\Updater.txt");
                tb_wowFolderLocation.Text = saveLocated;
            }
            catch (FileNotFoundException ex)
            {
                // Change tb_wowFolderLocation location to default
                tb_wowFolderLocation.Text = @"C:\Program Files (x86)\World of Warcraft";
            }
            
        }
		//To make wow exe not found msg box consistent
		private static void NoWowExeFound()
		{
			MessageBox.Show(@"Unable to find your Wow.exe, please make sure you've selected the correct directory.");
		}

        private void downloadButton_Click(object sender, EventArgs e)
        {
            // If tb_wowFolderLocation contains no text, return error
			// Checks to make sure wow.exe is present in the folder.
			// if unable to find wow.exe in specified path in tb_wowFolderLocation, display error to user.
			/*
			second condition will not be triggered unless first one is true
			also you can use only !File.Exists(tb_wowFolderLocation.Text + "\\wow.exe") because "" file doesn't exist also ;)
			*/
            if (tb_wowFolderLocation.Text == String.Empty && !File.Exists(tb_wowFolderLocation.Text + "\\wow.exe"))
            {
                NoWowExeFound();
				return;
            }

			DialogResult deleteCache = MessageBox.Show(@"This will also delete your WoW Cache folder. \n\tDo you wish to continue?", @"Delete Cache?", MessageBoxButtons.YesNo);
			// if user does not wish to delete their Cache, do nothing.
			if (deleteCache != DialogResult.Yes)
			{
				return;
			}
			
			// Deletes the cache folder
			string cacheToDelete = tb_wowFolderLocation.Text + @"\cache\";
			try
			{
				Directory.Delete(cacheToDelete, true);
			}
			catch (DirectoryNotFoundException ex)
			{

			}
			// Displays to user files are downloading
			//Name labels appropriately
			downloadStatusLabel.Text = @"Downloading...";

			// File location for download and save path of Patch-4.MPQ
			WebClient downloadPatch4 = new WebClient();
			downloadPatch4.DownloadFile(tb_patchLocation.Text.Trim(), tb_wowFolderLocation.Text.Trim() + @"\data\patch-4.MPQ");

			// File location for download and save path of realmlist.wtf
			WebClient downloadRealmList = new WebClient();
			downloadRealmList.DownloadFile(tb_realmListLocation.Text.Trim(), tb_wowFolderLocation.Text.Trim() + @"\data\enUS\realmlist.wtf");

			// Alerts user downloads complete and changess download button to reflect
			MessageBox.Show(@"Downloads completed successfully.");
			downloadStatusLabel.Text = "";
            
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog save = new FolderBrowserDialog {RootFolder = Environment.SpecialFolder.Desktop};
            if (save.ShowDialog() != DialogResult.OK) return;
			tb_wowFolderLocation.Text = save.SelectedPath;
			string saveLocation = tb_wowFolderLocation.Text;
			File.WriteAllText(@"C:\Users\Public\Documents\Updater.txt", saveLocation);
            if (File.Exists(tb_wowFolderLocation.Text + @"\wow.exe")) return;
            NoWowExeFound();
        }
		
        private void launchButton_Click(object sender, EventArgs e)
        {
			// if unable to find wow.exe in specified path in tb_wowFolderLocation, display error to user.
			/*
			second condition will not be triggered unless first one is true
			also you can use only !File.Exists(tb_wowFolderLocation.Text + "\\wow.exe") because "" file doesn't exist also ;)
			*/
            if (tb_wowFolderLocation.Text == String.Empty && !File.Exists(tb_wowFolderLocation.Text + @"\wow.exe")) 
            {
                NoWowExeFound();
				return;
            }
            Process.Start(tb_wowFolderLocation.Text + @"\wow.exe");
        }
    }
}
