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
using System.Globalization;
using UE4_PoFileEditor.Forms;

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

            // Load Languges
            LoadLanguage();

            // Load Cells
            NU_SetKeyCell.Value = (int)settingsControl.GetValue("KeyCell");
            NU_SetSourceCell.Value = (int)settingsControl.GetValue("SourceCell");
            NU_SetSourceLocationCell.Value = (int)settingsControl.GetValue("SourceLocationCell");
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

                DirectoryInfo NewPath = new DirectoryInfo(objDialog.SelectedPath);
                settingsControl.SetValue("UE4LocalizationPath", NewPath);
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

                FileInfo NewPath = new FileInfo(FindPOFile.FileName);
                settingsControl.SetValue("UE4MainPoFile", NewPath);
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

                FileInfo NewPath = new FileInfo(FindCSVFile.FileName);
                settingsControl.SetValue("LocalizationCSV", NewPath);
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

        private void BN_TestLocalizationFile_Click(object sender, EventArgs e)
        {
            FileInfo LocalizationFileInfo = (FileInfo)settingsControl.GetValue("LocalizationCSV");
            if (LocalizationFileInfo.Exists)
            {
                int KeyCell = (int)settingsControl.GetValue("KeyCell");
                int SourceCell = (int)settingsControl.GetValue("SourceCell");
                int SourceLocationCell = (int)settingsControl.GetValue("SourceLocationCell");

                List<LanguageCell> Lang = new List<LanguageCell>();
                List<cl_ListKeyInt> languageListCell = (List<cl_ListKeyInt>)settingsControl.GetValue("LanguageListCellID");
                foreach (cl_ListKeyInt item in languageListCell)
                {
                    Lang.Add(new LanguageCell(item.Key, item.value));
                }


                LocalizationFile NewLocalizationFileInfo = new LocalizationFile(LocalizationFileInfo, Lang, KeyCell, SourceCell, SourceLocationCell);
                if (NewLocalizationFileInfo.LanguageValues.Count > 0)
                {
                    MessageBox.Show("Localization File is ok!");
                    return;
                }
            }
            MessageBox.Show("Localization File is broken!");
        }

        private void BN_SaveSettings_Click(object sender, EventArgs e)
        {
            List<cl_ListKeyBool> Languages = new List<cl_ListKeyBool>();
            for (int i = 0; i < CHBX_Language.Items.Count; i++)
            {
                cl_ListKeyBool NewListKeyBool = new cl_ListKeyBool(CHBX_Language.Items[i].ToString(), CHBX_Language.GetItemChecked(i));
                Languages.Add(NewListKeyBool);
            }
            settingsControl.SetValue("LanguageListID", Languages);

            List<cl_ListKeyInt> languageListCell = new List<cl_ListKeyInt>();
            foreach (ListViewItem item in LIVI_LanguageCell.Items)
            {
                int value = Int32.Parse(item.SubItems[1].Text);
                cl_ListKeyInt NewListKeyInt = new cl_ListKeyInt(item.Text, value);
                languageListCell.Add(NewListKeyInt);
            }
            settingsControl.SetValue("LanguageListCellID", languageListCell);
            settingsControl.WriteAllValues();

            MessageBox.Show("Settings Saved!");
        }

        private void BN_LoadLanguageFromProject_Click(object sender, EventArgs e)
        {
            DirectoryInfo ProjectPath = (DirectoryInfo)settingsControl.GetValue("UE4LocalizationPath");
            List<cl_ListKeyBool> Languages = new List<cl_ListKeyBool>();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                if (ci.Name != "")
                    Languages.Add(new cl_ListKeyBool(ci.Name, false));
            }

            if (ProjectPath.Exists)
            {
                string[] subdirectoryEntries = Directory.GetDirectories(ProjectPath.FullName);
                foreach (string subdirectory in subdirectoryEntries)
                {
                    DirectoryInfo CheckLanguage = new DirectoryInfo(subdirectory);
                    foreach (cl_ListKeyBool lang in Languages)
                    {
                        if (lang.Key == CheckLanguage.Name)
                            lang.Bool = true;
                    }
                }

                settingsControl.SetValue("LanguageListID", Languages);
                settingsControl.WriteAllValues();

                LoadLanguage();
            }
                
        }

        private void BN_CreatePoFiles_Click(object sender, EventArgs e)
        {
            FileInfo PoFileInfo = (FileInfo)settingsControl.GetValue("UE4MainPoFile");
            PoFile NewPoFile = new PoFile(PoFileInfo);

            FolderBrowserDialog objDialog = new FolderBrowserDialog();
            objDialog.Description = "Choose the Project localization path";
            objDialog.SelectedPath = PoFileInfo.Directory.FullName;
            DialogResult objResult = objDialog.ShowDialog(this);
            if (objResult == DialogResult.OK)
            {
                FileInfo LocalizationFileInfo = (FileInfo)settingsControl.GetValue("LocalizationCSV");
                if (LocalizationFileInfo.Exists)
                {
                    List<LanguageCell> Lang = new List<LanguageCell>();
                    List<cl_ListKeyInt> languageListCell = (List<cl_ListKeyInt>)settingsControl.GetValue("LanguageListCellID");
                    foreach (cl_ListKeyInt item in languageListCell)
                    {
                        Lang.Add(new LanguageCell(item.Key, item.value));
                    }

                    int KeyCell = (int)settingsControl.GetValue("KeyCell");
                    int SourceCell = (int)settingsControl.GetValue("SourceCell");
                    int SourceLocationCell = (int)settingsControl.GetValue("SourceLocationCell");
                    LocalizationFile NewLocalizationFileInfo = new LocalizationFile(LocalizationFileInfo, Lang, KeyCell, SourceCell, SourceLocationCell);
                    if (NewLocalizationFileInfo.LanguageValues.Count > 0)
                    {
                        foreach (LanguageCell Language in NewLocalizationFileInfo.Languages)
                        {
                            PoFile NewLanguagePoFile = Utilities.CreatePofileFromLocalizationCSV(NewLocalizationFileInfo, Language.Language);
                            PoFile CombineLanguagePoFile = Utilities.CombinePoFiles(NewPoFile, NewLanguagePoFile);

                            FileInfo ToSavePo = new FileInfo(Path.Combine(objDialog.SelectedPath, Language.Language, PoFileInfo.Name));
                            if (!ToSavePo.Directory.Exists)
                                Directory.CreateDirectory(ToSavePo.Directory.FullName);

                            CombineLanguagePoFile.SaveFile(ToSavePo);
                        }
                    }

                    MessageBox.Show("Files are created!");
                }
            }
        }

        private void LIVI_LanguageCell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LIVI_LanguageCell.SelectedItems.Count > 0 && LIVI_LanguageCell.SelectedItems[0].SubItems.Count > 0)
                NU_SetCell.Value = Int32.Parse(LIVI_LanguageCell.SelectedItems[0].SubItems[1].Text);
        }

        private void NU_SetCell_ValueChanged(object sender, EventArgs e)
        {
            LIVI_LanguageCell.SelectedItems[0].SubItems[1].Text = NU_SetCell.Value.ToString();
        }

        private void LoadLanguage()
        {
            // Clear 
            CHBX_Language.Items.Clear();
            LIVI_LanguageCell.Items.Clear();

            List<cl_ListKeyInt> languageListCell = (List<cl_ListKeyInt>)settingsControl.GetValue("LanguageListCellID");
            // Set Language
            foreach (cl_ListKeyBool ci in (List<cl_ListKeyBool>)settingsControl.GetValue("LanguageListID"))
            {
                if (ci.Key != "")
                {
                    CHBX_Language.Items.Add(ci.Key, ci.Bool);

                    if (ci.Bool)
                    {
                        ListViewItem NewItem = new ListViewItem(ci.Key);
                        
                        bool found = false;
                        foreach (cl_ListKeyInt item in languageListCell)
                        {
                            if(item.Key == ci.Key)
                            {
                                NewItem.SubItems.Add(item.value.ToString());
                                LIVI_LanguageCell.Items.Add(NewItem);
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            NewItem.SubItems.Add((LIVI_LanguageCell.Items.Count + 5).ToString());
                            LIVI_LanguageCell.Items.Add(NewItem);
                        }
                    }
                }
            }


        }


        private void CHBX_Language_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (CHBX_Language.SelectedIndex != -1)
            {
                // Remove Item
                if (CHBX_Language.GetItemCheckState(CHBX_Language.SelectedIndex) == CheckState.Checked)
                {
                    foreach (ListViewItem item in LIVI_LanguageCell.Items)
                    {
                        string Check_01 = CHBX_Language.Items[CHBX_Language.SelectedIndex].ToString();
                        string Check_02 = item.Text;
                        if (Check_01 == Check_02)
                        {
                            LIVI_LanguageCell.Items.Remove(item);
                            break;
                        }
                    }
                }

                // Add Item
                if (CHBX_Language.GetItemCheckState(CHBX_Language.SelectedIndex) == CheckState.Unchecked)
                {
                    bool found = false;
                    foreach (ListViewItem item in LIVI_LanguageCell.Items)
                    {
                        string Check_01 = CHBX_Language.Items[CHBX_Language.SelectedIndex].ToString();
                        string Check_02 = item.Text;
                        if (Check_01 == Check_02)
                            found = true;
                    }

                    if (!found)
                    {
                        ListViewItem NewItem = new ListViewItem(CHBX_Language.Items[CHBX_Language.SelectedIndex].ToString());
                        NewItem.SubItems.Add(CHBX_Language.Items.Count.ToString());
                        LIVI_LanguageCell.Items.Add(NewItem);
                    }
                }
            }
        }

        private void BN_OpenViewer_Click(object sender, EventArgs e)
        {
            Viewer NewViewer = new Viewer();
            NewViewer.Show();
        }

        private void BN_CreateLocalizationCSV_Click(object sender, EventArgs e)
        {
            DirectoryInfo UE4LocalizationPath = (DirectoryInfo)settingsControl.GetValue("UE4LocalizationPath");
            string PoFileName = "VoiceOver.po";
            int KeyCell = (int)settingsControl.GetValue("KeyCell");
            int SourceCell = (int)settingsControl.GetValue("SourceCell");
            int SourceLocationCell = (int)settingsControl.GetValue("SourceLocationCell");

            if (UE4LocalizationPath.Exists)
            {
                List<LanguageCell> Languages = new List<LanguageCell>();
                List<cl_ListKeyInt> languageListCell = (List<cl_ListKeyInt>)settingsControl.GetValue("LanguageListCellID");
                foreach (cl_ListKeyInt item in languageListCell)
                {
                    Languages.Add(new LanguageCell(item.Key, item.value));
                }

                FileInfo PoFIlePath = (FileInfo)settingsControl.GetValue("UE4MainPoFile");

                SaveFileDialog SaveCSV = new SaveFileDialog();
                SaveCSV.Filter = PoFIlePath.Name.Replace(PoFIlePath.Extension, "") + ".csv (*.csv )|*.csv";
                SaveCSV.FileName = PoFIlePath.Name.Replace(PoFIlePath.Extension, "") + ".csv";
                SaveCSV.InitialDirectory = PoFIlePath.FullName;

                if (SaveCSV.ShowDialog() == DialogResult.OK)
                {
                    LocalizationFile NewLocalizationFileInfo = new LocalizationFile();
                    NewLocalizationFileInfo.KeyCell = KeyCell;
                    NewLocalizationFileInfo.SourceLocationCell = SourceLocationCell;
                    NewLocalizationFileInfo.SourceCell = SourceCell;
                    NewLocalizationFileInfo.Languages = Languages;


                    PoFile NewPoFile = new PoFile(PoFIlePath);
                    NewLocalizationFileInfo.AddPoFileSource(NewPoFile);

                    foreach (LanguageCell Language in Languages)
                    {
                        FileInfo PoFIleLanguagePath = new FileInfo(Path.Combine(UE4LocalizationPath.FullName, Language.Language, PoFileName));

                        if (PoFIleLanguagePath.Exists)
                        {
                            PoFile NewPoFileLanguage = new PoFile(PoFIleLanguagePath);
                            NewLocalizationFileInfo.AddPoFile(NewPoFileLanguage, Language);
                        }
                    }

                    FileInfo ToSaveFile = new FileInfo(SaveCSV.FileName);
                    NewLocalizationFileInfo.SaveFile(ToSaveFile);

                    MessageBox.Show("File is saved!");
                }

            }
        }
    }
}
