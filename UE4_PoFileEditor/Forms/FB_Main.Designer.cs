namespace UE4_PoFileEditor
{
    partial class FB_Main
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
            this.TXBX_UE4LocalizationPath = new System.Windows.Forms.TextBox();
            this.GB_UE4_General = new System.Windows.Forms.GroupBox();
            this.GB_LocalizationCSV = new System.Windows.Forms.GroupBox();
            this.LB_SetCell = new System.Windows.Forms.Label();
            this.NU_SetCell = new System.Windows.Forms.NumericUpDown();
            this.LIVI_LanguageCell = new System.Windows.Forms.ListView();
            this.Co_Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Co_LanguageCell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BN_SaveSettings = new System.Windows.Forms.Button();
            this.TXBX_LocalizationCSV = new System.Windows.Forms.TextBox();
            this.BN_FindLocalizationCsv = new System.Windows.Forms.Button();
            this.LB_Language = new System.Windows.Forms.Label();
            this.CHBX_Language = new System.Windows.Forms.CheckedListBox();
            this.LB_MainPoFile = new System.Windows.Forms.Label();
            this.BN_FindMainPoFile = new System.Windows.Forms.Button();
            this.TXBX_MainPoFile = new System.Windows.Forms.TextBox();
            this.LB_LocalizationFolder = new System.Windows.Forms.Label();
            this.BN_FindLocalizationFolder = new System.Windows.Forms.Button();
            this.BN_TestLocalizationFile = new System.Windows.Forms.Button();
            this.GB_Tools = new System.Windows.Forms.GroupBox();
            this.BN_ConvertCsvToPo = new System.Windows.Forms.Button();
            this.BN_ConvertPoToCsv = new System.Windows.Forms.Button();
            this.BN_LoadLanguageFromProject = new System.Windows.Forms.Button();
            this.BN_CreatePoFiles = new System.Windows.Forms.Button();
            this.GB_UE4_General.SuspendLayout();
            this.GB_LocalizationCSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetCell)).BeginInit();
            this.GB_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXBX_UE4LocalizationPath
            // 
            this.TXBX_UE4LocalizationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXBX_UE4LocalizationPath.Enabled = false;
            this.TXBX_UE4LocalizationPath.Location = new System.Drawing.Point(9, 35);
            this.TXBX_UE4LocalizationPath.Name = "TXBX_UE4LocalizationPath";
            this.TXBX_UE4LocalizationPath.ReadOnly = true;
            this.TXBX_UE4LocalizationPath.Size = new System.Drawing.Size(359, 20);
            this.TXBX_UE4LocalizationPath.TabIndex = 1;
            // 
            // GB_UE4_General
            // 
            this.GB_UE4_General.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_UE4_General.Controls.Add(this.GB_LocalizationCSV);
            this.GB_UE4_General.Controls.Add(this.LB_MainPoFile);
            this.GB_UE4_General.Controls.Add(this.BN_FindMainPoFile);
            this.GB_UE4_General.Controls.Add(this.TXBX_MainPoFile);
            this.GB_UE4_General.Controls.Add(this.LB_LocalizationFolder);
            this.GB_UE4_General.Controls.Add(this.BN_FindLocalizationFolder);
            this.GB_UE4_General.Controls.Add(this.TXBX_UE4LocalizationPath);
            this.GB_UE4_General.Location = new System.Drawing.Point(12, 12);
            this.GB_UE4_General.Name = "GB_UE4_General";
            this.GB_UE4_General.Size = new System.Drawing.Size(461, 483);
            this.GB_UE4_General.TabIndex = 2;
            this.GB_UE4_General.TabStop = false;
            this.GB_UE4_General.Text = "Unreal 4 General";
            // 
            // GB_LocalizationCSV
            // 
            this.GB_LocalizationCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_LocalizationCSV.Controls.Add(this.LB_SetCell);
            this.GB_LocalizationCSV.Controls.Add(this.NU_SetCell);
            this.GB_LocalizationCSV.Controls.Add(this.LIVI_LanguageCell);
            this.GB_LocalizationCSV.Controls.Add(this.BN_SaveSettings);
            this.GB_LocalizationCSV.Controls.Add(this.TXBX_LocalizationCSV);
            this.GB_LocalizationCSV.Controls.Add(this.BN_FindLocalizationCsv);
            this.GB_LocalizationCSV.Controls.Add(this.LB_Language);
            this.GB_LocalizationCSV.Controls.Add(this.CHBX_Language);
            this.GB_LocalizationCSV.Location = new System.Drawing.Point(9, 99);
            this.GB_LocalizationCSV.Name = "GB_LocalizationCSV";
            this.GB_LocalizationCSV.Size = new System.Drawing.Size(446, 375);
            this.GB_LocalizationCSV.TabIndex = 14;
            this.GB_LocalizationCSV.TabStop = false;
            this.GB_LocalizationCSV.Text = "LocalizationCSV";
            // 
            // LB_SetCell
            // 
            this.LB_SetCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_SetCell.AutoSize = true;
            this.LB_SetCell.Location = new System.Drawing.Point(158, 327);
            this.LB_SetCell.Name = "LB_SetCell";
            this.LB_SetCell.Size = new System.Drawing.Size(97, 13);
            this.LB_SetCell.TabIndex = 15;
            this.LB_SetCell.Text = "Set Language Cell:";
            // 
            // NU_SetCell
            // 
            this.NU_SetCell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NU_SetCell.Location = new System.Drawing.Point(161, 343);
            this.NU_SetCell.Name = "NU_SetCell";
            this.NU_SetCell.Size = new System.Drawing.Size(122, 20);
            this.NU_SetCell.TabIndex = 18;
            this.NU_SetCell.ValueChanged += new System.EventHandler(this.NU_SetCell_ValueChanged);
            // 
            // LIVI_LanguageCell
            // 
            this.LIVI_LanguageCell.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LIVI_LanguageCell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LIVI_LanguageCell.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Co_Language,
            this.Co_LanguageCell});
            this.LIVI_LanguageCell.FullRowSelect = true;
            this.LIVI_LanguageCell.GridLines = true;
            this.LIVI_LanguageCell.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LIVI_LanguageCell.Location = new System.Drawing.Point(161, 61);
            this.LIVI_LanguageCell.Name = "LIVI_LanguageCell";
            this.LIVI_LanguageCell.Size = new System.Drawing.Size(123, 258);
            this.LIVI_LanguageCell.TabIndex = 16;
            this.LIVI_LanguageCell.UseCompatibleStateImageBehavior = false;
            this.LIVI_LanguageCell.View = System.Windows.Forms.View.Details;
            this.LIVI_LanguageCell.SelectedIndexChanged += new System.EventHandler(this.LIVI_LanguageCell_SelectedIndexChanged);
            // 
            // Co_Language
            // 
            this.Co_Language.Text = "Language";
            // 
            // Co_LanguageCell
            // 
            this.Co_LanguageCell.Text = "Cell";
            this.Co_LanguageCell.Width = 40;
            // 
            // BN_SaveSettings
            // 
            this.BN_SaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_SaveSettings.Location = new System.Drawing.Point(290, 61);
            this.BN_SaveSettings.Name = "BN_SaveSettings";
            this.BN_SaveSettings.Size = new System.Drawing.Size(150, 56);
            this.BN_SaveSettings.TabIndex = 13;
            this.BN_SaveSettings.Text = "Save Settings";
            this.BN_SaveSettings.UseVisualStyleBackColor = true;
            this.BN_SaveSettings.Click += new System.EventHandler(this.BN_SaveSettings_Click);
            // 
            // TXBX_LocalizationCSV
            // 
            this.TXBX_LocalizationCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXBX_LocalizationCSV.Enabled = false;
            this.TXBX_LocalizationCSV.Location = new System.Drawing.Point(13, 19);
            this.TXBX_LocalizationCSV.Name = "TXBX_LocalizationCSV";
            this.TXBX_LocalizationCSV.ReadOnly = true;
            this.TXBX_LocalizationCSV.Size = new System.Drawing.Size(346, 20);
            this.TXBX_LocalizationCSV.TabIndex = 7;
            // 
            // BN_FindLocalizationCsv
            // 
            this.BN_FindLocalizationCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_FindLocalizationCsv.Location = new System.Drawing.Point(365, 19);
            this.BN_FindLocalizationCsv.Name = "BN_FindLocalizationCsv";
            this.BN_FindLocalizationCsv.Size = new System.Drawing.Size(75, 23);
            this.BN_FindLocalizationCsv.TabIndex = 8;
            this.BN_FindLocalizationCsv.Text = "Find";
            this.BN_FindLocalizationCsv.UseVisualStyleBackColor = true;
            this.BN_FindLocalizationCsv.Click += new System.EventHandler(this.BN_FindLocalizationCsv_Click);
            // 
            // LB_Language
            // 
            this.LB_Language.AutoSize = true;
            this.LB_Language.Location = new System.Drawing.Point(10, 45);
            this.LB_Language.Name = "LB_Language";
            this.LB_Language.Size = new System.Drawing.Size(55, 13);
            this.LB_Language.TabIndex = 12;
            this.LB_Language.Text = "Language";
            // 
            // CHBX_Language
            // 
            this.CHBX_Language.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CHBX_Language.FormattingEnabled = true;
            this.CHBX_Language.Location = new System.Drawing.Point(13, 61);
            this.CHBX_Language.Name = "CHBX_Language";
            this.CHBX_Language.Size = new System.Drawing.Size(142, 289);
            this.CHBX_Language.TabIndex = 11;
            this.CHBX_Language.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CHBX_Language_ItemCheck);
            // 
            // LB_MainPoFile
            // 
            this.LB_MainPoFile.AutoSize = true;
            this.LB_MainPoFile.Location = new System.Drawing.Point(6, 58);
            this.LB_MainPoFile.Name = "LB_MainPoFile";
            this.LB_MainPoFile.Size = new System.Drawing.Size(67, 13);
            this.LB_MainPoFile.TabIndex = 6;
            this.LB_MainPoFile.Text = "Main PO-File";
            // 
            // BN_FindMainPoFile
            // 
            this.BN_FindMainPoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_FindMainPoFile.Location = new System.Drawing.Point(374, 69);
            this.BN_FindMainPoFile.Name = "BN_FindMainPoFile";
            this.BN_FindMainPoFile.Size = new System.Drawing.Size(75, 23);
            this.BN_FindMainPoFile.TabIndex = 5;
            this.BN_FindMainPoFile.Text = "Find";
            this.BN_FindMainPoFile.UseVisualStyleBackColor = true;
            this.BN_FindMainPoFile.Click += new System.EventHandler(this.BN_FindMainPoFile_Click);
            // 
            // TXBX_MainPoFile
            // 
            this.TXBX_MainPoFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXBX_MainPoFile.Enabled = false;
            this.TXBX_MainPoFile.Location = new System.Drawing.Point(9, 72);
            this.TXBX_MainPoFile.Name = "TXBX_MainPoFile";
            this.TXBX_MainPoFile.ReadOnly = true;
            this.TXBX_MainPoFile.Size = new System.Drawing.Size(359, 20);
            this.TXBX_MainPoFile.TabIndex = 4;
            // 
            // LB_LocalizationFolder
            // 
            this.LB_LocalizationFolder.AutoSize = true;
            this.LB_LocalizationFolder.Location = new System.Drawing.Point(6, 21);
            this.LB_LocalizationFolder.Name = "LB_LocalizationFolder";
            this.LB_LocalizationFolder.Size = new System.Drawing.Size(95, 13);
            this.LB_LocalizationFolder.TabIndex = 3;
            this.LB_LocalizationFolder.Text = "Localization Folder";
            // 
            // BN_FindLocalizationFolder
            // 
            this.BN_FindLocalizationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_FindLocalizationFolder.Location = new System.Drawing.Point(374, 32);
            this.BN_FindLocalizationFolder.Name = "BN_FindLocalizationFolder";
            this.BN_FindLocalizationFolder.Size = new System.Drawing.Size(75, 23);
            this.BN_FindLocalizationFolder.TabIndex = 2;
            this.BN_FindLocalizationFolder.Text = "Find";
            this.BN_FindLocalizationFolder.UseVisualStyleBackColor = true;
            this.BN_FindLocalizationFolder.Click += new System.EventHandler(this.BN_FindLocalizationFolder_Click);
            // 
            // BN_TestLocalizationFile
            // 
            this.BN_TestLocalizationFile.Location = new System.Drawing.Point(9, 222);
            this.BN_TestLocalizationFile.Name = "BN_TestLocalizationFile";
            this.BN_TestLocalizationFile.Size = new System.Drawing.Size(114, 56);
            this.BN_TestLocalizationFile.TabIndex = 10;
            this.BN_TestLocalizationFile.Text = "Test LocalizationCSV";
            this.BN_TestLocalizationFile.UseVisualStyleBackColor = true;
            this.BN_TestLocalizationFile.Click += new System.EventHandler(this.BN_TestLocalizationFile_Click);
            // 
            // GB_Tools
            // 
            this.GB_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Tools.Controls.Add(this.BN_ConvertCsvToPo);
            this.GB_Tools.Controls.Add(this.BN_ConvertPoToCsv);
            this.GB_Tools.Controls.Add(this.BN_LoadLanguageFromProject);
            this.GB_Tools.Controls.Add(this.BN_CreatePoFiles);
            this.GB_Tools.Controls.Add(this.BN_TestLocalizationFile);
            this.GB_Tools.Location = new System.Drawing.Point(479, 12);
            this.GB_Tools.Name = "GB_Tools";
            this.GB_Tools.Size = new System.Drawing.Size(129, 349);
            this.GB_Tools.TabIndex = 3;
            this.GB_Tools.TabStop = false;
            this.GB_Tools.Text = "Tools";
            // 
            // BN_ConvertCsvToPo
            // 
            this.BN_ConvertCsvToPo.Location = new System.Drawing.Point(9, 57);
            this.BN_ConvertCsvToPo.Name = "BN_ConvertCsvToPo";
            this.BN_ConvertCsvToPo.Size = new System.Drawing.Size(114, 30);
            this.BN_ConvertCsvToPo.TabIndex = 1;
            this.BN_ConvertCsvToPo.Text = "Csv to Po";
            this.BN_ConvertCsvToPo.UseVisualStyleBackColor = true;
            this.BN_ConvertCsvToPo.Click += new System.EventHandler(this.BN_ConvertCsvToPo_Click);
            // 
            // BN_ConvertPoToCsv
            // 
            this.BN_ConvertPoToCsv.Location = new System.Drawing.Point(9, 19);
            this.BN_ConvertPoToCsv.Name = "BN_ConvertPoToCsv";
            this.BN_ConvertPoToCsv.Size = new System.Drawing.Size(114, 30);
            this.BN_ConvertPoToCsv.TabIndex = 0;
            this.BN_ConvertPoToCsv.Text = "Po to Csv";
            this.BN_ConvertPoToCsv.UseVisualStyleBackColor = true;
            this.BN_ConvertPoToCsv.Click += new System.EventHandler(this.BN_ConvertPoToCsv_Click);
            // 
            // BN_LoadLanguageFromProject
            // 
            this.BN_LoadLanguageFromProject.Location = new System.Drawing.Point(9, 160);
            this.BN_LoadLanguageFromProject.Name = "BN_LoadLanguageFromProject";
            this.BN_LoadLanguageFromProject.Size = new System.Drawing.Size(114, 56);
            this.BN_LoadLanguageFromProject.TabIndex = 14;
            this.BN_LoadLanguageFromProject.Text = "Load Language From Project";
            this.BN_LoadLanguageFromProject.UseVisualStyleBackColor = true;
            this.BN_LoadLanguageFromProject.Click += new System.EventHandler(this.BN_LoadLanguageFromProject_Click);
            // 
            // BN_CreatePoFiles
            // 
            this.BN_CreatePoFiles.Location = new System.Drawing.Point(9, 284);
            this.BN_CreatePoFiles.Name = "BN_CreatePoFiles";
            this.BN_CreatePoFiles.Size = new System.Drawing.Size(114, 56);
            this.BN_CreatePoFiles.TabIndex = 15;
            this.BN_CreatePoFiles.Text = "Create Po Files from LocalizationCSV";
            this.BN_CreatePoFiles.UseVisualStyleBackColor = true;
            this.BN_CreatePoFiles.Click += new System.EventHandler(this.BN_CreatePoFiles_Click);
            // 
            // FB_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 500);
            this.Controls.Add(this.GB_Tools);
            this.Controls.Add(this.GB_UE4_General);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FB_Main";
            this.Text = "Po - File Editor";
            this.GB_UE4_General.ResumeLayout(false);
            this.GB_UE4_General.PerformLayout();
            this.GB_LocalizationCSV.ResumeLayout(false);
            this.GB_LocalizationCSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetCell)).EndInit();
            this.GB_Tools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXBX_UE4LocalizationPath;
        private System.Windows.Forms.GroupBox GB_UE4_General;
        private System.Windows.Forms.Button BN_FindLocalizationFolder;
        private System.Windows.Forms.Label LB_MainPoFile;
        private System.Windows.Forms.Button BN_FindMainPoFile;
        private System.Windows.Forms.TextBox TXBX_MainPoFile;
        private System.Windows.Forms.Label LB_LocalizationFolder;
        private System.Windows.Forms.Button BN_FindLocalizationCsv;
        private System.Windows.Forms.TextBox TXBX_LocalizationCSV;
        private System.Windows.Forms.GroupBox GB_Tools;
        private System.Windows.Forms.Button BN_ConvertPoToCsv;
        private System.Windows.Forms.Button BN_ConvertCsvToPo;
        private System.Windows.Forms.Button BN_TestLocalizationFile;
        private System.Windows.Forms.Label LB_Language;
        private System.Windows.Forms.CheckedListBox CHBX_Language;
        private System.Windows.Forms.GroupBox GB_LocalizationCSV;
        private System.Windows.Forms.Button BN_SaveSettings;
        private System.Windows.Forms.Button BN_LoadLanguageFromProject;
        private System.Windows.Forms.Button BN_CreatePoFiles;
        private System.Windows.Forms.ListView LIVI_LanguageCell;
        private System.Windows.Forms.ColumnHeader Co_Language;
        private System.Windows.Forms.ColumnHeader Co_LanguageCell;
        private System.Windows.Forms.Label LB_SetCell;
        private System.Windows.Forms.NumericUpDown NU_SetCell;
    }
}

