using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                bindingSource.DataSource = _dt == null ? null : new PageOffsetList();
            }
        }

        [Browsable(true)]
        public DataGridView DataGridView
        {
            get { return dataGridView1; }
        }
        public BindingNavigator BindingNavigator
        {
            get { return bindingNavigator; }
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
            int offset = (int)bindingSource.Current;
            DataTable x = _dt.Clone();
            for (int i = offset; i < offset + pageSize && i < _totalRecords; i++)
                x.ImportRow(_dt.Rows[i]);
            dataGridView1.DataSource = x;
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

        private void txtPageSize_Leave(object sender, EventArgs e)
        {
            pageSize = Convert.ToInt16(txtPageSize.Text);
            bindingSource.DataSource=new PageOffsetList();
        }
    }

}
