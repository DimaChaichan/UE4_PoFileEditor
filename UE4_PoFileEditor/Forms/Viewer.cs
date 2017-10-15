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
        List<DataViewerValue> DataList = new List<DataViewerValue>();
        public Viewer(PoFile SourcePoFile)
        {
            InitializeComponent();
            DataList = new List<DataViewerValue>();

            foreach (PoFileValues item in SourcePoFile.Values)
            {
                DataViewerValue NewValue = new DataViewerValue(item.Key, item.msgid, item.SourceLocation);
                DataList.Add(NewValue);
            }

            BindingList<DataViewerValue> bindingList = new BindingList<DataViewerValue>(DataList);
            var source = new BindingSource(bindingList, null);
            DAGV_DataViewer.DataSource = source;

            DataGridViewColumn colSpacer = new DataGridViewTextBoxColumn();
            colSpacer.DataPropertyName = "";
            colSpacer.HeaderText = "";
            colSpacer.Name = "Spacer";
            colSpacer.DefaultCellStyle.BackColor = Color.DimGray;
            colSpacer.ReadOnly = true;
            colSpacer.Resizable = DataGridViewTriState.False;
            colSpacer.Width = 5;
            DAGV_DataViewer.Columns.Add(colSpacer);

        }
    }
}
