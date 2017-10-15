namespace UE4_PoFileEditor.Forms
{
    partial class Viewer
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
            this.DAGV_DataViewer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DAGV_DataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // DAGV_DataViewer
            // 
            this.DAGV_DataViewer.AllowUserToAddRows = false;
            this.DAGV_DataViewer.AllowUserToDeleteRows = false;
            this.DAGV_DataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DAGV_DataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DAGV_DataViewer.Location = new System.Drawing.Point(0, 0);
            this.DAGV_DataViewer.Name = "DAGV_DataViewer";
            this.DAGV_DataViewer.Size = new System.Drawing.Size(599, 336);
            this.DAGV_DataViewer.TabIndex = 0;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 336);
            this.Controls.Add(this.DAGV_DataViewer);
            this.Name = "Viewer";
            this.Text = "Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.DAGV_DataViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DAGV_DataViewer;
    }
}