using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UE4_PoFileEditor.Class;

namespace UE4_PoFileEditor.Forms
{
    public partial class Viewer : Form
    {
        public Viewer(LocalizationFile Localizationfile)
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("Status"); // Icon
            dt.Columns.Add("Key");
            dt.Columns.Add("Sourcelocation");
            dt.Columns.Add("Source");
            dt.Columns.Add(" "); // Spacer
            foreach (LanguageCell item in Localizationfile.Languages)
            {
                dt.Columns.Add(item.Language);
            }

            foreach (LocalizationFileLanguageListValues Row in Localizationfile.LanguageValues)
            {
                List<object> newRow = new List<object>();
                newRow.Add("");
                newRow.Add(Row.Key);
                newRow.Add(Row.SourceLocation);
                newRow.Add(Row.SourceValue);
                newRow.Add("");
                foreach (LocalizationFileLanguageValue Cell in Row.ListValues)
                {
                    newRow.Add(Cell.Value);
                }

                dt.Rows.Add(newRow.ToArray());
            }
            DAGV_DataViewer.DataSource = dt;


            //Block First Columns
            for (int i = 0; i < 4; i++)
            {
                if (DAGV_DataViewer.ColumnCount > i)
                {
                    DAGV_DataViewer.Columns[i].ReadOnly = true;
                    DAGV_DataViewer.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
                    DAGV_DataViewer.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }

            // Icon
            DAGV_DataViewer.Columns[0].DefaultCellStyle.BackColor = Color.DimGray;
            DAGV_DataViewer.Columns[0].ReadOnly = true;
            DAGV_DataViewer.Columns[0].Resizable = DataGridViewTriState.False;
            DAGV_DataViewer.Columns[0].Width = 50;

            //// Spacer
            DAGV_DataViewer.Columns[4].DefaultCellStyle.BackColor = Color.DimGray;
            DAGV_DataViewer.Columns[4].ReadOnly = true;
            DAGV_DataViewer.Columns[4].Resizable = DataGridViewTriState.False;
            DAGV_DataViewer.Columns[4].Width = 5;

        }
    }
}
