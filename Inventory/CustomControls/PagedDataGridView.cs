using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory.CustomControls
{
    public partial class PagedDataGridView : UserControl
    {
        #region LocalVariables

        static int _totalRecords = 100;
        static int pageSize = 10;
        private DataTable _dt;

        #endregion
        #region Properities
        public DataTable DataSource
        {
            set
            {
                _dt = value;
                _totalRecords = _dt == null ? 0 : _dt.Rows.Count;
                lblTotalCount.Text = _dt != null && _dt.Rows.Count > 0 ? $"Total count: {_totalRecords}" : string.Empty;
                Enabled = _dt != null && _dt.Rows.Count > 0;
                bindingSource.DataSource = _dt == null ? null : new PageOffsetList();
            }
            get { return (DataTable) dataGridView1.DataSource; }
        }

        public DataGridViewSelectedRowCollection SelectedRows
        {
            get { return dataGridView1.SelectedRows; }
        }
        public DataGridViewColumnCollection Columns
        {
            get { return dataGridView1.Columns; }
        }

        #endregion


        public PagedDataGridView()
        {
            InitializeComponent();
            _dt = new DataTable();
            bindingSource.CurrentChanged += bindingSource_CurrentChanged;
            bindingNavigator.BindingSource = bindingSource;
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.DataSource == null)
            {
                dataGridView1.DataSource = null;
                return;
            }
            int offset = (int?)bindingSource.Current ?? 0;
            DataTable x = _dt.Clone();
            for (int i = offset; i < offset + pageSize && i < _totalRecords; i++)
                x.ImportRow(_dt.Rows[i]);
            dataGridView1.DataSource = x;
            FormatGrid();
        }

        private void FormatGrid()
        {
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if (i % 2 == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
            }
        }

        private void txtPageSize_Leave(object sender, EventArgs e)
        {
            try
            {
                pageSize = Convert.ToInt16(txtPageSize.Text);

            }
            catch (Exception)
            {
                txtPageSize.Text = pageSize.ToString();
            }
            bindingSource.DataSource = new PageOffsetList();
        }

        class PageOffsetList : IListSource
        {
            public IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < _totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }

            public bool ContainsListCollection { get; }
        }

        class NumToolStripTextBox : ToolStripTextBox
        {
            public NumToolStripTextBox()
            {
                this.KeyPress += TextBox_KeyPress;
            }

            private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                e.Handled = !(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar));
            }

            public override string Text
            {
                get { return TextBox.Text; }
                set
                {
                    try
                    {
                        pageSize = Convert.ToInt16(value);
                        TextBox.Text = value;
                    }
                    catch (Exception)
                    {
                       
                    }
                }
            }
        }

    }

}
