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
using SettingsController;
using UE4_PoFileEditor.Class;

namespace UE4_PoFileEditor
{
    public partial class FB_Main : Form
    {
        // Setup
        SettingsControl settingsControl;

        // Initialize Form
        public FB_Main()
        {
            InitializeComponent();

            // Get Settingsfile
            string AppPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings.ini");
            settingsControl = new SettingsControl(AppPath);

            // Get All Paths
            DirectoryInfo UE4LocalizationPath = (DirectoryInfo)settingsControl.GetValue("UE4LocalizationPath");
            FileInfo UE4MainPoFile = (FileInfo)settingsControl.GetValue("UE4MainPoFile");
            FileInfo LocalizationCSV = (FileInfo)settingsControl.GetValue("LocalizationCSV");

            // Set Paths to Form
            TXBX_UE4LocalizationPath.Text = UE4LocalizationPath.FullName;
            TXBX_MainPoFile.Text = UE4MainPoFile.FullName;
            TXBX_LocalizationCSV.Text = LocalizationCSV.FullName;
        }


        // Form Events
        private void BN_FindLocalizationFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Choose the Project localization path";
            objDialog.SelectedPath = @"C:\";
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                TXBX_UE4LocalizationPath.Text = objDialog.SelectedPath;

                settingsControl.SetValue("UE4LocalizationPath", objDialog.SelectedPath);
                settingsControl.WriteAllValues();
            }
        }

        private void BN_FindMainPoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog FindPOFile = new OpenFileDialog();
            FindPOFile.Filter = "*.po (*.po )|*.po";
            FindPOFile.InitialDirectory = TXBX_MainPoFile.Text;
            if (FindPOFile.ShowDialog() == DialogResult.OK)
            {
                TXBX_MainPoFile.Text = FindPOFile.FileName;

                settingsControl.SetValue("UE4MainPoFile", FindPOFile.FileName);
                settingsControl.WriteAllValues();
            }
        }

        private void BN_FindLocalizationCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog FindCSVFile = new OpenFileDialog();
            FindCSVFile.Filter = "*.csv (*.csv )|*.csv";
            FindCSVFile.InitialDirectory = TXBX_LocalizationCSV.Text;
            if (FindCSVFile.ShowDialog() == DialogResult.OK)
            {
                TXBX_LocalizationCSV.Text = FindCSVFile.FileName;

                settingsControl.SetValue("LocalizationCSV", FindCSVFile.FileName);
                settingsControl.WriteAllValues();
            }
        }

        private void BN_ConvertPoToCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog FindPoFile = new OpenFileDialog();
            FindPoFile.Filter = "*.po (*.po )|*.po";
            FindPoFile.InitialDirectory = TXBX_UE4LocalizationPath.Text;
            if (FindPoFile.ShowDialog() == DialogResult.OK)
            {
                FileInfo PoFileInfo = new FileInfo(FindPoFile.FileName);

                SaveFileDialog SaveCSV = new SaveFileDialog();
                SaveCSV.Filter = PoFileInfo.Name.Replace(PoFileInfo.Extension, "") + ".csv (*.csv )|*.csv";
                SaveCSV.FileName = PoFileInfo.Name.Replace(PoFileInfo.Extension, "") + ".csv";
                SaveCSV.InitialDirectory = TXBX_MainPoFile.Text;
                if (SaveCSV.ShowDialog() == DialogResult.OK)
                {
                    if (PoFileInfo.Exists)
                    {
                        PoFile NewPoFile = new PoFile(PoFileInfo);
                        Utilities.ConvertAndSavePoToCsv(NewPoFile, new FileInfo(SaveCSV.FileName));
                    }
                }
            }
        }

        private void BN_ConvertCsvToPo_Click(object sender, EventArgs e)
        {
            OpenFileDialog CsvFileInfo = new OpenFileDialog();
            CsvFileInfo.Filter = ".csv (*.csv )|*.csv";
            CsvFileInfo.InitialDirectory = TXBX_UE4LocalizationPath.Text;
            if (CsvFileInfo.ShowDialog() == DialogResult.OK)
            {
                FileInfo FindPoFile = new FileInfo(CsvFileInfo.FileName);
                if (FindPoFile.Exists)
                {
                    SaveFileDialog SavePo = new SaveFileDialog();
                    SavePo.Filter = FindPoFile.Name.Replace(FindPoFile.Extension, "") + ".po (*.po )|*.po";
                    SavePo.FileName = FindPoFile.Name.Replace(FindPoFile.Extension, "") + ".po";
                    SavePo.InitialDirectory = TXBX_MainPoFile.Text;
                    if (SavePo.ShowDialog() == DialogResult.OK)
                    {

                        PoFile NewPoFile = Utilities.ConvertCsvToPoFile(FindPoFile);

                        FileInfo SavePoInfo = new FileInfo(SavePo.FileName);
                        NewPoFile.SaveFile(SavePoInfo);
                    }
                }
            }
        }


    }
}
