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
            this.LB_LocalizationCSV = new System.Windows.Forms.Label();
            this.BN_FindLocalizationCsv = new System.Windows.Forms.Button();
            this.TXBX_LocalizationCSV = new System.Windows.Forms.TextBox();
            this.LB_MainPoFile = new System.Windows.Forms.Label();
            this.BN_FindMainPoFile = new System.Windows.Forms.Button();
            this.TXBX_MainPoFile = new System.Windows.Forms.TextBox();
            this.LB_LocalizationFolder = new System.Windows.Forms.Label();
            this.BN_FindLocalizationFolder = new System.Windows.Forms.Button();
            this.GB_Tools = new System.Windows.Forms.GroupBox();
            this.BN_ConvertCsvToPo = new System.Windows.Forms.Button();
            this.BN_ConvertPoToCsv = new System.Windows.Forms.Button();
            this.GB_UE4_General.SuspendLayout();
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
            this.TXBX_UE4LocalizationPath.Size = new System.Drawing.Size(294, 20);
            this.TXBX_UE4LocalizationPath.TabIndex = 1;
            // 
            // GB_UE4_General
            // 
            this.GB_UE4_General.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_UE4_General.Controls.Add(this.LB_LocalizationCSV);
            this.GB_UE4_General.Controls.Add(this.BN_FindLocalizationCsv);
            this.GB_UE4_General.Controls.Add(this.TXBX_LocalizationCSV);
            this.GB_UE4_General.Controls.Add(this.LB_MainPoFile);
            this.GB_UE4_General.Controls.Add(this.BN_FindMainPoFile);
            this.GB_UE4_General.Controls.Add(this.TXBX_MainPoFile);
            this.GB_UE4_General.Controls.Add(this.LB_LocalizationFolder);
            this.GB_UE4_General.Controls.Add(this.BN_FindLocalizationFolder);
            this.GB_UE4_General.Controls.Add(this.TXBX_UE4LocalizationPath);
            this.GB_UE4_General.Location = new System.Drawing.Point(12, 12);
            this.GB_UE4_General.Name = "GB_UE4_General";
            this.GB_UE4_General.Size = new System.Drawing.Size(479, 140);
            this.GB_UE4_General.TabIndex = 2;
            this.GB_UE4_General.TabStop = false;
            this.GB_UE4_General.Text = "Unreal 4 General";
            // 
            // LB_LocalizationCSV
            // 
            this.LB_LocalizationCSV.AutoSize = true;
            this.LB_LocalizationCSV.Location = new System.Drawing.Point(6, 95);
            this.LB_LocalizationCSV.Name = "LB_LocalizationCSV";
            this.LB_LocalizationCSV.Size = new System.Drawing.Size(87, 13);
            this.LB_LocalizationCSV.TabIndex = 9;
            this.LB_LocalizationCSV.Text = "Localization CSV";
            // 
            // BN_FindLocalizationCsv
            // 
            this.BN_FindLocalizationCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN_FindLocalizationCsv.Location = new System.Drawing.Point(309, 107);
            this.BN_FindLocalizationCsv.Name = "BN_FindLocalizationCsv";
            this.BN_FindLocalizationCsv.Size = new System.Drawing.Size(75, 23);
            this.BN_FindLocalizationCsv.TabIndex = 8;
            this.BN_FindLocalizationCsv.Text = "Find";
            this.BN_FindLocalizationCsv.UseVisualStyleBackColor = true;
            this.BN_FindLocalizationCsv.Click += new System.EventHandler(this.BN_FindLocalizationCsv_Click);
            // 
            // TXBX_LocalizationCSV
            // 
            this.TXBX_LocalizationCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXBX_LocalizationCSV.Enabled = false;
            this.TXBX_LocalizationCSV.Location = new System.Drawing.Point(9, 109);
            this.TXBX_LocalizationCSV.Name = "TXBX_LocalizationCSV";
            this.TXBX_LocalizationCSV.ReadOnly = true;
            this.TXBX_LocalizationCSV.Size = new System.Drawing.Size(294, 20);
            this.TXBX_LocalizationCSV.TabIndex = 7;
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
            this.BN_FindMainPoFile.Location = new System.Drawing.Point(309, 70);
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
            this.TXBX_MainPoFile.Size = new System.Drawing.Size(294, 20);
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
            this.BN_FindLocalizationFolder.Location = new System.Drawing.Point(309, 33);
            this.BN_FindLocalizationFolder.Name = "BN_FindLocalizationFolder";
            this.BN_FindLocalizationFolder.Size = new System.Drawing.Size(75, 23);
            this.BN_FindLocalizationFolder.TabIndex = 2;
            this.BN_FindLocalizationFolder.Text = "Find";
            this.BN_FindLocalizationFolder.UseVisualStyleBackColor = true;
            this.BN_FindLocalizationFolder.Click += new System.EventHandler(this.BN_FindLocalizationFolder_Click);
            // 
            // GB_Tools
            // 
            this.GB_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Tools.Controls.Add(this.BN_ConvertCsvToPo);
            this.GB_Tools.Controls.Add(this.BN_ConvertPoToCsv);
            this.GB_Tools.Location = new System.Drawing.Point(12, 158);
            this.GB_Tools.Name = "GB_Tools";
            this.GB_Tools.Size = new System.Drawing.Size(101, 100);
            this.GB_Tools.TabIndex = 3;
            this.GB_Tools.TabStop = false;
            this.GB_Tools.Text = "Tools";
            // 
            // BN_ConvertCsvToPo
            // 
            this.BN_ConvertCsvToPo.Location = new System.Drawing.Point(9, 57);
            this.BN_ConvertCsvToPo.Name = "BN_ConvertCsvToPo";
            this.BN_ConvertCsvToPo.Size = new System.Drawing.Size(75, 30);
            this.BN_ConvertCsvToPo.TabIndex = 1;
            this.BN_ConvertCsvToPo.Text = "Csv to Po";
            this.BN_ConvertCsvToPo.UseVisualStyleBackColor = true;
            this.BN_ConvertCsvToPo.Click += new System.EventHandler(this.BN_ConvertCsvToPo_Click);
            // 
            // BN_ConvertPoToCsv
            // 
            this.BN_ConvertPoToCsv.Location = new System.Drawing.Point(9, 19);
            this.BN_ConvertPoToCsv.Name = "BN_ConvertPoToCsv";
            this.BN_ConvertPoToCsv.Size = new System.Drawing.Size(75, 30);
            this.BN_ConvertPoToCsv.TabIndex = 0;
            this.BN_ConvertPoToCsv.Text = "Po to Csv";
            this.BN_ConvertPoToCsv.UseVisualStyleBackColor = true;
            this.BN_ConvertPoToCsv.Click += new System.EventHandler(this.BN_ConvertPoToCsv_Click);
            // 
            // FB_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 278);
            this.Controls.Add(this.GB_Tools);
            this.Controls.Add(this.GB_UE4_General);
            this.Name = "FB_Main";
            this.Text = "Po - File Editor";
            this.GB_UE4_General.ResumeLayout(false);
            this.GB_UE4_General.PerformLayout();
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
        private System.Windows.Forms.Label LB_LocalizationCSV;
        private System.Windows.Forms.Button BN_FindLocalizationCsv;
        private System.Windows.Forms.TextBox TXBX_LocalizationCSV;
        private System.Windows.Forms.GroupBox GB_Tools;
        private System.Windows.Forms.Button BN_ConvertPoToCsv;
        private System.Windows.Forms.Button BN_ConvertCsvToPo;
    }
}

