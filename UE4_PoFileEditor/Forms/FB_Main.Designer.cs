﻿namespace UE4_PoFileEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FB_Main));
            this.TXBX_UE4LocalizationPath = new System.Windows.Forms.TextBox();
            this.GB_UE4_General = new System.Windows.Forms.GroupBox();
            this.GB_LocalizationCSV = new System.Windows.Forms.GroupBox();
            this.BN_ConvertCsvToPo = new System.Windows.Forms.Button();
            this.BN_CompareLocalizationCSV = new System.Windows.Forms.Button();
            this.BN_ConvertPoToCsv = new System.Windows.Forms.Button();
            this.BN_Viewer = new System.Windows.Forms.Button();
            this.BN_LoadLanguageFromProject = new System.Windows.Forms.Button();
            this.BN_TestLocalizationFile = new System.Windows.Forms.Button();
            this.BN_CreateLocalizationCSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NU_SetKeyCell = new System.Windows.Forms.NumericUpDown();
            this.NU_SetSourceLocationCell = new System.Windows.Forms.NumericUpDown();
            this.NU_SetSourceCell = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GB_Lan = new System.Windows.Forms.GroupBox();
            this.LIVI_LanguageCell = new System.Windows.Forms.ListView();
            this.Co_Language = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Co_LanguageCell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NU_SetCell = new System.Windows.Forms.NumericUpDown();
            this.LB_SetCell = new System.Windows.Forms.Label();
            this.BN_SaveSettings = new System.Windows.Forms.Button();
            this.BN_CreatePoFiles = new System.Windows.Forms.Button();
            this.TXBX_LocalizationCSV = new System.Windows.Forms.TextBox();
            this.BN_FindLocalizationCsv = new System.Windows.Forms.Button();
            this.LB_Language = new System.Windows.Forms.Label();
            this.CHBX_Language = new System.Windows.Forms.CheckedListBox();
            this.LB_MainPoFile = new System.Windows.Forms.Label();
            this.BN_FindMainPoFile = new System.Windows.Forms.Button();
            this.TXBX_MainPoFile = new System.Windows.Forms.TextBox();
            this.LB_LocalizationFolder = new System.Windows.Forms.Label();
            this.BN_FindLocalizationFolder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LIBX_Presets = new System.Windows.Forms.ListBox();
            this.BN_AddPreset = new System.Windows.Forms.Button();
            this.BN_RemovePreset = new System.Windows.Forms.Button();
            this.TXBX_PresetName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BN_RenamePreset = new System.Windows.Forms.Button();
            this.GB_UE4_General.SuspendLayout();
            this.GB_LocalizationCSV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetKeyCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetSourceLocationCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetSourceCell)).BeginInit();
            this.GB_Lan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetCell)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.TXBX_UE4LocalizationPath.Size = new System.Drawing.Size(657, 20);
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
            this.GB_UE4_General.Location = new System.Drawing.Point(163, 12);
            this.GB_UE4_General.Name = "GB_UE4_General";
            this.GB_UE4_General.Size = new System.Drawing.Size(759, 595);
            this.GB_UE4_General.TabIndex = 2;
            this.GB_UE4_General.TabStop = false;
            this.GB_UE4_General.Text = "Unreal 4 General";
            // 
            // GB_LocalizationCSV
            // 
            this.GB_LocalizationCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_LocalizationCSV.Controls.Add(this.BN_ConvertCsvToPo);
            this.GB_LocalizationCSV.Controls.Add(this.BN_CompareLocalizationCSV);
            this.GB_LocalizationCSV.Controls.Add(this.BN_ConvertPoToCsv);
            this.GB_LocalizationCSV.Controls.Add(this.BN_Viewer);
            this.GB_LocalizationCSV.Controls.Add(this.BN_LoadLanguageFromProject);
            this.GB_LocalizationCSV.Controls.Add(this.BN_TestLocalizationFile);
            this.GB_LocalizationCSV.Controls.Add(this.BN_CreateLocalizationCSV);
            this.GB_LocalizationCSV.Controls.Add(this.groupBox1);
            this.GB_LocalizationCSV.Controls.Add(this.GB_Lan);
            this.GB_LocalizationCSV.Controls.Add(this.BN_SaveSettings);
            this.GB_LocalizationCSV.Controls.Add(this.BN_CreatePoFiles);
            this.GB_LocalizationCSV.Controls.Add(this.TXBX_LocalizationCSV);
            this.GB_LocalizationCSV.Controls.Add(this.BN_FindLocalizationCsv);
            this.GB_LocalizationCSV.Controls.Add(this.LB_Language);
            this.GB_LocalizationCSV.Controls.Add(this.CHBX_Language);
            this.GB_LocalizationCSV.Location = new System.Drawing.Point(9, 99);
            this.GB_LocalizationCSV.Name = "GB_LocalizationCSV";
            this.GB_LocalizationCSV.Size = new System.Drawing.Size(744, 489);
            this.GB_LocalizationCSV.TabIndex = 14;
            this.GB_LocalizationCSV.TabStop = false;
            this.GB_LocalizationCSV.Text = "LocalizationCSV";
            // 
            // BN_ConvertCsvToPo
            // 
            this.BN_ConvertCsvToPo.Location = new System.Drawing.Point(441, 368);
            this.BN_ConvertCsvToPo.Name = "BN_ConvertCsvToPo";
            this.BN_ConvertCsvToPo.Size = new System.Drawing.Size(114, 57);
            this.BN_ConvertCsvToPo.TabIndex = 1;
            this.BN_ConvertCsvToPo.Text = "Csv to Po";
            this.BN_ConvertCsvToPo.UseVisualStyleBackColor = true;
            this.BN_ConvertCsvToPo.Click += new System.EventHandler(this.BN_ConvertCsvToPo_Click);
            // 
            // BN_CompareLocalizationCSV
            // 
            this.BN_CompareLocalizationCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_CompareLocalizationCSV.Location = new System.Drawing.Point(569, 110);
            this.BN_CompareLocalizationCSV.Name = "BN_CompareLocalizationCSV";
            this.BN_CompareLocalizationCSV.Size = new System.Drawing.Size(170, 56);
            this.BN_CompareLocalizationCSV.TabIndex = 17;
            this.BN_CompareLocalizationCSV.Text = "Compare LocalizationCSV";
            this.BN_CompareLocalizationCSV.UseVisualStyleBackColor = true;
            this.BN_CompareLocalizationCSV.Click += new System.EventHandler(this.BN_CompareLocalizationCSV_Click);
            // 
            // BN_ConvertPoToCsv
            // 
            this.BN_ConvertPoToCsv.Location = new System.Drawing.Point(441, 306);
            this.BN_ConvertPoToCsv.Name = "BN_ConvertPoToCsv";
            this.BN_ConvertPoToCsv.Size = new System.Drawing.Size(114, 56);
            this.BN_ConvertPoToCsv.TabIndex = 0;
            this.BN_ConvertPoToCsv.Text = "Po to Csv";
            this.BN_ConvertPoToCsv.UseVisualStyleBackColor = true;
            this.BN_ConvertPoToCsv.Click += new System.EventHandler(this.BN_ConvertPoToCsv_Click);
            // 
            // BN_Viewer
            // 
            this.BN_Viewer.Location = new System.Drawing.Point(166, 368);
            this.BN_Viewer.Name = "BN_Viewer";
            this.BN_Viewer.Size = new System.Drawing.Size(144, 57);
            this.BN_Viewer.TabIndex = 17;
            this.BN_Viewer.Text = "Viewer";
            this.BN_Viewer.UseVisualStyleBackColor = true;
            this.BN_Viewer.Click += new System.EventHandler(this.BN_Viewer_Click);
            // 
            // BN_LoadLanguageFromProject
            // 
            this.BN_LoadLanguageFromProject.Location = new System.Drawing.Point(316, 306);
            this.BN_LoadLanguageFromProject.Name = "BN_LoadLanguageFromProject";
            this.BN_LoadLanguageFromProject.Size = new System.Drawing.Size(114, 56);
            this.BN_LoadLanguageFromProject.TabIndex = 14;
            this.BN_LoadLanguageFromProject.Text = "Load Language From Project";
            this.BN_LoadLanguageFromProject.UseVisualStyleBackColor = true;
            this.BN_LoadLanguageFromProject.Click += new System.EventHandler(this.BN_LoadLanguageFromProject_Click);
            // 
            // BN_TestLocalizationFile
            // 
            this.BN_TestLocalizationFile.Location = new System.Drawing.Point(316, 369);
            this.BN_TestLocalizationFile.Name = "BN_TestLocalizationFile";
            this.BN_TestLocalizationFile.Size = new System.Drawing.Size(114, 56);
            this.BN_TestLocalizationFile.TabIndex = 10;
            this.BN_TestLocalizationFile.Text = "Test LocalizationCSV";
            this.BN_TestLocalizationFile.UseVisualStyleBackColor = true;
            this.BN_TestLocalizationFile.Click += new System.EventHandler(this.BN_TestLocalizationFile_Click);
            // 
            // BN_CreateLocalizationCSV
            // 
            this.BN_CreateLocalizationCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_CreateLocalizationCSV.Location = new System.Drawing.Point(569, 48);
            this.BN_CreateLocalizationCSV.Name = "BN_CreateLocalizationCSV";
            this.BN_CreateLocalizationCSV.Size = new System.Drawing.Size(170, 56);
            this.BN_CreateLocalizationCSV.TabIndex = 16;
            this.BN_CreateLocalizationCSV.Text = "Create LocalizationCSV from Pojectfolder";
            this.BN_CreateLocalizationCSV.UseVisualStyleBackColor = true;
            this.BN_CreateLocalizationCSV.Click += new System.EventHandler(this.BN_CreateLocalizationCSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NU_SetKeyCell);
            this.groupBox1.Controls.Add(this.NU_SetSourceLocationCell);
            this.groupBox1.Controls.Add(this.NU_SetSourceCell);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(316, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 193);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cell";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Set Key Cell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Set Sourcelocation Cell:";
            // 
            // NU_SetKeyCell
            // 
            this.NU_SetKeyCell.Location = new System.Drawing.Point(7, 38);
            this.NU_SetKeyCell.Name = "NU_SetKeyCell";
            this.NU_SetKeyCell.Size = new System.Drawing.Size(145, 20);
            this.NU_SetKeyCell.TabIndex = 21;
            // 
            // NU_SetSourceLocationCell
            // 
            this.NU_SetSourceLocationCell.Location = new System.Drawing.Point(9, 117);
            this.NU_SetSourceLocationCell.Name = "NU_SetSourceLocationCell";
            this.NU_SetSourceLocationCell.Size = new System.Drawing.Size(145, 20);
            this.NU_SetSourceLocationCell.TabIndex = 26;
            // 
            // NU_SetSourceCell
            // 
            this.NU_SetSourceCell.Location = new System.Drawing.Point(6, 78);
            this.NU_SetSourceCell.Name = "NU_SetSourceCell";
            this.NU_SetSourceCell.Size = new System.Drawing.Size(145, 20);
            this.NU_SetSourceCell.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Set Source Cell:";
            // 
            // GB_Lan
            // 
            this.GB_Lan.Controls.Add(this.LIVI_LanguageCell);
            this.GB_Lan.Controls.Add(this.NU_SetCell);
            this.GB_Lan.Controls.Add(this.LB_SetCell);
            this.GB_Lan.Location = new System.Drawing.Point(161, 45);
            this.GB_Lan.Name = "GB_Lan";
            this.GB_Lan.Size = new System.Drawing.Size(149, 317);
            this.GB_Lan.TabIndex = 24;
            this.GB_Lan.TabStop = false;
            this.GB_Lan.Text = "Language Cell";
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
            this.LIVI_LanguageCell.Location = new System.Drawing.Point(5, 19);
            this.LIVI_LanguageCell.Name = "LIVI_LanguageCell";
            this.LIVI_LanguageCell.Size = new System.Drawing.Size(138, 253);
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
            // NU_SetCell
            // 
            this.NU_SetCell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NU_SetCell.Location = new System.Drawing.Point(6, 291);
            this.NU_SetCell.Name = "NU_SetCell";
            this.NU_SetCell.Size = new System.Drawing.Size(137, 20);
            this.NU_SetCell.TabIndex = 18;
            this.NU_SetCell.ValueChanged += new System.EventHandler(this.NU_SetCell_ValueChanged);
            // 
            // LB_SetCell
            // 
            this.LB_SetCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_SetCell.AutoSize = true;
            this.LB_SetCell.Location = new System.Drawing.Point(6, 275);
            this.LB_SetCell.Name = "LB_SetCell";
            this.LB_SetCell.Size = new System.Drawing.Size(97, 13);
            this.LB_SetCell.TabIndex = 15;
            this.LB_SetCell.Text = "Set Language Cell:";
            // 
            // BN_SaveSettings
            // 
            this.BN_SaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_SaveSettings.Location = new System.Drawing.Point(316, 48);
            this.BN_SaveSettings.Name = "BN_SaveSettings";
            this.BN_SaveSettings.Size = new System.Drawing.Size(246, 93);
            this.BN_SaveSettings.TabIndex = 13;
            this.BN_SaveSettings.Text = "Save Settings";
            this.BN_SaveSettings.UseVisualStyleBackColor = true;
            this.BN_SaveSettings.Click += new System.EventHandler(this.BN_SaveSettings_Click);
            // 
            // BN_CreatePoFiles
            // 
            this.BN_CreatePoFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_CreatePoFiles.Location = new System.Drawing.Point(569, 205);
            this.BN_CreatePoFiles.Name = "BN_CreatePoFiles";
            this.BN_CreatePoFiles.Size = new System.Drawing.Size(170, 56);
            this.BN_CreatePoFiles.TabIndex = 15;
            this.BN_CreatePoFiles.Text = "Create Po Files from LocalizationCSV";
            this.BN_CreatePoFiles.UseVisualStyleBackColor = true;
            this.BN_CreatePoFiles.Click += new System.EventHandler(this.BN_CreatePoFiles_Click);
            // 
            // TXBX_LocalizationCSV
            // 
            this.TXBX_LocalizationCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXBX_LocalizationCSV.Enabled = false;
            this.TXBX_LocalizationCSV.Location = new System.Drawing.Point(13, 19);
            this.TXBX_LocalizationCSV.Name = "TXBX_LocalizationCSV";
            this.TXBX_LocalizationCSV.ReadOnly = true;
            this.TXBX_LocalizationCSV.Size = new System.Drawing.Size(644, 20);
            this.TXBX_LocalizationCSV.TabIndex = 7;
            // 
            // BN_FindLocalizationCsv
            // 
            this.BN_FindLocalizationCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_FindLocalizationCsv.Location = new System.Drawing.Point(663, 19);
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
            this.CHBX_Language.Size = new System.Drawing.Size(142, 394);
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
            this.BN_FindMainPoFile.Location = new System.Drawing.Point(672, 69);
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
            this.TXBX_MainPoFile.Size = new System.Drawing.Size(657, 20);
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
            this.BN_FindLocalizationFolder.Location = new System.Drawing.Point(672, 32);
            this.BN_FindLocalizationFolder.Name = "BN_FindLocalizationFolder";
            this.BN_FindLocalizationFolder.Size = new System.Drawing.Size(75, 23);
            this.BN_FindLocalizationFolder.TabIndex = 2;
            this.BN_FindLocalizationFolder.Text = "Find";
            this.BN_FindLocalizationFolder.UseVisualStyleBackColor = true;
            this.BN_FindLocalizationFolder.Click += new System.EventHandler(this.BN_FindLocalizationFolder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Presets";
            // 
            // LIBX_Presets
            // 
            this.LIBX_Presets.FormattingEnabled = true;
            this.LIBX_Presets.Location = new System.Drawing.Point(12, 28);
            this.LIBX_Presets.Name = "LIBX_Presets";
            this.LIBX_Presets.Size = new System.Drawing.Size(145, 147);
            this.LIBX_Presets.TabIndex = 15;
            this.LIBX_Presets.SelectedIndexChanged += new System.EventHandler(this.LIBX_Presets_SelectedIndexChanged);
            // 
            // BN_AddPreset
            // 
            this.BN_AddPreset.Location = new System.Drawing.Point(13, 181);
            this.BN_AddPreset.Name = "BN_AddPreset";
            this.BN_AddPreset.Size = new System.Drawing.Size(145, 47);
            this.BN_AddPreset.TabIndex = 18;
            this.BN_AddPreset.Text = "Add Preset";
            this.BN_AddPreset.UseVisualStyleBackColor = true;
            this.BN_AddPreset.Click += new System.EventHandler(this.BN_AddPreset_Click);
            // 
            // BN_RemovePreset
            // 
            this.BN_RemovePreset.Location = new System.Drawing.Point(13, 234);
            this.BN_RemovePreset.Name = "BN_RemovePreset";
            this.BN_RemovePreset.Size = new System.Drawing.Size(145, 47);
            this.BN_RemovePreset.TabIndex = 19;
            this.BN_RemovePreset.Text = "Remove Preset";
            this.BN_RemovePreset.UseVisualStyleBackColor = true;
            this.BN_RemovePreset.Click += new System.EventHandler(this.BN_RemovePreset_Click);
            // 
            // TXBX_PresetName
            // 
            this.TXBX_PresetName.Location = new System.Drawing.Point(6, 20);
            this.TXBX_PresetName.Name = "TXBX_PresetName";
            this.TXBX_PresetName.Size = new System.Drawing.Size(133, 20);
            this.TXBX_PresetName.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BN_RenamePreset);
            this.groupBox2.Controls.Add(this.TXBX_PresetName);
            this.groupBox2.Location = new System.Drawing.Point(12, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rename";
            // 
            // BN_RenamePreset
            // 
            this.BN_RenamePreset.Location = new System.Drawing.Point(6, 49);
            this.BN_RenamePreset.Name = "BN_RenamePreset";
            this.BN_RenamePreset.Size = new System.Drawing.Size(133, 45);
            this.BN_RenamePreset.TabIndex = 22;
            this.BN_RenamePreset.Text = "Rename Preset";
            this.BN_RenamePreset.UseVisualStyleBackColor = true;
            this.BN_RenamePreset.Click += new System.EventHandler(this.BN_RenamePreset_Click);
            // 
            // FB_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BN_RemovePreset);
            this.Controls.Add(this.BN_AddPreset);
            this.Controls.Add(this.LIBX_Presets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GB_UE4_General);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "FB_Main";
            this.Text = "Po - File Editor";
            this.Load += new System.EventHandler(this.FB_Main_Load);
            this.GB_UE4_General.ResumeLayout(false);
            this.GB_UE4_General.PerformLayout();
            this.GB_LocalizationCSV.ResumeLayout(false);
            this.GB_LocalizationCSV.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetKeyCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetSourceLocationCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetSourceCell)).EndInit();
            this.GB_Lan.ResumeLayout(false);
            this.GB_Lan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SetCell)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NU_SetSourceCell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NU_SetKeyCell;
        private System.Windows.Forms.GroupBox GB_Lan;
        private System.Windows.Forms.Button BN_CreateLocalizationCSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NU_SetSourceLocationCell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BN_Viewer;
        private System.Windows.Forms.Button BN_CompareLocalizationCSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LIBX_Presets;
        private System.Windows.Forms.Button BN_AddPreset;
        private System.Windows.Forms.Button BN_RemovePreset;
        private System.Windows.Forms.TextBox TXBX_PresetName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BN_RenamePreset;
    }
}

